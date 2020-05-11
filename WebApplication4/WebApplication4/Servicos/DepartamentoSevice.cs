using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models.Entidades;

namespace WebApplication4.Servicos
{
    public class DepartamentoSevice
    {
        private readonly WebApplication4Context _Context;

        public DepartamentoSevice(WebApplication4Context Context)
        {
            _Context = Context;
        }

        public List<Departamento> FindAll()
        {
            return _Context.Departamento.OrderBy(x => x.Nome).ToList();
        }
    }
}
