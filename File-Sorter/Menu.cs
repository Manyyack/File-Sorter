using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Sorter
{
	public partial class Menu : Form
	{
		
		Form sorter = new Form1();
		HelpForm help = new HelpForm();

		bool about_Form_Already_Opened = false;
		bool help_Already_Opened = false;
		bool monitoring_Already_Opened = false;

		public Menu()
		{
			InitializeComponent();

			this.MaximizeBox = false;
			this.Resize += Menu_Resize;
			
			sorter.MdiParent = this;
			sorter.Dock = DockStyle.Fill;
			sorter.WindowState = FormWindowState.Normal;
			sorter.Show();
		}

		private void Menu_Resize(object sender, EventArgs e)
		{
			if(this.WindowState == FormWindowState.Minimized)
			{
				
			}
		}

		private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//link to mohit's video.
			if (help_Already_Opened == false)
			{
				
				help.FormClosed += new FormClosedEventHandler(helpClosed);
				help.MdiParent = this;
				help.Dock = DockStyle.Fill;
				help.WindowState = FormWindowState.Normal;
				help_Already_Opened = true;
				help.Show();
				menuStrip1.Enabled = false;
			}
		}

		private void aboutFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (about_Form_Already_Opened == false)
			{
				Form abt = new About();
				abt.FormClosed += new FormClosedEventHandler(aboutClosed);
				abt.MdiParent = this;
				abt.Dock = DockStyle.Fill;
				abt.WindowState = FormWindowState.Normal; 
				abt.Show();
				about_Form_Already_Opened = true;
				menuStrip1.Enabled = false;
			}	
		}

		private void monitoringToolStripMenuItem_Click(object sender, EventArgs e)
		{
		
			MonitorForm monitoring = new MonitorForm();
			monitoring.FormClosed += new FormClosedEventHandler(monitorClosed);
			monitoring.MdiParent = this;
			monitoring.Dock = DockStyle.Fill;
			monitoring.WindowState = FormWindowState.Normal;
			monitoring.Show();
			menuStrip1.Enabled = false;
		}

		void aboutClosed(object sender,FormClosedEventArgs e)
		{
			about_Form_Already_Opened = false;
			menuStrip1.Enabled = true;
		}

		void helpClosed(object sender, FormClosedEventArgs e)
		{
			help_Already_Opened = false;
			menuStrip1.Enabled = true;
		}

		void monitorClosed(object sender, FormClosedEventArgs e)
		{
			monitoring_Already_Opened = false;
			menuStrip1.Enabled = true;
		}
	}
}
