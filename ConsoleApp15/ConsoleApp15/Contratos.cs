using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ConsoleApp15
{
    class Contratos
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Parcelas> lista = new List<Parcelas>();

        public Contratos()
        {
        }

        public Contratos(int numero, DateTime data, double valor)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valor;
        }
    }
    
}
