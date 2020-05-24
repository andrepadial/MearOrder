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
    public class TipoRefeicaoBO : ITipoRefeicaoBO
    {

        private readonly ITipoRefeicaoRepositorio repositorio = new TipoRefeicaoRepositorio();

        public TipoRefeicao GetTipoRefeicao(long id)
        {
            return repositorio.GetTipoRefeicao(id);
        }

        public List<TipoRefeicao> GetTipoRefeicoes()
        {
            return repositorio.GetTipoRefeicoes();
        }

        public List<TipoRefeicao> GetTipoRefeicoes(string nomeDescricao)
        {
            return repositorio.GetTipoRefeicoes(nomeDescricao);
        }
    }
}
