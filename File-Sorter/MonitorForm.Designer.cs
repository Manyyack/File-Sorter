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
			this.label1 = new System.Windows.Forms.Label();
			this.exit_Help = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(221, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Still Under Development.";
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
			this.exit_Help.Click += new System.EventHandler(this.exit_Help_Click);
			// 
			// MonitorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(666, 366);
			this.Controls.Add(this.exit_Help);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MonitorForm";
			this.Text = "MonitorForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button exit_Help;
	}
}