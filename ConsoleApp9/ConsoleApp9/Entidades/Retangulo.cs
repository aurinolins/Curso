using ConsoleApp9.Entidades;
using ConsoleApp9.Entidades.Enum;
using System;

namespace ConsoleApp9.Entidades
{
    class Retangulo : Figura
    {
        public double Lado { get; set; }
        public double Altura { get; set; }

        public Retangulo(double lado, double altura, Color color) :
                          base(color) 
            {
               Altura = altura;
               Lado = lado;
            }
        public override double Area()
         {
            return Lado * Altura;
         }

    }
}
