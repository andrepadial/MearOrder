using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealOrder.Business.BusinessObject;
using MealOrder.Business.Interfaces;
using MealOrder.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MealOrder.Controllers
{
    public class ProdutoController : Controller
    {

        private readonly IProdutoBO produto = new ProdutoBO();
        
        
        [HttpGet]
        public IActionResult Index()
        {
            List<Produto> produtos = new List<Produto>();
            produtos = produto.GetProdutos();
            return Json(produtos);
        }


        [HttpGet]
        public IActionResult Details(int id)
        {
            Produto prod = new Produto();
            prod = produto.GetProduto(id);
            return Json(prod);
        }      
        
        
    }
}
    