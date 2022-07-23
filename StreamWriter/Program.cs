using System;
using System.IO;

namespace StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\mxthe\source\repos\StreamWriter\file.txt";
            string targetPath = @"C:\Users\mxthe\source\repos\StreamWriter\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (var sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                        Console.WriteLine(line);
                    }
                }

            } catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
