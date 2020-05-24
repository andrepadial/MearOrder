using MealOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Repository.Interfaces
{
    public interface IRefeicaoRepositorio
    {
        public List<Refeicao> GetRefeicoes();
        public List<Refeicao> GetRefeicoes(List<ItemRefeicao> itensRefeicao);
        public List<Refeicao> GetRefeicoes(string nome);
    }
}
