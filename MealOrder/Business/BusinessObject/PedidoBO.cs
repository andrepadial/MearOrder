using MealOrder.Business.Interfaces;
using MealOrder.Models;
using MealOrder.Repository.DataAccess;
using MealOrder.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealOrder.Business.BusinessObject
{
    public class PedidoBO : IPedidoBO
    {

        private readonly IPedidoRepositorio repositorio = new PedidoRepositorio();
        private readonly IRefeicaoBO refeicaoRepositorio = new RefeicaoBO();
        private readonly IEstoqueBO estoqueRepositorio = new EstoqueBO();

        public List<Pedido> GetPedidos(DateTime dataInicial, DateTime dataFinal)
        {
            return repositorio.GetPedidos(dataInicial, dataFinal);
        }

        public void Incluir(DateTime dataPedido, double valorPago, List<ItemRefeicao> itensSelecionados)
        {
            List<ItemRefeicao> itensRefeicao = new List<ItemRefeicao>();
            var refeicao = refeicaoRepositorio.GetRefeicoes(itensSelecionados);
            var estoque = new Estoque();
            int contadorItensEstoque = 0;

            //Validando se existe itens em estoque para fechar o pedido
            foreach(var item in itensSelecionados)
            {
                estoque = estoqueRepositorio.GetEstoque(item.IdProduto);

                if (estoque.Quantidade < 1)
                    contadorItensEstoque += 1;
            }

            if (contadorItensEstoque > 0)
                throw new Exception("Não é possível fechar o pedido. Não há itens em estoque");


            //Validando valor e valor pago
            var valor = itensSelecionados.Sum(i => i.Valor);

            if (valor < valorPago)
                throw new Exception(String.Concat("Valor pago inferior ao valor previsto."));


            try
            {
                repositorio.Incluir(refeicao.FirstOrDefault().Id, dataPedido, valor, valorPago);
            }
            catch(Exception ex)
            {
                throw new Exception(String.Concat("Erro ao fechar pedido: ", ex.Message.ToString()));
            }           
            
        }
    }
}
