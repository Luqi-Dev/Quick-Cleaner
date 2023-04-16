using System;
using System.Collections.Generic;
using System.IO;

namespace Quick_Clean
{
	public class FileDeletion
	{
		public void FileDeleter()
		{
			
			List<string> lockedFiles = new List<string>();
			PathFinder pathFinder = new PathFinder();
			pathFinder.Files_Finder();
			
            foreach (string Files in Directory.GetFiles(pathFinder.TempPath))
            {   
           		try
    			{
        			using (FileStream stream = File.Open(Files, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
        			{
        				File.Delete(Files);
        			}
    			}
           		
    			catch (IOException)
    			{
        			lockedFiles.Add(Files);
    			}

            }

            string FileMessage = "The following files were unable to detele:\n";
            foreach(string Unable in lockedFiles)
            {
            	FileMessage += Unable + "\n";
            }   

			System.Windows.Forms.MessageBox.Show(FileMessage);
			
		}
	}
}
