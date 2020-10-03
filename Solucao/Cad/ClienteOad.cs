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
    public class ClienteOad
    {

        public static void CriarUsuario(string usuario, string roles)
        {
            Banco banco = new Banco();
            SqlConnection conexao = banco.Conexao();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;
                SqlDataAdapter da = banco.CriaComando(commandType, "PR_CRIAR_USUARIO");
                da.SelectCommand.Connection = conexao;

                da.SelectCommand.Parameters.Add("@ID_LOGIN", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@ID_LOGIN"].Value = usuario;

                da.SelectCommand.Parameters.Add("@USERID", SqlDbType.UniqueIdentifier);
                da.SelectCommand.Parameters["@USERID"].Value = Guid.NewGuid();


                da.SelectCommand.Parameters.Add("@ROLES", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@ROLES"].Value = roles;

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


        public static void OperacaoCliente(Cliente cliente, string operacao)
        {
            Banco banco = new Banco();
            SqlConnection conexao = banco.Conexao();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;
                SqlDataAdapter da = banco.CriaComando(commandType, "PR_OPERACOES_CLIENTE");
                da.SelectCommand.Connection = conexao;

                da.SelectCommand.Parameters.Add("@CD_CLIENTE", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_CLIENTE"].Value = cliente.Cd_Cliente;
                da.SelectCommand.Parameters.Add("@NM_CLIENTE", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@NM_CLIENTE"].Value = cliente.Nm_Cliente;

                da.SelectCommand.Parameters.Add("@NR_CNPJ", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@NR_CNPJ"].Value = cliente.Nr_Cnpj;
                da.SelectCommand.Parameters.Add("@NR_CPF", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@NR_CPF"].Value = cliente.Nr_Cpf;

                da.SelectCommand.Parameters.Add("@ID_LOGIN", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@ID_LOGIN"].Value = cliente.Id_Login;
                da.SelectCommand.Parameters.Add("@SENHA", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@SENHA"].Value = cliente.Senha;                

                da.SelectCommand.Parameters.Add("@DS_ENDERECO", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@DS_ENDERECO"].Value = cliente.Ds_Endereco;
                da.SelectCommand.Parameters.Add("@DS_TELEFONE", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@DS_TELEFONE"].Value = cliente.Ds_Telefone;

                if (!operacao.Equals("E"))
                {
                    da.SelectCommand.Parameters.Add("@USERID", SqlDbType.UniqueIdentifier);
                    da.SelectCommand.Parameters["@USERID"].Value = cliente.UserId;
                }

                da.SelectCommand.Parameters.Add("@NM_BASE", SqlDbType.Char);
                da.SelectCommand.Parameters["@NM_BASE"].Value = cliente.Nm_Base;

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
        
        public static List<Cliente> GetAll_Clientes()
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            List<Cliente> list = new List<Cliente>();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_ALL_CLIENTE");
                da.SelectCommand.Connection = conn;

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente temp = new Cliente();
                        temp.Cd_Cliente = Convert.ToInt16(reader["Cd_Cliente"]);
                        temp.Nm_Cliente = Convert.ToString(reader["Nm_Cliente"]);
                        temp.Ds_Endereco = Convert.ToString(reader["Ds_Endereco"]);
                        temp.Ds_Telefone = Convert.ToString(reader["Ds_Telefone"]);
                        temp.Nr_Cnpj = Convert.ToString(reader["Nr_Cnpj"]);
                        temp.Nr_Cpf = Convert.ToString(reader["Nr_Cpf"]);
                        temp.UserId = Convert.ToString(reader["UserId"]);
                        temp.Nm_Base = Convert.ToString(reader["Nm_Base"]);
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
        
        public static Cliente Get_Cliente(int cd_cliente)
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            Cliente cliente = new Cliente();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_CLIENTE");
                da.SelectCommand.Connection = conn;

                da.SelectCommand.Parameters.Add("@CD_CLIENTE", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_CLIENTE"].Value = cd_cliente;

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cliente.Cd_Cliente = Convert.ToInt16(reader["Cd_Cliente"]);
                        cliente.Nm_Cliente = Convert.ToString(reader["Nm_Cliente"]);
                        cliente.Ds_Telefone = Convert.ToString(reader["Ds_Telefone"]);
                        cliente.Ds_Endereco = Convert.ToString(reader["Ds_Endereco"]);
                        cliente.Nr_Cnpj = Convert.ToString(reader["Nr_Cnpj"]);
                        cliente.Nr_Cpf = Convert.ToString(reader["Nr_Cpf"]);
                        cliente.UserId = Convert.ToString(reader["UserId"]);
                        cliente.Nm_Base = Convert.ToString(reader["Nm_Base"]);
 
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
            return cliente;
        }
           
        public static Cliente Get_Cliente_By_UserID(string userid)
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            Cliente cliente = new Cliente();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_CLIENTE_BY_USERID");
                da.SelectCommand.Connection = conn;

                da.SelectCommand.Parameters.Add("@USERID", SqlDbType.UniqueIdentifier);
                da.SelectCommand.Parameters["@USERID"].Value = new Guid(userid);

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cliente.Cd_Cliente = Convert.ToInt16(reader["Cd_Cliente"]);
                        cliente.Nm_Cliente = Convert.ToString(reader["Nm_Cliente"]);
                        cliente.Ds_Telefone = Convert.ToString(reader["Ds_Telefone"]);
                        cliente.Ds_Endereco = Convert.ToString(reader["Ds_Endereco"]);
                        cliente.Nr_Cnpj = Convert.ToString(reader["Nr_Cnpj"]);
                        cliente.Nr_Cpf = Convert.ToString(reader["Nr_Cpf"]);
                        cliente.UserId = Convert.ToString(reader["UserId"]);
                        cliente.Nm_Base = Convert.ToString(reader["Nm_Base"]);
                        cliente.UserName = Convert.ToString(reader["UserName"]);
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
            return cliente;        }
    }
}
