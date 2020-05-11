using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    class BrasilTax : TaxService
    {
        public double valorimposto;
        public double Tax(double valorbase)
        {
            
            if (valorbase > 1000.00)
            {
                valorimposto = valorbase * 0.20;
            }
            else
            {
                valorimposto = valorbase * 0.10;
            }

            return valorimposto;

        }
    }
}
