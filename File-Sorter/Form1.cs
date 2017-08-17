using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace File_Sorter
{
	public partial class Form1 : Form
	{
		String D_Path;		

		public Form1()
		{
			InitializeComponent();			
		}

		private void Connect_Click(object sender, EventArgs e)
		{
			changeDirectoryAndOrganize(F_Path.Text, true, true);
		}

		void changeDirectoryAndOrganize(string path_to_dir,bool user_message,bool give_Record)
		{
			try
			{
				Directory.SetCurrentDirectory(path_to_dir);
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
				if (user_message == true)
				{
					MessageBox.Show("No Files present");
				}
				return;
			}

			string[] exclude_List = Exclude_List.Text.Split(';');

			List<String> File_Types = new List<string>();
			List<int> F_count = new List<int>();

			File_Types.Capacity = 0;
			F_count.Capacity = 0;

			foreach (string fileName in fileEntries)
			{
				bool do_Not_Move_F = false;

				//if(fileName.Contains("(1)")==true)
				//{
				//	//to run the code to delete the file
				//	Console.WriteLine("Deleting " + fileName);
				//	File.Delete(fileName);
				//}

				var f_Pos = fileName.LastIndexOf('.');
				string f_Type = fileName.Substring(f_Pos + 1).ToUpper();

				if (Exclude.Checked == true)
				{
					foreach (string list in exclude_List)
					{
						if (list.ToUpper() == f_Type)
						{
							do_Not_Move_F = true;
							break;
						}
					}
				}

				if (do_Not_Move_F != true)
				{
					if (Directory.Exists(D_Path + "\\" + f_Type) == false)
					{
						Directory.CreateDirectory(D_Path + "\\" + f_Type);
					}

					if (give_Record == true)
					{
						if (File_Types.Contains(f_Type) == false)
						{
							File_Types.Add(f_Type);
							F_count.Add(1);
						}
						else
						{
							var indexer = File_Types.IndexOf(f_Type);
							F_count[indexer]++;
						}
					}

					Directory.Move(fileName, fileName.Insert(fileName.LastIndexOf("\\") + 1, f_Type + "\\"));
				}
			}
			if (user_message == true)
			{
				MessageBox.Show("File Sort operation completed!");
			}
		}

		private void F_Path_TextChanged(object sender, EventArgs e)
		{
			D_Path = F_Path.Text;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ToolTip tooltip1 = new ToolTip();

			tooltip1.AutoPopDelay = 5000;
			tooltip1.InitialDelay = 500;
			tooltip1.ReshowDelay = 500;
			tooltip1.ShowAlways = true;

			tooltip1.SetToolTip(this.F_Path, "Enter the path of the directory which needs sorting of the files");
			tooltip1.SetToolTip(this.Organize, "Click to sort files");
			tooltip1.SetToolTip(this.Browse, "Browse the folder");
			tooltip1.SetToolTip(this.Exclude, "Check to exclude File Types");
			tooltip1.SetToolTip(this.Exclude_List, "Enter the file types to exclude seperated with ';'");
		}

		private void Browse_Click(object sender, EventArgs e)
		{
			FolderBrowser.ShowDialog();
			D_Path = FolderBrowser.SelectedPath;
			F_Path.Text = D_Path;
			FolderBrowser.Dispose();
		}

		private void Monitor_CheckedChanged(object sender, EventArgs e)
		{
			if(Monitor.Checked == true)
			{
				if (F_Path.Text != "")
				{
					F_Path.Enabled = false;
					Organize.Visible = false;
					fileSystemWatcher1.Path = F_Path.Text;
					fileSystemWatcher1.NotifyFilter = NotifyFilters.CreationTime;

					//fileSystemWatcher1.Changed += new FileSystemEventHandler(OnChanged);
					fileSystemWatcher1.Created += new FileSystemEventHandler(fileSystemWatcher1_Changed);
					//fileSystemWatcher1.Deleted += new FileSystemEventHandler(OnChanged);
					//fileSystemWatcher1.Renamed += new RenamedEventHandler(OnRenamed);

					fileSystemWatcher1.EnableRaisingEvents = true;
				}
				else
				{
					MessageBox.Show("Enter a path to Monitor");
					Monitor.Checked = false;
					return;
				}
			}
			else
			{
				fileSystemWatcher1.EndInit();
				Organize.Visible = true;
				F_Path.Enabled = true;
			}
		}

		private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
		{
			
		}
	}
}
		