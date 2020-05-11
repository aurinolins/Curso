using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entidades
{
    class Contrato
    {
        public int Numero { get; set; }
        public int QtdeHoras { get; set; }
        public double ValorHora { get; set; }
        DateTime DataInicial { get; set; }
        DateTime DataFinal { get; set; }

        public Contrato()
        {
        }
        public Contrato(int numero, int qtdeHoras, double valorHora,
            DateTime dataInicial, DateTime dataFinal)
        {
            Numero = numero;
            QtdeHoras = qtdeHoras;
            ValorHora = valorHora;
            DataInicial = dataInicial;
            DataFinal = dataFinal;
        }

    }
}
