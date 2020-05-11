using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int QtdeHoras { get; set; }
        public Double ValorHora { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, int qtdeHoras, double valorHora)
        {
            Nome = nome;
            QtdeHoras = qtdeHoras;
            ValorHora = valorHora;
        }
        public virtual double CalculaValor()
        {
            return QtdeHoras * ValorHora;
        }
    }
}
