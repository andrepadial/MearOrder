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
using MealOrder.Models;

namespace MealOrder.Repository.DataAccess
{
    public class TipoRefeicaoRepositorio : ITipoRefeicaoRepositorio
    {
        public Models.TipoRefeicao GetTipoRefeicao(long id)
        {
            return GetTipoRefeicoes().Where(tp => tp.Id == id).FirstOrDefault();
        }

        public List<Models.TipoRefeicao> GetTipoRefeicoes()
        {
            List<TipoRefeicao> tipoRefeicoes = new List<TipoRefeicao>();

            try
            {
                using (SqlConnection conn = Helpers.ConexaoDB.GetSqlLocalConnection())
                {
                    tipoRefeicoes = conn.Query<TipoRefeicao>(Helpers.DB.TipoRefeicaoDB.GetComandoListaTipoRefeicoes()).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return tipoRefeicoes;
        }

        public List<Models.TipoRefeicao> GetTipoRefeicoes(string nomeDescricao)
        {
            return GetTipoRefeicoes().Where(tp => tp.Nome == nomeDescricao || tp.Descricao == nomeDescricao).ToList();
        }
    }
}
