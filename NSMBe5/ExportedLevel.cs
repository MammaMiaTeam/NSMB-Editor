﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using NSMBe5.DSFileSystem;

namespace NSMBe5
{

    public class ExportedLevel
    {

        const string oldFileHeader = "NSMBe4 Exported Level";
        public const string fileHeader = "NSMBe5 Exported Level";
        public const ushort version = 1;

        public byte[] LevelFile;
        public byte[] BGDatFile;
        public int LevelFileID = 0;
        public int BGDatFileID = 0;

        public ExportedLevel()
        {

        }

        public ExportedLevel(byte[] LevelFile, byte[] BGDatFile, int LevelFileID, int BGDatFileID)
        {

            this.LevelFile = LevelFile;
            this.BGDatFile = BGDatFile;
            this.LevelFileID = LevelFileID;
            this.BGDatFileID = BGDatFileID;

        }

        public ExportedLevel(File LevelFile, File BGFile)
        {

            this.LevelFile = LevelFile.getContents();
            this.BGDatFile = BGFile.getContents();
            this.LevelFileID = (int)LevelFile.id;
            this.BGDatFileID = (int)BGFile.id;

        }

        public ExportedLevel(System.IO.BinaryReader br)
        {

            string Header = br.ReadString();

            if (!(Header == fileHeader || Header == oldFileHeader))
            {

                throw new Exception(LanguageManager.Get("NSMBLevel", "InvalidFile"));

            }

            ushort FileVersion = br.ReadUInt16();

            if (FileVersion > version)
            {

                throw new Exception(LanguageManager.Get("NSMBLevel", "OldVersion"));

            }

            LevelFileID = br.ReadUInt16();
            BGDatFileID = br.ReadUInt16();
            int LevelFileLength = br.ReadInt32();
            LevelFile = br.ReadBytes(LevelFileLength);

            int BGFileLength = br.ReadInt32();
            BGDatFile = br.ReadBytes(BGFileLength);

        }

        public static void Import(File destLevelFile, File destBGFile, byte[] levelFile, byte[] bgFile)
        {

            try
            {

                destLevelFile.beginEdit(destBGFile);

            }
            
            catch (AlreadyEditingException)
            {

                MessageBox.Show(LanguageManager.Get("Errors", "Level"));

                return;

            }

            try
            {

                destBGFile.beginEdit(destLevelFile);

            }
            
            catch (AlreadyEditingException)
            {

                MessageBox.Show(LanguageManager.Get("Errors", "Level"));

                return;

            }

            destLevelFile.replace(levelFile, destBGFile);
            destLevelFile.endEdit(destBGFile);
            destBGFile.replace(bgFile, destLevelFile);
            destBGFile.endEdit(destLevelFile);

        }

        public void Import(File destLevelFile, File destBGFile)
        {

            Import(destLevelFile, destBGFile, LevelFile, BGDatFile);

        }

        public void Write(System.IO.BinaryWriter bw)
        {

            bw.Write(fileHeader);
            bw.Write(version);
            bw.Write((ushort)LevelFileID);
            bw.Write((ushort)BGDatFileID);
            bw.Write(LevelFile.Length);
            bw.Write(LevelFile);
            bw.Write(BGDatFile.Length);
            bw.Write(BGDatFile);

        }

    }

}
