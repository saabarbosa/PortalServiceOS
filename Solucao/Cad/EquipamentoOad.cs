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
    public class EquipamentoOad
    {
        public static void OperacaoEquipamento(Equipamento equipamento, string operacao)
        {
            Banco banco = new Banco();
            SqlConnection conexao = banco.Conexao();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;
                SqlDataAdapter da = banco.CriaComando(commandType, "PR_OPERACOES_EQUIPAMENTO");
                da.SelectCommand.Connection = conexao;

                da.SelectCommand.Parameters.Add("@CD_EQUIPAMENTO", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_EQUIPAMENTO"].Value = equipamento.Cd_Equipamento;
                da.SelectCommand.Parameters.Add("@CD_CLIENTE", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_CLIENTE"].Value = equipamento.Cd_Cliente;

                da.SelectCommand.Parameters.Add("@NM_EQUIPAMENTO", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@NM_EQUIPAMENTO"].Value = equipamento.Nm_Equipamento;

                da.SelectCommand.Parameters.Add("@DS_EQUIPAMENTO", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@DS_EQUIPAMENTO"].Value = equipamento.Ds_Equipamento;
                //da.SelectCommand.Parameters.Add("@NM_MEDIDOR", SqlDbType.VarChar);
                //da.SelectCommand.Parameters["@NM_MEDIDOR"].Value = equipamento.Nm_Medidor;

                da.SelectCommand.Parameters.Add("@NM_SERIAL", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@NM_SERIAL"].Value = equipamento.Nm_Serial;

                da.SelectCommand.Parameters.Add("@NM_LOCALIZADOR", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@NM_LOCALIZADOR"].Value = equipamento.Nm_Localizador;

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

        public static void UpdateMedidor(Equipamento equipamento)
        {
            Banco banco = new Banco();
            SqlConnection conexao = banco.Conexao();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;
                SqlDataAdapter da = banco.CriaComando(commandType, "PR_UPDATE_MEDIDOR");
                da.SelectCommand.Connection = conexao;

                da.SelectCommand.Parameters.Add("@CD_EQUIPAMENTO", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_EQUIPAMENTO"].Value = equipamento.Cd_Equipamento;
                da.SelectCommand.Parameters.Add("@CD_CLIENTE", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_CLIENTE"].Value = equipamento.Cd_Cliente;

                da.SelectCommand.Parameters.Add("@NM_SERIAL", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@NM_SERIAL"].Value = equipamento.Nm_Serial;

                da.SelectCommand.Parameters.Add("@NM_LOCALIZADOR", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@NM_LOCALIZADOR"].Value = equipamento.Nm_Localizador;

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
        public static List<Equipamento> GetAll_Equipamentos()
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            List<Equipamento> list = new List<Equipamento>();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_ALL_EQUIPAMENTO");
                da.SelectCommand.Connection = conn;

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Equipamento temp = new Equipamento();
                        temp.Cd_Equipamento = Convert.ToInt16(reader["Cd_Equipamento"]);
                        temp.Cd_Cliente = Convert.ToInt16(reader["Cd_Cliente"]);
                        temp.Nm_Equipamento = Convert.ToString(reader["Nm_Equipamento"]);
                        temp.Ds_Equipamento = Convert.ToString(reader["Ds_Equipamento"]);
                        temp.Nm_Serial = Convert.ToString(reader["Nm_Serial"]);
                        temp.Nm_Localizador = Convert.ToString(reader["Nm_Localizador"]);
                        temp.Nm_Cliente = Convert.ToString(reader["Nm_Cliente"]);
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
        public static Equipamento Get_Equipamento_By_Equipamento(int cd_Equipamento)
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            Equipamento equipamento = new Equipamento();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_EQUIPAMENTO_BY_EQUIPAMENTO");
                da.SelectCommand.Connection = conn;

                da.SelectCommand.Parameters.Add("@CD_EQUIPAMENTO", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_EQUIPAMENTO"].Value = cd_Equipamento;

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        equipamento.Cd_Equipamento = Convert.ToInt16(reader["Cd_Equipamento"]);
                        equipamento.Cd_Cliente = Convert.ToInt16(reader["Cd_Cliente"]);
                        equipamento.Nm_Equipamento = Convert.ToString(reader["Nm_Equipamento"]);
                        equipamento.Ds_Equipamento = Convert.ToString(reader["Ds_Equipamento"]);
                        equipamento.Nm_Serial = Convert.ToString(reader["Nm_Serial"]);
                        equipamento.Nm_Localizador = Convert.ToString(reader["Nm_Localizador"]);
                        equipamento.Nm_Cliente = Convert.ToString(reader["Nm_Cliente"]);
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
            return equipamento;
        }
        public static List<Equipamento> Get_Equipamento_By_Cliente(int cd_Cliente)
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            List<Equipamento> list = new List<Equipamento>();            
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_EQUIPAMENTO_BY_CLIENTE");
                da.SelectCommand.Connection = conn;

                da.SelectCommand.Parameters.Add("@CD_CLIENTE", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_CLIENTE"].Value = cd_Cliente;

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Equipamento temp = new Equipamento();
                        temp.Cd_Equipamento = Convert.ToInt16(reader["Cd_Equipamento"]);
                        temp.Cd_Cliente = Convert.ToInt16(reader["Cd_Cliente"]);
                        temp.Nm_Equipamento = Convert.ToString(reader["Nm_Equipamento"]);
                        temp.Ds_Equipamento = Convert.ToString(reader["Ds_Equipamento"]);
                        temp.Nm_Serial = Convert.ToString(reader["Nm_Serial"]);
                        temp.Nm_Localizador = Convert.ToString(reader["Nm_Localizador"]);
                        temp.Nm_Cliente = Convert.ToString(reader["Nm_Cliente"]);
                        temp.Identificador = Convert.ToString(reader["Identificador"]);
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
