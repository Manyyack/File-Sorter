using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Timers;

namespace File_Sorter
{
	public partial class MonitorForm : Form
	{
		public MonitorForm()
		{
			InitializeComponent();
		}

		private void exit_Monitor_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void MonitorForm_Load(object sender, EventArgs e)
		{
			cb_Monitor1.Checked = Properties.Settings.Default.monitoring1;
			Folder_Path1.Text = Properties.Settings.Default.dir1;
			if(cb_Monitor1.Checked == false)
			{
				Folder_Path1.Enabled = false;
				bt_Browse1.Enabled = false;
			}

			ToolTip monitor_TT = new ToolTip();
			monitor_TT.AutoPopDelay = 500;
			monitor_TT.InitialDelay = 500;
			monitor_TT.ReshowDelay = 0;
			monitor_TT.AutomaticDelay = 500;

			monitor_TT.ShowAlways = true;

			
			Folder_Path2.Enabled = false;
			Folder_Path3.Enabled = false;
			Folder_Path4.Enabled = false;
			Folder_Path5.Enabled = false;

			
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
				Properties.Settings.Default.monitoring1 = true;
				Properties.Settings.Default.Save();
			}
			else
			{
				Folder_Path1.Enabled = false;
				bt_Browse1.Enabled = false;
				Folder_Path1.Text = "";
				Properties.Settings.Default.monitoring1 = false;
				Properties.Settings.Default.Save();
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
			Folder_Path1.Text = Browser.SelectedPath;
			Browser.Dispose();
			
		}

		private void Folder_Path1_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.dir1 = Folder_Path1.Text;
			Properties.Settings.Default.Save();
		}
	}
}							 
