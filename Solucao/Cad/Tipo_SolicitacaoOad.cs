using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

using Modelo;

namespace Cad
{
    public class Tipo_SolicitacaoOad
    {
        public static List<TipoSolicitacao> GetAll_Tipo_Solicitacao()
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            List<TipoSolicitacao> list = new List<TipoSolicitacao>();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_ALL_TIPO_SOLICITACAO");
                da.SelectCommand.Connection = conn;

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TipoSolicitacao temp = new TipoSolicitacao();
                        temp.Cd_TpSolicitacao = Convert.ToInt16(reader["Cd_TpSolicitacao"]);
                        temp.Tp_Solicitacao = Convert.ToString(reader["Tp_Solicitacao"]);
                        list.Add(temp);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }
        public static TipoSolicitacao Get_Tipo_Solicitacao(int Cd_TpSolicitacao)
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            TipoSolicitacao tipo_solicitacao = new TipoSolicitacao();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_TIPO_SOLICITACAO");
                da.SelectCommand.Connection = conn;

                da.SelectCommand.Parameters.Add("@CD_TPSOLICITACAO", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_TPSOLICITACAO"].Value = Cd_TpSolicitacao;

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tipo_solicitacao.Cd_TpSolicitacao = Convert.ToInt16(reader["Cd_TpSolicitacao"]);
                        tipo_solicitacao.Tp_Solicitacao = Convert.ToString(reader["Tp_Solicitacao"]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return tipo_solicitacao;
        }
    }
}
