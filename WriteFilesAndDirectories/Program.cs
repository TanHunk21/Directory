using System;
using System.IO;

namespace WriteFilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteFilePath();

        }
        public static void WriteFilePath()
        {
            Console.WriteLine("Tere Hommmikust");

            string filesPath = @"C:\Users\opilane\Samples\files.txt";
            string Directories = @"C:\Users\opilane\Samples";

            string[] files = Directory.GetFiles(Directories, "*.*", SearchOption.AllDirectories);

            //save to file
            File.WriteAllLines(filesPath, files);



        }
    }
}
