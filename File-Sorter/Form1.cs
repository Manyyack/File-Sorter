﻿using System;
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
			try
			{
				Directory.SetCurrentDirectory(F_Path.Text);
			}
			catch (ArgumentException)
			{
				MessageBox.Show("Enter the Valid Path.");
				return;
			}
			catch(DirectoryNotFoundException)
			{
				MessageBox.Show("No directory found!");
				return;
			}

			string[] fileEntries = Directory.GetFiles(Directory.GetCurrentDirectory());
			
			if(fileEntries.Length == 0)
			{
				MessageBox.Show("No Files present");
				return;
			}

			string[] exclude_List = Exclude_List.Text.Split(';');
			
			foreach (string fileName in fileEntries)
			{
				bool do_Not_Move_F = false;

				if(fileName.Contains("(1)")==true)
				{
					//to run the code to delete the file
				}

				var f_Pos = fileName.LastIndexOf('.');
				string f_Type = fileName.Substring(f_Pos + 1).ToUpper();

				if (Exclude.Checked == true)
				{
					foreach(string list in exclude_List)
					{
					    if(list.ToUpper() == f_Type)
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
					Directory.Move(fileName, fileName.Insert(fileName.LastIndexOf("\\") + 1, f_Type + "\\"));
				}
			}
			MessageBox.Show("File Sort operation completed!");
			Organize.Enabled = false;
		}
		private void F_Path_TextChanged(object sender, EventArgs e)
		{
			D_Path = F_Path.Text;
			Organize.Enabled = true;
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
			tooltip1.SetToolTip(this.Exclude, "Tick to exclude types of file");
			tooltip1.SetToolTip(this.Exclude_List, "Enter the file types to exclude seperated with ';'");
		}

		private void Browse_Click(object sender, EventArgs e)
		{
			FolderBrowser.ShowDialog();
			D_Path = FolderBrowser.SelectedPath;
			if(D_Path.Length != 0)
			{
				Organize.Enabled = true;
			}
			F_Path.Text = D_Path;
			FolderBrowser.Dispose();
		}

			
	}
}
		