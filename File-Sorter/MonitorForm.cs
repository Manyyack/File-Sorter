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
	public partial class MonitorForm : Form
	{
		public MonitorForm()
		{
			InitializeComponent();
		}

		private void exit_Help_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
