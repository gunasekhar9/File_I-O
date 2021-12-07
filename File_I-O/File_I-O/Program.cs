using File_I_O;
using System;
using System.IO;

namespace File_I_O
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper = new Operation();
            oper.FileExists();
            oper.ReadAllLines();
            oper.ReadAllText();
            oper.copypath();
            //oper.Deletepath();
            StreamReaderWriter stream = new StreamReaderWriter();
            stream.ReadFromStreamReader();
            stream.WriteUsingStreamWriter();
        }
    }
}