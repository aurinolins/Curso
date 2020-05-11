using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
    }
}
