/*
 * Created by SharpDevelop.
 * User: ampedPF
 * Date: 25/05/2014
 * Time: 17:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.ComponentModel;

namespace Champion_Item_List_Downloader
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		const string listFile = "Lists.txt";
		List<string> championsList = new List<string>();
		List<string> rolesList = new List<string>();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			loadList(listFile);
		}
		
		public void loadList(string file){
			try {
				using (StreamReader r = new StreamReader(file))
				{
				    string line;
				    bool isChamp = false;
				    while ((line = r.ReadLine()) != null)
				    {
				    	if (line == @"[Champions]") {
				    		isChamp = true;
				    	}
				    	
				    	if(line != @"[Champions]" && line != @"[Types]" && line != "")
				    	{
					    	if(isChamp == true){
								championsList.Add(line);
					    	} else {
					    		rolesList.Add(line);
					    	}
				    	}
				    }
				}
			} catch (Exception) {
			}
		}
		
		public void loadStringList(string file, List<string> list){
			try {
				using (StreamReader r = new StreamReader(file))
				{
				    string line;
				    while ((line = r.ReadLine()) != null)
				    {
						list.Add(line);
				    }
				}
			} catch (Exception) {
			}
		}
		
		void Btn_DownloadClick(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			
			progressBar.Maximum = championsList.Count * rolesList.Count;
			int count = 0;
			progressBar.Value = 0;
			
			string fileName = "";
	    	string url = "";
	    	string path = "";
			
			foreach (string c in championsList)
			{
				foreach (string r in rolesList)
				{
					try {
						fileName = c + @"_" + r + @"_scrape.json";
				    	url = @"http://www.lolflavor.com/champions/" + c + @"/Recommended/" + fileName;
				    	path = @"Champions\" + c + @"\Recommended\";
    					Directory.CreateDirectory(path);
    					webClient.DownloadFile(new Uri(url), path + fileName);
    					count++;
    					progressBar.Value = count;
				    	
					} catch (Exception) {
					}
				}
			}
			
			progressBar.Value = progressBar.Maximum;
			
			MessageBox.Show("Download completed!\n" + count.ToString() + " item lists successfully downloaded.");
		}
		
		void Ll_LolFlavorLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(@"http://www.lolflavor.com/");
		}
	}
}
