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
    public class ProdutoOad
    {
        public static void OperacaoProduto(Produto produto, string operacao)
        {
            Banco banco = new Banco();
            SqlConnection conexao = banco.Conexao();           
            try
            {
                CommandType commandType = CommandType.StoredProcedure;
                SqlDataAdapter da = banco.CriaComando(commandType, "PR_OPERACOES_PRODUTO");
                da.SelectCommand.Connection = conexao;

                da.SelectCommand.Parameters.Add("@ID_PRODUTO", SqlDbType.Int);
                da.SelectCommand.Parameters["@ID_PRODUTO"].Value = produto.Id_Produto;
                da.SelectCommand.Parameters.Add("@ID_CATEGORIA", SqlDbType.Int);
                da.SelectCommand.Parameters["@ID_CATEGORIA"].Value = produto.Id_Categoria;                   
                da.SelectCommand.Parameters.Add("@NM_PRODUTO", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@NM_PRODUTO"].Value = produto.Nm_Produto;
                da.SelectCommand.Parameters.Add("@DS_PRODUTO", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@DS_PRODUTO"].Value = produto.Ds_Produto;


                da.SelectCommand.Parameters.Add("@IMG_PRODUTO", SqlDbType.Image);
                da.SelectCommand.Parameters["@IMG_PRODUTO"].Value = produto.Img_Produto;
                da.SelectCommand.Parameters.Add("@TAM_PRODUTO", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@TAM_PRODUTO"].Value = produto.Tam_Produto;

                da.SelectCommand.Parameters.Add("@URL_PRODUTO", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@URL_PRODUTO"].Value = produto.Url_Produto;

                da.SelectCommand.Parameters.Add("@NR_ORDEM", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@NR_ORDEM"].Value = produto.Nr_Ordem;

                if ((produto.Id_Categoria == 1) || (produto.Id_Categoria == 2) )
                {
                    da.SelectCommand.Parameters.Add("@ORCA_TP_IMPRESSAO", SqlDbType.VarChar);
                    da.SelectCommand.Parameters["@ORCA_TP_IMPRESSAO"].Value = produto.Orca_Tp_Impressao;
                    da.SelectCommand.Parameters.Add("@ORCA_VL_IMPRESSAO", SqlDbType.VarChar);
                    da.SelectCommand.Parameters["@ORCA_VL_IMPRESSAO"].Value = produto.Orca_Vl_Impressao;
                    da.SelectCommand.Parameters.Add("@ORCA_CONEXAO", SqlDbType.VarChar);
                    da.SelectCommand.Parameters["@ORCA_CONEXAO"].Value = produto.Orca_Conexao;
                    da.SelectCommand.Parameters.Add("@ORCA_FRENTE_VERSO", SqlDbType.VarChar);
                    da.SelectCommand.Parameters["@ORCA_FRENTE_VERSO"].Value = produto.Orca_Frente_Verso;
                }
                if (produto.Id_Categoria == 2)
                {
                    da.SelectCommand.Parameters.Add("@ORCA_SCANNER", SqlDbType.VarChar);
                    da.SelectCommand.Parameters["@ORCA_SCANNER"].Value = produto.Orca_Scanner;
                    da.SelectCommand.Parameters.Add("@ORCA_FAX", SqlDbType.VarChar);
                    da.SelectCommand.Parameters["@ORCA_FAX"].Value = produto.Orca_Fax;
                    da.SelectCommand.Parameters.Add("@ORCA_ALIMENTADOR", SqlDbType.VarChar);
                    da.SelectCommand.Parameters["@ORCA_ALIMENTADOR"].Value = produto.Orca_Alimentador;
                }
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

        public static List<Produto> GetAll_Produtos()
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            List<Produto> list = new List<Produto>();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_ALL_PRODUTO");
                da.SelectCommand.Connection = conn;

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Produto temp = new Produto();
                        temp.Id_Produto = Convert.ToInt16(reader["id_Produto"]);
                        temp.Id_Categoria = Convert.ToInt16(reader["id_Categoria"]);
                        temp.Nm_Produto = Convert.ToString(reader["Nm_Produto"]);
                        temp.Ds_Produto = Convert.ToString(reader["Ds_Produto"]);
                        temp.Img_Produto = (byte[])reader["Img_Produto"];
                        temp.Tam_Produto = Convert.ToString(reader["Tam_Produto"]);
                        temp.Nm_Categoria = Convert.ToString(reader["Nm_Categoria"]);
                        temp.Url_Produto = Convert.ToString(reader["Url_Produto"]);
                        temp.Nr_Ordem = Convert.ToString(reader["Nr_Ordem"]);
                        if ((temp.Id_Categoria == 1) || (temp.Id_Categoria == 2))
                        {
                            temp.Orca_Tp_Impressao = Convert.ToString(reader["Orca_Tp_Impressao"]);
                            temp.Orca_Vl_Impressao = Convert.ToString(reader["Orca_Vl_Impressao"]);
                            temp.Orca_Conexao = Convert.ToString(reader["Orca_Conexao"]);
                            temp.Orca_Frente_Verso = Convert.ToString(reader["Orca_Frente_Verso"]);
                        }
                        if (temp.Id_Categoria == 2)
                        {
                            temp.Orca_Scanner = Convert.ToString(reader["Orca_Scanner"]);
                            temp.Orca_Fax = Convert.ToString(reader["Orca_Fax"]);
                            temp.Orca_Alimentador = Convert.ToString(reader["Orca_Alimentador"]);
                        }
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

        public static List<Produto> Get_OrcamentoProdutos(Produto produto)
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            List<Produto> list = new List<Produto>();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_ORCAMENTO");
                da.SelectCommand.Connection = conn;

                da.SelectCommand.Parameters.Add("@ID_CATEGORIA", SqlDbType.Int);
                da.SelectCommand.Parameters["@ID_CATEGORIA"].Value = produto.Id_Categoria;
                da.SelectCommand.Parameters.Add("@ORCA_TP_IMPRESSAO", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@ORCA_TP_IMPRESSAO"].Value = produto.Orca_Tp_Impressao;
                da.SelectCommand.Parameters.Add("@ORCA_VL_IMPRESSAO", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@ORCA_VL_IMPRESSAO"].Value = produto.Orca_Vl_Impressao;
                da.SelectCommand.Parameters.Add("@ORCA_CONEXAO", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@ORCA_CONEXAO"].Value = produto.Orca_Conexao;
                da.SelectCommand.Parameters.Add("@ORCA_FRENTE_VERSO", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@ORCA_FRENTE_VERSO"].Value = produto.Orca_Frente_Verso;
                da.SelectCommand.Parameters.Add("@ORCA_SCANNER", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@ORCA_SCANNER"].Value = produto.Orca_Scanner;
                da.SelectCommand.Parameters.Add("@ORCA_FAX", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@ORCA_FAX"].Value = produto.Orca_Fax;
                da.SelectCommand.Parameters.Add("@ORCA_ALIMENTADOR", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@ORCA_ALIMENTADOR"].Value = produto.Orca_Alimentador;

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Produto temp = new Produto();
                        temp.Id_Produto = Convert.ToInt16(reader["id_Produto"]);
                        temp.Id_Categoria = Convert.ToInt16(reader["id_Categoria"]);
                        temp.Nm_Produto = Convert.ToString(reader["Nm_Produto"]);
                        temp.Ds_Produto = Convert.ToString(reader["Ds_Produto"]);
                        temp.Img_Produto = (byte[])reader["Img_Produto"];
                        temp.Tam_Produto = Convert.ToString(reader["Tam_Produto"]);
                        temp.Url_Produto = Convert.ToString(reader["Url_Produto"]);
                        temp.Nr_Ordem = Convert.ToString(reader["Nr_Ordem"]);
                        if ((temp.Id_Categoria == 1) || (temp.Id_Categoria == 2))
                        {
                            temp.Orca_Tp_Impressao = Convert.ToString(reader["Orca_Tp_Impressao"]);
                            temp.Orca_Vl_Impressao = Convert.ToString(reader["Orca_Vl_Impressao"]);
                            temp.Orca_Conexao = Convert.ToString(reader["Orca_Conexao"]);
                            temp.Orca_Frente_Verso = Convert.ToString(reader["Orca_Frente_Verso"]);
                        }
                        if (temp.Id_Categoria == 2)
                        {
                            temp.Orca_Scanner = Convert.ToString(reader["Orca_Scanner"]);
                            temp.Orca_Fax = Convert.ToString(reader["Orca_Fax"]);
                            temp.Orca_Alimentador = Convert.ToString(reader["Orca_Alimentador"]);
                        }
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

        public static Produto Get_Produto(int id_produto)
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            Produto produto = new Produto();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_PRODUTO");
                da.SelectCommand.Connection = conn;

                da.SelectCommand.Parameters.Add("@ID_PRODUTO", SqlDbType.Int);
                da.SelectCommand.Parameters["@ID_PRODUTO"].Value = id_produto;
                
                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        
                        produto.Id_Produto = Convert.ToInt16(reader["id_Produto"]);
                        produto.Nm_Produto = Convert.ToString(reader["Nm_Produto"]);
                        produto.Ds_Produto = Convert.ToString(reader["Ds_Produto"]);
                        produto.Img_Produto = (byte[])reader["Img_Produto"];
                        produto.Tam_Produto = Convert.ToString(reader["Tam_Produto"]);
                        produto.Url_Produto = Convert.ToString(reader["Url_Produto"]);
                        produto.Id_Categoria = Convert.ToInt16(reader["id_Categoria"]);
                        produto.Nm_Categoria = Convert.ToString(reader["nm_Categoria"]);
                        produto.Nr_Ordem = Convert.ToString(reader["nr_Ordem"]);

                        if ((produto.Id_Categoria == 1) || (produto.Id_Categoria == 2))
                        {
                            produto.Orca_Tp_Impressao = Convert.ToString(reader["Orca_Tp_Impressao"]);
                            produto.Orca_Vl_Impressao = Convert.ToString(reader["Orca_Vl_Impressao"]);
                            produto.Orca_Conexao = Convert.ToString(reader["Orca_Conexao"]);
                            produto.Orca_Frente_Verso = Convert.ToString(reader["Orca_Frente_Verso"]);
                        }
                        if (produto.Id_Categoria == 2)
                        {
                            produto.Orca_Scanner = Convert.ToString(reader["Orca_Scanner"]);
                            produto.Orca_Fax = Convert.ToString(reader["Orca_Fax"]);
                            produto.Orca_Alimentador = Convert.ToString(reader["Orca_Alimentador"]);
                        }

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
            return produto;
        }

        public static List<Produto> Get_Produtos(int id_categoria)
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            List<Produto> list = new List<Produto>();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_PRODUTO_CATEGORIA");
                da.SelectCommand.Connection = conn;
                da.SelectCommand.Parameters.Add("@ID_CATEGORIA", SqlDbType.Int);
                da.SelectCommand.Parameters["@ID_CATEGORIA"].Value = id_categoria;

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Produto temp = new Produto();
                        temp.Id_Produto = Convert.ToInt16(reader["id_Produto"]);
                        temp.Id_Categoria = Convert.ToInt16(reader["id_Categoria"]);
                        temp.Nm_Produto = Convert.ToString(reader["Nm_Produto"]);
                        temp.Ds_Produto = Convert.ToString(reader["Ds_Produto"]);
                        temp.Img_Produto = (byte[])reader["Img_Produto"];
                        temp.Tam_Produto = Convert.ToString(reader["Tam_Produto"]);
                        temp.Nm_Categoria = Convert.ToString(reader["Nm_Categoria"]);
                        temp.Url_Produto = Convert.ToString(reader["Url_Produto"]);
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

    }
}
