using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Departamento>> FindAllAsync()
        {
            return await _Context.Departamento.OrderBy(x => x.Nome).ToListAsync();
        }
    }
}
