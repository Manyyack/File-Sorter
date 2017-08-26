using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace File_Sorter
{
	public partial class Form1 : Form
	{
		string D_Path;									//Directory Path
		string folder_Opener;							//when process uses to open the folder

		public delegate void organizeDelegate(string path_to_dir, bool user_message, bool give_Record);  //delegates created to invoke the function on to the main thread
		public organizeDelegate OrganizeDel;												  //delegates created to invoke the function on to the main thread

		NotifyIcon notifier = new NotifyIcon();

		FileSystemWatcher watcher1 = new FileSystemWatcher();		//5 filesystem watcher for monitoring
		FileSystemWatcher watcher2 = new FileSystemWatcher();		//5 filesystem watcher for monitoring
		FileSystemWatcher watcher3 = new FileSystemWatcher();		//5 filesystem watcher for monitoring
		FileSystemWatcher watcher4 = new FileSystemWatcher();		//5 filesystem watcher for monitoring
		FileSystemWatcher watcher5 = new FileSystemWatcher();		//5 filesystem watcher for monitoring

		System.Timers.Timer delay = new System.Timers.Timer();

		public Form1()
		{
			InitializeComponent();

			watcher1.NotifyFilter = NotifyFilters.LastWrite;
			watcher1.Filter = "*.*";
			watcher1.Changed += new FileSystemEventHandler(fileChanged1);

			Properties.Settings.Default.PropertyChanged += Default_PropertyChanged;


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

		private void F_Path_TextChanged(object sender, EventArgs e)
		{
			D_Path = F_Path.Text;
		}

		private void Connect_Click(object sender, EventArgs e)
		{
			Button_Box.Controls.Clear();
			changeDirectoryAndOrganize(D_Path, true, true);
		}

		public void changeDirectoryAndOrganize(string path_to_dir, bool user_message, bool give_Record)
		{
			if (InvokeRequired)																    //this whole part is to bring the control to the main thread from the worker thread.. IMP
			{																			    //this whole part is to bring the control to the main thread from the worker thread.. IMP
				object[] arr = new object[3];													    //this whole part is to bring the control to the main thread from the worker thread.. IMP
				arr[0] = path_to_dir;														    //this whole part is to bring the control to the main thread from the worker thread.. IMP
				arr[1] = user_message;														    //this whole part is to bring the control to the main thread from the worker thread.. IMP
				arr[2] = give_Record;														    //this whole part is to bring the control to the main thread from the worker thread.. IMP
				this.OrganizeDel += new organizeDelegate(changeDirectoryAndOrganize);					    //this whole part is to bring the control to the main thread from the worker thread.. IMP
				Invoke(OrganizeDel,arr);														    //this whole part is to bring the control to the main thread from the worker thread.. IMP
			}																			    //this whole part is to bring the control to the main thread from the worker thread.. IMP
			else
			{
				Button_Panel.Visible = false;									//make information about previous folders organized disappear
				Button_Box.Visible = false;									//make information about previous folders organized disappear

				if (checkForDirectory(path_to_dir) == false)						//if directory entered is not present, return and exit
				{
					return;
				}

				string[] fileEntries = Directory.GetFiles(Directory.GetCurrentDirectory());

				if (fileEntries.Length == 0)									//if no files are present to organize, return and exit
				{
					if (user_message == true)
					{
						MessageBox.Show("No Files present");
					}
					return;
				}

				string[] exclude_List;

				if (user_message == true)									//when this particular function is being called from the form1 , take the exclude list as provided
				{
					exclude_List = Exclude_List.Text.Split(';');
				}
				else														//if the user messages are not going to be provided, hence the function has been called from the monitoring form,
				{
					exclude_List = new string[1];						//in that case , take the default files that needs to be excluded for example .part files are generated when downloading using the firefox, hence ignore the file till it is fully downloaded
					exclude_List[0] = "part";
				}


				List<String> File_Types = new List<string>();				//variable that stores all the file types
				List<int> F_count = new List<int>();						//variable that stores the counts for the specific file types for all the filetypes

				File_Types.Capacity = 0;
				F_count.Capacity = 0;

				foreach (string fileName in fileEntries)
				{
					bool do_Not_Move_F = false;

					var f_Pos = fileName.LastIndexOf('.');							//search for the last '.' present in the filename , hence we will be left with only extension
					string f_Type = fileName.Substring(f_Pos + 1).ToUpper();

					if (Exclude.Checked == true || user_message == false)			    //if exclude is check when running  from the main form or the no user message for monitoring, donot attempt to move the file
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
						if (Directory.Exists(path_to_dir + "\\" + f_Type) == false)		//if directory for the specific extension is not generated before 
						{
							Directory.CreateDirectory(path_to_dir + "\\" + f_Type);	//generate
						}

						//Console.WriteLine(fileName);
						//Console.WriteLine(fileName.Insert(fileName.LastIndexOf("\\") + 1, f_Type + "\\"));

						try
						{
							FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.None);		//open the file to check if other process in the system is accessing the file
							FileInfo info = new FileInfo(fileName);												//get the information regarding the file
							stream.Close();																//close the stream to proceed with the smooth operation of the file organizing

							if (info.Length != 0)							//if file size is not ZERO
							{
								try
								{
									Directory.Move(fileName, fileName.Insert(fileName.LastIndexOf("\\") + 1, f_Type + "\\"));      //ORGANIZE
								}
								catch(System.IO.IOException)
								{

								}
							}

							if (give_Record == true)										//if the record is needed, that is being run from the main form , generate all the information for creating a record.
							{
								if (File_Types.Contains(f_Type) == false)					//if the file type for record has not been added before, add the file type and set the count to 1;
								{
									File_Types.Add(f_Type);
									F_count.Add(1);
								}
								else												  //other wise simply increment the count
								{
									var indexer = File_Types.IndexOf(f_Type);
									F_count[indexer]++;
								}
							}
						}
						catch(IOException)											//if file was being used. OP message
						{
							if(user_message == true)
							{
								MessageBox.Show(fileName + " is currently being accessed by another process.");
							}
						}	
					}
				}

				if (user_message == true)			//OP Message
				{
					MessageBox.Show("Your Folder has been organized!");

				}
				else
				{
					folder_Opener = path_to_dir;
					notifier.Icon = new Icon(Application.StartupPath + @"\icon.ico");
					notifier.BalloonTipTitle = "Folder Organized";
					notifier.BalloonTipText = "Click to open the folder";
					notifier.Text = "Open Folder";
					notifier.Visible = true;
					notifier.ShowBalloonTip(5000);
					notifier.BalloonTipClicked += new EventHandler(Notifier_BalloonTipClicked);
				}

				if (user_message == true)
				{
					Button[] folder_Open = new Button[File_Types.Count];
					Label[] file_info = new Label[File_Types.Count];
					ToolTip button_info = new ToolTip();

					button_info.AutoPopDelay = 5000;
					button_info.InitialDelay = 500;
					button_info.ReshowDelay = 500;
					button_info.ShowAlways = true;

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

						file_info[indexer].Text = F_count[indexer].ToString() + " ." + thistypes.ToLower() + " File";
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

						button_info.SetToolTip(folder_Open[indexer], "Click to open " + thistypes + " files");

						if (indexer == 0)
						{
							file_info[indexer].Location = new System.Drawing.Point(X_Start, Y_Start);
							folder_Open[indexer].Location = new Point(file_info[indexer].Width + Button_Offset_Frm_Label, file_info[indexer].Location.Y);
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

						//Console.WriteLine("Files operated of " + thistypes + " are " + F_count[indexer].ToString());
					}

					Button_Panel.Width = Button_Box.Width + 25;
					//Button_Box.Visible = true;
				}

				File_Types.Clear();
			}
				
		}

		void openFolder(object sender, EventArgs e)
		{
			//Console.WriteLine(sender.ToString());
			var temp = sender.ToString().LastIndexOf(' ');
			string folder_Name = sender.ToString().Substring(temp + 1);
			string path_to_folder = D_Path + "\\" + folder_Name;
			//Console.WriteLine(folder_Name);
			//Console.WriteLine(path_to_folder);
			Process.Start(@path_to_folder);

		}
		
		private void Notifier_MouseDoubleClick(object sender, EventArgs e)
		{
			Process.Start(@folder_Opener);

			notifier.Visible = false;
			notifier.Icon = null;
			//notifier.Dispose();
		}

		private void Notifier_MouseClick(object sender, EventArgs e)
		{
			Process.Start(folder_Opener);

			notifier.Visible = false;
			notifier.Icon = null;
			//notifier.Dispose();
		}

		private void Notifier_BalloonTipClicked(object sender, EventArgs e)
		{
			Process.Start(@folder_Opener);

			
			notifier.Icon = null;
			notifier.Visible = false;
			//notifier.Dispose();
		}

		private void Default_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (Properties.Settings.Default.monitoring1 == true && Properties.Settings.Default.dir1 != "")
			{
				watcher1.Path = Properties.Settings.Default.dir1;

				if (checkForDirectory(watcher1.Path) == true)
				{
					watcher1.EnableRaisingEvents = true;
				}
				else
				{
					watcher1.EnableRaisingEvents = false;
					return;
				}
			}
			else
			{
				watcher1.EnableRaisingEvents = false;
			}
		}

		void fileChanged1(object sender, FileSystemEventArgs e)
		{
			checkForDirectory(watcher1.Path);

			string[] files_present = Directory.GetFiles(Directory.GetCurrentDirectory());

			if (files_present.Length == 0)
			{
				return;
			}

			delay.Interval = 2000;
			delay.Elapsed += Delay_Tick;
			delay.Enabled = true;
			
		}

		private void Delay_Tick(object sender, EventArgs e)
		{
			delay.Enabled = false;
			changeDirectoryAndOrganize(Properties.Settings.Default.dir1, false, false);

		}

		bool checkForDirectory(string dir_path_temp)
		{
			try
			{
				Directory.SetCurrentDirectory(dir_path_temp);
				return true;
			}
			catch (ArgumentException)
			{
				MessageBox.Show("Enter the Valid Path.");
				return false;
			}
			catch (DirectoryNotFoundException)
			{
				MessageBox.Show("No directory found!");
				return false;
			}
		}
	}
}