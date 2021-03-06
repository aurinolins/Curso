﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Servicos.SalesService
{
    public class SalesService
    {
        private readonly WebApplication4Context _Context;


        public SalesService(WebApplication4Context Context)
        {
            _Context = Context;
        }
        public async Task<List<Vendas>> FindByDateAsync(DateTime? datamin, DateTime? datamax)
        {
            var result = from obj in _Context.Vendas select obj;

            if (datamin.HasValue)
            {
                result = result.Where(x => x.Data >= datamin.Value);
            }
            if (datamax.HasValue)
            {
                result = result.Where(x => x.Data <= datamax.Value);
            }
            return await result.
                Include(x => x.Vendedor).
                Include(x => x.Vendedor.Departamento).
                OrderByDescending(x => x.Data).
                ToListAsync();
               
        }
        public async Task<List<IGrouping<Departamento , Vendas>>> FindByDateGroupAsync
            (DateTime? datamin, DateTime? datamax,int? departamentoId, int? vendedorId)
        {
            var result = from obj in _Context.Vendas select obj;

            if (datamin.HasValue)
            {
                result = result.Where(x => x.Data >= datamin.Value);
            }
            if (datamax.HasValue)
            {
                result = result.Where(x => x.Data <= datamax.Value);
            }
            
            if (vendedorId.HasValue)
            {
                result = result.Where(x => x.VendedorId == vendedorId);
            }
            
            if (departamentoId.HasValue)
            {
                result = result.Where(x => x.Vendedor.DepartamentoId == departamentoId);
            }
       
            return await result
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Data)
                .GroupBy(x => x.Vendedor.Departamento)
                .ToListAsync();

        }
    }
}

