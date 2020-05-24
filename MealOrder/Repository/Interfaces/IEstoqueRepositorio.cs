using MealOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Repositorio.Interfaces
{
    public interface IEstoqueRepositorio
    {
        public Estoque GetEstoque(Int64 idProduto);
    }
}
