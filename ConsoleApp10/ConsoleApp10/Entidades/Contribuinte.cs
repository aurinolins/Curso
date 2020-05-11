using System;
using System.Collections.Generic;
using ConsoleApp10.Entidades;

namespace ConsoleApp10.Entidades
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double Ganho { get; set; }

        public Contribuinte(string nome, double ganho)
        {
            Nome = nome;
            Ganho = ganho;
        }
        public abstract double Imposto();
       
    }
}
