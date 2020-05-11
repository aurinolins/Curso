using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models.Entidades;

namespace WebApplication4.Servicos
{
    public class SellerService
    {
        private readonly WebApplication4Context _Context;

        public SellerService(WebApplication4Context Context)
        {
            _Context = Context;
        }

        public List<Vendedor> FindAll()
        {
            return _Context.Vendedor.ToList();
        }
        public void Insert(Vendedor vendedor)
        {
            _Context.Vendedor.Add(vendedor);
            _Context.SaveChanges();

        }
    }
}
