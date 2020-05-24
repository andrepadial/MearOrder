using MealOrder.Business.Interfaces;
using MealOrder.Models;
using MealOrder.Repository.DataAccess;
using MealOrder.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Business.BusinessObject
{
    public class ItemRefeicaoBO : IItemRefeicaoBO
    {

        private readonly IItemRefeicaoRepositorio repositorio = new ItemRefeicaoRepositorio();

        public ItemRefeicao GetItemRefeicao(long idTipoRefeicao, long idProduto)
        {
            return repositorio.GetItemRefeicao(idTipoRefeicao, idProduto);
        }

        public List<ItemRefeicao> GetItensRefeicao()
        {
            return repositorio.GetItensRefeicao();
        }

        public List<ItemRefeicao> GetItensRefeicao(long idTipoRefeicao)
        {
            return repositorio.GetItensRefeicao(idTipoRefeicao);
        }
    }
}
