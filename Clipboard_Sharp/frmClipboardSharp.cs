using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clipboard_Sharp.Classes;

namespace Clipboard_Sharp
{
	public partial class frmClipboardSharp : Form
	{
		private bool allowshowdisplay = false;
		ClipboardDetect dt;
		public static bool saveClips = true;
		


		protected override void SetVisibleCore(bool value)
		{
			base.SetVisibleCore(allowshowdisplay ? value : allowshowdisplay);
		}
		public frmClipboardSharp()
		{
			InitializeComponent();
			dt = new ClipboardDetect(icoSysTray);

			if (dt.getDisplay())
			{
				mnuClipSharp.Items[3].Text = "Disable Clip Notifications";
			}
			else
			{
				mnuClipSharp.Items[3].Text = "Enable Clip Notifications";
			}
		}

		

		private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		

		private void saveToggle_Click(object sender, EventArgs e)
		{
			if (saveClips)
			{
				saveClips = !saveClips;
				dt.Stop();
				mnuClipSharp.Items[1].Text = "Start Saving Clips";
				dt.displayMessage("Stopped saving clips.");
			}
			else
			{
				dt.displayMessage("Started saving clips!");
				saveClips = !saveClips;
				mnuClipSharp.Items[1].Text = "Stop Saving Clips";
				dt = new ClipboardDetect(icoSysTray);
			}
		}

		private void delOldClips_Click(object sender, EventArgs e)
		{
			System.IO.DirectoryInfo di = new DirectoryInfo(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "ClipboardSharp"));

			foreach (FileInfo file in di.GetFiles())
			{
				file.Delete();
			}
			foreach (DirectoryInfo dir in di.GetDirectories())
			{
				dir.Delete(true);
			}
		}

		private void icoSysTray_MouseDoubleClick(object sender, MouseEventArgs e)
		{

		}

		private void disableClipNotificationsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dt.getDisplay())
			{
				Properties.Settings.Default["displayClipSaved"] = false;
				dt.resetClipStatus();
				mnuClipSharp.Items[3].Text = "Enable Clip Notifications";
			}
			else
			{
				Properties.Settings.Default["displayClipSaved"] = true;
				dt.resetClipStatus();
				mnuClipSharp.Items[3].Text = "Disable Clip Notifications";
			}

			
		}
	}
}
