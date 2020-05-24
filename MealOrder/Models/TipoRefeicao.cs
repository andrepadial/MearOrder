using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Models
{
    public class TipoRefeicao
    {
        public Int64 Id { set; get; }
        public string Nome { set; get; }
        public string Descricao { set; get; }

    }
}
