using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealOrder.Business.BusinessObject;
using MealOrder.Business.Interfaces;
using MealOrder.Models;
using MealOrder.Repository.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MealOrder.Controllers
{
    public class PedidoController : Controller
    {

        private readonly IPedidoBO repositorio = new PedidoBO();
        
        // GET: PedidoController
        [HttpGet]
        public IActionResult Index(DateTime dataInicio, DateTime dataFinal)
        {
            List<Pedido> pedidos = new List<Pedido>();
            pedidos = repositorio.GetPedidos(dataInicio, dataFinal);
            return Json(pedidos);
        }

        // GET: PedidoController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: PedidoController/Create
        [HttpPost]
        public IActionResult Create(DateTime dataPedido, double valorPago, List<ItemRefeicao> itensSelecionados)
        {
            repositorio.Incluir(dataPedido, valorPago, itensSelecionados);
            return View();
        }

        // POST: PedidoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PedidoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PedidoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PedidoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PedidoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
