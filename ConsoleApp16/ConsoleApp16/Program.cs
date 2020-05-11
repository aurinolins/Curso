using System;
using System.IO;
using System.Collections.Generic;
namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            var origem = @"c:\Curso\Teste20.txt";
            try
            {
                StreamReader sr = File.OpenText(origem);
                string line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();

                    lista.Add(line);
                }
                foreach (string str in lista)
                {

                    Console.WriteLine(str);
                }
                lista.Sort();
                    foreach (string str in lista)
                {

                    Console.WriteLine(str);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro : " + e.Message);
            }
        }
    }
}
