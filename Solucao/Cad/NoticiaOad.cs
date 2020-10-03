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
    public class NoticiaOad
    {
        public static void OperacaoNoticia(Noticia noticia, string operacao)
        {
            Banco banco = new Banco();
            SqlConnection conexao = banco.Conexao();           
            try
            {
                CommandType commandType = CommandType.StoredProcedure;
                SqlDataAdapter da = banco.CriaComando(commandType, "PR_OPERACOES_NOTICIA");
                da.SelectCommand.Connection = conexao;

                da.SelectCommand.Parameters.Add("@CD_NOTICIA", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_NOTICIA"].Value = noticia.Id_Noticia;
                da.SelectCommand.Parameters.Add("@DS_MANCHETE", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@DS_MANCHETE"].Value = noticia.Ds_Manchete;                   
                da.SelectCommand.Parameters.Add("@DS_CHAMADA", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@DS_CHAMADA"].Value = noticia.Ds_Chamada;
                da.SelectCommand.Parameters.Add("@DS_CONTEUDO", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@DS_CONTEUDO"].Value = noticia.Ds_Conteudo;
                da.SelectCommand.Parameters.Add("@DT_CRIACAO", SqlDbType.DateTime);
                da.SelectCommand.Parameters["@DT_CRIACAO"].Value = noticia.Dt_Criacao;

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

        public static List<Noticia> GetAll_Noticias()
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            List<Noticia> list = new List<Noticia>();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_ALL_NOTICIA");
                da.SelectCommand.Connection = conn;

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Noticia temp = new Noticia();
                        temp.Id_Noticia = Convert.ToInt16(reader["id_Noticia"]);
                        temp.Ds_Manchete = Convert.ToString(reader["ds_Manchete"]);
                        temp.Ds_Chamada = Convert.ToString(reader["ds_Chamada"]);
                        temp.Ds_Conteudo = Convert.ToString(reader["ds_Conteudo"]);
                        temp.Dt_Criacao = Convert.ToDateTime(reader["dt_Criacao"]);
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


        public static Noticia Get_Noticia(int id_noticia)
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            Noticia noticia = new Noticia();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_NOTICIA");
                da.SelectCommand.Connection = conn;

                da.SelectCommand.Parameters.Add("@CD_NOTICIA", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_NOTICIA"].Value = id_noticia;
                
                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        noticia.Id_Noticia = Convert.ToInt16(reader["id_Noticia"]);
                        noticia.Ds_Manchete = Convert.ToString(reader["Ds_Manchete"]);
                        noticia.Ds_Chamada = Convert.ToString(reader["Ds_Chamada"]);
                        noticia.Ds_Conteudo = Convert.ToString(reader["Ds_Conteudo"]);
                        noticia.Dt_Criacao = Convert.ToDateTime(reader["Dt_Criacao"]);
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
            return noticia;
        }


    }
}
