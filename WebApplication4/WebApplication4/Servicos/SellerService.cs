using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Servicos.Exception;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Servicos
{
    public class SellerService
    {
        private readonly WebApplication4Context _Context;


        public SellerService(WebApplication4Context Context)
        {
            _Context = Context;
        }

        public async Task<List<Vendedor>> FindAllAsync()
        {
            return await _Context.Vendedor.ToListAsync();
        }
        public async Task InsertAsync(Vendedor vendedor)
        {
            _Context.Vendedor.Add(vendedor);
            await _Context.SaveChangesAsync();

        }
        public async Task<Vendedor> FindbyIdAsync(int id)
        {
            return await _Context.Vendedor.Include(x => x.Departamento).FirstOrDefaultAsync(obj => obj.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _Context.Vendedor.FindAsync(id);
                _Context.Vendedor.Remove(obj);
                await _Context.SaveChangesAsync();
            }
            catch(DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }
        }
        public async Task AtualizarAsync(Vendedor obj)
        {
            bool HasAny = await _Context.Vendedor.AnyAsync(x => x.Id == obj.Id);
            if (!HasAny)
            {
                throw new NotFoundException("Id Não Encontrado");

            }

            try
            {
                _Context.Vendedor.Update(obj);
                await _Context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DBConcurrencyException(e.Message);
            }

        }
    }
}

