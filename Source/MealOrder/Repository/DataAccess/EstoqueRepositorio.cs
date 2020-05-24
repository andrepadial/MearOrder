using MealOrder.Models;
using MealOrder.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib;
using DapperExtensions;
using System.Data;

namespace MealOrder.Repository.DataAccess
{
    public class EstoqueRepositorio : IEstoqueRepositorio
    {

        public Estoque GetEstoque(long idProduto)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@IdProduto", idProduto);
            Estoque estoque = new Estoque();

            try
            {
                using (SqlConnection conn = Helpers.ConexaoDB.GetSqlLocalConnection())
                {
                    estoque = conn.Query<Estoque>(Helpers.DB.EstoqueDB.GetComandoListaEstoque(), parameters, null, true, 0, CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return estoque;
        }
    }
}
