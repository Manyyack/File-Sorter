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

			cb_Monitor2.Checked = Properties.Settings.Default.monitoring2;
			Folder_Path2.Text = Properties.Settings.Default.dir2;

			cb_Monitor3.Checked = Properties.Settings.Default.monitoring3;
			Folder_Path3.Text = Properties.Settings.Default.dir3;

			cb_Monitor4.Checked = Properties.Settings.Default.monitoring4;
			Folder_Path4.Text = Properties.Settings.Default.dir4;

			cb_Monitor5.Checked = Properties.Settings.Default.monitoring5;
			Folder_Path5.Text = Properties.Settings.Default.dir5;

			if (cb_Monitor1.Checked == false)
			{
				Folder_Path1.Enabled = false;
				bt_Browse1.Enabled = false;
			}

			if (cb_Monitor2.Checked == false)
			{
				Folder_Path2.Enabled = false;
				bt_Browse2.Enabled = false;
			}

			if (cb_Monitor3.Checked == false)
			{
				Folder_Path3.Enabled = false;
				bt_Browse3.Enabled = false;
			}

			if (cb_Monitor4.Checked == false)
			{
				Folder_Path4.Enabled = false;
				bt_Browse4.Enabled = false;
			}

			if (cb_Monitor5.Checked == false)
			{
				Folder_Path5.Enabled = false;
				bt_Browse5.Enabled = false;
			}


			ToolTip monitor_TT = new ToolTip();
			monitor_TT.AutoPopDelay = 500;
			monitor_TT.InitialDelay = 500;
			monitor_TT.ReshowDelay = 0;
			monitor_TT.AutomaticDelay = 500;

			monitor_TT.ShowAlways = true;

			monitor_TT.SetToolTip(cb_Monitor1, "Check to monitor a new folder for organizing");
			monitor_TT.SetToolTip(cb_Monitor2, "Check to monitor a new folder for organizing");
			monitor_TT.SetToolTip(cb_Monitor3, "Check to monitor a new folder for organizing");
			monitor_TT.SetToolTip(cb_Monitor4, "Check to monitor a new folder for organizing");
			monitor_TT.SetToolTip(cb_Monitor5, "Check to monitor a new folder for organizing");

			monitor_TT.SetToolTip(bt_Browse1, "Browse the folder");
			monitor_TT.SetToolTip(bt_Browse2, "Browse the folder");
			monitor_TT.SetToolTip(bt_Browse3, "Browse the folder");
			monitor_TT.SetToolTip(bt_Browse4, "Browse the folder");
			monitor_TT.SetToolTip(bt_Browse5, "Browse the folder");

			monitor_TT.SetToolTip(exit_Settings, "Save and exit.");
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
				Properties.Settings.Default.monitoring3 = true;
				Properties.Settings.Default.Save();
			}
			else
			{
				Folder_Path3.Enabled = false;
				bt_Browse3.Enabled = false;
				Properties.Settings.Default.monitoring3 = false;
				Properties.Settings.Default.Save();
			}
		}

		private void cb_Monitor2_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_Monitor2.Checked == true)
			{
				Folder_Path2.Enabled = true;
				bt_Browse2.Enabled = true;
				Properties.Settings.Default.monitoring2 = true;
				Properties.Settings.Default.Save();
			}
			else
			{
				Folder_Path2.Enabled = false;
				bt_Browse2.Enabled = false;
				Properties.Settings.Default.monitoring2 = false;
				Properties.Settings.Default.Save();
			}
		}

		private void cb_Monitor4_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_Monitor4.Checked == true)
			{
				Folder_Path4.Enabled = true;
				bt_Browse4.Enabled = true;
				Properties.Settings.Default.monitoring4 = true;
				Properties.Settings.Default.Save();
			}
			else
			{
				Folder_Path4.Enabled = false;
				bt_Browse4.Enabled = false;
				Properties.Settings.Default.monitoring4 = false;
				Properties.Settings.Default.Save();
			}
		}

		private void cb_Monitor5_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_Monitor5.Checked == true)
			{
				Folder_Path5.Enabled = true;
				bt_Browse5.Enabled = true;
				Properties.Settings.Default.monitoring5 = true;
				Properties.Settings.Default.Save();
			}
			else
			{
				Folder_Path5.Enabled = false;
				bt_Browse5.Enabled = false;
				Properties.Settings.Default.monitoring5 = false;
				Properties.Settings.Default.Save();
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

		private void bt_Browse2_Click(object sender, EventArgs e)
		{
			Browser.ShowDialog();
			Folder_Path2.Text = Browser.SelectedPath;
			Browser.Dispose();
		}

		private void bt_Browse3_Click(object sender, EventArgs e)
		{
			Browser.ShowDialog();
			Folder_Path3.Text = Browser.SelectedPath;
			Browser.Dispose();
		}

		private void bt_Browse4_Click(object sender, EventArgs e)
		{
			Browser.ShowDialog();
			Folder_Path4.Text = Browser.SelectedPath;
			Browser.Dispose();
		}

		private void bt_Browse5_Click(object sender, EventArgs e)
		{
			Browser.ShowDialog();
			Folder_Path5.Text = Browser.SelectedPath;
			Browser.Dispose();
		}

		private void Folder_Path2_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.dir2 = Folder_Path2.Text;
			Properties.Settings.Default.Save();
		}

		private void Folder_Path3_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.dir3 = Folder_Path3.Text;
			Properties.Settings.Default.Save();
		}

		private void Folder_Path4_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.dir4 = Folder_Path4.Text;
			Properties.Settings.Default.Save();
		}

		private void Folder_Path5_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.dir5 = Folder_Path5.Text;
			Properties.Settings.Default.Save();
		}
	}
}							 
