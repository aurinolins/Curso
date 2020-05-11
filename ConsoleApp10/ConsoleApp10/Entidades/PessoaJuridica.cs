using System;
using System.Collections.Generic;
using ConsoleApp10.Entidades;

namespace ConsoleApp10.Entidades
{
    class PessoaJuridica : Contribuinte
    {
        public int QtdeFunc { get; set; }

        public PessoaJuridica(string nome, double ganho, int qtdeFunc) :
              base(nome, ganho)
        {
            QtdeFunc = qtdeFunc;
        }
        public override double Imposto()
        {
            if (QtdeFunc > 10)
                return Ganho * 0.14;
            else
                return Ganho * 0.16;
        }   
    }
}
