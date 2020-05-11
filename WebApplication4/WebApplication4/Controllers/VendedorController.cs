using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models.Entidades;
using WebApplication4.Models.ViewModel;
using WebApplication4.Servicos;

namespace WebApplication4.Controllers
{
    public class VendedorController : Controller
    {

        private readonly SellerService _Seller;
        private readonly DepartamentoSevice _departamentoService;

        public VendedorController(SellerService Seller, DepartamentoSevice departamentoService)
        {
            _Seller = Seller;
            _departamentoService = departamentoService;
        }

        public IActionResult Index()
        {
            var list = _Seller.FindAll();
            return View(list);
        }
        public IActionResult Create()
        {
            var departamentos = _departamentoService.FindAll();
            var viewmodel = new SellerFormViewModel { Departamentos = departamentos };
           return View(viewmodel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor vendedor)
        {
            _Seller.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }
    }
}