using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Zipping
    {
		public static void ZipFolder(string sourcePath, string destinationPath)
		{
			try
			{
				destinationPath += ".zip";
				ZipFile.CreateFromDirectory(sourcePath, destinationPath);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				throw;
			}

		}

	}
}
