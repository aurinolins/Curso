using System;
using System.IO;
using System.Collections.Generic;
using ConsoleApp17;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empregado> lista = new List<Empregado>();
           
            var origem = @"c:\Curso\Teste20.txt";
            try
            {
                StreamReader sr = File.OpenText(origem);
                string line;
                while (!sr.EndOfStream)

                {
                    line = sr.ReadLine();
                    if (line != " ")
                    {
                        Console.WriteLine("Vou chamar a instanciação :");
                        Console.ReadLine();
                        lista.Add(new Empregado(line));
                    }

                }
                Console.WriteLine("Vou chamar o primeiro foreach");
                Console.ReadLine();
                foreach (Empregado emp in lista)
                {

                    Console.WriteLine(emp.Nome + " " + emp.Salario);
                }
                lista.Sort();
                Console.WriteLine("Vou chamar o segundo foreach");
                Console.ReadLine();
                foreach (Empregado emp in lista)
                {

                    Console.WriteLine(emp.Nome + " " + emp.Salario);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("(Exception Error " + e.Message);
            }
        }
    }
}