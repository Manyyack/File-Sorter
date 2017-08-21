namespace File_Sorter
{
	partial class MonitorForm
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
			this.exit_Help = new System.Windows.Forms.Button();
			this.bt_Browse1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Folder_Path1 = new System.Windows.Forms.RichTextBox();
			this.cb_Monitor1 = new System.Windows.Forms.CheckBox();
			this.cb_Monitor2 = new System.Windows.Forms.CheckBox();
			this.bt_Browse2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.Folder_Path2 = new System.Windows.Forms.RichTextBox();
			this.cb_Monitor3 = new System.Windows.Forms.CheckBox();
			this.bt_Browse3 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.Folder_Path3 = new System.Windows.Forms.RichTextBox();
			this.cb_Monitor4 = new System.Windows.Forms.CheckBox();
			this.bt_Browse4 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.Folder_Path4 = new System.Windows.Forms.RichTextBox();
			this.cb_Monitor5 = new System.Windows.Forms.CheckBox();
			this.bt_Browse5 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.Folder_Path5 = new System.Windows.Forms.RichTextBox();
			this.Browser = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// exit_Help
			// 
			this.exit_Help.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.exit_Help.Location = new System.Drawing.Point(280, 331);
			this.exit_Help.Name = "exit_Help";
			this.exit_Help.Size = new System.Drawing.Size(75, 23);
			this.exit_Help.TabIndex = 2;
			this.exit_Help.Text = "Exit";
			this.exit_Help.UseVisualStyleBackColor = true;
			this.exit_Help.Click += new System.EventHandler(this.exit_Monitor_Click);
			// 
			// bt_Browse1
			// 
			this.bt_Browse1.BackColor = System.Drawing.Color.Transparent;
			this.bt_Browse1.ForeColor = System.Drawing.SystemColors.InfoText;
			this.bt_Browse1.Location = new System.Drawing.Point(601, 30);
			this.bt_Browse1.Name = "bt_Browse1";
			this.bt_Browse1.Size = new System.Drawing.Size(53, 23);
			this.bt_Browse1.TabIndex = 7;
			this.bt_Browse1.Text = "Browse";
			this.bt_Browse1.UseVisualStyleBackColor = false;
			this.bt_Browse1.Click += new System.EventHandler(this.bt_Browse1_Click);
			// 
			// label1
			// 
			this.label1.Cursor = System.Windows.Forms.Cursors.PanEast;
			this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label1.Location = new System.Drawing.Point(97, 27);
			this.label1.MaximumSize = new System.Drawing.Size(80, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Folder Path";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Folder_Path1
			// 
			this.Folder_Path1.AcceptsTab = true;
			this.Folder_Path1.AutoWordSelection = true;
			this.Folder_Path1.BackColor = System.Drawing.Color.White;
			this.Folder_Path1.DetectUrls = false;
			this.Folder_Path1.EnableAutoDragDrop = true;
			this.Folder_Path1.Location = new System.Drawing.Point(170, 30);
			this.Folder_Path1.Multiline = false;
			this.Folder_Path1.Name = "Folder_Path1";
			this.Folder_Path1.Size = new System.Drawing.Size(425, 21);
			this.Folder_Path1.TabIndex = 5;
			this.Folder_Path1.Text = "";
			this.Folder_Path1.TextChanged += new System.EventHandler(this.Folder_Path1_TextChanged);
			// 
			// cb_Monitor1
			// 
			this.cb_Monitor1.Location = new System.Drawing.Point(30, 30);
			this.cb_Monitor1.Name = "cb_Monitor1";
			this.cb_Monitor1.Size = new System.Drawing.Size(61, 16);
			this.cb_Monitor1.TabIndex = 8;
			this.cb_Monitor1.Text = "Monitor";
			this.cb_Monitor1.UseVisualStyleBackColor = true;
			this.cb_Monitor1.CheckedChanged += new System.EventHandler(this.cb_Monitor1_CheckedChanged);
			// 
			// cb_Monitor2
			// 
			this.cb_Monitor2.Location = new System.Drawing.Point(30, 59);
			this.cb_Monitor2.Name = "cb_Monitor2";
			this.cb_Monitor2.Size = new System.Drawing.Size(61, 16);
			this.cb_Monitor2.TabIndex = 14;
			this.cb_Monitor2.Text = "Monitor";
			this.cb_Monitor2.UseVisualStyleBackColor = true;
			this.cb_Monitor2.CheckedChanged += new System.EventHandler(this.cb_Monitor2_CheckedChanged);
			// 
			// bt_Browse2
			// 
			this.bt_Browse2.BackColor = System.Drawing.Color.Transparent;
			this.bt_Browse2.ForeColor = System.Drawing.SystemColors.InfoText;
			this.bt_Browse2.Location = new System.Drawing.Point(601, 59);
			this.bt_Browse2.Name = "bt_Browse2";
			this.bt_Browse2.Size = new System.Drawing.Size(53, 23);
			this.bt_Browse2.TabIndex = 13;
			this.bt_Browse2.Text = "Browse";
			this.bt_Browse2.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.Cursor = System.Windows.Forms.Cursors.PanEast;
			this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label2.Location = new System.Drawing.Point(97, 56);
			this.label2.MaximumSize = new System.Drawing.Size(80, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 20);
			this.label2.TabIndex = 12;
			this.label2.Text = "Folder Path";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Folder_Path2
			// 
			this.Folder_Path2.AcceptsTab = true;
			this.Folder_Path2.AutoWordSelection = true;
			this.Folder_Path2.BackColor = System.Drawing.Color.White;
			this.Folder_Path2.DetectUrls = false;
			this.Folder_Path2.EnableAutoDragDrop = true;
			this.Folder_Path2.Location = new System.Drawing.Point(170, 59);
			this.Folder_Path2.Multiline = false;
			this.Folder_Path2.Name = "Folder_Path2";
			this.Folder_Path2.Size = new System.Drawing.Size(425, 21);
			this.Folder_Path2.TabIndex = 11;
			this.Folder_Path2.Text = "";
			// 
			// cb_Monitor3
			// 
			this.cb_Monitor3.Location = new System.Drawing.Point(30, 88);
			this.cb_Monitor3.Name = "cb_Monitor3";
			this.cb_Monitor3.Size = new System.Drawing.Size(61, 16);
			this.cb_Monitor3.TabIndex = 19;
			this.cb_Monitor3.Text = "Monitor";
			this.cb_Monitor3.UseVisualStyleBackColor = true;
			this.cb_Monitor3.CheckedChanged += new System.EventHandler(this.cb_Monitor3_CheckedChanged);
			// 
			// bt_Browse3
			// 
			this.bt_Browse3.BackColor = System.Drawing.Color.Transparent;
			this.bt_Browse3.ForeColor = System.Drawing.SystemColors.InfoText;
			this.bt_Browse3.Location = new System.Drawing.Point(601, 88);
			this.bt_Browse3.Name = "bt_Browse3";
			this.bt_Browse3.Size = new System.Drawing.Size(53, 23);
			this.bt_Browse3.TabIndex = 18;
			this.bt_Browse3.Text = "Browse";
			this.bt_Browse3.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			this.label3.Cursor = System.Windows.Forms.Cursors.PanEast;
			this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label3.Location = new System.Drawing.Point(97, 85);
			this.label3.MaximumSize = new System.Drawing.Size(80, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 20);
			this.label3.TabIndex = 17;
			this.label3.Text = "Folder Path";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Folder_Path3
			// 
			this.Folder_Path3.AcceptsTab = true;
			this.Folder_Path3.AutoWordSelection = true;
			this.Folder_Path3.BackColor = System.Drawing.Color.White;
			this.Folder_Path3.DetectUrls = false;
			this.Folder_Path3.EnableAutoDragDrop = true;
			this.Folder_Path3.Location = new System.Drawing.Point(170, 88);
			this.Folder_Path3.Multiline = false;
			this.Folder_Path3.Name = "Folder_Path3";
			this.Folder_Path3.Size = new System.Drawing.Size(425, 21);
			this.Folder_Path3.TabIndex = 16;
			this.Folder_Path3.Text = "";
			// 
			// cb_Monitor4
			// 
			this.cb_Monitor4.Location = new System.Drawing.Point(30, 117);
			this.cb_Monitor4.Name = "cb_Monitor4";
			this.cb_Monitor4.Size = new System.Drawing.Size(61, 16);
			this.cb_Monitor4.TabIndex = 24;
			this.cb_Monitor4.Text = "Monitor";
			this.cb_Monitor4.UseVisualStyleBackColor = true;
			this.cb_Monitor4.CheckedChanged += new System.EventHandler(this.cb_Monitor4_CheckedChanged);
			// 
			// bt_Browse4
			// 
			this.bt_Browse4.BackColor = System.Drawing.Color.Transparent;
			this.bt_Browse4.ForeColor = System.Drawing.SystemColors.InfoText;
			this.bt_Browse4.Location = new System.Drawing.Point(601, 117);
			this.bt_Browse4.Name = "bt_Browse4";
			this.bt_Browse4.Size = new System.Drawing.Size(53, 23);
			this.bt_Browse4.TabIndex = 23;
			this.bt_Browse4.Text = "Browse";
			this.bt_Browse4.UseVisualStyleBackColor = false;
			// 
			// label4
			// 
			this.label4.Cursor = System.Windows.Forms.Cursors.PanEast;
			this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label4.Location = new System.Drawing.Point(97, 114);
			this.label4.MaximumSize = new System.Drawing.Size(80, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 20);
			this.label4.TabIndex = 22;
			this.label4.Text = "Folder Path";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Folder_Path4
			// 
			this.Folder_Path4.AcceptsTab = true;
			this.Folder_Path4.AutoWordSelection = true;
			this.Folder_Path4.BackColor = System.Drawing.Color.White;
			this.Folder_Path4.DetectUrls = false;
			this.Folder_Path4.EnableAutoDragDrop = true;
			this.Folder_Path4.Location = new System.Drawing.Point(170, 117);
			this.Folder_Path4.Multiline = false;
			this.Folder_Path4.Name = "Folder_Path4";
			this.Folder_Path4.Size = new System.Drawing.Size(425, 21);
			this.Folder_Path4.TabIndex = 21;
			this.Folder_Path4.Text = "";
			// 
			// cb_Monitor5
			// 
			this.cb_Monitor5.Location = new System.Drawing.Point(30, 146);
			this.cb_Monitor5.Name = "cb_Monitor5";
			this.cb_Monitor5.Size = new System.Drawing.Size(61, 16);
			this.cb_Monitor5.TabIndex = 29;
			this.cb_Monitor5.Text = "Monitor";
			this.cb_Monitor5.UseVisualStyleBackColor = true;
			this.cb_Monitor5.CheckedChanged += new System.EventHandler(this.cb_Monitor5_CheckedChanged);
			// 
			// bt_Browse5
			// 
			this.bt_Browse5.BackColor = System.Drawing.Color.Transparent;
			this.bt_Browse5.ForeColor = System.Drawing.SystemColors.InfoText;
			this.bt_Browse5.Location = new System.Drawing.Point(601, 146);
			this.bt_Browse5.Name = "bt_Browse5";
			this.bt_Browse5.Size = new System.Drawing.Size(53, 23);
			this.bt_Browse5.TabIndex = 28;
			this.bt_Browse5.Text = "Browse";
			this.bt_Browse5.UseVisualStyleBackColor = false;
			// 
			// label5
			// 
			this.label5.Cursor = System.Windows.Forms.Cursors.PanEast;
			this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label5.Location = new System.Drawing.Point(97, 143);
			this.label5.MaximumSize = new System.Drawing.Size(80, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 20);
			this.label5.TabIndex = 27;
			this.label5.Text = "Folder Path";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Folder_Path5
			// 
			this.Folder_Path5.AcceptsTab = true;
			this.Folder_Path5.AutoWordSelection = true;
			this.Folder_Path5.BackColor = System.Drawing.Color.White;
			this.Folder_Path5.DetectUrls = false;
			this.Folder_Path5.EnableAutoDragDrop = true;
			this.Folder_Path5.Location = new System.Drawing.Point(170, 146);
			this.Folder_Path5.Multiline = false;
			this.Folder_Path5.Name = "Folder_Path5";
			this.Folder_Path5.Size = new System.Drawing.Size(425, 21);
			this.Folder_Path5.TabIndex = 26;
			this.Folder_Path5.Text = "";
			// 
			// MonitorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(666, 366);
			this.Controls.Add(this.cb_Monitor5);
			this.Controls.Add(this.bt_Browse5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Folder_Path5);
			this.Controls.Add(this.cb_Monitor4);
			this.Controls.Add(this.bt_Browse4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Folder_Path4);
			this.Controls.Add(this.cb_Monitor3);
			this.Controls.Add(this.bt_Browse3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Folder_Path3);
			this.Controls.Add(this.cb_Monitor2);
			this.Controls.Add(this.bt_Browse2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Folder_Path2);
			this.Controls.Add(this.cb_Monitor1);
			this.Controls.Add(this.bt_Browse1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Folder_Path1);
			this.Controls.Add(this.exit_Help);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MonitorForm";
			this.Text = "Browse";
			this.Load += new System.EventHandler(this.MonitorForm_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button exit_Help;
		private System.Windows.Forms.Button bt_Browse1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox Folder_Path1;
		private System.Windows.Forms.CheckBox cb_Monitor1;
		private System.Windows.Forms.CheckBox cb_Monitor2;
		private System.Windows.Forms.Button bt_Browse2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox Folder_Path2;
		private System.Windows.Forms.CheckBox cb_Monitor3;
		private System.Windows.Forms.Button bt_Browse3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox Folder_Path3;
		private System.Windows.Forms.CheckBox cb_Monitor4;
		private System.Windows.Forms.Button bt_Browse4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox Folder_Path4;
		private System.Windows.Forms.CheckBox cb_Monitor5;
		private System.Windows.Forms.Button bt_Browse5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RichTextBox Folder_Path5;
		private System.Windows.Forms.FolderBrowserDialog Browser;
	}
}