using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Timers;

namespace File_Sorter
{
	public partial class MonitorForm : Form
	{
		string dir_Path1;
		FileSystemWatcher watcher = new FileSystemWatcher();

		System.Timers.Timer delay = new System.Timers.Timer();

		public MonitorForm()
		{
			InitializeComponent();
		}

		private void exit_Monitor_Click(object sender, EventArgs e)
		{
			if (cb_Monitor1.Checked == true)
			{
				Application.OpenForms.OfType<Menu>().Single().menuStrip1.Enabled = true;
				Hide();
			}
			else
			{
				Close();
			}
		}

		private void MonitorForm_Load(object sender, EventArgs e)
		{

			ToolTip monitor_TT = new ToolTip();
			monitor_TT.AutoPopDelay = 500;
			monitor_TT.InitialDelay = 500;
			monitor_TT.ReshowDelay = 0;
			monitor_TT.AutomaticDelay = 500;

			monitor_TT.ShowAlways = true;

			Folder_Path1.Enabled = false;
			Folder_Path2.Enabled = false;
			Folder_Path3.Enabled = false;
			Folder_Path4.Enabled = false;
			Folder_Path5.Enabled = false;

			bt_Browse1.Enabled = false;
			bt_Browse2.Enabled = false;
			bt_Browse3.Enabled = false;
			bt_Browse4.Enabled = false;
			bt_Browse5.Enabled = false;

			//take the previous values using the application settings.
			//Future implementation.
		}

		private void cb_Monitor1_CheckedChanged(object sender, EventArgs e)
		{
			if(cb_Monitor1.Checked == true)
			{
				Folder_Path1.Enabled = true;
				bt_Browse1.Enabled = true;
			}
			else
			{
				Folder_Path1.Enabled = false;
				bt_Browse1.Enabled = false;
			}
		}

		private void cb_Monitor3_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_Monitor3.Checked == true)
			{
				Folder_Path3.Enabled = true;
				bt_Browse3.Enabled = true;
			}
			else
			{
				Folder_Path3.Enabled = false;
				bt_Browse3.Enabled = false;
			}
		}

		private void cb_Monitor2_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_Monitor2.Checked == true)
			{
				Folder_Path2.Enabled = true;
				bt_Browse2.Enabled = true;
			}
			else
			{
				Folder_Path2.Enabled = false;
				bt_Browse2.Enabled = false;
			}
		}

		private void cb_Monitor4_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_Monitor4.Checked == true)
			{
				Folder_Path4.Enabled = true;
				bt_Browse4.Enabled = true;
			}
			else
			{
				Folder_Path4.Enabled = false;
				bt_Browse4.Enabled = false;
			}
		}

		private void cb_Monitor5_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_Monitor5.Checked == true)
			{
				Folder_Path5.Enabled = true;
				bt_Browse5.Enabled = true;
			}
			else
			{
				Folder_Path5.Enabled = false;
				bt_Browse5.Enabled = false;
			}
		}

		private void bt_Browse1_Click(object sender, EventArgs e)
		{
			Browser.ShowDialog();
			dir_Path1 = Browser.SelectedPath;
			Folder_Path1.Text = dir_Path1;
			Browser.Dispose();
			
		}

		private void Folder_Path1_TextChanged(object sender, EventArgs e)
		{
			dir_Path1 = Folder_Path1.Text;

			watcher.Path = dir_Path1;
			watcher.NotifyFilter = NotifyFilters.LastWrite;
			watcher.Filter = "*.*";
			watcher.Changed += new FileSystemEventHandler(fileChanged);
			watcher.EnableRaisingEvents = true;
		}

		void fileChanged(object sender,FileSystemEventArgs e)
		{
			if(Directory.Exists(e.FullPath) == true)
			{
				return;
			}
			try
			{
				Directory.SetCurrentDirectory(dir_Path1);
			}
			catch (ArgumentException)
			{
				MessageBox.Show("Enter the Valid Path.");
				return;
			}
			catch (DirectoryNotFoundException)
			{
				MessageBox.Show("No directory found!");
				return;
			}

			string[] fileEntries = Directory.GetFiles(Directory.GetCurrentDirectory());

			if (fileEntries.Length == 0)
			{
				return;
			}

			watcher.EnableRaisingEvents = false;

			delay.Interval = 2000;
			delay.Elapsed += Delay_Elapsed;
			delay.Enabled = true;
			delay.Start();
			
		}

		private void Delay_Elapsed(object sender, ElapsedEventArgs e)
		{
			delay.Stop();
			var open_Form = Application.OpenForms.OfType<Form1>().Single();
			open_Form.changeDirectoryAndOrganize(dir_Path1, false, false);
		}

		public void enableWatcher()
		{
			watcher.EnableRaisingEvents = true;
		}
	}
}							 
