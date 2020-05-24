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
    public class RefeicaoBO : IRefeicaoBO
    {
        private readonly IRefeicaoRepositorio repositorio = new RefeicaoRepositorio();

        public List<Refeicao> GetRefeicoes()
        {
            return repositorio.GetRefeicoes();
        }

        public List<Refeicao> GetRefeicoes(List<ItemRefeicao> itensRefeicao)
        {
            return repositorio.GetRefeicoes(itensRefeicao);
        }

        public List<Refeicao> GetRefeicoes(string nome)
        {
            return repositorio.GetRefeicoes(nome);
        }
    }
}
