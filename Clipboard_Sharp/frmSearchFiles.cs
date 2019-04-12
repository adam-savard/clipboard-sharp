using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipboard_Sharp
{
	public partial class frmSearchFiles : Form
	{
		Dictionary<string, string> files = new Dictionary<string, string>();
		public frmSearchFiles()
		{
			InitializeComponent();
			this.Visible = true;
		}
		static string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "ClipboardSharp");

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			files.Clear();

			string[] fileArray = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
			

			foreach (string f in fileArray)
			{
				string pathValue = Path.GetDirectoryName(f);
				

				string text = File.ReadAllText(f);

				FileInfo info = new FileInfo(f);

				if (text.Contains(txtSearch.Text))
				{
					files.Add(info.FullName, info.Name);
				}

				
			}

			if(files.Count < 1)
			{
				files.Add("null", "Nothing!");
			}

			lstFiles.DataSource = new BindingSource(files, null);
			lstFiles.DisplayMember = "Value";
			lstFiles.ValueMember = "Key";
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start(lstFiles.SelectedValue.ToString());
			}
			catch(System.ComponentModel.Win32Exception ex)
			{
				MessageBox.Show("There's are no files with that search term!");
			}
			
		}
	}
}
