using System;
using System.IO;
using System.Windows;

namespace Quick_Clean
{
	public class Temporary_Files_Finder : Window
	{
		public int Final;
		public long Size;
		public string TempPath;
		public DirectoryInfo TempSize;
		
		public void Files_Finder()
		{
			TempPath = Path.GetTempPath();
			TempSize = new DirectoryInfo(TempPath);
		}
		
		public void Size_Viewer()
		{
			foreach(FileInfo FI in TempSize.EnumerateFiles("*", SearchOption.AllDirectories))
			{
			Size += FI.Length;
			}
			
			double ExactSize = (double)Size / (1024*1024);
			
			Final = (int) ExactSize;
		}
	}
}
