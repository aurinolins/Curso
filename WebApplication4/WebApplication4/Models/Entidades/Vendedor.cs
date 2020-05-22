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

        [Required(ErrorMessage = "{0} Obrigatoio")]
        [StringLength(60, MinimumLength = 03, ErrorMessage =  "{0} Invalido - Permitido de {2} até {1}")]
        public string Nome { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} Obrigatoio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} Obrigatoio")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "{0} Obrigatoio")]
        [Range(100.00, 50000.00, ErrorMessage = "{0} deve ser de {1} até {2}")]
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
