using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models.Entidades
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<Vendas> Vendas { get; set; } = new List<Vendas>();

        public Vendedor()
        {
        }
        public Vendedor(int id, string none, string email, DateTime nascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = none;
            Email = email;
            Nascimento = nascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }
        public void InclueVendas()
        {
        }
        public void RemoveVendas()
        {
        }
        public double TotalVendas(DateTime dataincio , DateTime datafinal)
        {
            return Vendas.Where(P => P.Data >= dataincio && P.Data <= datafinal).Select(P => P.Valor).Sum();
        }
    }
}
