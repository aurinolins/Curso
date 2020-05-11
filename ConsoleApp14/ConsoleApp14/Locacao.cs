using System;
namespace ConsoleApp14
{
    class Locacao : ServiceLocacao
    {
        public DateTime DataSaida { get; set; }
        public DateTime DataChegada { get; set; }
        public double ValorBase { get; private set; }
        public double ValorImposto { get; private set; }
        public double ValorTotal { get; private set; }

        public Locacao(DateTime dataSaida, DateTime dataChegada, double valorbase, double valorimposto)
        {
            this.DataSaida = dataSaida;
            this.DataChegada = dataChegada;
            this.ValorBase = valorbase;
            this.ValorImposto = valorimposto;
            this.ValorTotal = this.ValorBase + this.ValorImposto;
        }
             
    }
}
