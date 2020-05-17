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

        public List<Vendedor> FindAll()
        {
            return _Context.Vendedor.ToList();
        }
        public void Insert(Vendedor vendedor)
        {
            _Context.Vendedor.Add(vendedor);
            _Context.SaveChanges();

        }
        public Vendedor FindbyId(int id)
        {
            return _Context.Vendedor.Include(x => x.Departamento).FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _Context.Vendedor.Find(id);
            _Context.Vendedor.Remove(obj);
            _Context.SaveChanges();
        }
        public void  Atualizar(Vendedor obj)
        {
            if (!_Context.Vendedor.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id Não Encontrado");

            }
           
            try
            {
                _Context.Vendedor.Update(obj);
                 _Context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DBConcurrencyException(e.Message);
            }
            
        }
    }
}

