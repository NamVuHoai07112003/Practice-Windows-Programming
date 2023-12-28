using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Exercise1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter a name for the new directory:");
			string DirName = Console.ReadLine();
			// Checking if string is empty or not
			if (DirName != String.Empty)
			{
				// Creating the Directory
				Directory.CreateDirectory(DirName);
				// Checking Directory is created
				// Successfully or not
				if (Directory.Exists(DirName))
				{
					Console.WriteLine("The directory was created!");
					Console.ReadKey();
				}
			}
		}
	}
}
