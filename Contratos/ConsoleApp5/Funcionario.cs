using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entidades
{
    class Funcionario
    {
        public int Matricula { get; set; }
        public String Nome { get; set; }
        public Departamento Depto { get; set; }
        List<Contrato> Lista = new List<Contrato>();
        public Funcionario
            (int matricula, string nome, Departamento depto)
        {
            Matricula = matricula;
            Nome = nome;
            Depto = depto;
        }
        public void ObterGanhos(List<Contrato> lista)
        {
            double total = 0;
            foreach (Contrato objeto in lista)
            {
                total += objeto.QtdeHoras * objeto.ValorHora;
            }
        }
        }
    }
