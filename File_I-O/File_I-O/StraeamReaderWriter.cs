using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace File_I_O
{
    public class StreamReaderWriter
    {
        public void WriteUsingStreamWriter()
        {
            string path = @"C:\Users\gunas\OneDrive\Documents\Git Problems\File_I-O\File_I-O\File_I-O\Files.txt\FirstExample.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello World - .NET is Awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.WriteLine();
        }
        public void ReadFromStreamReader()
        {
            string path = @"C:\Users\gunas\OneDrive\Documents\Git Problems\File_I-O\File_I-O\File_I-O\Files.txt\FirstExample.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine();
        }
    }
}
