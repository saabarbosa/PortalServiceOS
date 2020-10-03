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
    public class CategoriaOad
    {
        public static void OperacaoCategoria(Categoria categoria, string operacao)
        {
            Banco banco = new Banco();
            SqlConnection conexao = banco.Conexao();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;
                SqlDataAdapter da = banco.CriaComando(commandType, "PR_OPERACOES_CATEGORIA");
                da.SelectCommand.Connection = conexao;

                da.SelectCommand.Parameters.Add("@ID_CATEGORIA", SqlDbType.Int);
                da.SelectCommand.Parameters["@ID_CATEGORIA"].Value = categoria.Id_Categoria;

                da.SelectCommand.Parameters.Add("@NM_CATEGORIA", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@NM_CATEGORIA"].Value = categoria.Nm_Categoria;                
                
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

        public static List<Categoria> GetAll_Categorias()
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            List<Categoria> list = new List<Categoria>();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_ALL_CATEGORIA");
                da.SelectCommand.Connection = conn;                                
                
                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Categoria temp = new Categoria();
                        
                        temp.Id_Categoria = Convert.ToInt16(reader["id_Categoria"]);
                        temp.Nm_Categoria = Convert.ToString(reader["Nm_Categoria"]);
                        

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

        public static Categoria Get_Categoria(int id_categoria)
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            Categoria categoria = new Categoria();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_CATEGORIA");
                da.SelectCommand.Connection = conn;

                da.SelectCommand.Parameters.Add("@ID_CATEGORIA", SqlDbType.Int);
                da.SelectCommand.Parameters["@ID_CATEGORIA"].Value = id_categoria;

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        categoria.Id_Categoria = Convert.ToInt16(reader["id_Categoria"]);
                        categoria.Nm_Categoria = Convert.ToString(reader["Nm_Categoria"]);                        
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
            return categoria;
        }
    }
}
