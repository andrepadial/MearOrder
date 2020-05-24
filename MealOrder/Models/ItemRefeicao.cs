using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Models
{
    public class ItemRefeicao
    {
        public Int64 Id { set; get; }
        public long IdProduto { set; get; }
        public long IdTipoRefeicao { set; get; }

        public double Valor { set; get; }

    }
}
