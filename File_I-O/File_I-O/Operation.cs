using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace File_I_O
{
    class Operation
    {
            public void FileExists()
            {
                string path = @"C:\Users\gunas\OneDrive\Documents\Git Problems\File_I-O\File_I-O\File_I-O\Files.txt\FirstExample.txt";
                if (File.Exists(path))
                {
                    Console.WriteLine("File Exists");
                }
                Console.WriteLine();
            }
            public void ReadAllLines()
            {
                string path = @"C:\Users\gunas\OneDrive\Documents\Git Problems\File_I-O\File_I-O\File_I-O\Files.txt\FirstExample.txt";
                string[] lines;
                lines = File.ReadAllLines(path);
                Console.WriteLine(lines[0]);
                Console.WriteLine(lines[1]);
                Console.WriteLine();
            }
            public void ReadAllText()
            {
                string path = @"C:\Users\gunas\OneDrive\Documents\Git Problems\File_I-O\File_I-O\File_I-O\Files.txt\FirstExample.txt";
                string lines;
                lines = File.ReadAllText(path);
                Console.WriteLine(lines);
                Console.WriteLine();
            }
            public void copypath()
            {
                string path = @"C:\Users\gunas\OneDrive\Documents\Git Problems\File_I-O\File_I-O\File_I-O\Files.txt\FirstExample.txt";
                string copypath = @"C:\Users\gunas\OneDrive\Documents\Git Problems\File_I-O\File_I-O\File_I-O\Files.txt\SecondExample.txt";
                File.Copy(path, copypath);
                Console.WriteLine();
            }
                public void Deletepath()
            {
                string path = @"C:\Users\gunas\OneDrive\Documents\Git Problems\File_I-O\File_I-O\File_I-O\Files.txt\FirstExample.txt";
                File.Delete(path);
                Console.WriteLine();
            }
    }
}