namespace ConsoleApp14
{
    class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public double PrecoHora { get; set; }
        public double PrecoDia { get; set; }

        public Veiculo(string marca, string modelo, string placa, double precoHora, double precoDia)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            PrecoHora = precoHora;
            PrecoDia = precoDia;
        }
    }
}
