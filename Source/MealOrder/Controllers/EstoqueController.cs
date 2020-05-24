using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealOrder.Business.BusinessObject;
using MealOrder.Business.Interfaces;
using MealOrder.Models;
using Microsoft.AspNetCore.Mvc;

namespace MealOrder.Controllers
{
    public class EstoqueController : Controller
    {

        private readonly IEstoqueBO estoqueBO = new EstoqueBO();

        [HttpGet]
        public IActionResult Index(long idProduto)
        {
            Estoque estoque = new Estoque();
            estoque = estoqueBO.GetEstoque(idProduto);            
            return Json(estoque);
        }
    }
}
