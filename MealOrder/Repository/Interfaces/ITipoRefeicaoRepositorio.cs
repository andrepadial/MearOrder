using MealOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Repository.Interfaces
{
    public interface ITipoRefeicaoRepositorio
    {
        public List<TipoRefeicao> GetTipoRefeicoes();
        public TipoRefeicao GetTipoRefeicao(long id);
        public List<TipoRefeicao> GetTipoRefeicoes(string nomeDescricao);

    }
}
