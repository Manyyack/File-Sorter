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
		public Menu()
		{
			InitializeComponent();
			
			Form sorter = new Form1();
			sorter.MdiParent = this;
			sorter.Dock = DockStyle.Fill;
			sorter.WindowState = FormWindowState.Normal;
			sorter.Show();
		}

		private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//link to mohit's video.
		}

		private void aboutFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form abt = new About();
			abt.Dock = DockStyle.Right;
			abt.Show();
		}
	}
}
