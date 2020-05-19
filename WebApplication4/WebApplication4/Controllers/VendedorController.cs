using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models.Entidades;
using WebApplication4.Models.ViewModel;
using WebApplication4.Servicos;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Servicos.Exception;
using WebApplication4.Models;
using System.Diagnostics;

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
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Nulo" });
            }
            var obj = _Seller.FindbyId(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Objeto Nulo" });
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _Seller.Remove(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Nulo" });
            }
            var obj = _Seller.FindbyId(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Não Encontrado" });
            }
            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Nulo" });
            }
            var obj = _Seller.FindbyId(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Nulo" });
            }
            List<Departamento> departamentos = _departamentoService.FindAll();
            SellerFormViewModel viewmodel = new SellerFormViewModel { Vendedor = obj, Departamentos = departamentos };
            return View(viewmodel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, SellerFormViewModel obj)
        {
            if (id != obj.Vendedor.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Nulo" });
            }
            try
            {
                _Seller.Atualizar(obj.Vendedor);
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { mssage = e.Message });
            }

            return RedirectToAction(nameof(Index));

        }
        public IActionResult Error(string message)
        {
            var veiwmodel = new ErrorViewModel();
            veiwmodel.Message = message;
            veiwmodel.RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View(veiwmodel);
        }
    }
}
