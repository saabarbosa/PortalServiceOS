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
    public class SolicitacaoOad
    {
        public static void OperacaoSolicitacao(Solicitacao solicitacao, string operacao)
        {
            Banco banco = new Banco();
            SqlConnection conexao = banco.Conexao();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;
                SqlDataAdapter da = banco.CriaComando(commandType, "PR_OPERACOES_SOLICITACAO");
                da.SelectCommand.Connection = conexao;

                da.SelectCommand.Parameters.Add("@CD_SOLICITACAO", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_SOLICITACAO"].Value = solicitacao.Cd_Solicitacao;

                da.SelectCommand.Parameters.Add("@CD_EQUIPAMENTO", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_EQUIPAMENTO"].Value = solicitacao.Cd_Equipamento;

                da.SelectCommand.Parameters.Add("@CD_TPSOLICITACAO", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_TPSOLICITACAO"].Value = solicitacao.Cd_TpSolicitacao;

                da.SelectCommand.Parameters.Add("@CD_STATUS", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_STATUS"].Value = solicitacao.Cd_Status;

                da.SelectCommand.Parameters.Add("@DS_SOLICITACAO", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@DS_SOLICITACAO"].Value = solicitacao.Ds_Solicitacao;

                da.SelectCommand.Parameters.Add("@DT_SOLICITACAO", SqlDbType.DateTime);
                da.SelectCommand.Parameters["@DT_SOLICITACAO"].Value = solicitacao.Dt_Solicitacao;

                da.SelectCommand.Parameters.Add("@NM_MEDIDOR", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@NM_MEDIDOR"].Value = solicitacao.Nm_Medidor;


                da.SelectCommand.Parameters.Add("@DS_DEFEITO", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@DS_DEFEITO"].Value = solicitacao.Ds_Defeito;

                da.SelectCommand.Parameters.Add("@OPERACAO", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@OPERACAO"].Value = operacao;

                da.SelectCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static List<Solicitacao> Get_Solicitacao_By_Cliente(int cd_Cliente)
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            List<Solicitacao> list = new List<Solicitacao>();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_SOLICITACAO_BY_CLIENTE");
                da.SelectCommand.Connection = conn;

                da.SelectCommand.Parameters.Add("@CD_CLIENTE", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_CLIENTE"].Value = cd_Cliente;

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Solicitacao temp = new Solicitacao();
                        temp.Cd_Equipamento = Convert.ToInt16(reader["Cd_Equipamento"]);
                        temp.Cd_Solicitacao = Convert.ToInt16(reader["Cd_Solicitacao"]);
                        temp.Cd_Status = Convert.ToInt16(reader["Cd_Status"]);
                        temp.Cd_TpSolicitacao = Convert.ToInt16(reader["Cd_TpSolicitacao"]);
                        temp.Ds_Solicitacao = Convert.ToString(reader["Ds_Solicitacao"]);
                        temp.Dt_Solicitacao = Convert.ToDateTime(reader["Dt_Solicitacao"]);
                        temp.Nm_Equipamento = Convert.ToString(reader["Nm_Equipamento"]);
                        temp.Nm_Localizador = Convert.ToString(reader["Nm_Localizador"]);
                        temp.Nm_Cliente = Convert.ToString(reader["Nm_Cliente"]);
                        temp.Nm_Status = Convert.ToString(reader["Nm_Status"]);
                        temp.Tp_Solicitacao = Convert.ToString(reader["Tp_Solicitacao"]);
                        temp.Nm_Medidor = Convert.ToString(reader["Nm_Medidor"]);
                        temp.Ds_Defeito = Convert.ToString(reader["Ds_Defeito"]);
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

        public static List<Solicitacao> Get_All_Solicitacao_Pendentes()
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            List<Solicitacao> list = new List<Solicitacao>();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_ALL_SOLICITACAO_PENDENTES");
                da.SelectCommand.Connection = conn;               

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Solicitacao temp = new Solicitacao();
                        temp.Cd_Equipamento = Convert.ToInt16(reader["Cd_Equipamento"]);
                        temp.Cd_Solicitacao = Convert.ToInt16(reader["Cd_Solicitacao"]);
                        temp.Cd_Status = Convert.ToInt16(reader["Cd_Status"]);
                        temp.Cd_TpSolicitacao = Convert.ToInt16(reader["Cd_TpSolicitacao"]);
                        temp.Ds_Solicitacao = Convert.ToString(reader["Ds_Solicitacao"]);
                        temp.Dt_Solicitacao = Convert.ToDateTime(reader["Dt_Solicitacao"]);
                        temp.Nm_Equipamento = Convert.ToString(reader["Equipamento"]);
                        temp.Cd_Cliente = Convert.ToInt16(reader["Cd_Cliente"]);
                        temp.Nm_Cliente = Convert.ToString(reader["Nm_Cliente"]);
                        temp.Nm_Status = Convert.ToString(reader["Nm_Status"]);
                        temp.Tp_Solicitacao = Convert.ToString(reader["Tp_Solicitacao"]);
                        temp.Nm_Medidor = Convert.ToString(reader["Nm_Medidor"]);
                        temp.Ds_Defeito = Convert.ToString(reader["Ds_Defeito"]);
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

        public static Solicitacao Get_Solicitacao_By_Solicitacao(int cd_Solicitacao)
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            Solicitacao solicitacao = new Solicitacao();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_SOLICITACAO_BY_SOLICITACAO");
                da.SelectCommand.Connection = conn;

                da.SelectCommand.Parameters.Add("@CD_SOLICITACAO", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_SOLICITACAO"].Value = cd_Solicitacao;

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        solicitacao.Cd_Equipamento = Convert.ToInt16(reader["Cd_Equipamento"]);
                        solicitacao.Cd_Solicitacao = Convert.ToInt16(reader["Cd_Solicitacao"]);
                        solicitacao.Cd_Status = Convert.ToInt16(reader["Cd_Status"]);
                        solicitacao.Cd_TpSolicitacao = Convert.ToInt16(reader["Cd_TpSolicitacao"]);
                        solicitacao.Ds_Solicitacao = Convert.ToString(reader["Ds_Solicitacao"]);
                        solicitacao.Dt_Solicitacao = Convert.ToDateTime(reader["Dt_Solicitacao"]);
                        solicitacao.Nm_Equipamento = Convert.ToString(reader["Nm_Equipamento"]);
                        solicitacao.Cd_Cliente = Convert.ToInt16(reader["Cd_Cliente"]);
                        solicitacao.Nm_Cliente = Convert.ToString(reader["Nm_Cliente"]);
                        solicitacao.Nm_Status = Convert.ToString(reader["Nm_Status"]);
                        solicitacao.Tp_Solicitacao = Convert.ToString(reader["Tp_Solicitacao"]);
                        solicitacao.Nm_Medidor = Convert.ToString(reader["Nm_Medidor"]);
                        solicitacao.Ds_Defeito = Convert.ToString(reader["Ds_Defeito"]);
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
            return solicitacao;
        }
    }
}
