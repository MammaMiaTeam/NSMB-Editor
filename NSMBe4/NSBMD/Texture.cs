﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace NSMBe4.NSBMD
{
    public class Texture
    {
        public bool color0Transp;
        public int width, height;
        public int format;
        public byte bpp;
        public uint offset, size;
        public string name;
        public bool needsPal = true;
        public uint f5DataOffset;

	    static byte[] bpps = new byte[] { 0, 8, 2, 4, 8, 2, 8, 16 };
        static byte[] mask = new byte[] { 0, 0xFF, 3, 7, 0xFF, 3, 0xFF, 0x0 };
        static byte[] cmsk = new byte[] { 0, 0x1F, 3, 7, 0xFF, 3, 0x08, 0x0 };
        NSBTX parent;

        public Texture(NSBTX p, bool color0, int width, int height, int format, uint offset, string name)
        {
            parent = p;
            this.color0Transp = color0;
            this.width = width;
            this.height = height;
            this.format = format;
            this.offset = offset;
            this.name = name;

            bpp = bpps[format];
            size = (uint)(width * height * bpp / 8);
        }

        public byte[] getContents()
        {
            byte[] d = new byte[size];
            parent.str.seek(offset);
            parent.str.read(d);
            return d;
        }

        public Bitmap render(Palette p, int palnum)
        {
            byte bit = 8;
            byte bi = 0;

            Bitmap b = new Bitmap(width, height);
            if (format == 5) //fucking complicated 4x4 texel format :(:(:(
            {
                uint w = (uint)width / 4;
                uint h = (uint)height / 4;
                for (uint y = 0; y < h; y++)
                    for (uint x = 0; x < w; x++)
                    {
                        parent.str.seek(f5DataOffset + y*w*2 + x*2);
                        ushort palDat = parent.str.readUShort();
                        ushort palOffs = (ushort)((palDat & 0x3FFF) * 2);
                        ushort mode = (ushort)((palDat >> 14) & 3);

                        for (uint yy = 0; yy < 4; yy++)
                        {
                            parent.str.seek(offset + y*w*4 + x*4 + yy);
                            byte row = parent.str.readByte();
                            for (uint xx = 0; xx < 4; xx++)
                            {
                                byte color = (byte)(row >> (byte)(xx*2));
                                color &= 3;
                                Color col;
                                col = p.getColor(palOffs + color);
                                switch (mode)
                                {
                                    case 0:
                                        if (color == 3) col = Color.Transparent;
                                        break;
                                    case 1:
                                        if (color == 2) col = ImageTiler.colorMean(p.getColor(palOffs), p.getColor(palOffs + 1), 1, 1);
                                        if (color == 3) col = Color.Transparent;
                                        break;
                                    case 3:
                                        if (color == 2) col = ImageTiler.colorMean(p.getColor(palOffs), p.getColor(palOffs + 1), 5, 3);
                                        if (color == 3) col = ImageTiler.colorMean(p.getColor(palOffs), p.getColor(palOffs + 1), 3, 5);
                                        break;
                                }
                                b.SetPixel((int)x * 4 + (int)xx, (int)y * 4 + (int)yy, col);
                            }
                        }
                    }
            }
            else
            {
                parent.str.seek(offset);
                for (int y = 0; y < height; y++)
                    for (int x = 0; x < width; x++)
                    {
                        if (bit == 8)
                        {
                            bi = parent.str.readByte();
                            bit = 0;
                        }
                        int col = (int)(bi & mask[format] << bit) >> bit;
                        Color color = p.getColor(col&cmsk[format] + palnum);
                        int alpha = 255;
                        if (format == 1)
                            alpha = 32 * col >> 5;
                        if (format == 6)
                            alpha = 8 * (col >> 3);
                        color = Color.FromArgb(alpha, color);
                        if (col == 0 & color0Transp)
                            b.SetPixel(x, y, Color.Transparent);
                        else
                            b.SetPixel(x, y, color);
                        bit += bpp;
                    }
            }

            return b;
        }

        public void replace(Bitmap b, int ox, int oy, Palette p, int palnum, int palsize)
        {
            parent.str.seek(offset);
            byte bit = 0;
            byte currByte = 0;

         
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    Color c = b.GetPixel(x+ox, y+oy);
                    byte col = 0;
                    if(c != Color.Transparent)
                        col = (byte)p.getClosestColor(c, palnum, palsize);

                    currByte |= (byte)(col << bit);
                    bit += bpp;

                    if (bit == 8)
                    {
                        parent.str.writeByte(currByte);
                        currByte = 0;
                        bit = 0;
                    }
                }

            parent.save();
        }

        public byte getPixel(int x, int y)
        {
            int offs = x + y * width;
            int b = offs * bpp / 8;
            byte bit = (byte)(offs % (8 / bpp));
            parent.str.seek((uint)(offset + offs));
            byte p = parent.str.readByte();
            return (byte)(((byte)p >> bit) & mask[format]);
        }

        public override string ToString()
        {
            return name;
        }

        public bool usesPalette()
        {
            return format != 7;
        }
    }
}
