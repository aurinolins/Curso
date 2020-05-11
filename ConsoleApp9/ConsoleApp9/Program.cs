using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using ConsoleApp9.Entidades;
using ConsoleApp9.Entidades.Enum;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();

            Console.WriteLine("Digite a Quantidade de Figuras :");
            double qtde = 0;
            qtde = double.Parse(Console.ReadLine());
            for (int i = 0; i < qtde; i++)
            {
                Console.WriteLine("Preto,Branco,Azul : ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                Console.WriteLine("Circulo ou Retangulo c ou r :");
                char tipo = char.Parse(Console.ReadLine());
                if (tipo == 'c')
                {
                    Console.WriteLine("Digite o Raio : ");
                    double raio = double.Parse(Console.ReadLine());
                    lista.Add(new Circulo(raio, color));
                }
                else
                {
                    Console.WriteLine("Digite o Lado : ");
                    double lado = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a Altura : ");
                    double altura = double.Parse(Console.ReadLine());
                    lista.Add(new Retangulo(lado, altura, color));
                }
            }
            Console.WriteLine("Areas das Figuras : ");
            foreach (Figura figura in lista)
            {
                Console.WriteLine(figura.Area());
            }

        }
    }
}
