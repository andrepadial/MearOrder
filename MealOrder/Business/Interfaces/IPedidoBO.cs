using MealOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Business.Interfaces
{
    public interface IPedidoBO
    {
        public void Incluir(DateTime dataPedido, double valorPago, List<ItemRefeicao> itensSelecionados);
        public List<Pedido> GetPedidos(DateTime dataInicial, DateTime dataFinal);
    }
}
