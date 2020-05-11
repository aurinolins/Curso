using System;
using System.Collections.Generic;
using WebApplication4.Models.Entidades;
namespace WebApplication4.Models.ViewModel
{
    public class SellerFormViewModel
    {
        public Vendedor Vendedor{get ; set; }
        public ICollection<Departamento> Departamentos { get; set; }
    }
}
