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
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NSMBe5.NSBMD;
using NSMBe5.TilemapEditor;

namespace NSMBe5.DSFileSystem
{
    public partial class FilesystemBrowser : UserControl
    {
        private Filesystem fs;

        public FilesystemBrowser()
        {
            InitializeComponent();

            LanguageManager.ApplyToContainer(this, "FilesystemBrowser");
            UpdateFileInfo();

            //The ImageList is created here rather than in Visual Studio
            //because it looks like the Mono compiler can't handle ImageList resources.
            //So, please don't create ImageLists using the Designer!!

            fileTreeView.ImageList = new ImageList();
            fileTreeView.ImageList.ColorDepth = ColorDepth.Depth32Bit;

            for(int i = 0; i < 4; i++)
            {
                List<Bitmap> bitmaps = new List<Bitmap>();

                bitmaps.Add(new Icon(Properties.Resources.folder_open, new Size(16, 16)).ToBitmap());
                bitmaps.Add(new Icon(Properties.Resources.file_unk, new Size(16, 16)).ToBitmap());
                bitmaps.Add(Properties.Resources.file_narc);
                bitmaps.Add(new Icon(Properties.Resources.file_ncg, new Size(16, 16)).ToBitmap());
                bitmaps.Add(Properties.Resources.file_ncl);
                bitmaps.Add(Properties.Resources.file_nsc);
                bitmaps.Add(Properties.Resources.file_nsbmd);
                bitmaps.Add(Properties.Resources.file_nsbtx);
                bitmaps.Add(Properties.Resources.file_sdat);
                bitmaps.Add(Properties.Resources.file_enpg);
                bitmaps.Add(Properties.Resources.file_nsbca);
                bitmaps.Add(Properties.Resources.file_nsbtp);
                bitmaps.Add(Properties.Resources.file_nsbta);
                bitmaps.Add(Properties.Resources.file_nsbma);
                bitmaps.Add(Properties.Resources.file_nsbva);
                bitmaps.Add(new Icon(Properties.Resources.file_txt, new Size(16, 16)).ToBitmap());
                bitmaps.Add(Properties.Resources.file_spa);
                bitmaps.Add(new Icon(Properties.Resources.file_config, new Size(16, 16)).ToBitmap());
                bitmaps.Add(Properties.Resources.file_bnbl);
                bitmaps.Add(Properties.Resources.file_bncl);

                foreach (Bitmap bitmap in bitmaps)
                {
                    Bitmap result = new Bitmap(bitmap, new Size(16, 16));

                    //Add LZ icons
                    Graphics g = Graphics.FromImage(result);
                    if (i == 1)
                        g.DrawImage(new Bitmap(Properties.Resources.lz_icon, new Size(16, 16)), new Point(0, 0));
                    else if (i == 2)
                        g.DrawImage(new Bitmap(Properties.Resources.lz_wh_icon, new Size(16, 16)), new Point(0, 0));
                    else if (i == 3)
                        g.DrawImage(new Bitmap(Properties.Resources.yaz0_icon, new Size(16, 16)), new Point(0, 0));

                    fileTreeView.ImageList.Images.Add(result);
                }
            }
        }

        public new void Load(Filesystem fs)
        {
            this.fs = fs;

            extractFileDialog.Filter = LanguageManager.Get("Filters", "all");
            replaceFileDialog.Filter = LanguageManager.Get("Filters", "all");

            fileTreeView.Nodes.Clear();

            if (fs == null)
            {
                return;
            }

            TreeNode main = new TreeNode(fs.mainDir.name, 0, 0);
            main.Tag = fs.mainDir;

            loadDir(main, fs.mainDir);

            fileTreeView.Nodes.Clear();
            fileTreeView.Nodes.Add(main);
            main.Expand();
        }

        private string getFileTypeForFile(File f)
        {
            string name = f.name.ToLowerInvariant();

            if (f.id == 131)
                return "NSMBeUD";

            //Name checks
            if (name == "banner.bin") return "BANNER";
            if (name.Contains("_ncg")) return "NCG";
            if (name.Contains("_ncl")) return "NCL";
            if (name.Contains("_nsc")) return "NSC";
            if (name.EndsWith(".enpg")) return "ENPG"; //ENPG (256x256 Bitmap with 256x256 Palette)

            //Header checks
            CompressedFile.CompressionType CompressionType = f.guessCompression(true);

            int i = 0;
            if (CompressionType == CompressedFile.CompressionType.LZ)
                i = 5;
            else if (CompressionType == CompressedFile.CompressionType.LZWithHeader)
                i = 9;
            else if (CompressionType == CompressedFile.CompressionType.Yaz0)
                i = 17;

            int HeaderMinSize = 4 + i;

            if (f.fileSize >= HeaderMinSize + 0x10 && f.getUintAt(i + 0x10) == 0x43484152) return "NCGR"; //NCGR (NCR with header)
            if (f.fileSize >= HeaderMinSize + 0x10 && f.getUintAt(i + 0x10) == 0x504C5454) return "NCLR"; //NCLR (NCL with header)
            if (f.fileSize >= HeaderMinSize + 0x10 && f.getUintAt(i + 0x10) == 0x5343524E) return "NSCR"; //NSCR (NSC with header)
            if (f.fileSize >= HeaderMinSize && f.getUintAt(i) == 0x4352414E) return "NARC"; //NARC (ARCHIVE)
            if (f.fileSize >= HeaderMinSize && f.getUintAt(i) == 0x30444D42) return "BMD0"; //BMD0 (NSBMD/MODEL)
            if (f.fileSize >= HeaderMinSize && f.getUintAt(i) == 0x30585442) return "BTX0"; //BTX0 (NSBTX/MODEL TEXTURE)
            if (f.fileSize >= HeaderMinSize && f.getUintAt(i) == 0x54414453) return "SDAT"; //SDAT (SDAT/MUSIC)
            if (f.fileSize >= HeaderMinSize && f.getUintAt(i) == 0x30414342) return "BCA0"; //BCA0 (NSBCA/ANIMATION)
            if (f.fileSize >= HeaderMinSize && f.getUintAt(i) == 0x30505442) return "BTP0"; //BTP0 (NSBTP)
            if (f.fileSize >= HeaderMinSize && f.getUintAt(i) == 0x30415442) return "BTA0"; //BTA0 (NSBTA)
            if (f.fileSize >= HeaderMinSize && f.getUintAt(i) == 0x30414D42) return "BMA0"; //BMA0 (NSBMA)
            if (f.fileSize >= HeaderMinSize && f.getUintAt(i) == 0x30415642) return "BVA0"; //BVA0 (NSBVA)
            if (f.fileSize >= HeaderMinSize && f.getUintAt(i) == 0x4753454D) return "BMG"; //MESG (BMG/MESSAGE)
            if (f.fileSize >= HeaderMinSize + 4 && f.getUintAt(i) == 0x53504120 && f.getUintAt(i + 4) == 0x315F3232) return "SPA"; // APS22_1 (SPA/PARTICLE)
            if (f.fileSize >= HeaderMinSize && f.getUintAt(i) == 0X4C424E4A) return "BNBL"; //JNBL (BNBL/TOUCHPOS)
            if (f.fileSize >= HeaderMinSize && f.getUintAt(i) == 0x4C434E4A) return "BNCL"; //JNCL (BNCL/GFXPOS)
            if (f.fileSize >= HeaderMinSize && f.getUintAt(i) == 0x44434E4A) return "BNCD"; //JNCD (BNCD/BITMAP)

            return "Unknown File";
        }

        private int getIconForFile(File f)
        {
            int returnValue = 1;

            CompressedFile.CompressionType CompressionType = f.guessCompression(true);
            string type = getFileTypeForFile(f);

            if (type == "NSMBeUD") returnValue = 17;
            if (type == "NARC") returnValue = 2;
            if (type == "CARC") returnValue = 2;
            if (type == "NCG") returnValue = 3;
            if (type == "NCGR") returnValue = 3;
            if (type == "BNCD") returnValue = 3;
            if (type == "BANNER") returnValue = 3;
            if (type == "NCL") returnValue = 4;
            if (type == "NCLR") returnValue = 4;
            if (type == "NSC") returnValue = 5;
            if (type == "NSCR") returnValue = 5;
            if (type == "BMD0") returnValue = 6;
            if (type == "BTX0") returnValue = 7;
            if (type == "SDAT") returnValue = 8;
            if (type == "ENPG") returnValue = 9;
            if (type == "BCA0") returnValue = 10;
            if (type == "BTP0") returnValue = 11;
            if (type == "BTA0") returnValue = 12;
            if (type == "BMA0") returnValue = 13;
            if (type == "BVA0") returnValue = 14;
            if (type == "BMG") returnValue = 15;
            if (type == "SPA") returnValue = 16;
            if (type == "BNBL") returnValue = 18;
            if (type == "BNCL") returnValue = 19;

            int intCompressionType = 0;
            if (CompressionType == CompressedFile.CompressionType.LZ)
                intCompressionType = 1;
            else if (CompressionType == CompressedFile.CompressionType.LZWithHeader)
                intCompressionType = 2;
            else if (CompressionType == CompressedFile.CompressionType.Yaz0)
                intCompressionType = 3;

            return returnValue + (intCompressionType * (fileTreeView.ImageList.Images.Count / 4));
        }

        private void loadDir(TreeNode node, Directory dir)
        {
            foreach (File f in dir.childrenFiles)
            {
                int ic = getIconForFile(f);
                TreeNode fileNode = new TreeNode(f.name, ic, ic);
                fileNode.Tag = f;
                node.Nodes.Add(fileNode);
            }

            foreach (Directory d in dir.childrenDirs)
            {
                TreeNode dirNode = new TreeNode(d.name, 0, 0);
                dirNode.Tag = d;
                loadDir(dirNode, d);
                node.Nodes.Add(dirNode);
            }
        }

        private void fileTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateFileInfo();
        }

        private void UpdateFileInfo()
        {
            TreeNode n = fileTreeView.SelectedNode;

            string StatusMsg;
            bool e;
            bool extract = false;

            if (n == null)
            {
                e = false;
                StatusMsg = LanguageManager.Get("FilesystemBrowser", "NoFileSelected");
            }
            else if (n.Tag is Directory)
            {
                StatusMsg = string.Format(LanguageManager.Get("FilesystemBrowser", "FolderStatus"), n.Text, (n.Tag as Directory).id);
                e = false;
                extract = true;
            }
            else
            {
                File f = n.Tag as File;
                StatusMsg = string.Format(LanguageManager.Get("FilesystemBrowser", "FileStatus"), (f is PhysicalFile)?((PhysicalFile)f).fileBegin.ToString("X"):"?", f.fileSize.ToString(), f.id);
                e = true;
                extract = true;

                n.ImageIndex = getIconForFile(f);
                n.SelectedImageIndex = getIconForFile(f);
            }

            extractFileButton.Enabled = extract;
            replaceFileButton.Enabled = extract;
            compressFileButton.Enabled = e;
            decompressFileButton.Enabled = e;
            hexEdButton.Enabled = e;
            //compressWithHeaderButton.Enabled = e;
            //decompressWithHeaderButton.Enabled = e;
            decompressOverlayButton.Enabled = e;

            selectedFileInfo.Text = StatusMsg;
        }

        private void extractFileButton_Click(object sender, EventArgs e)
        {
            if (fileTreeView.SelectedNode.Tag is File)
            {
                File f = fileTreeView.SelectedNode.Tag as File;

                string FileName = f.name;
                extractFileDialog.FileName = FileName;
                if (extractFileDialog.ShowDialog() == DialogResult.OK)
                    extractFile(f, extractFileDialog.FileName);
            }
            else
            {
                Directory d = fileTreeView.SelectedNode.Tag as Directory;

                if (extractDirectoryDialog.ShowDialog() == DialogResult.OK)
                    extractDirectory(d, extractDirectoryDialog.SelectedPath);
            }
        }

        private void extractFile(File f, String fileName)
        {
            byte[] tempFile = f.getContents();
            FileStream wfs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            wfs.Write(tempFile, 0, tempFile.GetLength(0));
            wfs.Dispose();
        }

        private string extractDirectory(Directory d, String filePath)
        {
            String newFolderName;
            if (d.name.Contains(Path.DirectorySeparatorChar.ToString())) // This will be the root folder
                newFolderName = "FILESYSTEM";
            else
                newFolderName = d.name;
            String destDir = System.IO.Path.Combine(filePath, newFolderName);
            if (!System.IO.Directory.Exists(destDir))
                System.IO.Directory.CreateDirectory(destDir);

            foreach (File f in d.childrenFiles)
                extractFile(f, System.IO.Path.Combine(destDir, f.name));
            foreach (Directory subd in d.childrenDirs)
                extractDirectory(subd, destDir);
            return destDir;
        }

        private void replaceFileButton_Click(object sender, EventArgs e)
        {
            if (fileTreeView.SelectedNode.Tag is File)
            {
                File f = fileTreeView.SelectedNode.Tag as File;

                try {
                    f.beginEdit(this);
                } catch (AlreadyEditingException) {
                    MessageBox.Show(LanguageManager.Get("Errors", "File"));
                    return;
                }
                
                string FileName = f.name;
                replaceFileDialog.FileName = FileName;
                if (replaceFileDialog.ShowDialog() != DialogResult.OK) {
                    UpdateFileInfo();
                    f.endEdit(this);
                    return;
                }

                //if (f.id >= 0 && f.id <= ROM.OverlayCount)
                //{
                //    DialogResult r = MessageBox.Show(LanguageManager.Get("FilesystemBrowser", "ImportOverlay"), LanguageManager.Get("FilesystemBrowser", "ImportOverlayTitle"), MessageBoxButtons.YesNoCancel);
                //    if(r == DialogResult.Cancel)
                //    {
                //        UpdateFileInfo();
                //        f.endEdit(this);
                //        return;
                //    }

                //    f.isCompressed = r == DialogResult.Yes;
                //}
                replaceFile(f, replaceFileDialog.FileName);

                UpdateFileInfo();
                f.endEdit(this);
            }
            else
            {
                if (extractDirectoryDialog.ShowDialog() == DialogResult.OK)
                {
                    Directory d = fileTreeView.SelectedNode.Tag as Directory;
                    replaceDirectory(d, extractDirectoryDialog.SelectedPath);
                }
            }
        }

        private void replaceFile(File f, String inputFile)
        {
            // NOTE: f.beginEdit(this) must be called before this function
            FileStream rfs = new FileStream(inputFile, FileMode.Open, FileAccess.Read, FileShare.Read);
            byte[] tempFile = new byte[rfs.Length];
            rfs.Read(tempFile, 0, (int)rfs.Length);
            rfs.Dispose();
            f.replace(tempFile, this);
        }

        private void replaceDirectory(Directory d, String inputDir)
        {
            foreach (File f in d.childrenFiles)
            {
                try
                {
                    String inputFile = System.IO.Path.Combine(inputDir, f.name);
                    if (System.IO.File.Exists(inputFile))
                    {
                        f.beginEdit(this);
                        replaceFile(f, inputFile);
                        f.endEdit(this);
                    }
                    else
                        Console.Out.WriteLine("Input file does not exist: " + inputFile);
                }
                catch (Exception ex) {
                    Console.Out.WriteLine("Failed to replace file: " + f.name + "\n\n" + ex.Message);
                }
            }
            foreach (Directory subd in d.childrenDirs)
            {
                String nextDir = System.IO.Path.Combine(inputDir, subd.name);
                replaceDirectory(subd, nextDir);
            }
        }

        private void compressFileButton_Click(object sender, EventArgs e)
        {
            File f = fileTreeView.SelectedNode.Tag as File;

            try
            {
                f.beginEdit(this);
            }
            catch (AlreadyEditingException)
            {
                MessageBox.Show(LanguageManager.Get("Errors", "File"));
                return;
            }
            byte[] RawFile = f.getContents();
            byte[] CompFile = RawFile;

            CompressFilePrompt compressFilePrompt = new CompressFilePrompt();
            if (compressFilePrompt.Canceled)
            {
                f.endEdit(this);
                return;
            }

            if (compressFilePrompt.ChosenCompression == CompressedFile.CompressionType.LZ)
                CompFile = ROM.LZ77_Compress(CompFile, false);
            else if (compressFilePrompt.ChosenCompression == CompressedFile.CompressionType.LZWithHeader)
                CompFile = ROM.LZ77_Compress(CompFile, true);
            else if (compressFilePrompt.ChosenCompression == CompressedFile.CompressionType.Yaz0)
                CompFile = ROM.Yaz0_Compress(CompFile);

            f.replace(CompFile, this);
            UpdateFileInfo();
            f.endEdit(this);
        }

        private void decompressFileButton_Click(object sender, EventArgs e)
        {
            File f = fileTreeView.SelectedNode.Tag as File;
            try
            {
                try
                {
                    f.beginEdit(this);
                }
                catch (AlreadyEditingException)
                {
                    MessageBox.Show(LanguageManager.Get("Errors", "File"));
                    return;
                }

                CompressedFile RawFile = new CompressedFile(f, CompressedFile.CompressionType.MaybeCompressed);

                f.replace(RawFile.getContents(), this);
                UpdateFileInfo();
                f.endEdit(this);
            }
            catch (Exception)
            {
                MessageBox.Show(LanguageManager.Get("FilesystemBrowser", "DecompressionFail"));
                if (f.beingEditedBy(this))
                    f.endEdit(this);
            }
        }

        private void compressWithHeaderButton_Click(object sender, EventArgs e)
        {
            File f = fileTreeView.SelectedNode.Tag as File;

            try
            {
                f.beginEdit(this);
            }
            catch (AlreadyEditingException)
            {
                MessageBox.Show(LanguageManager.Get("Errors", "File"));
                return;
            }
            byte[] RawFile = f.getContents();
            byte[] CompFile = ROM.LZ77_Compress(RawFile, true);
            f.replace(CompFile, this);
            UpdateFileInfo();
            f.endEdit(this);
        }

        private void decompressWithHeaderButton_Click(object sender, EventArgs e)
        {
            File f = fileTreeView.SelectedNode.Tag as File;
            try
            {

                try
                {
                    f.beginEdit(this);
                }
                catch (AlreadyEditingException)
                {
                    MessageBox.Show(LanguageManager.Get("Errors", "File"));
                    return;
                }

                if (f.getUintAt(0) != 0x37375A4C)
                {
                    MessageBox.Show(LanguageManager.Get("Errors", "NoLZHeader"));
                    f.endEdit(this);
                    return;
                }

                byte[] CompFile = f.getContents();
                byte[] CompFileWithoutHeader = new byte[CompFile.Length - 4];
                Array.Copy(CompFile, 4, CompFileWithoutHeader, 0, CompFileWithoutHeader.Length);
                byte[] RawFile = ROM.LZ77_Decompress(CompFileWithoutHeader, false);
                f.replace(RawFile, this);
                UpdateFileInfo();
                f.endEdit(this);
            }
            catch (Exception)
            {
                MessageBox.Show(LanguageManager.Get("FilesystemBrowser", "DecompressionFail"));
                if (f.beingEditedBy(this))
                    f.endEdit(this);
            }
        }

        private void fileTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is Directory)
            {
                e.Node.Expand();
                return;
            }
            File f = e.Node.Tag as File;

            try
            {
                if (!(f.id < 0))
                    f = new CompressedFile(f, CompressedFile.CompressionType.MaybeCompressed);

                switch (getFileTypeForFile(f))
                {
                    case "BANNER":
                        {
                            LevelChooser.showImgMgr();
                            File imgFile = new InlineFile(f, 0x20, 0x200, f.name);
                            File palFile = new InlineFile(f, 0x220, 0x20, f.name);
                            LevelChooser.imgMgr.m.addImage(new Image2D(imgFile, 32, true));
                            LevelChooser.imgMgr.m.addPalette(new FilePalette(palFile));
                        }
                        break;
                    case "ENPG":
                        {
                            LevelChooser.showImgMgr();
                            File imgFile = new InlineFile(f, 0, 0x10000, f.name);
                            File palFile = new InlineFile(f, 0x10000, 0x200, f.name);
                            LevelChooser.imgMgr.m.addImage(new EnpgImage2D(imgFile));
                            LevelChooser.imgMgr.m.addPalette(new FilePalette(palFile));
                        }
                        break;
                    case "BNCD":
                        {
                            DialogResult result = MessageBox.Show("Is this a 256 colors BNCD?\n(No by default, Yes if using the 256 worldmap icons code hack)", LanguageManager.Get("General", "Question"), MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                                new Bncd256(f);
                            else if (result == DialogResult.No)
                                new Bncd(f);
                        }
                        break;
                    case "BTX0":
                    case "BMD0":
                        {
                            new NSBTX(f);
                        }
                        break;
                    case "NSCR":
                    case "NCGR":
                    case "NCLR":
                        {
                            SectionFileLoader.load(f);
                        }
                        break;
                    case "NARC":
                        {
                            //CARC is just the LZ compressed form of the NARC and because
                            //NSMBe can now detect the LZ form it won't be needed anymore
                            new FilesystemBrowserDialog(new NarcFilesystem(f)).Show();
                        }
                        break;
                    case "NCL":
                        {
                            new PaletteViewer(f).Show();
                        }
                        break;
                    case "NSC":
                        {
                            if (LevelChooser.imgMgr != null)
                            {
                                Image2D img = LevelChooser.imgMgr.m.getSelectedImage();
                                Palette[] pals = LevelChooser.imgMgr.m.getPalettes();
                                if(img != null && pals != null && pals.Length > 0)
                                {
                                    NSCPrompt nscPrompt = new NSCPrompt(f.getContents().Length);
                                    if(!nscPrompt.canceled)
                                    {
                                        Tilemap t = new Tilemap(f, nscPrompt.tileWidth, img, pals, nscPrompt.imgOffs, nscPrompt.palOffs);
                                        new TilemapEditorWindow(t).Show();
                                    }
                                    break;
                                }
                            }

                            MessageBox.Show("Please make sure you have at least a bitmap and a palette opened in the 2D Viewer before opening an NSC file.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    case "NCG":
                        {
                            LevelChooser.showImgMgr();
                            LevelChooser.imgMgr.m.addImage(new Image2D(f, 256, false));
                        }
                        break;
                    case "BNBL":
                        {
                            new BNBL(f);
                        }
                        break;
                    case "BNCL":
                        {
                            new BNCL(f);
                        }
                        break;
                }
            }
            catch (AlreadyEditingException ex)
            {
                MessageBox.Show(this, (LanguageManager.Get("Errors", "File")));
            }
        }

        private void hexEdButton_Click(object sender, EventArgs e)
        {
            File f = fileTreeView.SelectedNode.Tag as File;

            try
            {
                new FileHexEditor(f).Show();
            }
            catch (AlreadyEditingException)
            {
                MessageBox.Show(LanguageManager.Get("Errors", "File"));
                return;
            }     
        }

        private void decompressOverlayButton_Click(object sender, EventArgs e)
        {
        	//TODO
            File f = fileTreeView.SelectedNode.Tag as File;

            if (f.id < 0 || f.id > ROM.OverlayCount)
            {
                MessageBox.Show(LanguageManager.Get("FilesystemBrowser", "ErrorNotOverlay"));
                return;
            }

            Overlay ovdec = ROM.arm9ovs2[(int)f.id];

            if (!ovdec.isCompressed)
                MessageBox.Show(LanguageManager.Get("FilesystemBrowser", "ErrorDecompressed"));

            ovdec.decompress();
        }

        private void fileTreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            TreeNode node = e.Item as TreeNode;

            if (node.Tag is File)
            {
                // The dragged file must first be saved to disk
                File f = node.Tag as File;
                string FileName = f.name;
                string DestFileName = Path.Combine(System.IO.Path.GetTempPath(), FileName);
                extractFile(f, DestFileName);

                // Then start a drag and drop
                String[] files = new String[] { DestFileName };
                DragDropEffects drop = DoDragDrop(new DataObject(DataFormats.FileDrop, files), DragDropEffects.Move);
                // Delete the file if it wasn't dropped anywhere
                if (System.IO.File.Exists(DestFileName))
                    System.IO.File.Delete(DestFileName);
            }
            else if (node.Tag is Directory)
            {
                // Same process as above
                Directory d = node.Tag as Directory;
                String DestDir = System.IO.Path.GetTempPath();
                DestDir = extractDirectory(d, DestDir);

                String[] folders = new String[] { DestDir };
                DragDropEffects drop = DoDragDrop(new DataObject(DataFormats.FileDrop, folders), DragDropEffects.Move);
                if (System.IO.Directory.Exists(DestDir))
                    System.IO.Directory.Delete(DestDir, true);
            }
        }
    }
}
