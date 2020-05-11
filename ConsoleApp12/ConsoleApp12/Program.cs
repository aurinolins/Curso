using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string origem = @"c:\curso\arquivo05.txt";
            string destino = @"c:\curso\arquivo10.txt";
            if (!File.Exists(destino))
            {
                File.CreateText(destino);
            }
           

            StreamReader sr = File.OpenText(origem);

            StreamWriter sw = new StreamWriter(destino);
          


            while (! sr.EndOfStream)
            {
                string line = sr.ReadLine();
                sw.WriteLine(line);
                Console.WriteLine(line);
            }
            Console.WriteLine("Fechar Arquivos : ");
            var v1 = Console.ReadLine();
            sr.Close();
            sw.Close();
           
            
        }
    }
}
