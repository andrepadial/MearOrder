using MealOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Repositorio.Interfaces
{
    public interface IProdutoRepositorio
    {
        public Produto GetProduto(Int64 idProduto);
        public List<Produto> GetProdutos(string produto);
        public List<Produto> GetProdutos(DateTime dataInclusaoAlteracao);
        public List<Produto> GetProdutos();
    }
}
