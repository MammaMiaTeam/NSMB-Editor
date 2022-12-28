using NSMBe5.DSFileSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSMBe5
{

    public partial class CompressFilePrompt : Form
    {

        public bool Canceled = true;
        public CompressedFile.CompressionType ChosenCompression;

        public CompressFilePrompt()
        {

            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            ShowDialog();

        }

        private void LZ77Button_Click(object sender, EventArgs e)
        {

            Canceled = false;
            ChosenCompression = CompressedFile.CompressionType.LZ;
            Close();

        }

        private void LZ77hButton_Click(object sender, EventArgs e)
        {

            Canceled = false;
            ChosenCompression = CompressedFile.CompressionType.LZWithHeader;
            Close();

        }

        private void Yaz0Button_Click(object sender, EventArgs e)
        {

            Canceled = false;
            ChosenCompression = CompressedFile.CompressionType.Yaz0;
            Close();

        }

    }

}
