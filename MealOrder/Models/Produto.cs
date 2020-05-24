using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Models
{
    public class Produto
    {
        public Int64 Id { set; get; }
        public string Nome { set; get; }
        public DateTime DataInclusao { set; get; }
        public DateTime DataAlteracao { set; get; }
        public double ValorCompra { set; get; }

    }
}
