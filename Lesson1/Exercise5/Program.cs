using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Exercise5
{
	class Program
	{
		static void Main(string[] args)
		{
			// Takinga a new input stream i.e.
			// geeksforgeeks.txt and opens it
			StreamReader sr = new StreamReader("C:\\Users\\pc\\Downloads\\C#Form/tmp.txt");
			Console.WriteLine("Content of the File");
			// This is use to specify from where
			// to start reading input stream
			sr.BaseStream.Seek(0, SeekOrigin.Begin);
			// To read line from input stream
			string str = sr.ReadLine();
			// To read the whole file line by line
			while (str != null)
			{
				Console.WriteLine(str);
				str = sr.ReadLine();
			}
			Console.ReadLine();
			// to close the stream
			sr.Close();
		}
	}
}
