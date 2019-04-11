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
	/// <summary>
	/// Detects any clipboard changes every 200ms
	/// </summary>
	public class ClipboardDetect
	{
		/// <summary>
		/// That checks for changes every 200ms
		/// </summary>
		static System.Timers.Timer scanForClipboardChange;
		/// <summary>
		/// Current data, initialized to nothing; saves first clip automatically
		/// </summary>
		static string currentData = "";
		
		/// <summary>
		/// Stores the notification icon for displayeing messages to the user.
		/// </summary>
		static NotifyIcon icon;

		/// <summary>
		/// Checks whether to display messages about saving text files or not. Stored in default settings.
		/// </summary>
		public static bool displayCopied = Convert.ToBoolean(Properties.Settings.Default["displayClipSaved"]);

		/// <summary>
		/// Getter and setter using property.
		/// </summary>
		public static bool DisplayCopied { get => displayCopied; set => displayCopied = value; }

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="i">The notification icon of the program.</param>
		public ClipboardDetect(NotifyIcon i)
		{
			Start();
			icon = i;
		}

		/// <summary>
		/// Displays a message to the user through the notification bar.
		/// </summary>
		/// <param name="message">The message you want to display.</param>
		public void displayMessage(string message)
		{
			icon.BalloonTipText = message;
			icon.ShowBalloonTip(2000);
		}

		public bool getDisplay()
		{
			return DisplayCopied;
		}

		public void resetClipStatus()
		{
			displayCopied = Convert.ToBoolean(Properties.Settings.Default["displayClipSaved"]);
		}

		/// <summary>
		/// Starts the timer.
		/// </summary>
		public void Start()
		{
			scanForClipboardChange = new System.Timers.Timer(200);
			scanForClipboardChange.Elapsed += CheckClipboardChange;
			scanForClipboardChange.AutoReset = true;
			scanForClipboardChange.Enabled = true;
			scanForClipboardChange.Start();
		}

		/// <summary>
		/// Stops the timer.
		/// </summary>
		public void Stop()
		{
			scanForClipboardChange.Stop();
		}

		/// <summary>
		/// Checking method that's used for the lambda function.
		/// </summary>
		public static void chk()
		{
			string currentClip = Clipboard.GetText();
			if (currentClip != "")
			{
				if (!currentClip.Equals(currentData))
				{
					currentData = currentClip;
					
					ClipboardWriter.writeToFile(currentData);

					if (displayCopied)
					{
						icon.BalloonTipText = "Clip Saved!";
						icon.BalloonTipIcon = ToolTipIcon.Info;
						icon.ShowBalloonTip(2000);
					}
				}
			}
		}
		
		/// <summary>
		/// Creates a new thread to check for a clipboard change.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		private static void CheckClipboardChange(Object source, ElapsedEventArgs e)
		{
			Thread thread = new Thread(() => chk());
			thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
			thread.Start();
			thread.Join();

			
		}

	}
}
