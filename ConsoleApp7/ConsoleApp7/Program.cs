using System;
using System.Collections.Generic;
namespace ConsoleApp7.Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();
            Console.WriteLine("Digite a Quntidade de Funcionarios : ");
            int QtdeFunc = int.Parse(Console.ReadLine());
            for (int i = 0; i < QtdeFunc ; i++)
            {
                Console.WriteLine("Terceirizado(S/n) ? :");
                char Resposta = char.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Nome : ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a Quntidade de Horas : ");
                int qtdehoras = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Valor da Hora : ");
                double valorhora = double.Parse(Console.ReadLine());
                if (Resposta == 'S')
                {
                    Console.WriteLine("Digite o Valor da Despesa : ");
                    double valordespesa = double.Parse(Console.ReadLine());
                    lista.Add(new  Terceirizado(nome, qtdehoras, valorhora,
                                                valordespesa));
                }
                else
                {
                    lista.Add(new Funcionario(nome, qtdehoras, valorhora)); 
                }
                       
            }
            Console.WriteLine("Pagamentos : ");
            foreach(Funcionario pessoa in lista)
            {
               Console.WriteLine(pessoa.Nome + " - " + pessoa.CalculaValor());
            }

        }
    }
}
