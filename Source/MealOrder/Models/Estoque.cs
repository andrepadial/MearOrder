using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Models
{
    public class Estoque
    {
        public Int64 Id { set; get; }
        public long IdProduto { set; get; }
        public int Quantidade { set; get; }
        public DateTime DataInclusao { set; get; }
        public string UsuarioInclusao { set; get; }
        public DateTime DataBaixa { set; get; }
        public string UsuarioBaixa { set; get; }


    }
}
