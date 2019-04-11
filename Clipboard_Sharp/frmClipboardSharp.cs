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

		static bool saveClips = true;

		protected override void SetVisibleCore(bool value)
		{
			base.SetVisibleCore(allowshowdisplay ? value : allowshowdisplay);
		}
		public frmClipboardSharp()
		{
			InitializeComponent();
			dt = new ClipboardDetect();
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
			}
			else
			{
				saveClips = !saveClips;
				dt = new ClipboardDetect();
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
	}
}
