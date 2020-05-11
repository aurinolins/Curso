using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    class Precos
    {
        public double PrecoHora { get; set; }
        public double PrecoDia  { get; set; }

        public Precos(double precoHora, double precoDia)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
        }
    }
}
