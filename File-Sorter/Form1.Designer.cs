﻿namespace File_Sorter
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Organize = new System.Windows.Forms.Button();
			this.F_Path = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Browse = new System.Windows.Forms.Button();
			this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
			this.Exclude = new System.Windows.Forms.CheckBox();
			this.Exclude_List = new System.Windows.Forms.TextBox();
			this.Monitor = new System.Windows.Forms.CheckBox();
			this.Button_Box = new System.Windows.Forms.GroupBox();
			this.Button_Panel = new System.Windows.Forms.Panel();
			this.Button_Panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// Organize
			// 
			this.Organize.BackColor = System.Drawing.SystemColors.Control;
			this.Organize.ForeColor = System.Drawing.SystemColors.MenuText;
			this.Organize.Location = new System.Drawing.Point(530, 30);
			this.Organize.Name = "Organize";
			this.Organize.Size = new System.Drawing.Size(122, 22);
			this.Organize.TabIndex = 0;
			this.Organize.Text = "Organize";
			this.Organize.UseVisualStyleBackColor = false;
			this.Organize.Click += new System.EventHandler(this.Connect_Click);
			// 
			// F_Path
			// 
			this.F_Path.AcceptsTab = true;
			this.F_Path.AutoWordSelection = true;
			this.F_Path.BackColor = System.Drawing.Color.White;
			this.F_Path.DetectUrls = false;
			this.F_Path.EnableAutoDragDrop = true;
			this.F_Path.Location = new System.Drawing.Point(45, 31);
			this.F_Path.Multiline = false;
			this.F_Path.Name = "F_Path";
			this.F_Path.Size = new System.Drawing.Size(447, 21);
			this.F_Path.TabIndex = 1;
			this.F_Path.Text = "";
			this.F_Path.TextChanged += new System.EventHandler(this.F_Path_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.PanEast;
			this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label1.Location = new System.Drawing.Point(10, 34);
			this.label1.MaximumSize = new System.Drawing.Size(40, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Path";
			// 
			// Browse
			// 
			this.Browse.BackColor = System.Drawing.Color.Transparent;
			this.Browse.ForeColor = System.Drawing.SystemColors.InfoText;
			this.Browse.Location = new System.Drawing.Point(498, 29);
			this.Browse.Name = "Browse";
			this.Browse.Size = new System.Drawing.Size(26, 23);
			this.Browse.TabIndex = 3;
			this.Browse.Text = "...";
			this.Browse.UseVisualStyleBackColor = false;
			this.Browse.Click += new System.EventHandler(this.Browse_Click);
			// 
			// FolderBrowser
			// 
			this.FolderBrowser.ShowNewFolderButton = false;
			// 
			// Exclude
			// 
			this.Exclude.AutoSize = true;
			this.Exclude.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.Exclude.Location = new System.Drawing.Point(45, 59);
			this.Exclude.Name = "Exclude";
			this.Exclude.Size = new System.Drawing.Size(64, 17);
			this.Exclude.TabIndex = 4;
			this.Exclude.Text = "Exclude";
			this.Exclude.UseVisualStyleBackColor = true;
			// 
			// Exclude_List
			// 
			this.Exclude_List.Location = new System.Drawing.Point(105, 59);
			this.Exclude_List.Name = "Exclude_List";
			this.Exclude_List.Size = new System.Drawing.Size(209, 20);
			this.Exclude_List.TabIndex = 5;
			// 
			// Monitor
			// 
			this.Monitor.AutoSize = true;
			this.Monitor.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.Monitor.Location = new System.Drawing.Point(431, 57);
			this.Monitor.Name = "Monitor";
			this.Monitor.Size = new System.Drawing.Size(61, 17);
			this.Monitor.TabIndex = 6;
			this.Monitor.Text = "Monitor";
			this.Monitor.UseVisualStyleBackColor = true;
			this.Monitor.CheckedChanged += new System.EventHandler(this.Monitor_CheckedChanged);
			// 
			// Button_Box
			// 
			this.Button_Box.Location = new System.Drawing.Point(3, 3);
			this.Button_Box.Name = "Button_Box";
			this.Button_Box.Size = new System.Drawing.Size(200, 20);
			this.Button_Box.TabIndex = 0;
			this.Button_Box.TabStop = false;
			this.Button_Box.Text = "Folder Information";
			this.Button_Box.Visible = false;
			// 
			// Button_Panel
			// 
			this.Button_Panel.AutoScroll = true;
			this.Button_Panel.Controls.Add(this.Button_Box);
			this.Button_Panel.Location = new System.Drawing.Point(13, 85);
			this.Button_Panel.Name = "Button_Panel";
			this.Button_Panel.Size = new System.Drawing.Size(209, 274);
			this.Button_Panel.TabIndex = 7;
			this.Button_Panel.Visible = false;
			// 
			// Form1
			// 
			this.AcceptButton = this.Organize;
			this.AllowDrop = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(666, 366);
			this.ControlBox = false;
			this.Controls.Add(this.Button_Panel);
			this.Controls.Add(this.Monitor);
			this.Controls.Add(this.Exclude_List);
			this.Controls.Add(this.Exclude);
			this.Controls.Add(this.Browse);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.F_Path);
			this.Controls.Add(this.Organize);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.ForeColor = System.Drawing.SystemColors.Menu;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "File Sorter";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Button_Panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Organize;
		private System.Windows.Forms.RichTextBox F_Path;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Browse;
		private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
		private System.Windows.Forms.CheckBox Exclude;
		private System.Windows.Forms.TextBox Exclude_List;
		private System.Windows.Forms.CheckBox Monitor;
		private System.Windows.Forms.GroupBox Button_Box;
		private System.Windows.Forms.Panel Button_Panel;
	}
}

