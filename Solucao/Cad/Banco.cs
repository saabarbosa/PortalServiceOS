using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Cad
{
    class Banco
    {
        private static string strConexao = null;

        public Banco()
        {
            try
            {
                string nomeStringConexao = ChaveStringConexao();
                ConnectionStringSettings configStringConexao = ConfigurationManager.ConnectionStrings[nomeStringConexao];
                strConexao = configStringConexao.ConnectionString;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private string ChaveStringConexao()
        {
            return ConfigurationManager.AppSettings["strconexao_SqlServer"];
        }

        public SqlConnection Conexao()
        {
            SqlConnection conn = new SqlConnection(strConexao);
            try
            {
                conn.Open();
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return conn;

        }

        public SqlDataAdapter CriaComando(CommandType commandType, string commandText)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.CommandText = commandText;
            da.SelectCommand.CommandType = commandType;
            return da;
        }



    }
}
