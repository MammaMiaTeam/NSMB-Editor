/*
*   This file is part of NSMB Editor 5.
*
*   NSMB Editor 5 is free software: you can redistribute it and/or modify
*   it under the terms of the GNU General Public License as published by
*   the Free Software Foundation, either version 3 of the License, or
*   (at your option) any later version.
*
*   NSMB Editor 5 is distributed in the hope that it will be useful,
*   but WITHOUT ANY WARRANTY; without even the implied warranty of
*   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
*   GNU General Public License for more details.
*
*   You should have received a copy of the GNU General Public License
*   along with NSMB Editor 5.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;

using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using NSMBe5.DSFileSystem;
using NSMBe5.Patcher;
using System.Diagnostics;
using System.Drawing;
using NSMBe5.Plugin;
using System.Linq;
using NSMBe5.TilemapEditor;

namespace NSMBe5 {
    public partial class LevelChooser : Form
    {
        public static ImageManagerWindow imgMgr;
        public TextInputForm textForm = new TextInputForm();
        // init has to be used because Winforms is setting the value of autoBackupTime before the form loads
        //   This causes it to be saved in the settings before the settings value is loaded.
        public bool init = false;
        private bool romLoaded = false;

        public static void showImgMgr()
        {
            if (imgMgr == null || imgMgr.IsDisposed)
                imgMgr = new ImageManagerWindow();

            imgMgr.Show();
        }

        public LevelChooser()
        {
            InitializeComponent();
        }

        private void LevelChooser_Load(object sender, EventArgs e)
		{
			dlpCheckBox.Checked = Properties.Settings.Default.dlpMode;
            chkAutoBackup.Checked = Properties.Settings.Default.AutoBackup > 0;
            if (chkAutoBackup.Checked)
                autoBackupTime.Value = Properties.Settings.Default.AutoBackup;
            init = true;

            // Check if ROM is loaded
            romLoaded = ROM.FS != null;

            if (romLoaded)
            {
                LoadROMDependentData();
            }
            else
            {
                // Set title without ROM name
                Text = "NSMB Editor " + Version.GetString();
                DisableROMDependentControls();
            }

            LanguageManager.ApplyToContainer(this, "LevelChooser");
            openROMDialog.Filter = LanguageManager.Get("Filters", "rom");
            importLevelDialog.Filter = LanguageManager.Get("Filters", "level");
            exportLevelDialog.Filter = LanguageManager.Get("Filters", "level");
            openPatchDialog.Filter = LanguageManager.Get("Filters", "patch");
            savePatchDialog.Filter = LanguageManager.Get("Filters", "patch");
            openTextFileDialog.Filter = LanguageManager.Get("Filters", "text");
            saveTextFileDialog.Filter = LanguageManager.Get("Filters", "text");
            
            // Load recent files
            LoadRecentFiles();
            
            //Get Language Files
            string langDir = System.IO.Path.Combine(Application.StartupPath, "Languages");
            if (System.IO.Directory.Exists(langDir)) {
                string[] files = System.IO.Directory.GetFiles(langDir);
                for (int l = 0; l < files.Length; l++) {
                    if (files[l].EndsWith(".ini")) {
                        int startPos = files[l].LastIndexOf(System.IO.Path.DirectorySeparatorChar) + 1;
                        languagesComboBox.Items.Add(files[l].Substring(startPos, files[l].LastIndexOf('.') - startPos));
                    }
                }
            }
            languagesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            languagesComboBox.SelectedIndexChanged -= new EventHandler(languagesComboBox_SelectedIndexChanged);
            languagesComboBox.SelectedItem = Properties.Settings.Default.LanguageFile;
            languagesComboBox.SelectedIndexChanged += new EventHandler(languagesComboBox_SelectedIndexChanged);

            string[] codePatchingMethods =
            {
                "NSMBe",
                "Fireflower",
                "NCPatcher"
            };

            patchMethodComboBox.Items.AddRange(codePatchingMethods);
            patchMethodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            patchMethodComboBox.SelectedIndexChanged -= new EventHandler(patchMethodComboBox_SelectedIndexChanged);
            patchMethodComboBox.SelectedIndex = Properties.Settings.Default.CodePatchingMethod;
            patchMethodComboBox.SelectedIndexChanged += new EventHandler(patchMethodComboBox_SelectedIndexChanged);

            fontTextBox.Text = Properties.Settings.Default.UIFont;
            Program.ApplyFontToControls(Controls);
            
            versionLabel.Text = "NSMB Editor " + Version.GetString() + " " + Properties.Resources.BuildDate.Trim();
            Icon = Properties.Resources.nsmbe;
            
            UpdateMenuState();
            Activate();
        }

        private void LoadLevelNames()
        {
            List<string> LevelNames = LanguageManager.GetList("LevelNames");

            TreeNode WorldNode = null;
            TreeNode LevelNode;
            TreeNode AreaNode;
            for (int NameIdx = 0; NameIdx < LevelNames.Count; NameIdx++) {
                LevelNames[NameIdx] = LevelNames[NameIdx].Trim();
                if (LevelNames[NameIdx] == "") continue;
                if (LevelNames[NameIdx][0] == '-') {
                    // Create a world
                    string[] ParseWorld = LevelNames[NameIdx].Substring(1).Split('|');
                    WorldNode = levelTreeView.Nodes.Add("ln" + NameIdx.ToString(), ParseWorld[0]);
                } else {
                    // Create a level
                    string[] ParseLevel = LevelNames[NameIdx].Split('|');
                    int AreaCount = ParseLevel.Length - 1;
                    if (AreaCount == 1) {
                        // One area only; no need for a subfolder here
                        LevelNode = WorldNode.Nodes.Add("ln" + NameIdx.ToString(), ParseLevel[0]);
                        LevelNode.Tag = ParseLevel[1];
                    } else {
                        // Create a subfolder
                        LevelNode = WorldNode.Nodes.Add("ln" + NameIdx.ToString(), ParseLevel[0]);
                        for (int AreaIdx = 1; AreaIdx <= AreaCount; AreaIdx++) {
                            AreaNode = LevelNode.Nodes.Add("ln" + NameIdx.ToString() + "a" + AreaIdx.ToString(), LanguageManager.Get("LevelChooser", "Area") + " " + AreaIdx.ToString());
                            AreaNode.Tag = ParseLevel[AreaIdx];
                        }
                    }
                }
            }
        }

        private void levelTreeView_AfterSelect(object sender, TreeViewEventArgs e) {
            bool enabled = e.Node.Tag != null;
            importLevelButton.Enabled = enabled;
            exportLevelButton.Enabled = enabled;
            editLevelButton.Enabled = enabled;
            hexEditLevelButton.Enabled = enabled;
            importClipboard.Enabled = enabled;
            exportClipboard.Enabled = enabled;
        }

        private void editLevelButton_Click(object sender, EventArgs e)
        {
            // Make a caption
            string EditorCaption = "";

            if (levelTreeView.SelectedNode.Parent.Parent == null) {
                EditorCaption += levelTreeView.SelectedNode.Text;
            } else {
                EditorCaption += levelTreeView.SelectedNode.Parent.Text + ", " + levelTreeView.SelectedNode.Text;
            }

            // Open it
            try
            {
                LevelEditor NewEditor = new LevelEditor(new NSMBLevel(new InternalLevelSource((string)levelTreeView.SelectedNode.Tag, EditorCaption)));
                NewEditor.Show();
            }
            catch (AlreadyEditingException)
            {
                MessageBox.Show(LanguageManager.Get("Errors", "Level"));
            }                
        }

        private void hexEditLevelButton_Click(object sender, EventArgs e) {
            if (levelTreeView.SelectedNode == null) return;

            // Make a caption
            string EditorCaption = LanguageManager.Get("General", "EditingSomething") + " ";

            if (levelTreeView.SelectedNode.Parent.Parent == null) {
                EditorCaption += levelTreeView.SelectedNode.Text;
            } else {
                EditorCaption += levelTreeView.SelectedNode.Parent.Text + ", " + levelTreeView.SelectedNode.Text;
            }

            // Open it
            try
            {
                LevelHexEditor NewEditor = new LevelHexEditor((string)levelTreeView.SelectedNode.Tag);
                NewEditor.Text = EditorCaption;
                NewEditor.Show();
            }
            catch (AlreadyEditingException)
            {
                MessageBox.Show(LanguageManager.Get("Errors", "Level"));
            }                
        }

        private void levelTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (e.Node.Tag != null && editLevelButton.Enabled == true) {
                editLevelButton_Click(null, null);
            }
        }

        private void importLevelButton_Click(object sender, EventArgs e) {
            if (levelTreeView.SelectedNode == null) return;

            // Figure out what file to import
            if (importLevelDialog.ShowDialog() == DialogResult.Cancel)
                return;

            // Get the files
            string LevelFilename = (string)levelTreeView.SelectedNode.Tag;
            DSFileSystem.File LevelFile = ROM.getLevelFile(LevelFilename);
            DSFileSystem.File BGFile = ROM.getBGDatFile(LevelFilename);

            // Load it
            try
            {
                ExternalLevelSource level = new ExternalLevelSource(importLevelDialog.FileName);
                level.level.Import(LevelFile, BGFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exportLevelButton_Click(object sender, EventArgs e) {
            if (levelTreeView.SelectedNode == null) return;

            // Figure out what file to export to
            if (exportLevelDialog.ShowDialog() == DialogResult.Cancel)
                return;

            // Get the files
            string LevelFilename = (string)levelTreeView.SelectedNode.Tag;
            DSFileSystem.File LevelFile = ROM.getLevelFile(LevelFilename);
            DSFileSystem.File BGFile = ROM.getBGDatFile(LevelFilename);

            // Load it
            FileStream fs = new FileStream(exportLevelDialog.FileName, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            new ExportedLevel(LevelFile, BGFile).Write(bw);
            bw.Close();
        }

        private void openLevel_Click(object sender, EventArgs e)
        {
            if (importLevelDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            try {
                new LevelEditor(new NSMBLevel(new ExternalLevelSource(importLevelDialog.FileName))).Show();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void importClipboard_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show((LanguageManager.Get("LevelChooser", "replaceclipboard")), (LanguageManager.Get("LevelChooser", "replaceclipboardtitle")), MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                string LevelFilename = (string)levelTreeView.SelectedNode.Tag;
                DSFileSystem.File LevelFile = ROM.getLevelFile(LevelFilename);
                DSFileSystem.File BGFile = ROM.getBGDatFile(LevelFilename);
                ClipboardLevelSource level = new ClipboardLevelSource();
                level.level.Import(LevelFile, BGFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show((LanguageManager.Get("LevelChooser", "clipinvalidlevel")));
            }
        }

        private void exportClipboard_Click(object sender, EventArgs e)
        {
            string LevelFilename = (string)levelTreeView.SelectedNode.Tag;
            DSFileSystem.File LevelFile = ROM.getLevelFile(LevelFilename);
            DSFileSystem.File BGFile = ROM.getBGDatFile(LevelFilename);

            ByteArrayInputStream strm = new ByteArrayInputStream(new byte[0]);
            BinaryWriter bw = new BinaryWriter(strm);

            new ExportedLevel(LevelFile, BGFile).Write(bw);
            ClipboardLevelSource.copyData(strm.getData());
            bw.Close();
        }

        private void openClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                new LevelEditor(new NSMBLevel(new ClipboardLevelSource())).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageManager.Get("LevelChooser", "clipinvalidlevel"));
            }
        }

        private DataFinder DataFinderForm;

        private void dataFinderButton_Click(object sender, EventArgs e) {
            if (DataFinderForm == null || DataFinderForm.IsDisposed) {
                DataFinderForm = new DataFinder();
            }

            DataFinderForm.Show();
            DataFinderForm.Activate();
        }


        /**
         * PATCH FILE FORMAT
         * 
         * - String "NSMBe5 Exported Patch"
         * - Some files (see below)
         * - byte 0
         * 
         * STRUCTURE OF A FILE
         * - byte 1
         * - File name as a string
         * - File ID as ushort (to check for different versions, only gives a warning)
         * - File length as uint
         * - File contents as byte[]
         */

        const string oldPatchHeader = "NSMBe4 Exported Patch";
        public const string patchHeader = "NSMBe5 Exported Patch";

        private void patchExport_Click(object sender, EventArgs e)
        {
            //output to show to the user
            bool differentRomsWarning = false; // tells if we have shown the warning
            int fileCount = 0;

            //load the original rom
            MessageBox.Show(LanguageManager.Get("Patch", "SelectROM"), LanguageManager.Get("Patch", "Export"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (openROMDialog.ShowDialog() == DialogResult.Cancel)
                return;
            NitroROMFilesystem origROM = new NitroROMFilesystem(openROMDialog.FileName);

            //open the output patch
            MessageBox.Show(LanguageManager.Get("Patch", "SelectLocation"), LanguageManager.Get("Patch", "Export"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (savePatchDialog.ShowDialog() == DialogResult.Cancel)
                return;

            FileStream fs = new FileStream(savePatchDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
            
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(patchHeader);

            //DO THE PATCH!!
            ProgressWindow progress = new ProgressWindow(LanguageManager.Get("Patch", "ExportProgressTitle"));
            progress.Show();
            progress.SetMax(ROM.FS.allFiles.Count);
            int progVal = 0;
            MessageBox.Show(LanguageManager.Get("Patch", "StartingPatch"), LanguageManager.Get("Patch", "Export"), MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (NSMBe5.DSFileSystem.File f in ROM.FS.allFiles)
            {
                if (f.isSystemFile) continue;

                Console.Out.WriteLine("Checking " + f.name);
                progress.SetCurrentAction(string.Format(LanguageManager.Get("Patch", "ComparingFile"), f.name));

                NSMBe5.DSFileSystem.File orig = origROM.getFileByName(f.name);
                //check same version
                if(orig == null)
                {
                    new ErrorMSGBox("", "", "In this case it is recommended that you continue.", "This ROM has more files than the original clean ROM or a file was renamed!\n\nPlease make an XDelta patch instead.\n\nExport will end now.").ShowDialog();
                    bw.Write((byte)0);
                    bw.Close();
                    origROM.close();
                    progress.SetCurrentAction("");
                    progress.WriteLine(string.Format(LanguageManager.Get("Patch", "ExportReady"), fileCount));
                    return;
                }
                else if(!differentRomsWarning && f.id != orig.id)
                {
                    if (MessageBox.Show(LanguageManager.Get("Patch", "ExportDiffVersions"), LanguageManager.Get("General", "Warning"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        differentRomsWarning = true;
                    else
                    {
                        fs.Close();
                        return;
                    }
                }

                byte[] oldFile = orig.getContents();
                byte[] newFile = f.getContents();

                if (!arrayEqual(oldFile, newFile))
                {
                    //include file in patch
                    string fileName = orig.name;
                    Console.Out.WriteLine("Including: " + fileName);
                    progress.WriteLine(string.Format(LanguageManager.Get("Patch", "IncludedFile"), fileName));
                    fileCount++;

                    bw.Write((byte)1);
                    bw.Write(fileName);
                    bw.Write((ushort)f.id);
                    bw.Write((uint)newFile.Length);
                    bw.Write(newFile, 0, newFile.Length);
                }
                progress.setValue(++progVal);
            }
            bw.Write((byte)0);
            bw.Close();
            origROM.close();
            progress.SetCurrentAction("");
            progress.WriteLine(string.Format(LanguageManager.Get("Patch", "ExportReady"), fileCount));
        }

        public bool arrayEqual(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;

            for (int i = 0; i < a.Length; i++)
                if (a[i] != b[i])
                    return false;

            return true;
        }

        private void patchImport_Click(object sender, EventArgs e)
        {
            //output to show to the user
            bool differentRomsWarning = false; // tells if we have shown the warning
            int fileCount = 0;

            //open the input patch
            if (openPatchDialog.ShowDialog() == DialogResult.Cancel)
                return;

            FileStream fs = new FileStream(openPatchDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryReader br = new BinaryReader(fs);

            string header = br.ReadString();
            if (!(header == patchHeader || header == oldPatchHeader))
            {
                MessageBox.Show(
                    LanguageManager.Get("Patch", "InvalidFile"),
                    LanguageManager.Get("Patch", "Unreadable"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                br.Close();
                return;
            }


            ProgressWindow progress = new ProgressWindow(LanguageManager.Get("Patch", "ImportProgressTitle"));
            progress.Show();

            byte filestartByte = br.ReadByte();
            try
            {
                while (filestartByte == 1)
                {
                    string fileName = br.ReadString();
                    progress.WriteLine(string.Format(LanguageManager.Get("Patch", "ReplacingFile"), fileName));
                    ushort origFileID = br.ReadUInt16();
                    NSMBe5.DSFileSystem.File f = ROM.FS.getFileByName(fileName);
                    uint length = br.ReadUInt32();

                    byte[] newFile = new byte[length];
                    br.Read(newFile, 0, (int)length);
                    filestartByte = br.ReadByte();

                    if (f != null)
                    {
                        ushort fileID = (ushort)f.id;

                        if (!differentRomsWarning && origFileID != fileID)
                        {
                            MessageBox.Show(LanguageManager.Get("Patch", "ImportDiffVersions"), LanguageManager.Get("General", "Warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            differentRomsWarning = true;
                        }
                        if (!f.isSystemFile)
                        {
                            Console.Out.WriteLine("Replace " + fileName);
                            f.beginEdit(this);
                            f.replace(newFile, this);
                            f.endEdit(this);
                        }
                        fileCount++;
                    }
                }
            }
            catch (AlreadyEditingException)
            {
                MessageBox.Show(string.Format(LanguageManager.Get("Patch", "Error"), fileCount), LanguageManager.Get("General", "Completed"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            br.Close();
            MessageBox.Show(string.Format(LanguageManager.Get("Patch", "ImportReady"), fileCount), LanguageManager.Get("General", "Completed"), MessageBoxButtons.OK, MessageBoxIcon.Information);
//            progress.Close();
        }

        private void mpPatch_Click(object sender, EventArgs e)
        {
            NarcReplace("Dat_Field.narc",    "J01_1.bin");
            NarcReplace("Dat_Basement.narc", "J02_1.bin");
            NarcReplace("Dat_Ice.narc",      "J03_1.bin");
            NarcReplace("Dat_Pipe.narc",     "J04_1.bin");
            NarcReplace("Dat_Fort.narc",     "J05_1.bin");
            NarcReplace("Dat_Field.narc",    "J01_1_bgdat.bin");
            NarcReplace("Dat_Basement.narc", "J02_1_bgdat.bin");
            NarcReplace("Dat_Ice.narc",      "J03_1_bgdat.bin");
            NarcReplace("Dat_Pipe.narc",     "J04_1_bgdat.bin");
            NarcReplace("Dat_Fort.narc",     "J05_1_bgdat.bin");

            MessageBox.Show(LanguageManager.Get("General", "Completed"));
        }

        private void mpPatch2_Click(object sender, EventArgs e)
        {
            NSMBLevel lvl = new NSMBLevel(new InternalLevelSource("J01_1", ""));
            NarcReplace("Dat_Field.narc", "I_M_nohara.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_UNT));
            NarcReplace("Dat_Field.narc", "I_M_nohara_hd.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_UNT_HD));
            NarcReplace("Dat_Field.narc", "d_2d_PA_I_M_nohara.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_PNL));
            NarcReplace("Dat_Field.narc", "NoHaRaMainUnitChangeData.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_CHK));
            NarcReplace("Dat_Field.narc", "d_2d_I_M_tikei_nohara_ncg.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_NCG));
            NarcReplace("Dat_Field.narc", "d_2d_I_M_tikei_nohara_ncl.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_NCL));

            NarcReplace("Dat_Field.narc", "d_2d_I_M_back_nohara_VS_UR_nsc.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x6], ROM.Data.Table_BG_NSC));
            NarcReplace("Dat_Field.narc", "d_2d_I_M_back_nohara_VS_ncg.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x6], ROM.Data.Table_BG_NCG));
            NarcReplace("Dat_Field.narc", "d_2d_I_M_back_nohara_VS_ncl.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x6], ROM.Data.Table_BG_NCL));

            NarcReplace("Dat_Field.narc", "d_2d_I_M_free_nohara_VS_UR_nsc.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x12], ROM.Data.Table_FG_NSC));
            NarcReplace("Dat_Field.narc", "d_2d_I_M_free_nohara_VS_ncg.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x12], ROM.Data.Table_FG_NCG));
            NarcReplace("Dat_Field.narc", "d_2d_I_M_free_nohara_VS_ncl.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x12], ROM.Data.Table_FG_NCL));


            lvl = new NSMBLevel(new InternalLevelSource("J02_1", ""));
            NarcReplace("Dat_Basement.narc", "I_M_chika3.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_UNT));
            NarcReplace("Dat_Basement.narc", "I_M_chika3_hd.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_UNT_HD));
            NarcReplace("Dat_Basement.narc", "d_2d_PA_I_M_chika3.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_PNL));
            NarcReplace("Dat_Basement.narc", "ChiKa3MainUnitChangeData.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_CHK));
            NarcReplace("Dat_Basement.narc", "d_2d_I_M_tikei_chika3_ncg.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_NCG));
            NarcReplace("Dat_Basement.narc", "d_2d_I_M_tikei_chika3_ncl.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_NCL));

            NarcReplace("Dat_Basement.narc", "d_2d_I_M_back_chika3_R_nsc.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x6], ROM.Data.Table_BG_NSC));
            NarcReplace("Dat_Basement.narc", "d_2d_I_M_back_chika3_ncg.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x6], ROM.Data.Table_BG_NCG));
            NarcReplace("Dat_Basement.narc", "d_2d_I_M_back_chika3_ncl.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x6], ROM.Data.Table_BG_NCL));


            lvl = new NSMBLevel(new InternalLevelSource("J03_1", ""));
            NarcReplace("Dat_Ice.narc", "I_M_setsugen2.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_UNT));
            NarcReplace("Dat_Ice.narc", "I_M_setsugen2_hd.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_UNT_HD));
            NarcReplace("Dat_Ice.narc", "d_2d_PA_I_M_setsugen2.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_PNL));
            NarcReplace("Dat_Ice.narc", "SeTsuGen2MainUnitChangeData.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_CHK));
            NarcReplace("Dat_Ice.narc", "d_2d_I_M_tikei_setsugen2_ncg.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_NCG));
            NarcReplace("Dat_Ice.narc", "d_2d_I_M_tikei_setsugen2_ncl.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_NCL));

            NarcReplace("Dat_Ice.narc", "d_2d_I_M_back_setsugen2_UR_nsc.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x6], ROM.Data.Table_BG_NSC));
            NarcReplace("Dat_Ice.narc", "d_2d_I_M_back_setsugen2_ncg.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x6], ROM.Data.Table_BG_NCG));
            NarcReplace("Dat_Ice.narc", "d_2d_I_M_back_setsugen2_ncl.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x6], ROM.Data.Table_BG_NCL));

            NarcReplace("Dat_Ice.narc", "d_2d_I_M_free_setsugen2_UR_nsc.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x12], ROM.Data.Table_FG_NSC));
            NarcReplace("Dat_Ice.narc", "d_2d_I_M_free_setsugen2_ncg.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x12], ROM.Data.Table_FG_NCG));
            NarcReplace("Dat_Ice.narc", "d_2d_I_M_free_setsugen2_ncl.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x12], ROM.Data.Table_FG_NCL));


            lvl = new NSMBLevel(new InternalLevelSource("J04_1", ""));
            NarcReplace("Dat_Pipe.narc", "W_M_dokansoto.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_UNT));
            NarcReplace("Dat_Pipe.narc", "W_M_dokansoto_hd.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_UNT_HD));
            NarcReplace("Dat_Pipe.narc", "d_2d_PA_W_M_dokansoto.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_PNL));
            NarcReplace("Dat_Pipe.narc", "DoKaNSoToMainUnitChangeData.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_CHK));
            NarcReplace("Dat_Pipe.narc", "d_2d_W_M_tikei_dokansoto_ncg.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_NCG));
            NarcReplace("Dat_Pipe.narc", "d_2d_W_M_tikei_dokansoto_ncl.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_NCL));

            NarcReplace("Dat_Pipe.narc", "d_2d_W_M_back_dokansoto_R_nsc.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x6], ROM.Data.Table_BG_NSC));
            NarcReplace("Dat_Pipe.narc", "d_2d_W_M_back_dokansoto_ncg.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x6], ROM.Data.Table_BG_NCG));
            NarcReplace("Dat_Pipe.narc", "d_2d_W_M_back_dokansoto_ncl.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x6], ROM.Data.Table_BG_NCL));

            NarcReplace("Dat_Pipe.narc", "d_2d_W_M_free_dokansoto_R_nsc.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x12], ROM.Data.Table_FG_NSC));
            NarcReplace("Dat_Pipe.narc", "d_2d_W_M_free_dokansoto_ncg.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x12], ROM.Data.Table_FG_NCG));
            NarcReplace("Dat_Pipe.narc", "d_2d_W_M_free_dokansoto_ncl.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x12], ROM.Data.Table_FG_NCL));


            lvl = new NSMBLevel(new InternalLevelSource("J05_1", ""));
            NarcReplace("Dat_Fort.narc", "I_M_yakata.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_UNT));
            NarcReplace("Dat_Fort.narc", "I_M_yakata_hd.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_UNT_HD));
            NarcReplace("Dat_Fort.narc", "d_2d_PA_I_M_yakata.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_PNL));
            NarcReplace("Dat_Fort.narc", "YaKaTaMainUnitChangeData.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_CHK));
            NarcReplace("Dat_Fort.narc", "d_2d_I_M_tikei_yakata_ncg.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_NCG));
            NarcReplace("Dat_Fort.narc", "d_2d_I_M_tikei_yakata_ncl.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0xC], ROM.Data.Table_TS_NCL));

            NarcReplace("Dat_Fort.narc", "d_2d_I_M_back_yakata_UR_nsc.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x6], ROM.Data.Table_BG_NSC));
            NarcReplace("Dat_Fort.narc", "d_2d_I_M_back_yakata_ncg.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x6], ROM.Data.Table_BG_NCG));
            NarcReplace("Dat_Fort.narc", "d_2d_I_M_back_yakata_ncl.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x6], ROM.Data.Table_BG_NCL));


            NarcReplace("Dat_Fort.narc", "d_2d_I_M_free_yakata_UR_nsc.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x12], ROM.Data.Table_FG_NSC));
            NarcReplace("Dat_Fort.narc", "d_2d_I_M_free_yakata_ncg.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x12], ROM.Data.Table_FG_NCG));
            NarcReplace("Dat_Fort.narc", "d_2d_I_M_free_yakata_ncl.bin", ROM.GetFileIDFromTable(lvl.Blocks[0][0x12], ROM.Data.Table_FG_NCL));

            MessageBox.Show(LanguageManager.Get("General", "Completed"));
        }

        //WTF was this for?!
        //private void NarcReplace(string NarcName, string f1, string f2) { }

        private void NarcReplace(string NarcName, string f1, ushort f2)
        {
            NarcFilesystem fs = new NarcFilesystem(ROM.FS.getFileByName(NarcName));

            NSMBe5.DSFileSystem.File f = fs.getFileByName(f1);
            if (f == null)
                Console.Out.WriteLine("No File: " + NarcName + "/" + f1);
            else
            {
                f.beginEdit(this);
                f.replace(ROM.FS.getFileById(f2).getContents(), this);
                f.endEdit(this);
            }
            fs.close();            
        }

        private void NarcReplace(string NarcName, string f1)
        {
            NarcFilesystem fs = new NarcFilesystem(ROM.FS.getFileByName(NarcName));

            NSMBe5.DSFileSystem.File f = fs.getFileByName(f1);
            f.beginEdit(this);
            f.replace(ROM.FS.getFileByName(f1).getContents(), this);
            f.endEdit(this);

            fs.close();
        }

        // Code hacking tools
        private void decompArm9Bin_Click(object sender, EventArgs e)
        {
            Arm9BinaryHandler handler = new Arm9BinaryHandler();
            handler.decompress();
            MessageBox.Show("Arm9 binary successfully decompressed", "Arm9 binary decompressing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private CodePatcher GetCodePatcher(DirectoryInfo path)
        {
            switch (Properties.Settings.Default.CodePatchingMethod)
            {
                case CodePatcher.Method.NSMBe:
                    return new CodePatcherNSMBe(path);
                case CodePatcher.Method.Fireflower:
                    return new CodePatcherModern(path, "fireflower");
                case CodePatcher.Method.NCPatcher:
                    return new CodePatcherModern(path, "ncpatcher");
                default:
                    throw new Exception("Illegal code patching method specified");
            }
        }

        private void compileInsert_Click(object sender, EventArgs e)
        {
            CodePatcher patcher = GetCodePatcher(ROM.romfile.Directory);

            try
            {
                patcher.Execute();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong during code patching:\n" + ex.Message, "Code patching", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleanBuild_Click(object sender, EventArgs e)
        {
            CodePatcher patcher = GetCodePatcher(ROM.romfile.Directory);

            try
            {
                patcher.CleanBuild();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong during build cleaning:\n" + ex.Message, "Build cleaning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //Settings

        private void updateStageObjSetsButton_Click(object sender, EventArgs e)
        {
			StageObjSettings.Update();
        }
        
        //Other crap
        
        private void LevelChooser_FormClosing(object sender, FormClosingEventArgs e)
        {
            ROM.close();
            Console.Out.WriteLine(e.CloseReason.ToString());
            Properties.Settings.Default.BackupFiles = "";
            Properties.Settings.Default.Save();
        }

        private void renameBtn_Click(object sender, EventArgs e)
        {
            if (musicList.SelectedIndex == -1)
                return;
            string newName;
            string oldName = musicList.SelectedItem.ToString();
            oldName = oldName.Substring(oldName.IndexOf(" ") + 1);
            if (textForm.ShowDialog(LanguageManager.Get("LevelChooser", "rnmmusic"), oldName, out newName) == DialogResult.OK)
            {
                if (newName == string.Empty)
                {
                    ROM.UserInfo.removeListItem("Music", musicList.SelectedIndex, true);
                    musicList.Items[musicList.SelectedIndex] = string.Format("{0}: {1}", musicList.SelectedIndex, LanguageManager.GetList("Music")[musicList.SelectedIndex].Split('=')[1]);
                    return;
                }
                ROM.UserInfo.setListItem("Music", musicList.SelectedIndex, string.Format("{0}={1}", musicList.SelectedIndex, newName), true);
                musicList.Items[musicList.SelectedIndex] = string.Format("{0}: {1}", musicList.SelectedIndex, newName);
            }
        }

        private void autoBackupTime_ValueChanged(object sender, EventArgs e)
        {
            if (init)
            {
                Properties.Settings.Default.AutoBackup = chkAutoBackup.Checked ? (int)autoBackupTime.Value : 0;
                Properties.Settings.Default.Save();
            }
        }

        private void deleteBackups_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show((LanguageManager.Get("LevelChooser", "delbackup")), (LanguageManager.Get("LevelChooser", "delbacktitle")), MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                String backupPath = Path.Combine(Application.StartupPath, "Backup");
                if (System.IO.Directory.Exists(backupPath))
                    System.IO.Directory.Delete(backupPath, true);
            }
        }

        private void dlpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ROM.dlpMode = dlpCheckBox.Checked;
            Properties.Settings.Default.dlpMode = dlpCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void LevelChooser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Xdelta_export_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LanguageManager.Get("Patch", "XSelectROM") + LanguageManager.Get("Patch", "XRestartAfterApplied"), LanguageManager.Get("Patch", "XExport"), MessageBoxButtons.OK, MessageBoxIcon.Information);

            OpenFileDialog cleanROM_openFileDialog = new OpenFileDialog();
            cleanROM_openFileDialog.Title = "Please select a clean NSMB ROM file";
            cleanROM_openFileDialog.Filter = "Nintendo DS ROM (*.nds)|*.nds|All files (*.*)|*.*";

            if (cleanROM_openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            SaveFileDialog xdelta_saveFileDialog = new SaveFileDialog();
            xdelta_saveFileDialog.Title = "Please select where to save the XDelta patch";
            xdelta_saveFileDialog.Filter = "XDelta Patch (*.xdelta)|*.xdelta|All files (*.*)|*.*";

            if (xdelta_saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                ROM.close();

                string str = " -f -s \"" + cleanROM_openFileDialog.FileName + "\" \"" + Properties.Settings.Default.ROMPath + "\" \"" + xdelta_saveFileDialog.FileName + "\"";
                Process process = new Process();
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = "xdelta3.exe";
                process.StartInfo.Arguments = str;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardError = true;
                process.Start();
                string end = process.StandardError.ReadToEnd();
                if (end == "")
                {
                    MessageBox.Show("Patch created successfully!", "Success!");
                }
                else
                {
                    MessageBox.Show(end, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                process.WaitForExit();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An unexpected exception has occured!\nDetails:\n" + ex, LanguageManager.Get("SpriteData", "ErrorTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Restart NSMBe
                Process process2 = new Process();
                process2.StartInfo.FileName = Application.ExecutablePath;
                process2.StartInfo.Arguments = "\"" + Properties.Settings.Default.ROMPath + "\"";
                process2.Start();
                Application.Exit();
            }
        }

        private void Xdelta_import_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All of the ROM contents will be replaced with the XDelta patch, unlike the NSMBe patches, this one overwrites the ROM entirely!\n\nNSMBe is going to restart after the import has finished.\n\nDo you still want to contiue?", LanguageManager.Get("General", "Warning"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            MessageBox.Show(LanguageManager.Get("Patch", "XSelectROM"), LanguageManager.Get("Patch", "XImport"), MessageBoxButtons.OK, MessageBoxIcon.Information);

            OpenFileDialog cleanROM_openFileDialog = new OpenFileDialog();
            cleanROM_openFileDialog.Title = "Please select a clean NSMB ROM file";
            cleanROM_openFileDialog.Filter = "Nintendo DS ROM (*.nds)|*.nds|All files (*.*)|*.*";

            if (cleanROM_openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            OpenFileDialog xdelta_openFileDialog = new OpenFileDialog();
            xdelta_openFileDialog.Title = "Please select the XDelta patch to import";
            xdelta_openFileDialog.Filter = "XDelta Patch (*.xdelta)|*.xdelta|All files (*.*)|*.*";

            if (xdelta_openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                ROM.close();

                string str = " -d -f -s \"" + cleanROM_openFileDialog.FileName + "\" \"" + xdelta_openFileDialog.FileName + "\" \"" + Properties.Settings.Default.ROMPath + "\"";
                Process process = new Process();
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = "xdelta3.exe";
                process.StartInfo.Arguments = str;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardError = true;
                process.Start();
                string end = process.StandardError.ReadToEnd();
                if (end == "")
                {
                    MessageBox.Show("ROM patched successfully, restarting NSMBe...");
                }
                else
                {
                    MessageBox.Show(end + "\n\nRestarting NSMBe!", "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                process.WaitForExit();

                //Restart NSMBe
                Process process2 = new Process();
                process2.StartInfo.FileName = Application.ExecutablePath;
                process2.StartInfo.Arguments = "\"" + Properties.Settings.Default.ROMPath + "\"";
                process2.Start();
                Application.Exit();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An unexpected exception has occured, restarting!\nDetails:\n" + ex, LanguageManager.Get("SpriteData", "ErrorTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Restart NSMBe
                Process process2 = new Process();
                process2.StartInfo.FileName = Application.ExecutablePath;
                process2.StartInfo.Arguments = "\"" + Properties.Settings.Default.ROMPath + "\"";
                process2.Start();
                Application.Exit();
            }
        }

        private void patchMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CodePatchingMethod = patchMethodComboBox.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void languagesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = languagesComboBox.SelectedItem.ToString();

            if (selected == Properties.Settings.Default.LanguageFile)
            {
                return;
            }

            Properties.Settings.Default.LanguageFile = selected;
            Properties.Settings.Default.Save();

            string text = LanguageManager.Get("LevelChooser", "LangChanged");
            string caption = LanguageManager.Get("LevelChooser", "LangChangedTitle");
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/TheGameratorT/NSMB-Editor");
        }

        private void linkOgRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Dirbaio/NSMB-Editor");
        }

        private void linkNSMBHD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://nsmbhd.net");
        }

        private bool IsFontInstalled(string fontName)
        {
            using (var testFont = new Font(fontName, 8))
            {
                return fontName == testFont.Name;
            }
        }

        private void setFontBtn_Click(object sender, EventArgs e)
        {
            string fontName = fontTextBox.Text;
            if (IsFontInstalled(fontName))
            {
                Properties.Settings.Default.UIFont = fontTextBox.Text;
                Program.ApplyFontToControls(Controls);
            }
            else
            {
                MessageBox.Show("Could not find the font \"" + fontName + "\"", "Font not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void managePluginsBtn_Click(object sender, EventArgs e)
		{
			PluginSelector.Open();
		}

        #region Menu Event Handlers

        private void openROMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenROM();
        }

        private void openBackupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenBackups();
        }

        private void closeROMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseROM();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connectToNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectToNetwork();
        }

        #endregion

        #region ROM Management Methods

        private void OpenROM()
        {
            string path = "";

            OpenFileDialog openROMDialog = new OpenFileDialog();
            openROMDialog.Filter = LanguageManager.Get("Filters", "rom");
            if (Properties.Settings.Default.ROMFolder != "")
                openROMDialog.InitialDirectory = Properties.Settings.Default.ROMFolder;
            if (openROMDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                path = openROMDialog.FileName;

            if (path == "")
                return;

            LoadROMFromPath(path);
        }

        private void OpenBackups()
        {
            if (Properties.Settings.Default.BackupFiles == "" ||
                MessageBox.Show(LanguageManager.Get("StartForm", "OpenBackups"), LanguageManager.Get("StartForm", "OpenBackupsTitle"), MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            string[] backups = Properties.Settings.Default.BackupFiles.Split(';');
            string path = backups[0];

            if (path == "")
                return;

            // Add remaining backups to the ROM backup list
            for (int l = 1; l < backups.Length; l++)
                ROM.fileBackups.Add(backups[l]);

            LoadROMFromPath(path);
        }

        private void LoadROMFromPath(string path)
        {
            try
            {
                NitroROMFilesystem fs = new NitroROMFilesystem(path);
                Properties.Settings.Default.ROMPath = path;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.ROMFolder = System.IO.Path.GetDirectoryName(path);
                Properties.Settings.Default.Save();

                ROM.load(fs);
                StageObjSettings.Load();

                romLoaded = true;
                LoadROMDependentData();
                UpdateMenuState();
                
                // Add to recent files
                AddToRecentFiles(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadROMDependentData()
        {
            if (!romLoaded) return;

            filesystemBrowser1.Load(ROM.FS);
            PluginManager.Initialize();

            LoadLevelNames();
            if (ROM.UserInfo != null)
            {
                musicList.Items.Clear();
                musicList.Items.AddRange(ROM.UserInfo.getFullList("Music").ToArray());
            }

            // Refresh tileset and background lists
            tilesetList1.RefreshList();
            backgroundList1.RefreshList();

            // Load file backups from crash
            string backupPath = Path.Combine(Application.StartupPath, "Backup");
            if (ROM.fileBackups.Count > 0) {
                foreach (string filename in ROM.fileBackups) {
                    try
                    {
                        new LevelEditor(new NSMBLevel(LevelSource.getForBackupLevel(filename, backupPath))).Show();
                    }
                    catch (Exception) { }
                }
            }

            Text = "NSMB Editor " + Version.GetString() + " - " + ROM.filename;

            if (!ROM.isNSMBRom)
            {
                if (tabControl1.TabPages.Contains(tabPage2))
                    tabControl1.TabPages.Remove(tabPage2);
                if (tabControl1.TabPages.Contains(tabPage5))
                    tabControl1.TabPages.Remove(tabPage5);
                if (tabControl1.TabPages.Contains(tabPage6))
                    tabControl1.TabPages.Remove(tabPage6);
                nsmbToolsGroupbox.Enabled = false;
                musicSlotsGrp.Enabled = false;
            }
            else
            {
                if (!tabControl1.TabPages.Contains(tabPage2))
                    tabControl1.TabPages.Insert(0, tabPage2);
                if (!tabControl1.TabPages.Contains(tabPage5))
                    tabControl1.TabPages.Insert(1, tabPage5);
                if (!tabControl1.TabPages.Contains(tabPage6))
                    tabControl1.TabPages.Insert(2, tabPage6);
                nsmbToolsGroupbox.Enabled = true;
                musicSlotsGrp.Enabled = true;
            }

            EnableROMDependentControls();
        }

        private void CloseROM()
        {
            if (!romLoaded) return;

            // Close all ROM-dependent windows
            CloseROMDependentWindows();

            // Clear ROM data and properly close file handles
            ROM.close();
            ROM.FS = null;
            ROM.filename = "";
            romLoaded = false;

            // Clear UI
            levelTreeView.Nodes.Clear();
            musicList.Items.Clear();
            filesystemBrowser1.Load(null);

            // Refresh tileset and background lists (clear them)
            tilesetList1.RefreshList();
            backgroundList1.RefreshList();

            // Update title
            Text = "NSMB Editor " + Version.GetString();

            DisableROMDependentControls();
            UpdateMenuState();
        }

        private void CloseROMDependentWindows()
        {
            // Close static forms that are tracked
            if (imgMgr != null && !imgMgr.IsDisposed)
            {
                imgMgr.Close();
                imgMgr = null;
            }

            if (DataFinderForm != null && !DataFinderForm.IsDisposed)
            {
                DataFinderForm.Close();
                DataFinderForm = null;
            }

            // Close all forms that depend on ROM data
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form form in openForms)
            {
                // Skip the main LevelChooser form
                if (form == this)
                    continue;

                // Close forms
                form.Close();
            }
        }

        private void ConnectToNetwork()
        {
            try
            {
                NetFilesystem fs = new NetFilesystem(hostTextBox.Text, Int32.Parse(portTextBox.Text));
                ROM.load(fs);
                StageObjSettings.Load();

                romLoaded = true;
                LoadROMDependentData();
                UpdateMenuState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EnableROMDependentControls()
        {
            tabControl1.Enabled = true;
        }

        private void DisableROMDependentControls()
        {
            tabControl1.Enabled = false;
        }

        private void UpdateMenuState()
        {
            closeROMToolStripMenuItem.Enabled = romLoaded;
            openBackupsToolStripMenuItem.Enabled = Properties.Settings.Default.BackupFiles != "";
            recentFilesToolStripMenuItem.Enabled = true; // Recent files should always be accessible
        }

        #endregion

        #region Recent Files Management

        private const int MaxRecentFiles = 10;

        private void LoadRecentFiles()
        {
            UpdateRecentFilesMenu();
        }

        private void AddToRecentFiles(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                return;

            var recentFiles = GetRecentFiles();
            
            // Remove if already exists
            recentFiles.Remove(filePath);
            
            // Add to beginning
            recentFiles.Insert(0, filePath);
            
            // Keep only MaxRecentFiles
            while (recentFiles.Count > MaxRecentFiles)
                recentFiles.RemoveAt(recentFiles.Count - 1);
            
            // Save back to settings
            Properties.Settings.Default.RecentFiles = string.Join(";", recentFiles.ToArray());
            Properties.Settings.Default.Save();
            
            UpdateRecentFilesMenu();
        }

        private List<string> GetRecentFiles()
        {
            var recentFiles = new List<string>();
            if (!string.IsNullOrEmpty(Properties.Settings.Default.RecentFiles))
            {
                var files = Properties.Settings.Default.RecentFiles.Split(';');
                foreach (var file in files)
                {
                    if (!string.IsNullOrEmpty(file) && System.IO.File.Exists(file))
                        recentFiles.Add(file);
                }
            }
            return recentFiles;
        }

        private void UpdateRecentFilesMenu()
        {
            // Clear existing recent files
            recentFilesToolStripMenuItem.DropDownItems.Clear();
            
            var recentFiles = GetRecentFiles();
            
            if (recentFiles.Count == 0)
            {
                var emptyItem = new ToolStripMenuItem("(No recent files)");
                emptyItem.Enabled = false;
                recentFilesToolStripMenuItem.DropDownItems.Add(emptyItem);
            }
            else
            {
                for (int i = 0; i < recentFiles.Count; i++)
                {
                    var fileName = System.IO.Path.GetFileName(recentFiles[i]);
                    var menuText = $"&{i + 1} {fileName}";
                    var menuItem = new ToolStripMenuItem(menuText);
                    menuItem.Tag = recentFiles[i];
                    menuItem.Click += RecentFileMenuItem_Click;
                    recentFilesToolStripMenuItem.DropDownItems.Add(menuItem);
                }
                
                // Add separator and clear option
                recentFilesToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
                var clearItem = new ToolStripMenuItem("Clear Recent Files");
                clearItem.Click += ClearRecentFiles_Click;
                recentFilesToolStripMenuItem.DropDownItems.Add(clearItem);
            }
        }

        private void RecentFileMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            if (menuItem?.Tag is string filePath)
            {
                if (System.IO.File.Exists(filePath))
                {
                    LoadROMFromPath(filePath);
                }
                else
                {
                    MessageBox.Show($"File not found: {filePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Remove from recent files if it doesn't exist
                    var recentFiles = GetRecentFiles();
                    recentFiles.Remove(filePath);
                    Properties.Settings.Default.RecentFiles = string.Join(";", recentFiles.ToArray());
                    Properties.Settings.Default.Save();
                    UpdateRecentFilesMenu();
                }
            }
        }

        private void ClearRecentFiles_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RecentFiles = "";
            Properties.Settings.Default.Save();
            UpdateRecentFilesMenu();
        }

        #endregion
    }
}
