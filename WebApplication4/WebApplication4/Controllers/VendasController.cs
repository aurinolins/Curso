using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models.ViewModel;
using WebApplication4.Servicos;
using WebApplication4.Servicos.SalesService;

namespace WebApplication4.Controllers
{
    public class VendasController : Controller
    {
        private readonly SalesService _SalesService;
        private readonly SellerService _Seller;
        private readonly DepartamentoSevice _departamentoService;

        public VendasController(SalesService SalesService, SellerService Seller, DepartamentoSevice departamentoService)
        {
            _SalesService = SalesService;
            _Seller = Seller;
            _departamentoService = departamentoService;
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
        public async Task<IActionResult> BuscaAgrupada
            (DateTime? datamin, DateTime? datamax, int? departamentoId, int? vendedorId)
        {

            if (!datamin.HasValue)
            {
                datamin = new DateTime(DateTime.Now.Year, 01, 01);
            }
            if (!datamax.HasValue)
            {
                datamax = DateTime.Now;
            }
                     
            var vendedores = await _Seller.FindAllAsync();
            var departamentos = await _departamentoService.FindAllAsync();
            var vendas = await _SalesService.FindByDateGroupAsync(datamin, datamax, departamentoId, vendedorId);
            var viewmodel = new SalesFormViewModel
            { Vendas = vendas, Departamentos = departamentos, Vendedores = vendedores };
           

            ViewData["datamin"] = datamin.Value.ToString("dd/MM/yyyy");
            ViewData["datamax"] = datamin.Value.ToString("dd/MM/yyyy");
            return View(viewmodel);
        }

    }
}