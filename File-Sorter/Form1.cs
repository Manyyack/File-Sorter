using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

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

		void changeDirectoryAndOrganize(string path_to_dir, bool user_message, bool give_Record)
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

			Button[] folder_Open = new Button[File_Types.Count];
			Label[] file_info = new Label[File_Types.Count];
			ToolTip button = new ToolTip();

			Button_Panel.Visible = true;
			Button_Box.Visible = true;

			int X_Start = 10;
			int Y_Start = 20;
			int Button_Offset_Frm_Label = 10;
			int Offset_Bwtn_Button = 10;
			int Group_Box_Offset = 10;

			foreach (string thistypes in File_Types)
			{
				int indexer = File_Types.IndexOf(thistypes);
				folder_Open[indexer] = new Button();
				file_info[indexer] = new Label();

				file_info[indexer].Text = F_count[indexer].ToString() + " " + thistypes + " File";
				if (F_count[indexer] > 1)
				{
					file_info[indexer].Text += "s";
				}

				file_info[indexer].ForeColor = label1.ForeColor;

				folder_Open[indexer].Width = Organize.Width;
				folder_Open[indexer].Height = Organize.Height;
				folder_Open[indexer].BackColor = Organize.BackColor;
				folder_Open[indexer].ForeColor = Organize.ForeColor;
				folder_Open[indexer].Text = "Open " + thistypes.ToUpper();
				folder_Open[indexer].Click += new EventHandler(openFolder);

				if (indexer == 0)
				{
					file_info[indexer].Location = new System.Drawing.Point(X_Start, Y_Start);
					folder_Open[indexer].Location = new System.Drawing.Point(file_info[indexer].Width + Button_Offset_Frm_Label, file_info[indexer].Location.Y);
				}
				else
				{
					folder_Open[indexer].Location = new System.Drawing.Point(folder_Open[indexer - 1].Location.X, folder_Open[indexer - 1].Location.Y + Offset_Bwtn_Button + folder_Open[indexer - 1].Height);
					file_info[indexer].Location = new System.Drawing.Point(file_info[indexer - 1].Location.X, folder_Open[indexer].Location.Y);
				}

				Button_Box.Height = folder_Open[indexer].Height + folder_Open[indexer].Location.Y + Group_Box_Offset;
				Button_Box.Width = folder_Open[indexer].Width + folder_Open[indexer].Location.X + Group_Box_Offset;
				Button_Box.Controls.Add(file_info[indexer]);
				Button_Box.Controls.Add(folder_Open[indexer]);

				Console.WriteLine("Files operated of " + thistypes + " are " + F_count[indexer].ToString());
			}

			Button_Panel.Width = Button_Box.Width + 25;
			//Button_Box.Visible = true;
		}

		void openFolder(object sender, EventArgs e)
		{
			Console.WriteLine(sender.ToString());
			var temp = sender.ToString().LastIndexOf(' ');
			string folder_Name = sender.ToString().Substring(temp + 1);
			string path_to_folder = D_Path + "\\" + folder_Name;
			Console.WriteLine(folder_Name);
			Console.WriteLine(path_to_folder);

			//Process.Start("explorer.exe", "/select , \"" + path_to_folder + "\"");
			Process.Start(@path_to_folder);

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
			if (Monitor.Checked == true)
			{
				if (F_Path.Text != "")
				{
					F_Path.Enabled = false;
					Organize.Visible = false;
					//code to monitor the changes in file to sort.
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
				Organize.Visible = true;
				F_Path.Enabled = true;
			}
		}	
	}
}