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
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace NSMBe5.Patcher
{
	public abstract class CodePatcher
	{
		public static class Method
		{
			public const int NSMBe = 0;
			public const int Fireflower = 1;
			public const int NCPatcher = 2;
		}

		protected DirectoryInfo romdir;


		public CodePatcher(DirectoryInfo romdir)
		{
			this.romdir = romdir;
		}


		public abstract void Execute();

		public abstract void CleanBuild();

		public static int RunProcess(string proc, string cwd)
		{
			ProcessStartInfo info = new ProcessStartInfo();

			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				info.FileName = "cmd.exe";
				info.Arguments = "/C " + proc + " || pause";
			}
			else
			{
				info.FileName = "/bin/bash";
				info.Arguments = "-c \"" + proc + "\"";
			}
			
			info.CreateNoWindow = false;
			info.UseShellExecute = false;
			info.WorkingDirectory = cwd;

			Process p = Process.Start(info);
			p.WaitForExit();

			return p.ExitCode;
		}

		public static void RunProcessThrow(string proc, string cwd)
		{
			int ret = RunProcess(proc, cwd);

			if (ret != 0)
			{
                throw new Exception($"The process '{proc}' returned {ret}");
            }
		}
	}
}
