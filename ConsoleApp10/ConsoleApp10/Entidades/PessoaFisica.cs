using System;
using System.Collections.Generic;
using ConsoleApp10.Entidades;

namespace ConsoleApp10.Entidades
{
    class PessoaFisica : Contribuinte
    {
        public double Gastos { get; set; }

        public PessoaFisica(string nome , double ganhos , double gastos) :
                base(nome, ganhos)
        {
            Gastos = gastos;
        }

        public override double Imposto()
        {
            if (Ganho < 20000)
                return Ganho * 0.15 - (Gastos * 0.5);
            else
                return Ganho * 0.25 - (Gastos * 0.5);
        }
    }
}
