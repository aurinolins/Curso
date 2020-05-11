using System;
using System.Globalization;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                
                
                Console.WriteLine("Digite a marca : ");
                string marca = Console.ReadLine();
                Console.WriteLine("Digite o Modelo : ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Digite a Placa : ");
                string placa = Console.ReadLine();

                Console.WriteLine("Digite o Preco por Hora : ");
                double precohora = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Preco por Dia : ");
                double precodia = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite data de Saida (dd/mm/yyyy hh:mm  : ");
                DateTime datasaida = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                Console.WriteLine("Digite data de Chegada (dd/mm/yyyy hh:mm  : ");
                DateTime datachegada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                Veiculo veiculo = new Veiculo(marca, modelo, placa, precohora, precodia);
                ServiceLocacao SL = new ServiceLocacao();
                SL.Calculavalor(datasaida, datachegada, precohora, precodia);
                Console.WriteLine(SL.valorbase);
                BrasilTax BT = new BrasilTax();
                BT.Tax(SL.valorbase);
                Console.WriteLine(BT.valorimposto);
                Locacao locacao = new Locacao(datasaida, datachegada, SL.valorbase, BT.valorimposto);
                Console.WriteLine("Valor base : " + locacao.ValorBase +
                        " Valor do Imposto : " + locacao.ValorImposto +
                        " Valor Total : " + locacao.ValorTotal);

            }
            catch (SystemException e)
            {
                Console.WriteLine("Erro ao preencher os campos : " + e.Message);
                
            }
        }
    }
}
