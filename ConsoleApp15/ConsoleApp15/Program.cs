using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero do Contrato : ");
            int Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Data :");
            DateTime Data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Valor : ");
            double Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de Parcelas : ");
            int QtdeParc = int.Parse(Console.ReadLine());
            //*
            Contratos Contrato = new Contratos(Numero, Data, Valor);
            //*
            Console.WriteLine(Contrato);
            double ValorBase = Valor / QtdeParc;
            double TaxadeServico = 0.02;
            double TaxadeJuros = 0.00;
            Console.WriteLine("Taxa de Servicos : " + TaxadeServico);
            Console.WriteLine("Taxa de Juros : " + TaxadeJuros);
            int QtdeMes = 0;
            for (int Indi = 1; Indi <= QtdeParc; Indi ++)
            {

                QtdeMes += 1;
                DateTime DataParc = Data.AddMonths(QtdeMes);
                TaxadeJuros += 0.01;
                double Juros = ValorBase * TaxadeJuros;
                double Despesa = (ValorBase + Juros) * TaxadeServico;
                double Total = ValorBase + Juros + Despesa;
                //*
                Parcelas Parcela = new Parcelas(Contrato, DataParc, ValorBase, Despesa, Juros, Total);
                //*
                Console.WriteLine("Parcela :");
                Console.WriteLine(Parcela.Contrato);
                Console.WriteLine(Parcela.Vencimento);
                Console.WriteLine(Parcela.Valor);
                Console.WriteLine(Parcela.Despesa);
                Console.WriteLine(Parcela.Juros);
                Console.WriteLine(Parcela.Total);

                Contrato.lista.Add(Parcela);
            }
            Console.ReadLine();


        }
    }
}
