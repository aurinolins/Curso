using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    class Parcelas
    {
        public Contratos Contrato { get; set; }
        public DateTime Vencimento { get; private set; }
        public double Valor { get; private set; }
        public double Despesa { get; private set; }
        public double Juros { get; private set; }
        public double Total { get; private set; }

        public Parcelas(Contratos contrato, DateTime vencimento, double valor, double despesa, double juros, double total)
        {
            Contrato = contrato;
            Vencimento = vencimento;
            Valor = valor;
            Despesa = despesa;
            Juros = juros;
            Total = total;
        }
    }
}
