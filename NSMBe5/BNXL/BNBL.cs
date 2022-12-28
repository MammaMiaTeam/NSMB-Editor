using NSMBe5.DSFileSystem;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

//Ported from https://github.com/TheGameratorT/NDS_BNBL_Editor

namespace NSMBe5
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class BNBL : Form
    {

        DSFileSystem.File f;

        public BNBL(DSFileSystem.File f)
        {

            this.f = f;
            f.beginEdit(this);

            InitializeComponent();

            Text += " - " + f.name;

            LoadBNBL();
            Show();

        }

        Button2[] objn_button = new Button2[256];
        bool allowedToCreateButtons = true;
        byte[] objn_xPos = new byte[256];
        byte[] objn_yPos = new byte[256];
        byte[] objn_width = new byte[256];
        byte[] objn_height = new byte[256];

        public void LoadBNBL()
        {

            allowedToCreateButtons = false;

            numberOfTouchObjs_UpDown.Value = f.getByteAt(6);

            for (int i = 1; i <= numberOfTouchObjs_UpDown.Value; i++)
            {

                objn_button[i] = new Button2()
                {

                    Opacity = 192, //0.75
                    Text = string.Format("Object {0}", i),
                    Name = string.Format("ObjectN_Button_{0}", i),
                    Tag = i

                };

                objn_button[i].Click += new EventHandler(objn_Click);
                panel1.Controls.Add(objn_button[i]);

                ushort xPosUInt16 = f.getUshortAt(0x8 - 0x6 + (i * 0x6));
                byte xPosUInt12 = (byte)(xPosUInt16 & 0xFFF);
                byte xPosAlignmentByte = (byte)(xPosUInt16 >> 12 & 3);
                objn_xPos[i] = xPosUInt12;

                ushort yPosUInt16 = f.getUshortAt(0xA - 0x6 + (i * 0x6));
                byte yPosUInt12 = (byte)(yPosUInt16 & 0xFFF);
                byte yPosAlignmentByte = (byte)(yPosUInt16 >> 12 & 3);
                objn_yPos[i] = yPosUInt12;

                byte widthByte = f.getByteAt(0xC - 0x6 + (i * 0x6));
                objn_width[i] = widthByte;

                byte heightByte = f.getByteAt(0xD - 0x6 + (i * 0x6));
                objn_height[i] = heightByte;

                //Do some calculations

                //If X is centered
                if (xPosAlignmentByte == 1)
                {

                    objn_xPos[i] -= (byte)((widthByte + 1) / 2);

                }

                //If X is set to Bottom/Right
                else if (xPosAlignmentByte == 2) 
                {

                    objn_xPos[i] -= widthByte;

                }

                //If Y is centered
                if (yPosAlignmentByte == 1) 
                {

                    objn_yPos[i] -= (byte)((heightByte + 1) / 2);

                }

                //If Y is set to Bottom/Right
                else if (yPosAlignmentByte == 2)
                {

                    objn_yPos[i] -= heightByte;

                }

                objn_button[i].Location = new Point(objn_xPos[i], objn_yPos[i]);
                objn_button[i].Width = objn_width[i];
                objn_button[i].Height = objn_height[i];

                xPos_UpDown.Value = objn_xPos[1];
                yPos_UpDown.Value = objn_yPos[1];
                width_UpDown.Value = objn_width[1];
                height_UpDown.Value = objn_height[1];

                ObjectClicked(null, null);

            }

            currentTouchObj_UpDown.Value = 1;
            allowedToCreateButtons = true;

        }

        void objn_Click(object sender, EventArgs e)
        {

            currentTouchObj_UpDown.Value = (int)(sender as Button2).Tag;

        }

        private void ObjectClicked(object sender, EventArgs e)
        {

            if ( currentTouchObj_UpDown != null && numberOfTouchObjs_UpDown != null)
            {

                currentTouchObj_UpDown.Maximum = numberOfTouchObjs_UpDown.Value;

                if(currentTouchObj_UpDown.Value > currentTouchObj_UpDown.Maximum && currentTouchObj_UpDown.Value != 1)
                {

                    currentTouchObj_UpDown.Value = currentTouchObj_UpDown.Maximum;

                }

                if(xPos_UpDown != null && yPos_UpDown != null && width_UpDown != null && height_UpDown != null)
                {

                    xPos_UpDown.Value = objn_xPos[(byte)currentTouchObj_UpDown.Value];
                    yPos_UpDown.Value = objn_yPos[(byte)currentTouchObj_UpDown.Value];
                    width_UpDown.Value = objn_width[(byte)currentTouchObj_UpDown.Value];
                    height_UpDown.Value = objn_height[(byte)currentTouchObj_UpDown.Value];

                }

                for (int i = 1; i < objn_button.Length; i++)
                {

                    if(objn_button[i] != null)
                    {

                        if (currentTouchObj_UpDown.Value == i)
                        {

                            objn_button[i].BackColor = Color.FromArgb(Color.Yellow.R, Color.Yellow.G, Color.Yellow.B);

                        }

                        else
                        {

                            objn_button[i].BackColor = Color.FromArgb(221, 221, 221);

                        }

                        if (i > numberOfTouchObjs_UpDown.Value)
                        {

                            panel1.Controls.Remove(objn_button[i]);
                            objn_button[i] = null;

                        }

                    }

                    else if (objn_button[i] == null && i <= numberOfTouchObjs_UpDown.Value)
                    {

                        if(allowedToCreateButtons == true)
                        {

                            objn_button[i] = new Button2()
                            {

                                Width = 75,
                                Height = 50,
                                Opacity = 192, //0.75
                                Text = string.Format("Object {0}", i),
                                Name = string.Format("ObjectN_Button_{0}", i),
                                Tag = i

                            };

                            objn_button[i].Click += new EventHandler(objn_Click);
                            panel1.Controls.Add(objn_button[i]);

                            objn_xPos[i] = 0;
                            objn_yPos[i] = 0;
                            objn_width[i] = 75;
                            objn_height[i] = 50;

                        }

                    }

                }

            }

        }

        private void OpenImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All supported image formats|*bmp; *gif; *.jpg; *.jpeg; *.jpe; *.jif; *.jfif; *.jfi; *png; *.tiff; *.tif|" +
                "Bitmap images|*.bmp|" +
                "GIF images|*.gif|" +
                "JPEG images|*.jpg; *.jpeg; *.jpe; *.jif; *.jfif; *.jfi|" +
                "PNG images|*.png|" +
                "TIFF images|*.tiff; *.tif|" +
                "All files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                Bitmap bmpImg = new Bitmap(openFileDialog.FileName);
                panel1.BackgroundImage = bmpImg;

            }

        }

        async private void valueChanged(object sender, EventArgs e)
        {
            await Task.Delay(1);

            byte v1 = (byte)currentTouchObj_UpDown.Value;

            if (objn_button[v1] != null)
            {

                objn_xPos[v1] = (byte)xPos_UpDown.Value;
                objn_yPos[v1] = (byte)yPos_UpDown.Value;
                objn_height[v1] = (byte)height_UpDown.Value;
                objn_width[v1] = (byte)width_UpDown.Value;

                objn_button[v1].Location = new Point(objn_xPos[v1], objn_yPos[v1]);
                objn_button[v1].Width = objn_width[v1];
                objn_button[v1].Height = objn_height[v1];

            }

            for (int i = 1; i < objn_button.Length; i++)
            {

                if(objn_button[i] != null)
                {

                    if (objn_width[i] <= 48)
                    {

                        objn_button[i].Text = i.ToString();

                    }

                    if (objn_width[i] > 48)
                    {

                        objn_button[i].Text = string.Format("Object {0}", i);

                    }

                }

            }

        }

        /*
        private void About_Click(object sender, RoutedEventArgs e)
        {

            new About().ShowDialog();

        }
        */

        private void BNBL_ClosedEvent(object sender, EventArgs e)
        {

            f.endEdit(this);

        }

        private void SaveFile_Click(object sender, EventArgs e)
        {

            using (MemoryStream memoryStream = new MemoryStream())
            {

                using (BinaryWriter bw = new BinaryWriter(memoryStream))
                {

                    bw.Write("JNBL".ToCharArray());

                    bw.BaseStream.Position = 0x6;
                    bw.BaseStream.WriteByte((byte)numberOfTouchObjs_UpDown.Value);

                    if (numberOfTouchObjs_UpDown.Value == 0)
                    {

                        f.replace(memoryStream.ToArray(), this);

                        return;

                    }

                    for (int i = 1; i <= numberOfTouchObjs_UpDown.Value; i++)
                    {

                        bw.BaseStream.Position = 0x8 - 0x6 + (i * 0x6);
                        bw.BaseStream.WriteByte(objn_xPos[i]);
                        bw.BaseStream.Position = 0xA - 0x6 + (i * 0x6);
                        bw.BaseStream.WriteByte(objn_yPos[i]);
                        bw.BaseStream.Position = 0xC - 0x6 + (i * 0x6);
                        bw.BaseStream.WriteByte(objn_width[i]);
                        bw.BaseStream.Position = 0xD - 0x6 + (i * 0x6);
                        bw.BaseStream.WriteByte(objn_height[i]);

                    }

                    f.replace(memoryStream.ToArray(), this);

                }

            }

        }

    }

}