using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models.Entidades;

namespace WebApplication4.Models.ViewModel
{
    public class SalesFormViewModel
    {
        public int VendedorId { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }
        public ICollection<IGrouping<Departamento ,  Vendas>> Vendas { get; set; }
    }
}
