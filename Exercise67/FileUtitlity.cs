using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exercise67
{
    class FileUtility
    {
        public static void CreateFile(string fileName)
        {
            //string filePath = @"C:\Users\mcevoy21\source\repos\GrandCircus\Exercises\Exercise67\List of Numbers";
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }
        }
        public static void WriteToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("7");
                writer.WriteLine("12");
                writer.WriteLine("13");
                writer.WriteLine("15");
                writer.WriteLine("12");
                writer.WriteLine("11");
            }
        }
        public static void ReadFromfile(string filename)
        {
            using(StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
        }
    }
}
