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
using System.Drawing;
using System.Diagnostics;
using System.IO;

using NSMBe5.DSFileSystem;
using NSMBe5.NSBMD;
using NSMBe5.Patcher;


namespace NSMBe5
{
    public static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string langDir = System.IO.Path.Combine(Application.StartupPath, "Languages");
            string langFileName = System.IO.Path.Combine(langDir, Properties.Settings.Default.LanguageFile + ".ini");
            if (System.IO.File.Exists(langFileName))
            {
                System.IO.StreamReader rdr = new StreamReader(langFileName);
                LanguageManager.Load(rdr.ReadToEnd().Split('\n'));
                rdr.Close();
            }
            else
            {
                MessageBox.Show("File " + langFileName + " could not be found, so the language has defaulted to English.");
                LanguageManager.Load(Properties.Resources.English.Split('\n'));
            }

            string[] args = Environment.GetCommandLineArgs();

            if (args.Length == 2)
            {
                Console.Out.WriteLine("Loading ROM: " + args[1]);

                NitroROMFilesystem fs = new NitroROMFilesystem(args[1]);
                ROM.load(fs);

                new LevelChooser().Show();
                StageObjSettings.Load();
            }
            else
            {
                new LevelChooser().Show();
            }

            Application.Run();
        }

		public static void ApplyFontToControls(Control.ControlCollection ctrls)
		{
			string fontName = Properties.Settings.Default.UIFont;
			foreach (Control ctrl in ctrls)
			{
				if (ctrl.Controls != null)
					ApplyFontToControls(ctrl.Controls);
				ctrl.Font = new Font(fontName, ctrl.Font.Size);
			}
		}
	}
}
