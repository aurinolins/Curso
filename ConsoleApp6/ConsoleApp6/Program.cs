using System;
using System.IO;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"c:\curso\file1,txt";
                FileStream Fs = new FileStream(path, FileMode.Create);

                Console.WriteLine("Hello World!");
            }
            catch
                

        }
    }
}
