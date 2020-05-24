using MealOrder.Models;
using MealOrder.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib;
using DapperExtensions;
using System.Data.SqlClient;
using System.Data;

namespace MealOrder.Repository.DataAccess
{
    public class ItemRefeicaoRepositorio : IItemRefeicaoRepositorio
    {
        public ItemRefeicao GetItemRefeicao(long idTipoRefeicao, long idProduto)
        {
            return GetItensRefeicao().Where(it => it.IdTipoRefeicao == idTipoRefeicao && it.IdProduto == idProduto).FirstOrDefault();
        }

        public List<ItemRefeicao> GetItensRefeicao()
        {
            List<ItemRefeicao> itensRefeicao = new List<ItemRefeicao>();

            try
            {
                using (SqlConnection conn = Helpers.ConexaoDB.GetSqlLocalConnection())
                {
                    itensRefeicao = conn.Query<ItemRefeicao>(Helpers.DB.ItemRefeicaoDB.GetComandoListaItensRefeicao()).ToList<ItemRefeicao>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return itensRefeicao;
        }

        public List<ItemRefeicao> GetItensRefeicao(long idTipoRefeicao)
        {
            return GetItensRefeicao().Where(it => it.IdTipoRefeicao == idTipoRefeicao).ToList();
        }
    }
}
