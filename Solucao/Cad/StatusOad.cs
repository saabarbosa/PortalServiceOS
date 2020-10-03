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
    public class StatusOad
    {
        public static List<Status> GetAll_Status()
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            List<Status> list = new List<Status>();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_ALL_STATUS");
                da.SelectCommand.Connection = conn;

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Status temp = new Status();
                        temp.Cd_Status = Convert.ToInt16(reader["Cd_Status"]);
                        temp.Nm_Status = Convert.ToString(reader["Nm_Status"]);                        
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

        public static Status Get_Status(int cd_status)
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.Conexao();
            Status status = new Status();
            try
            {
                CommandType commandType = CommandType.StoredProcedure;

                SqlDataAdapter da = banco.CriaComando(commandType, "PR_GET_STATUS");
                da.SelectCommand.Connection = conn;

                da.SelectCommand.Parameters.Add("@CD_STATUS", SqlDbType.Int);
                da.SelectCommand.Parameters["@CD_STATUS"].Value = cd_status;

                using (SqlDataReader reader = da.SelectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        status.Cd_Status = Convert.ToInt16(reader["Cd_Status"]);
                        status.Nm_Status = Convert.ToString(reader["Nm_Status"]);                        
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
            return status;
        }
           
    }
}
