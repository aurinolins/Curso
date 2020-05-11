using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.Entidades
{
    class Terceirizado : Funcionario
    {
        public Double Despesa { get; set; }

        public Terceirizado(string nome, int qtdeHoras, 
            double valorHoras, double despesa) 
            : base(nome, qtdeHoras, valorHoras)
        {
           Despesa = despesa;
        }
        public override double CalculaValor()
        {
            return base.CalculaValor() + Despesa * 1.1;
        }

    }
    
}
