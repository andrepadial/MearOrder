using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Models
{
    public class Refeicao
    {
        public Int64 Id { set; get; }
        public string Nome { set; get; }
        public string Descricao { set; get; }
        public long IdItemRefeicao { set; get; }


    }
}
