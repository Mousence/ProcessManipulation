namespace ProcessManipulation
{
	partial class ManipulationForm
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
			this.btnStart = new System.Windows.Forms.Button();
			this.listBoxRunnedAssemblies = new System.Windows.Forms.ListBox();
			this.listBoxAvalableAssemblies = new System.Windows.Forms.ListBox();
			this.lblAvalableAssembles = new System.Windows.Forms.Label();
			this.lblRunnedAssembles = new System.Windows.Forms.Label();
			this.btnCloseWindow = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(367, 36);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// listBoxRunnedAssemblies
			// 
			this.listBoxRunnedAssemblies.FormattingEnabled = true;
			this.listBoxRunnedAssemblies.Location = new System.Drawing.Point(467, 36);
			this.listBoxRunnedAssemblies.Name = "listBoxRunnedAssemblies";
			this.listBoxRunnedAssemblies.Size = new System.Drawing.Size(322, 225);
			this.listBoxRunnedAssemblies.TabIndex = 3;
			// 
			// listBoxAvalableAssemblies
			// 
			this.listBoxAvalableAssemblies.FormattingEnabled = true;
			this.listBoxAvalableAssemblies.Location = new System.Drawing.Point(12, 36);
			this.listBoxAvalableAssemblies.Name = "listBoxAvalableAssemblies";
			this.listBoxAvalableAssemblies.Size = new System.Drawing.Size(322, 225);
			this.listBoxAvalableAssemblies.TabIndex = 4;
			// 
			// lblAvalableAssembles
			// 
			this.lblAvalableAssembles.AutoSize = true;
			this.lblAvalableAssembles.Location = new System.Drawing.Point(12, 9);
			this.lblAvalableAssembles.Name = "lblAvalableAssembles";
			this.lblAvalableAssembles.Size = new System.Drawing.Size(106, 13);
			this.lblAvalableAssembles.TabIndex = 5;
			this.lblAvalableAssembles.Text = "Доступные сборки:";
			// 
			// lblRunnedAssembles
			// 
			this.lblRunnedAssembles.AutoSize = true;
			this.lblRunnedAssembles.Location = new System.Drawing.Point(464, 9);
			this.lblRunnedAssembles.Name = "lblRunnedAssembles";
			this.lblRunnedAssembles.Size = new System.Drawing.Size(114, 13);
			this.lblRunnedAssembles.TabIndex = 6;
			this.lblRunnedAssembles.Text = "Запущенные сборки:";
			// 
			// btnCloseWindow
			// 
			this.btnCloseWindow.Location = new System.Drawing.Point(367, 94);
			this.btnCloseWindow.Name = "btnCloseWindow";
			this.btnCloseWindow.Size = new System.Drawing.Size(75, 23);
			this.btnCloseWindow.TabIndex = 7;
			this.btnCloseWindow.Text = "CloseWindow";
			this.btnCloseWindow.UseVisualStyleBackColor = true;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(367, 123);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 8;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(367, 65);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 23);
			this.btnStop.TabIndex = 9;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(367, 153);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 10;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// ManipulationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnCloseWindow);
			this.Controls.Add(this.lblRunnedAssembles);
			this.Controls.Add(this.lblAvalableAssembles);
			this.Controls.Add(this.listBoxAvalableAssemblies);
			this.Controls.Add(this.listBoxRunnedAssemblies);
			this.Controls.Add(this.btnStart);
			this.Name = "ManipulationForm";
			this.Text = "Manipulator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManipulationForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.ListBox listBoxRunnedAssemblies;
		private System.Windows.Forms.ListBox listBoxAvalableAssemblies;
		private System.Windows.Forms.Label lblAvalableAssembles;
		private System.Windows.Forms.Label lblRunnedAssembles;
		private System.Windows.Forms.Button btnCloseWindow;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}

