using System;
using System.Text;
using System.Collections.Generic;
using ConsoleApp3.Entidades;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contrato> lista = new List<Contrato>();
            Console.WriteLine("Digite o Nome do Departamento :");
            string depto = Console.ReadLine();
            Departamento Departamento = new Departamento(depto);
            Console.WriteLine("Campo Nome - Departamento : "
                + Departamento.Nome);
            Console.ReadLine();
            Console.WriteLine("Digite  a Quantidade de Funcionarios : ");
            int qtdeFunc = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdeFunc; i++)
            {
                Console.WriteLine("Digite a Matricula : ");
                int matricula = 0;
                matricula = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Nome : ");
                string nome = Console.ReadLine();
                Funcionario Pessoa = new Funcionario(matricula, nome, Departamento);
                Console.WriteLine("Digite a Quantidade de Contratos : ");
                int qtdecont = int.Parse(Console.ReadLine());

                for (int j = 0; j < qtdecont; j++)
                {
                    Console.WriteLine("Digite o Contrato : ");
                    int contrato = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a Qtde. Horas : ");
                    int qtdehoras = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor da Hora : ");
                    double valorhora = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a Data Inicial : ");
                    DateTime datainicial = DateTime.Now;
                    Console.WriteLine("Digite a Data Final : ");
                    DateTime datafinal = DateTime.Now;
                    Contrato documento = new Contrato(contrato, qtdehoras,
                             valorhora, datainicial, datafinal);
                    Pessoa.AdicionarContrato(documento);

                    Console.WriteLine("campo Documento : " +
                                    documento.Numero);
                                      
                    Console.ReadLine();
                  

                }
             double total = 0;
             Pessoa.ObterGanhos(total);
             Console.WriteLine("Total  : " + total);
             Console.WriteLine("Campo Pessoa Matricula : " +
             Pessoa.Matricula + "Campo Pessoa Nome : " + Pessoa.Nome);
             


                
            }
        }
    }
}
