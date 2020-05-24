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
    public class RefeicaoRepositorio : IRefeicaoRepositorio
    {
        public List<Refeicao> GetRefeicoes()
        {
            List<Refeicao> refeicoes = new List<Refeicao>();

            try
            {
                using (SqlConnection conn = Helpers.ConexaoDB.GetSqlLocalConnection())
                {
                    refeicoes = conn.Query<Refeicao>(Helpers.DB.RefeicaoDB.GetComandoListaRefeicoes()).ToList<Refeicao>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return refeicoes;
        }

        public List<Refeicao> GetRefeicoes(List<ItemRefeicao> itensRefeicao)
        {
            var refeicoes = GetRefeicoes();
            var refeicoesFiltradas = refeicoes.Select(r => r.IdItemRefeicao).Intersect(itensRefeicao.Select(x => x.IdTipoRefeicao));
            var result = refeicoes.Where(r => refeicoesFiltradas.Contains(r.IdItemRefeicao));

            return result.ToList();
        }

        public List<Refeicao> GetRefeicoes(string nome)
        {
            return GetRefeicoes().Where(r => r.Nome == nome).ToList();
        }
    }
}
