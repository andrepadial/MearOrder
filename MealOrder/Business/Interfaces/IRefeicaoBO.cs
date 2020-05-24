using MealOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Business.Interfaces
{
    public interface IRefeicaoBO
    {
        public List<Refeicao> GetRefeicoes();
        public List<Refeicao> GetRefeicoes(List<ItemRefeicao> itensRefeicao);
        public List<Refeicao> GetRefeicoes(string nome);
    }
}
