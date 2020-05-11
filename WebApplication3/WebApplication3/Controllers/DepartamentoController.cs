using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;


namespace WebApplication3.Controllers
{
    public class DepartamentoController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> lista = new List<Departamento>();
            lista.Add(new Departamento(001, "Informatica"));
            lista.Add(new Departamento(002, "Financeio"));
            lista.Add(new Departamento(003, "Contabilidade"));
            lista.Add(new Departamento(004, "Logistica"));
            lista.Add(new Departamento(005, "Recursos Humanos"));

            return View(lista);
        }
    }
}