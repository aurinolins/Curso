using System;
using System.Collections.Generic;
namespace ConsoleApp3.Entidades
{
    class Funcionario
    {
        public int Matricula { get; set; }
        public String Nome { get; set; }
        public Departamento Depto { get; set; }
        List<Contrato> lista = new List<Contrato>();
        public Funcionario
            (int matricula, string nome, Departamento depto)
        {
            Matricula = matricula;
            Nome = nome;
            Depto = depto;
        }
        
         public double ObterGanhos(double total)
        {
            
            foreach (Contrato objeto in lista)
            {
                total += objeto.QtdeHoras * objeto.ValorHora;
                Console.WriteLine("Numero do Contrato : " + objeto.Numero 
                    + "Qtde Horas : " + objeto.QtdeHoras + 
                    "Valor da Hora : " + objeto.ValorHora);
                Console.ReadLine();
            }
            Console.WriteLine("valor Total dos Ganhos : " + total);
            Console.ReadLine();
            return total;
        }
        public void  AdicionarContrato(Contrato contrato)
        {
            lista.Add(contrato);
        }
        public void ExcluirContrato(Contrato contrato)
        {
            lista.Remove(contrato);
        }
    }
}
