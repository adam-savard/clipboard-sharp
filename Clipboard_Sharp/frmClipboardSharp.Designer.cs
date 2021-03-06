﻿namespace Clipboard_Sharp
{
	partial class frmClipboardSharp
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClipboardSharp));
			this.mnuClipSharp = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToggle = new System.Windows.Forms.ToolStripMenuItem();
			this.delOldClips = new System.Windows.Forms.ToolStripMenuItem();
			this.disableClipNotificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.archiveDataToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.icoSysTray = new System.Windows.Forms.NotifyIcon(this.components);
			this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuClipSharp.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuClipSharp
			// 
			this.mnuClipSharp.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mnuClipSharp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.advancedToolStripMenuItem,
            this.saveToggle,
            this.delOldClips,
            this.disableClipNotificationsToolStripMenuItem,
            this.archiveDataToExcelToolStripMenuItem,
            this.exitToolStripMenuItem1});
			this.mnuClipSharp.Name = "mnuClipSharp";
			this.mnuClipSharp.Size = new System.Drawing.Size(248, 172);
			// 
			// showToolStripMenuItem
			// 
			this.showToolStripMenuItem.Name = "showToolStripMenuItem";
			this.showToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
			this.showToolStripMenuItem.Text = "Open Saved Clips";
			this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
			// 
			// saveToggle
			// 
			this.saveToggle.Name = "saveToggle";
			this.saveToggle.Size = new System.Drawing.Size(247, 24);
			this.saveToggle.Text = "Stop Saving Clips";
			this.saveToggle.Click += new System.EventHandler(this.saveToggle_Click);
			// 
			// delOldClips
			// 
			this.delOldClips.Name = "delOldClips";
			this.delOldClips.Size = new System.Drawing.Size(247, 24);
			this.delOldClips.Text = "Delete Old Clips";
			this.delOldClips.Click += new System.EventHandler(this.delOldClips_Click);
			// 
			// disableClipNotificationsToolStripMenuItem
			// 
			this.disableClipNotificationsToolStripMenuItem.Name = "disableClipNotificationsToolStripMenuItem";
			this.disableClipNotificationsToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
			this.disableClipNotificationsToolStripMenuItem.Text = "Disable Clip Notifications";
			this.disableClipNotificationsToolStripMenuItem.Click += new System.EventHandler(this.disableClipNotificationsToolStripMenuItem_Click);
			// 
			// archiveDataToExcelToolStripMenuItem
			// 
			this.archiveDataToExcelToolStripMenuItem.Name = "archiveDataToExcelToolStripMenuItem";
			this.archiveDataToExcelToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
			this.archiveDataToExcelToolStripMenuItem.Text = "Archive Data to Excel";
			this.archiveDataToExcelToolStripMenuItem.Click += new System.EventHandler(this.archiveDataToExcelToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem1
			// 
			this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
			this.exitToolStripMenuItem1.Size = new System.Drawing.Size(247, 24);
			this.exitToolStripMenuItem1.Text = "Exit";
			this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
			// 
			// icoSysTray
			// 
			this.icoSysTray.ContextMenuStrip = this.mnuClipSharp;
			this.icoSysTray.Icon = ((System.Drawing.Icon)(resources.GetObject("icoSysTray.Icon")));
			this.icoSysTray.Text = "Clipboard#";
			this.icoSysTray.Visible = true;
			this.icoSysTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.icoSysTray_MouseDoubleClick);
			// 
			// advancedToolStripMenuItem
			// 
			this.advancedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem});
			this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
			this.advancedToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
			this.advancedToolStripMenuItem.Text = "Advanced";
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.searchToolStripMenuItem.Text = "Search";
			this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
			// 
			// frmClipboardSharp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmClipboardSharp";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Clipboard#";
			this.Load += new System.EventHandler(this.frmClipboardSharp_Load);
			this.mnuClipSharp.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip mnuClipSharp;
		private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToggle;
		private System.Windows.Forms.NotifyIcon icoSysTray;
		private System.Windows.Forms.ToolStripMenuItem delOldClips;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem disableClipNotificationsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archiveDataToExcelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
	}
}

