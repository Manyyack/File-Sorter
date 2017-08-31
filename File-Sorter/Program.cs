using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace File_Sorter
{
	

	static class Program
	{

		//Startup registry key and value
		private static readonly string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
		private static readonly string StartupValue = "File-Sorter";


		private static void SetStartup()
		{
			//Set the application to run at startup
			RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
			key.SetValue(StartupValue, Application.ExecutablePath.ToString());
		}
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

			SetStartup();
			Application.Run(new Menu());
		}
	}

	
}
