using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clipboard_Sharp.Classes
{
	public class FileManipulation
	{

		/// <summary>
		/// Archives all the files for storage inside an excel worksheet.
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static DataTable archiveFiles(string path)
		{
			DataTable archive = new DataTable("Clipboard Archive - " + DateTime.Now.ToString("yyyy-MM-dd"));
			archive.Columns.Add("Date Added to Archive");
			archive.Columns.Add("Text Copied");

			string[] fileArray = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);

			foreach (string f in fileArray)
			{
				string date = Path.GetDirectoryName(f);
				date = new DirectoryInfo(date).Name;

				string text = File.ReadAllText(f);

				archive.Rows.Add(date, text);
			}

			return archive;
		}

		/// <summary>
		/// Writes a datatable to an excel worksheet.
		/// </summary>
		/// <param name="path"></param>
		public static void writeToXL(string path)
		{
			using (XLWorkbook wb = new XLWorkbook()) { 
					DataTable dt = archiveFiles(path);
					wb.Worksheets.Add(dt, dt.TableName);

					wb.SaveAs(path + ".xlsx");
			}
			
		}
	}
}
