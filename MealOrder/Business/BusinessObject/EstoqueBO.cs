using MealOrder.Business.Interfaces;
using MealOrder.Models;
using MealOrder.Repositorio.Interfaces;
using MealOrder.Repository.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Business.BusinessObject
{
    public class EstoqueBO : IEstoqueBO
    {

        private readonly IEstoqueRepositorio repositorio = new EstoqueRepositorio();

        public Estoque GetEstoque(long idProduto)
        {
            return repositorio.GetEstoque(idProduto);
        }
    }
}
