using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models.Entidades
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public void InclueVeendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);

        }
        public double TotVendasDep(DateTime datainicio, DateTime datafinal)
        {
            return Vendedores.Sum(P => P.TotalVendas(datainicio, datafinal));
        }

    }
}
