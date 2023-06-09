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
			
            		PathFinder pathFinder = new PathFinder();
            		pathFinder.Files_Finder();
            		pathFinder.Size_Viewer();

            		JunkSize.Text = "Temporary files\n consumes " + pathFinder.Final.ToString() + " MB\n of your storage";
            		JunkSize.TextAlignment = TextAlignment.Center;		
		}
		
	public void JunkCleaner(object sender, RoutedEventArgs e)
        {
		PathFinder pathFinder = new PathFinder();
		pathFinder.Files_Finder();
        	
        	FileDeletion fileDeletion = new FileDeletion();
        	
        	fileDeletion.FileDeleter();
        	
        	DirectoryDeletion directoryDeletion = new DirectoryDeletion();
        	
        	directoryDeletion.DirectoryDeleter();

            	pathFinder.Size_Viewer();
            	JunkSize.Text = "Temporary files\n consumes " + pathFinder.Final.ToString() + " MB\n of your storage";
            	JunkSize.TextAlignment = TextAlignment.Center;
        	}
	}
}
