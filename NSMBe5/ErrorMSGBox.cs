using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSMBe5
{

    public partial class ErrorMSGBox : Form
    {

        public ErrorMSGBox(string title = "", string text = "", string subtext = "", string error = null)
        {

            InitializeComponent();

            if (string.IsNullOrEmpty(title))
                this.Text = LanguageManager.Get("SpriteData", "ErrorTitle");

            else
                this.Text = title;

            if(!string.IsNullOrEmpty(text))
                textLabel.Text = text;

            if (!string.IsNullOrEmpty(subtext))
                subtextLabel.Text = subtext;

            if (error != null)
                richTextBox1.Text = error;

        }

        private void Continue_button_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void Reload_button_Click(object sender, EventArgs e)
        {

            ROM.close();

            Process process2 = new Process();
            process2.StartInfo.FileName = Application.ExecutablePath;
            process2.StartInfo.Arguments = "\"" + Properties.Settings.Default.ROMPath + "\"";
            process2.Start();
            Environment.Exit(0);

        }

    }

}
