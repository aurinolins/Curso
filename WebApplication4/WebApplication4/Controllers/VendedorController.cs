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

        public async Task<IActionResult> Index()
        {
            var list =  await _Seller.FindAllAsync();
            return View(list);
        }
        public  async Task<IActionResult> Create()
        {
            var departamentos = await  _departamentoService.FindAllAsync();
            var viewmodel = new SellerFormViewModel { Departamentos = departamentos };
            return View(viewmodel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Vendedor vendedor)
        {
            if (!ModelState.IsValid)
            {
                var departamentos =  await _departamentoService.FindAllAsync();
                var viewmodel = new SellerFormViewModel {Vendedor = vendedor, Departamentos = departamentos };
                return View(viewmodel);
            }

             await _Seller.InsertAsync(vendedor);
            return RedirectToAction(nameof(Index));
        }
        public  async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Nulo" });
            }
            var obj =  await _Seller.FindbyIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Objeto Nulo" });
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            try
            {
                await _Seller.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException)
            {
                return RedirectToAction(nameof(Error), new { message = "Não pode deleter - Este Vendedor tem Vendas" });
            }
        }
        public  async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Nulo" });
            }
            var obj =  await _Seller.FindbyIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Não Encontrado" });
            }
            return View(obj);
        }
        public  async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Nulo" });
            }
            var obj =  await _Seller.FindbyIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Nulo" });
            }
            List<Departamento> departamentos =  await  _departamentoService.FindAllAsync();
            SellerFormViewModel viewmodel = new SellerFormViewModel { Vendedor = obj, Departamentos = departamentos };
            return View(viewmodel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SellerFormViewModel obj)
        {
            if (id != obj.Vendedor.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Nulo" });
            }
            if (!ModelState.IsValid)
            {
               return View(obj);
            }
            try
            {
                 await _Seller.AtualizarAsync(obj.Vendedor);
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
