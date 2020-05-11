using System;
using ConsoleApp9.Entidades.Enum;


namespace ConsoleApp9.Entidades
{
    class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo(double raio, Color color) : base (color)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
