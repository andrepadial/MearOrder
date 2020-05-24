using MealOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Repository.Interfaces
{
    public interface IItemRefeicaoRepositorio
    {
        public List<ItemRefeicao> GetItensRefeicao();
        public List<ItemRefeicao> GetItensRefeicao(long idTipoRefeicao);
        public ItemRefeicao GetItemRefeicao(long idTipoRefeicao, long idProduto);
    }
}
