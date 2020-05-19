using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;


namespace WebApplication4.Models.Entidades
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Nascimento { get; set; }

        [Display(Name = "Salario Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
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
