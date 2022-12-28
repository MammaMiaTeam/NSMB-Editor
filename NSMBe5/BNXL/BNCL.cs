using NSMBe5.DSFileSystem;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

//Ported from https://github.com/TheGameratorT/NDS_BNCL_Editor

namespace NSMBe5
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class BNCL : Form
    {

        DSFileSystem.File f;

        public BNCL(DSFileSystem.File f)
        {

            this.f = f;
            f.beginEdit(this);

            InitializeComponent();

            Text += " - " + f.name;

            LoadBNCL();
            Show();

        }

        Button2[] objn_button = new Button2[256];
        bool UpdaterCanCreateButtons = true;
        ushort[] objn_xPos = new ushort[256];
        ushort[] objn_yPos = new ushort[256];
        byte[] objn_xAlign = new byte[256];
        byte[] objn_yAlign = new byte[256];
        byte[] objn_graphicID = new byte[256];
        public static byte[] graphicID_width = new byte[256];
        public static byte[] graphicID_height = new byte[256];
        public static string[] graphicID_comment = new string[256];

        public void LoadBNCL()
        {

            UpdaterCanCreateButtons = false;

            numberOfObjs_UpDown.Value = 0;

            for (int i = 1; i < objn_button.Length; i++)
            {

                panel1.Controls.Remove(objn_button[i]);
                objn_button[i] = null;
                objn_xPos[i] = 0;
                objn_yPos[i] = 0;
                objn_xAlign[i] = 0;
                objn_yAlign[i] = 0;
                objn_graphicID[i] = 0;
                graphicID_width[i] = 0;
                graphicID_height[i] = 0;
                graphicID_comment[i] = "";

            }

            GetGfxIDSizesForFilename();

            numberOfObjs_UpDown.Value = f.getByteAt(6);

            for (int i = 1; i <= numberOfObjs_UpDown.Value; i++)
            {

                objn_button[i] = new Button2()
                {

                    Opacity = 192,
                    Text = string.Format("Object {0}", i),
                    Name = string.Format("ObjectN_Button_{0}", i),
                    Tag = i

                };

                objn_button[i].Click += new EventHandler(objn_Click);
                panel1.Controls.Add(objn_button[i]);

                ushort xPosUInt16 = f.getUshortAt(0x8 - 0x8 + (i * 0x8));
                objn_xAlign[i] = (byte)(xPosUInt16 >> 12 & 3);
                objn_xPos[i] = (ushort)(xPosUInt16 & 0xFFF);

                if (objn_xPos[i] > 255)
                    objn_xPos[i] = 255;

                ushort yPosUInt16 = f.getUshortAt(0xA - 0x8 + (i * 0x8));
                objn_yAlign[i] = (byte)(yPosUInt16 >> 12 & 3);
                objn_yPos[i] = (ushort)(yPosUInt16 & 0xFFF);

                if (objn_yPos[i] > 255)
                    objn_yPos[i] = 255;

                objn_graphicID[i] = f.getByteAt(0xC - 0x8 + (i * 0x8));

            }

            currentObj_UpDown.Value = 1;
            OnSelectedObjectChange(null, null);

            UpdaterCanCreateButtons = true;

        }

        #region GraphicDefsPresetOperations

        XDocument SizePresetsXML;

        string XMLDefsFileName = AppDomain.CurrentDomain.BaseDirectory + "/BNCL_defs.xml";

        private void CheckForSizePresetsFilePresence()
        {

            try
            {

                if (!System.IO.File.Exists(XMLDefsFileName) || new FileInfo(XMLDefsFileName).Length == 0)
                {

                    DialogResult downloadPresetsPrompt = MessageBox.Show(XMLDefsFileName + " wasn't found or is empty, would you like to download that file?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (downloadPresetsPrompt == DialogResult.Yes)
                    {

                        using (var client = new WebClient())
                        {

                            client.DownloadFile("https://raw.githubusercontent.com/TheGameratorT/NDS_BNCL_Editor/master/NDS_BNCL_Editor/SizePresets.xml", XMLDefsFileName);

                        }

                    }

                    else if (downloadPresetsPrompt == DialogResult.No)
                    {

                        Close();

                        return;

                    }

                }

                SizePresetsXML = XDocument.Load(XMLDefsFileName);

            }

            catch (Exception ex)
            {

                new ErrorMSGBox("", "XML Parse Failed!", "", ex.ToString()).ShowDialog();

            }

        }

        private void GetGfxIDSizesForFilename()
        {

            CheckForSizePresetsFilePresence();

            for (int i = 0; i < 256; i++)
            {

                //Default values if value not found or XML parse failed
                graphicID_width[i] = 16;
                graphicID_height[i] = 16;
                graphicID_comment[i] = null;

                try
                {

                    var GraphicsWidth = SizePresetsXML
                        .Descendants("Game")
                        .Where(node => (string)node.Attribute("Name") == "New Super Mario Bros.")
                        .Descendants("Scene")
                        .Where(node => node.Attribute("Name").Value.Contains(f.name))
                        .Descendants("Graphic")
                        .Where(node => (int)node.Attribute("ID") == i)
                        .Attributes("Width");

                    foreach (var GraphicWidth in GraphicsWidth)
                    {

                        graphicID_width[i] = byte.Parse(GraphicWidth.Value);

                    }

                    var GraphicsHeight = SizePresetsXML
                        .Descendants("Game")
                        .Where(node => (string)node.Attribute("Name") == "New Super Mario Bros.")
                        .Descendants("Scene")
                        .Where(node => node.Attribute("Name").Value.Contains(f.name))
                        .Descendants("Graphic")
                        .Where(node => (int)node.Attribute("ID") == i)
                        .Attributes("Height");

                    foreach (var GraphicHeight in GraphicsHeight)
                    {

                        graphicID_height[i] = byte.Parse(GraphicHeight.Value);

                    }

                    var GraphicsComment = SizePresetsXML
                        .Descendants("Game")
                        .Where(node => (string)node.Attribute("Name") == "New Super Mario Bros.")
                        .Descendants("Scene")
                        .Where(node => node.Attribute("Name").Value.Contains(f.name))
                        .Descendants("Graphic")
                        .Where(node => (int)node.Attribute("ID") == i)
                        .Attributes("Comment");

                    foreach (var GraphicComment in GraphicsComment)
                    {

                        graphicID_comment[i] = GraphicComment.Value;

                    }

                }

                catch (Exception ex)
                {

                    new ErrorMSGBox("", "XML Parse Failed!", "", ex.ToString()).ShowDialog();

                }

            }

        }

        private void UpdateGFXDefs_Click(object sender, EventArgs e)
        {

            try
            {

                System.IO.File.Delete(XMLDefsFileName);

                using (var client = new WebClient())
                {

                    client.DownloadFile("https://raw.githubusercontent.com/TheGameratorT/NDS_BNCL_Editor/master/NDS_BNCL_Editor/SizePresets.xml", XMLDefsFileName);

                }

                GetGfxIDSizesForFilename();

            }

            catch (Exception ex)
            {

                new ErrorMSGBox("", "Update Failed!", "", ex.ToString()).ShowDialog();

            }

        }

        #endregion

        void objn_Click(object sender, EventArgs e)
        {

            currentObj_UpDown.Value = (int)(sender as Button2).Tag;

        }

        private void OnSelectedObjectChange(object sender, EventArgs e)
        {

            if (currentObj_UpDown != null &&
                numberOfObjs_UpDown != null &&
                xPos_UpDown != null &&
                yPos_UpDown != null &&
                xPosAlign_UpDown != null &&
                yPosAlign_UpDown != null &&
                graphicID_UpDown != null &&
                gfxWidth_UpDown != null &&
                gfxHeight_UpDown != null &&
                desc_label != null)
            {

                currentObj_UpDown.Maximum = numberOfObjs_UpDown.Value;

                if (currentObj_UpDown.Value > currentObj_UpDown.Maximum && currentObj_UpDown.Value != 1)
                {

                    currentObj_UpDown.Value = currentObj_UpDown.Maximum;

                }

                xPos_UpDown.Value = objn_xPos[(byte)currentObj_UpDown.Value];
                yPos_UpDown.Value = objn_yPos[(byte)currentObj_UpDown.Value];
                xPosAlign_UpDown.Value = objn_xAlign[(byte)currentObj_UpDown.Value];
                yPosAlign_UpDown.Value = objn_yAlign[(byte)currentObj_UpDown.Value];
                graphicID_UpDown.Value = objn_graphicID[(byte)currentObj_UpDown.Value];

                gfxWidth_UpDown.Value = graphicID_width[(byte)graphicID_UpDown.Value];
                gfxHeight_UpDown.Value = graphicID_height[(byte)graphicID_UpDown.Value];
                desc_label.Text = graphicID_comment[(byte)graphicID_UpDown.Value];

            }

            for (int i = 1; i < objn_button.Length; i++)
            {

                if (objn_button[i] != null)
                {

                    if (currentObj_UpDown.Value == i)
                        objn_button[i].BackColor = Color.FromArgb(0xFFFF00);
                    
                    else
                        objn_button[i].BackColor = Color.FromArgb(225, 225, 225);

                    if (i > numberOfObjs_UpDown.Value)
                    {

                        panel1.Controls.Remove(objn_button[i]);
                        objn_button[i] = null;

                    }

                }

                else if (objn_button[i] == null && numberOfObjs_UpDown.Value >= i)
                {

                    if (UpdaterCanCreateButtons == true)
                    {

                        objn_button[i] = new Button2()
                        {

                            Opacity = 192,
                            Text = string.Format("Object {0}", i),
                            Name = string.Format("ObjectN_Button_{0}", i),
                            Tag = i

                        };

                        objn_button[i].Click += new EventHandler(objn_Click);
                        panel1.Controls.Add(objn_button[i]);

                        objn_xPos[i] = 0;
                        objn_xAlign[i] = 0;
                        objn_yPos[i] = 0;
                        objn_yAlign[i] = 0;
                        objn_graphicID[i] = 0;

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

        async private void OnObjectPropertiesChange(object sender, EventArgs e)
        {

            await Task.Delay(1);

            byte currentObject = (byte)currentObj_UpDown.Value;

            if (objn_button[currentObject] != null &&
                xPos_UpDown != null &&
                yPos_UpDown != null &&
                xPosAlign_UpDown != null &&
                yPosAlign_UpDown != null &&
                graphicID_UpDown != null &&
                desc_label != null)
            {

                objn_xPos[currentObject] = (ushort)xPos_UpDown.Value;
                objn_yPos[currentObject] = (ushort)yPos_UpDown.Value;
                objn_xAlign[currentObject] = (byte)xPosAlign_UpDown.Value;
                objn_yAlign[currentObject] = (byte)yPosAlign_UpDown.Value;
                objn_graphicID[currentObject] = (byte)graphicID_UpDown.Value;

                RenderView();

            }

        }

        private void RenderView()
        {

            for (int i = 1; i < objn_button.Length; i++)
            {

                if (objn_button[i] != null)
                {

                    int xPosRenderResult = objn_xPos[i];

                    if (objn_xAlign[i] == 1)
                        xPosRenderResult -= (byte)((graphicID_width[objn_graphicID[i]] + 1) / 2);

                    if (objn_xAlign[i] == 2)
                        xPosRenderResult -= graphicID_width[objn_graphicID[i]];

                    int yPosRenderResult = objn_yPos[i];

                    if (objn_yAlign[i] == 1)
                        yPosRenderResult -= (byte)((graphicID_height[objn_graphicID[i]] + 1) / 2);

                    if (objn_yAlign[i] == 2)
                        yPosRenderResult -= graphicID_height[objn_graphicID[i]];

                    objn_button[i].Location = new Point(xPosRenderResult, yPosRenderResult);
                    objn_button[i].Width = graphicID_width[objn_graphicID[i]];
                    objn_button[i].Height = graphicID_height[objn_graphicID[i]];

                    if (graphicID_width[objn_graphicID[i]] <= 48)
                    {

                        objn_button[i].Text = i.ToString();
                        objn_button[i].Font = new Font(objn_button[i].Font.FontFamily, 5.8f);

                    }

                    else if (graphicID_width[objn_graphicID[i]] > 48)
                    {

                        objn_button[i].Text = string.Format("Object {0}", i);
                        objn_button[i].Font = new Font(objn_button[i].Font.FontFamily, 7.8f);

                    }

                }

            }

        }

        /*private void About_Click(object sender, RoutedEventArgs e)
        {
            new About().ShowDialog();
        }*/

        private void BNCL_ClosedEvent(object sender, EventArgs e)
        {

            f.endEdit(this);

        }

        private void SaveFile_Click(object sender, EventArgs e)
        {

            using (MemoryStream memoryStream = new MemoryStream())
            {

                using (BinaryWriter bw = new BinaryWriter(memoryStream))
                {

                    bw.Write("JNCL".ToCharArray());

                    bw.BaseStream.Position = 0x6;
                    bw.BaseStream.WriteByte((byte)numberOfObjs_UpDown.Value);

                    if (numberOfObjs_UpDown.Value == 0)
                    {

                        f.replace(memoryStream.ToArray(), this);
                        return;

                    }

                    for (int i = 1; i <= numberOfObjs_UpDown.Value; i++)
                    {

                        bw.BaseStream.Position = 0x8 - 0x8 + (i * 0x8);

                        if (objn_xAlign[i] == 0)
                            bw.Write(objn_xPos[i]);

                        else if (objn_xAlign[i] == 1)
                            bw.Write((ushort)(objn_xPos[i] + 0x1000));

                        else if (objn_xAlign[i] == 2)
                            bw.Write((ushort)(objn_xPos[i] + 0x2000));

                        bw.BaseStream.Position = 0xA - 0x8 + (i * 0x8);

                        if (objn_yAlign[i] == 0)
                            bw.Write(objn_yPos[i]);

                        else if (objn_yAlign[i] == 1)
                            bw.Write((ushort)(objn_yPos[i] + 0x1000));

                        else if (objn_yAlign[i] == 2)
                            bw.Write((ushort)(objn_yPos[i] + 0x2000));

                        bw.BaseStream.Position = 0xC - 0x8 + (i * 0x8);
                        bw.BaseStream.WriteByte(objn_graphicID[i]);

                    }

                    bw.Write((ushort)0); //Padding
                    bw.Write((byte)0); //Padding

                    f.replace(memoryStream.ToArray(), this);

                }

            }

        }

    }

}