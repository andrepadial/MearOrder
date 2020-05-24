using MealOrder.Models;
using MealOrder.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib;
using DapperExtensions;
using System.Data;
using System.Data.SqlClient;

namespace MealOrder.Repository.DataAccess
{
    public class PedidoRepositorio : IPedidoRepositorio
    {
        public List<Pedido> GetPedidos(DateTime dataInicial, DateTime dataFinal)
        {

            var parameters = new DynamicParameters();
            parameters.Add("@DataInicial", dataInicial);
            parameters.Add("@DataFinal", dataFinal);

            List<Pedido> pedidos = new List<Pedido>();

            try
            {
                using (SqlConnection conn = Helpers.ConexaoDB.GetSqlLocalConnection())
                {
                    pedidos = conn.Query<Pedido>(Helpers.DB.PedidosDB.GetComandoListaPedidos(), parameters, null, true, 0, CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return pedidos;
        }

        public void Incluir(long idRefeicao, DateTime dataPedido, double valor, double valorPago)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@IdRefeicao", idRefeicao);
            parameters.Add("@DataPedido", dataPedido);
            parameters.Add("@Valor", valor);
            parameters.Add("@ValorPago", valorPago);

            try
            {
                using (SqlConnection conn = Helpers.ConexaoDB.GetSqlLocalConnection())
                {
                    var retorno = conn.Execute(Helpers.DB.PedidosDB.GetComandoIncluirPedido(), parameters, null, 0, CommandType.StoredProcedure);                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }
    }
}
