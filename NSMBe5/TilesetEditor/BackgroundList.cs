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

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NSMBe5.DSFileSystem;
using NSMBe5.TilemapEditor;

namespace NSMBe5
{
    public partial class BackgroundList : UserControl
    {
        private class BackgroundEntry
        {
            public bool topLayer;
            public int id;
            public string name;
            public bool mappedTileset;
            public bool empty;
            public int GFXFileID;
            public int PalFileID;
            public int LayoutFileID;
            public int BitmapOffset;
            public int PaletteOffsets;

            public BackgroundEntry(bool topLayer, int id, string name, bool mappedTileset, bool empty = false)
            {
                string[] nameArray = name.Split('@');

                this.id = id;
                this.name = nameArray[0];
                this.topLayer = topLayer;
                this.mappedTileset = mappedTileset;
                this.empty = empty;
                this.GFXFileID = ROM.GetFileIDFromTable(this.id, this.topLayer ? ROM.Data.Table_FG_NCG : ROM.Data.Table_BG_NCG);
                this.PalFileID = ROM.GetFileIDFromTable(this.id, this.topLayer ? ROM.Data.Table_FG_NCL : ROM.Data.Table_BG_NCL);
                this.LayoutFileID = ROM.GetFileIDFromTable(this.id, this.topLayer ? ROM.Data.Table_FG_NSC : ROM.Data.Table_BG_NSC);
                this.BitmapOffset = this.topLayer ? 256 : 576;
                this.PaletteOffsets = this.topLayer ? 8 : 10;
                try { if (nameArray.Length > 1 && nameArray[1] != "default") this.GFXFileID = int.Parse(nameArray[1]); } catch (Exception) { this.GFXFileID = 65535; }
                try { if (nameArray.Length > 2 && nameArray[2] != "default") this.PalFileID = int.Parse(nameArray[2]); } catch (Exception) { this.PalFileID = 65535; }
                try { if (nameArray.Length > 3 && nameArray[3] != "default") this.LayoutFileID = int.Parse(nameArray[3]); } catch (Exception) { this.LayoutFileID = 65535; }
                try { if (nameArray.Length > 4 && nameArray[4] != "default") this.BitmapOffset = int.Parse(nameArray[4]); } catch (Exception) { this.BitmapOffset = 0; }
                try { if (nameArray.Length > 5 && nameArray[5] != "default") this.PaletteOffsets = int.Parse(nameArray[5]); } catch (Exception) { this.PaletteOffsets = 0; }
            }

            public override string ToString()
            {
                string type;
                if(mappedTileset)
                    type = LanguageManager.Get("BackgroundList", "tileset");
                else if (topLayer)
                    type = LanguageManager.Get("BackgroundList", "top");
                else
                    type = LanguageManager.Get("BackgroundList", "bottom");

                if(id > 75 && !mappedTileset)
                    return "" + type + " " + name;

                return type + " " + name;
            }
        }

        public TextInputForm textForm = new TextInputForm();

        public BackgroundList()
        {
            InitializeComponent();
            LanguageManager.ApplyToContainer(this, "BackgroundList");

            RefreshList();
        }

        public void RefreshList()
        {
            // Clear existing items
            tilesetListBox.Items.Clear();

            if (ROM.UserInfo == null) return;
            
            int id = 0;
            List<string> list = ROM.UserInfo.getFullList("Foregrounds");
            foreach (string name in list)
            {
                if (name == list[list.Count - 1]) continue;
                string trimmedname = name.Trim();
                if (trimmedname == "") continue;

                bool empty = false;
                string[] nameArray = trimmedname.Split(':');
                if (nameArray[1] == "")
                {
                    if (int.Parse(nameArray[0]) < 76)
                    {
                        nameArray[1] = " " + LanguageManager.Get("BackgroundList", "empty");
                        empty = true;
                    }
                    else
                        continue;
                }
                trimmedname = string.Join(":", nameArray[0], nameArray[1]);

                tilesetListBox.Items.Add(new BackgroundEntry(true, id, trimmedname, false, empty));
                id++;
            }
            id = 0;
            list = ROM.UserInfo.getFullList("Backgrounds");
            foreach (string name in list)
            {
                if (name == list[list.Count - 1]) continue;
                string trimmedname = name.Trim();
                if (trimmedname == "") continue;

                bool empty = false;
                string[] nameArray = trimmedname.Split(':');
                if (nameArray[1] == "")
                {
                    if (int.Parse(nameArray[0]) < 76)
                    {
                        nameArray[1] = " " + LanguageManager.Get("BackgroundList", "empty");
                        empty = true;
                    }
                    else
                        continue;
                }
                trimmedname = string.Join(":", nameArray[0], nameArray[1]);

                tilesetListBox.Items.Add(new BackgroundEntry(false, id, trimmedname, false, empty));
                id++;
            }
            list = ROM.UserInfo.getFullList("MappedTilesets");
            foreach (string name in list)
            {
                if (name == list[list.Count - 1]) continue;
                string trimmedname = name.Trim();
                if (trimmedname == "") continue;

                bool empty = false;
                string[] nameArray = trimmedname.Split(':');
                if (nameArray[1] == "")
                {
                    if (int.Parse(nameArray[0]) < 76)
                    {
                        nameArray[1] = " " + LanguageManager.Get("BackgroundList", "empty");
                        empty = true;
                    }
                    else
                        continue;
                }
                trimmedname = string.Join(":", nameArray[0], nameArray[1]);

                tilesetListBox.Items.Add(new BackgroundEntry(false, int.Parse(nameArray[0]), trimmedname, true, empty));
            }
        }

        File GFXFile;
        File PalFile;
        File LayoutFile;
        BackgroundEntry bg;

        private void getFiles()
        {
            bg = (BackgroundEntry)tilesetListBox.SelectedItem;

            GFXFile = ROM.FS.getFileById(bg.GFXFileID);
            PalFile = ROM.FS.getFileById(bg.PalFileID);
            LayoutFile = ROM.FS.getFileById(bg.LayoutFileID);
        }

        private Tilemap getTilemap()
        {

            getFiles();
            if (GFXFile == null) return null;
            if (PalFile == null) return null;
            if (LayoutFile == null) return null;

            LayoutFile = new CompressedFile(LayoutFile, CompressedFile.CompressionType.LZ);

            Image2D image = new Image2D(new CompressedFile(GFXFile, CompressedFile.CompressionType.MaybeCompressed), 256, false);
            CompressedFile paletteFile = new CompressedFile(PalFile, CompressedFile.CompressionType.MaybeCompressed);

            int palSize = 256;
            Color[] pal = FilePalette.arrayToPalette(paletteFile.getContents());
            if (pal.Length < 256)
                palSize = 16;
            List<Palette> palettes = new List<Palette>();
            for (int i = 0; i + palSize <= pal.Length; i += palSize)
            {
                int palOffs = i;
                int palLen = palSize;
                if (palOffs + palLen > pal.Length)
                    palLen = pal.Length - palOffs;

                palettes.Add(new FilePalette(new InlineFile(paletteFile, palOffs * 2, palLen * 2, paletteFile.name)));
            }

            Tilemap t = new Tilemap(LayoutFile, 64, image, palettes.ToArray(), bg.BitmapOffset, bg.PaletteOffsets);
            return t;
        }

        private void editSelectedBG()
        {
            if (tilesetListBox.SelectedItem == null)
                return;

            Tilemap t = getTilemap();
            if (t == null) return;

            if (bg.empty)
            {
                MessageBox.Show("This background is empty, please set it up first.", "NSMBe " + Version.GetString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            t.render();
            new TilemapEditorWindow(t).Show();
        }

        private void tilesetListBox_DoubleClick(object sender, EventArgs e)
        {
            editSelectedBG();
        }

        private void editTilesetBtn_Click(object sender, EventArgs e)
        {
            editSelectedBG();
        }

        string fileHeader = "NSMBe Exported Background";

        private void importTilesetBtn_Click(object sender, EventArgs e)
        {
            getFiles();

            if (GFXFile == null) return;
            if (PalFile == null) return;
            if (LayoutFile == null) return;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = LanguageManager.Get("Filters", "background");
            ofd.CheckFileExists = true;

            if (ofd.ShowDialog() != DialogResult.OK) return;

            System.IO.BinaryReader br = new System.IO.BinaryReader(
                new System.IO.FileStream(ofd.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read));
            string header = br.ReadString();
            if (header != fileHeader)
            {
                MessageBox.Show(
                    LanguageManager.Get("NSMBLevel", "InvalidFile"),
                    LanguageManager.Get("NSMBLevel", "Unreadable"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            readFileContents(GFXFile, br);
            readFileContents(PalFile, br);
            readFileContents(LayoutFile, br);
            br.Close();
        }

        private void exportTilesetBtn_Click(object sender, EventArgs e)
        {
            getFiles();

            if (GFXFile == null) return;
            if (PalFile == null) return;
            if (LayoutFile == null) return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = LanguageManager.Get("Filters", "background");
            if (sfd.ShowDialog() != DialogResult.OK) return;

            System.IO.BinaryWriter bw = new System.IO.BinaryWriter(
                new System.IO.FileStream(sfd.FileName, System.IO.FileMode.Create, System.IO.FileAccess.Write));
            bw.Write(fileHeader);
            writeFileContents(GFXFile, bw);
            writeFileContents(PalFile, bw);
            writeFileContents(LayoutFile, bw);
            bw.Close();
        }

        private void writeFileContents(File f, System.IO.BinaryWriter bw)
        {
            bw.Write((int)f.fileSize);
            bw.Write(f.getContents());
        }

        void readFileContents(File f, System.IO.BinaryReader br)
        {
            int len = br.ReadInt32();
            byte[] data = new byte[len];
            br.Read(data, 0, len);
            f.beginEdit(this);
            f.replace(data, this);
            f.endEdit(this);
        }

        private void importPNGButton_Click(object sender, EventArgs e)
        {
            getFiles();

            if (GFXFile == null) return;
            if (PalFile == null) return;
            if (LayoutFile == null) return;

            // Create a local copy because the global variables could be overwritten while the background is importing
            File myGFXFile = GFXFile;
            File myPalFile = PalFile;
            File myLayoutFile = LayoutFile;

            int offs = bg.topLayer ? 256 : 576;
            int palOffs = bg.topLayer ? 8 : 10;

            if(bg.mappedTileset)
            {
                offs = 192;
                palOffs = 2;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = LanguageManager.Get("Filters", "png");
            ofd.CheckFileExists = true;

            if (ofd.ShowDialog() != DialogResult.OK) return;
            string filename = ofd.FileName;

            Bitmap b = new Bitmap(filename);

            if (b.Size != new Size(512, 512))
                throw new Exception("Wrong image size");

            BgPNGImportPrompt bgPrompt = new BgPNGImportPrompt(bg.topLayer, bg.mappedTileset);
            if (!bgPrompt.finished)
                return;

            ImageTiler ti;
            if (bg.topLayer)
            {
                bgPrompt.bgFirstTileOffset = 0;
                ti = new ImageTiler(b, new Size(256, bgPrompt.fgHeightInPixels), new Size(512, 512), 50);
            }
            else
                ti = new ImageTiler(b, new Size(256, bgPrompt.bgHeightInPixels), new Size(512, 512), 50);

            Color[] palette = ImageIndexer.createPaletteForImage(b);

            ByteArrayOutputStream oo = new ByteArrayOutputStream();
            for (int i = 0; i < palette.Length; i++)
                oo.writeUShort(NSMBTileset.toRGB15(palette[i]));

            ByteArrayOutputStream offsetBitmapData = new ByteArrayOutputStream();
            for (int i = 0; i < 256 * bgPrompt.bgFirstTileOffset; i++)
                offsetBitmapData.writeByte(0);

            //byte[] newBitmapData = ImageIndexer.indexImageWithPalette(ti.tileBuffer, palette);
            byte[] newBitmapData = new byte[offsetBitmapData.getArray().Length + ImageIndexer.indexImageWithPalette(ti.tileBuffer, palette).Length];
            Buffer.BlockCopy(offsetBitmapData.getArray(), 0, newBitmapData, 0, offsetBitmapData.getArray().Length);
            Buffer.BlockCopy(ImageIndexer.indexImageWithPalette(ti.tileBuffer, palette), 0, newBitmapData, offsetBitmapData.getArray().Length, ImageIndexer.indexImageWithPalette(ti.tileBuffer, palette).Length);

            myPalFile.beginEdit(this);
            myPalFile.replace(ROM.LZ77_Compress(oo.getArray()), this);
            myPalFile.endEdit(this);
            myGFXFile.beginEdit(this);
            myGFXFile.replace(ROM.LZ77_Compress(newBitmapData), this);
            myGFXFile.endEdit(this);
            b.Dispose();

            ByteArrayOutputStream layout = new ByteArrayOutputStream();
            for (int y = 0; y < ti.heightTileCount; y++)
                for (int x = 0; x < ti.widthTileCount; x++)
                    layout.writeUShort((ushort)((ti.tileMap[x, y] + offs + (bgPrompt.bgFirstTileOffset * 4)) | (palOffs<<12)));

            myLayoutFile.beginEdit(this);
            myLayoutFile.replace(ROM.LZ77_Compress(layout.getArray()), this);
            myLayoutFile.endEdit(this);
        }

        private void exportPNGButton_Click(object sender, EventArgs e)
        {
            Tilemap t = getTilemap();
            if (t == null) return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = LanguageManager.Get("Filters", "png");
            if (sfd.ShowDialog() != DialogResult.OK) return;

            t.render();
            t.buffer.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void RenameBtn_Click(object sender, EventArgs e)
        {
            string newName;
            BackgroundEntry bg = tilesetListBox.SelectedItem as BackgroundEntry;
            string listName = bg.topLayer ? "Foregrounds" : "Backgrounds";
            if (textForm.ShowDialog(LanguageManager.Get("BackgroundList", "renamePrompt"), bg.name, out newName) == DialogResult.OK)
            {
                if (newName == string.Empty)
                {
                    ROM.UserInfo.removeListItem(listName, bg.id, true);
                    tilesetListBox.Items[tilesetListBox.SelectedIndex] = new BackgroundEntry(bg.topLayer, bg.id, LanguageManager.GetList(listName)[bg.id], false);
                    return;
                }
                ROM.UserInfo.setListItem(listName, bg.id, newName, true);
                tilesetListBox.Items[tilesetListBox.SelectedIndex] = new BackgroundEntry(bg.topLayer, bg.id, newName, false);
            }
        }

        private void Setproperties_btn_Click(object sender, EventArgs e)
        {
            bg = (BackgroundEntry)tilesetListBox.SelectedItem;

            bool IsLevelBG = true;
            if (bg.id > 75 || bg.mappedTileset)
                IsLevelBG = false;
            SetBGPropertiesDialog newBg = new SetBGPropertiesDialog(bg.id, bg.name.Split(':')[1].Remove(0, 1), bg.GFXFileID, bg.PalFileID, bg.LayoutFileID, bg.BitmapOffset, bg.PaletteOffsets, IsLevelBG);
            if (newBg.Canceled)
                return;

            string listName = bg.topLayer ? "Foregrounds" : "Backgrounds";
            if (bg.mappedTileset)
                listName = "MappedTileset";

            if (string.IsNullOrWhiteSpace(newBg.bgName))
            {
                ROM.UserInfo.removeListItem(listName, bg.id, true);
                string newName = LanguageManager.GetList(listName)[bg.id];
                bool empty = false;
                if (string.IsNullOrWhiteSpace(newName.Split(':')[1]))
                {
                    newName += " " + LanguageManager.Get("BackgroundList", "empty");
                    empty = true;
                }

                tilesetListBox.Items[tilesetListBox.SelectedIndex] = new BackgroundEntry(bg.topLayer, bg.id, newName, bg.mappedTileset, empty);
                return;
            }

            string NewFullName = string.Format("{0}: {1}", bg.id, newBg.bgName);
            if (!IsLevelBG)
                NewFullName = string.Format("{0}: {1}@{2}@{3}@{4}@{5}@{6}@not_level_bg", bg.id, newBg.bgName, newBg.bgNCGID, newBg.bgNCLID, newBg.bgNSCID, newBg.bgBMPOffs, newBg.bgPALOffs);
            else
            {
                ROM.SetFileIDFromTable(bg.id, bg.topLayer ? ROM.Data.Table_FG_NCG : ROM.Data.Table_BG_NCG, (ushort)newBg.bgNCGID);
                ROM.SetFileIDFromTable(bg.id, bg.topLayer ? ROM.Data.Table_FG_NCL : ROM.Data.Table_BG_NCL, (ushort)newBg.bgNCLID);
                ROM.SetFileIDFromTable(bg.id, bg.topLayer ? ROM.Data.Table_FG_NSC : ROM.Data.Table_BG_NSC, (ushort)newBg.bgNSCID);
            }

            ROM.UserInfo.setListItem(listName, bg.id, NewFullName, true);
            tilesetListBox.Items[tilesetListBox.SelectedIndex] = new BackgroundEntry(bg.topLayer, bg.id, NewFullName, false);
        }
    }
}
