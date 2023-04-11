using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Quick_Clean
{
	public partial class Main : Window
	{
		public Main()
		{
			InitializeComponent();
			
			Temporary_Files_Finder FileFinder = new Temporary_Files_Finder();
			
			FileFinder.Files_Finder();
			
			FileFinder.Size_Viewer(); 
									
			JunkSize.Text = "Temporary files\n consumes " + FileFinder.Final.ToString() + " MB\n of your storage";
			JunkSize.TextAlignment = TextAlignment.Center;		
		}
		
		public void JunkCleaner(object sender, RoutedEventArgs e)
		{
			WhiteList whitelist = new WhiteList();
			
			whitelist.Kill();
			
			Temporary_Files_Finder FileFinder = new Temporary_Files_Finder();
			
			FileFinder.Files_Finder();
			
			foreach(string Files in Directory.GetFiles(FileFinder.TempPath))
			{
				File.Delete(Files);
			}
			
			JunkSize.Text = "Temporary files\n consumes " + FileFinder.Final.ToString() + " MB\n of your storage";
			JunkSize.TextAlignment = TextAlignment.Center;	
		}
	}
}
