using System;
using System.Collections.Generic;
using ConsoleApp10.Entidades;
using System.Linq;
namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> lista = new List<Contribuinte>();
            Console.WriteLine("Quantidade de Contribuintes : ");
            int Qtde = int.Parse(Console.ReadLine());

            for (int i = 0; i < Qtde; i++)
            {
                lista.Where(p => p.Ganho > 1000).Select(p => p.Ganho += p.Ganho * 0.10);
                Console.WriteLine("Nome : ");
                string nome = Console.ReadLine();
                Console.WriteLine("Ganho Anual : ");
                double ganho = double.Parse(Console.ReadLine());
                Console.WriteLine("Fisica ou Juridica - f ou j :");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'f')
                {
                    Console.WriteLine("Despesas com Saude :");
                    double gastos = double.Parse(Console.ReadLine());
                    lista.Add(new PessoaFisica(nome, ganho, gastos));
                }
                else
                {
                    Console.WriteLine("Quantidade de Funcioanarios :");
                    int qtdefunc = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaFisica(nome, ganho, qtdefunc));
                }
            }
            Console.WriteLine("Impostos a Pagar : ");
            double total = 0;
            foreach(Contribuinte pessoa in lista)
            {
                Console.WriteLine(pessoa.Nome + ": $" + pessoa.Imposto());
                total += pessoa.Imposto();
            }
            Console.WriteLine("Total de Impostos : " + total);
        }
    }
}
