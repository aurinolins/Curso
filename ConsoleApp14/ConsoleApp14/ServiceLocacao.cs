using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    class ServiceLocacao
    {
        public double valorbase;
        public double Calculavalor(DateTime datasaida, DateTime datachegada, double precohora, double precodia)
        {
            TimeSpan Duracao = datachegada.Subtract(datasaida);

            if (Duracao.TotalHours < 24)
            {
                valorbase = precohora * Math.Ceiling(Duracao.TotalHours);
            }
            else
            {
                valorbase = precodia * Math.Ceiling(Duracao.TotalDays);
            }
            return valorbase;

        }
    }
}
