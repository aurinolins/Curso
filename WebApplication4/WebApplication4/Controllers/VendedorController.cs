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
                return NotFound();
            }
            var obj = _Seller.FindbyId(id.Value);
            if (obj == null)
            {
                return NotFound();
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
                return NotFound();
            }
            var obj = _Seller.FindbyId(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _Seller.FindbyId(id.Value);
            if (obj == null)
            {
                return NotFound();
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
                return BadRequest();
            }
            try
            {
                _Seller.Atualizar(obj.Vendedor);
            }
            catch (DBConcurrencyException e)
            {
                throw new DBConcurrencyException(e.Message);
            }
            return RedirectToAction(nameof(Index));

        }
    }
}
