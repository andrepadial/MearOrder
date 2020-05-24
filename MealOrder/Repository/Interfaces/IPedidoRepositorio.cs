using MealOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Repository.Interfaces
{
    public interface IPedidoRepositorio
    {
        public void Incluir(long idRefeicao, DateTime dataPedido, double valor, double valorPago);
        public List<Pedido> GetPedidos(DateTime dataInicial, DateTime dataFinal);
    }
}
