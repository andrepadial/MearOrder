using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Models
{
    public class Pedido
    {
        public long Id { set; get; }
        public long IdRefeicao { set; get; }
        public DateTime Data { set; get; }
        public double Valor { set; get; }
        public double ValorPago { set; get; }

    }
}
