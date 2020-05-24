using MealOrder.Models;
using MealOrder.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib;
using DapperExtensions;
using System.Data.SqlClient;
using System.Data;

namespace MealOrder.Repositorio.DataAccess
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        public Produto GetProduto(long idProduto)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", idProduto);
            Produto produto = new Produto();

            try
            {
                using (SqlConnection conn = Helpers.ConexaoDB.GetSqlLocalConnection())
                {
                    produto = conn.Query<Produto>(Helpers.DB.ProdutoDB.GetComandoListaProduto(), parameters, null, true, 0, CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return produto;

        }

        public List<Produto> GetProdutos(string produto)
        {
            return GetProdutos().Where(p => p.Nome == produto).ToList();
        }

        public List<Produto> GetProdutos(DateTime dataInclusaoAlteracao)
        {
            return GetProdutos().Where(p => p.DataInclusao == dataInclusaoAlteracao || p.DataAlteracao == dataInclusaoAlteracao).ToList();
        }

        public List<Produto> GetProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            try
            {
                using (SqlConnection conn = Helpers.ConexaoDB.GetSqlLocalConnection())
                {
                    produtos = conn.Query<Produto>(Helpers.DB.ProdutoDB.GetComandoListaProdutos()).ToList<Produto>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return produtos;
        }
    }
}
