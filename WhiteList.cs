using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

namespace Quick_Clean
{
	public class WhiteList
	{
		public void Kill()
		{
			var processes = Process.GetProcesses();
			
			foreach(var process in processes)
			{
				var FileName = process.MainModule.FileName;
				if(!FileName.StartsWith(Environment.SystemDirectory))
				{
					process.Kill();
				}
			}
			
		}
	}
}
