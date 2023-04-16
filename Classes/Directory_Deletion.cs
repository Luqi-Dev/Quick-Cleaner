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
			
			if(pathFinder.TempPath != null)
        		{
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
            
					if (lockedDirectories.Count > 0)
					{
    						string directoryMessage = "The following files were unable to delete:\n";
    						foreach (string unable in lockedDirectories)
    					{
        					directoryMessage += unable + "\n";
    					}
    				
    					System.Windows.Forms.MessageBox.Show(directoryMessage);
				}
        		}
		}
	}
}
