using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clipboard_Sharp.Classes
{
	public class ClipboardWriter
	{
		static string folder = DateTime.Now.ToString("yyyy-MM-dd");
		static string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "ClipboardSharp", folder);

		/// <summary>
		/// Writes all text to a predefined storage format.
		/// </summary>
		/// <param name="content">Text for the file.</param>
		public static void writeToFile(string content)
		{
			string file = DateTime.Now.ToString("hh-mm-ss-ffff") + ".txt";
			folder = DateTime.Now.ToString("yyyy-MM-dd");
			
		

			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}

			File.WriteAllText(System.IO.Path.Combine(path, file), content);
			
		}

		public static void archiveData()
		{
			path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "ClipboardSharp", folder);
			FileManipulation.writeToXL(path);
		}
	}
}
