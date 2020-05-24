using MealOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Business.Interfaces
{
    public interface IProdutoBO
    {
        public Produto GetProduto(Int64 idProduto);
        public List<Produto> GetProdutos(string produto);
        public List<Produto> GetProdutos(DateTime dataInclusaoAlteracao);
        public List<Produto> GetProdutos();

    }
}
