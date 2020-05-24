using MealOrder.Business.Interfaces;
using MealOrder.Models;
using MealOrder.Repositorio.DataAccess;
using MealOrder.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Business.BusinessObject
{
    public class ProdutoBO : IProdutoBO
    {
        private readonly IProdutoRepositorio repositorio = new ProdutoRepositorio();

        public Produto GetProduto(long idProduto)
        {
            return repositorio.GetProduto(idProduto);
        }

        public List<Produto> GetProdutos(string produto)
        {
            return repositorio.GetProdutos(produto);
        }

        public List<Produto> GetProdutos(DateTime dataInclusaoAlteracao)
        {
            return repositorio.GetProdutos(dataInclusaoAlteracao);
        }

        public List<Produto> GetProdutos()
        {
            return repositorio.GetProdutos();
        }
    }
}
