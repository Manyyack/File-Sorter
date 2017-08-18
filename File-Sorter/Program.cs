using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Sorter
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			String thisprocessname = Process.GetCurrentProcess().ProcessName;

			if (Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
			{
				MessageBox.Show("Instance of the software already running.");
				return;
			}

			Application.Run(new Menu());
		}
	}
}
