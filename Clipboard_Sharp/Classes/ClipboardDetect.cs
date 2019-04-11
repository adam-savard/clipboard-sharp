using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Clipboard_Sharp.Classes
{
	public class ClipboardDetect
	{
		static System.Timers.Timer scanForClipboardChange;
		static string currentData = "";
		static bool displayCopied = false;

		public static bool DisplayCopied { get => displayCopied; set => displayCopied = value; }

		public ClipboardDetect()
		{
			Start();
		}

		public void Start()
		{
			scanForClipboardChange = new System.Timers.Timer(200);
			scanForClipboardChange.Elapsed += CheckClipboardChange;
			scanForClipboardChange.AutoReset = true;
			scanForClipboardChange.Enabled = true;
			scanForClipboardChange.Start();
		}

		public void Stop()
		{
			scanForClipboardChange.Stop();
		}

		public static void chk()
		{
			string currentClip = Clipboard.GetText();
			if (currentClip != "")
			{
				if (!currentClip.Equals(currentData))
				{
					currentData = currentClip;
					DisplayCopied = true;
					ClipboardWriter.writeToFile(currentData);
				}
			}
		}
		
		private static void CheckClipboardChange(Object source, ElapsedEventArgs e)
		{
			Thread thread = new Thread(() => chk());
			thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
			thread.Start();
			thread.Join();

			
		}

	}
}
