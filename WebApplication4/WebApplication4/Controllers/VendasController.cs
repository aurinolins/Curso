using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Servicos.SalesService;

namespace WebApplication4.Controllers
{
    public class VendasController : Controller
    {
        private readonly SalesService _SalesService;

        public VendasController(SalesService SalesService)
        {
            _SalesService = SalesService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> BuscaSimples(DateTime? datamin, DateTime? datamax)
        {

            if (!datamin.HasValue)
            {
                datamin = new DateTime(DateTime.Now.Year, 01, 01);
            }
            if (!datamax.HasValue)
            {
                datamax = DateTime.Now;
            }
                        
            var result = await _SalesService.FindByDateAsync(datamin, datamax);

            ViewData["datamin"] = datamin.Value.ToString("dd/MM/yyyy");
            ViewData["datamax"] = datamin.Value.ToString("dd/MM/yyyy");
            return View(result);
        }
        public IActionResult BuscaAgrupada()
        {
            return View();
        }


    }
}