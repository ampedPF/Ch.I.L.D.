/*
 * Created by SharpDevelop.
 * User: ampedPF
 * Date: 29/05/2014
 * Time: 12:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace Champion_Item_List_Downloader
{
	/// <summary>
	/// Description of Settings.
	/// </summary>
	public class Settings
	{
		private string urlPattern;
		private string pathPattern;
		
		public Settings()
		{
			urlPattern = @"http://www.lolflavor.com/champions/%c%/Recommended/%c%_%t%_scrape.json";
			pathPattern = @"Champions\%c%\Recommended\";
		}
		
		public Settings(string urlPattern, string pathPattern)
		{
			this.urlPattern = urlPattern;
			this.pathPattern = pathPattern;
		}
		
		public void loadSettings(string settingFile)
		{
			try {
				using (StreamReader r = new StreamReader(settingFile))
				{
				    string line;
				    while ((line = r.ReadLine()) != null)
				    {
				    	if (line.StartsWith("urlPattern")) {
				    		urlPattern = line.Split('=')[1].Replace(" ", "");
				    	}
				    	if (line.StartsWith("pathPattern")) {
				    		pathPattern = line.Split('=')[1].Replace(" ", "");
				    	}
				    }
				}
			} catch (Exception) {
			}
		}
		
		public string getUrlPattern()
		{
			return urlPattern;
		}
		
		public string getPathPattern()
		{
			return pathPattern;
		}
	}
}
