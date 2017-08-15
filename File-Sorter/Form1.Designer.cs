namespace File_Sorter
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
			this.SuspendLayout();
			// 
			// Organize
			// 
			this.Organize.Enabled = false;
			this.Organize.Location = new System.Drawing.Point(529, 11);
			this.Organize.Name = "Organize";
			this.Organize.Size = new System.Drawing.Size(122, 21);
			this.Organize.TabIndex = 0;
			this.Organize.Text = "Organize";
			this.Organize.UseVisualStyleBackColor = true;
			this.Organize.Click += new System.EventHandler(this.Connect_Click);
			// 
			// F_Path
			// 
			this.F_Path.AcceptsTab = true;
			this.F_Path.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.F_Path.AutoWordSelection = true;
			this.F_Path.BackColor = System.Drawing.Color.White;
			this.F_Path.DetectUrls = false;
			this.F_Path.EnableAutoDragDrop = true;
			this.F_Path.Location = new System.Drawing.Point(44, 12);
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
			this.label1.Location = new System.Drawing.Point(9, 12);
			this.label1.MaximumSize = new System.Drawing.Size(40, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Path";
			// 
			// Browse
			// 
			this.Browse.BackColor = System.Drawing.Color.Transparent;
			this.Browse.Location = new System.Drawing.Point(497, 10);
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
			// Form1
			// 
			this.AcceptButton = this.Organize;
			this.AllowDrop = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(666, 42);
			this.Controls.Add(this.Browse);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.F_Path);
			this.Controls.Add(this.Organize);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Opacity = 0.9D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "File Sorter";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Organize;
		private System.Windows.Forms.RichTextBox F_Path;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Browse;
		private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
	}
}

