using System;
using System.Collections.Generic;
using System.IO;

namespace Quick_Clean
{
	public class DirectoryDeletion
	{
		public void DirectoryDeleter()
		{
			
			PathFinder pathFinder = new PathFinder();
			
        	List<string> lockedDirectories = new List<string>();
            
			foreach (string Directories in Directory.GetDirectories(pathFinder.TempPath))
            {   
           		try
    			{
        			Directory.Delete(Directories, true);
        		}
           		
    			catch (IOException)
    			{
        			lockedDirectories.Add(Directories);
    			}

			}
            
            string DirectoryMessage = "The following files were unable to detele:\n";
            foreach(string Unable in lockedDirectories)
            {
            	DirectoryMessage += Unable + "\n";
            }
            
            System.Windows.Forms.MessageBox.Show(DirectoryMessage);
            
		}
	}
}
