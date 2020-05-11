﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models.Entidades;


namespace WebApplication4.Models.Entidades
{
    public class WebApplication4Context : DbContext
    {
        public WebApplication4Context (DbContextOptions<WebApplication4Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication4.Models.Entidades.Departamento> Departamento { get; set; }
        public DbSet<WebApplication4.Models.Entidades.Vendedor> Vendedor { get; set; }
        public DbSet<WebApplication4.Models.Entidades.Vendas> Vendas { get; set; }
    }
}
