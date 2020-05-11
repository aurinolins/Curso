using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp19
{
    class Program
    {
        public static IEnumerable<string> lista2 { get; private set; }
        public static IEnumerable<string> lista3 { get; private set; }
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            lista.Add("marcelo junior");
            lista.Add("aurino junior" );
            lista.Add("tiana" );
            lista.Add("sebastiana andrade bezerra" );
            lista.Add("daniel bezerra lins" );
            lista.Add("ana silva" );
            lista.Add("ana" );
            lista.Add("nelicio de queiroz lins");
            lista.Add( "nelicio" );
            lista.Add( "jorge" );
            lista.Add( "jorge queiroz lins" );

            foreach (string nome in lista)
            {
                Console.WriteLine("Nome : " + nome);

            }

            Console.WriteLine();

            lista2 = lista.Where(nome => nome.Length > 10).Select(nome => nome.ToUpper());

            foreach (string nome in lista2)
            {
                Console.WriteLine("Nome : " + nome);

            }

            Console.WriteLine();

            lista3 = lista2.OrderBy(nome => nome);

            foreach (string nome in lista3)
            {
                Console.WriteLine("Nome : " + nome);
                
            }
        }
    }
}
