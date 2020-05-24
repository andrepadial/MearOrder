using MealOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Business.Interfaces
{
    public interface IEstoqueBO
    {

        public Estoque GetEstoque(Int64 idProduto);
    }
}
