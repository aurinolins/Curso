using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models.Entidades
{
    public class Vendas
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public Status Status { get; set; }
        public Vendedor Vendedor { get; set; }
        public int   VendedorId { get; set; }

        public Vendas()
        {
        }

        public Vendas(int id, DateTime data, double valor, Status status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Valor = valor;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
