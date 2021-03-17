using System;
using System.Collections;
using System.Data;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

/// <summary>
/// Summary description for clsObjetosBanco.
/// </summary>

namespace WaterSaving
{
    public class BancodeDados
    {
        static string cString;

        static SqlConnection cn;
        static SqlCommand cmd;
        static SqlDataAdapter da;
        static SqlDataReader dr;

        // Gera uma conexão conforme especificado no web.config
        public static SqlConnection AbrirConexao()
        {
            cString = ConfigurationManager.ConnectionStrings["WaterSaving"].ConnectionString;
            if (cn == null)
            {
                cn = new SqlConnection(cString);
                cn.Open();
            }
            else if (cn.State.Equals(ConnectionState.Closed))
            {
                BancodeDados.FecharConexao();
                cn = new SqlConnection(cString);
                cn.Open();
            }

            return cn;
        }


        public static void FecharConexao()
        {
            if (cn != null)
            {
                if (cn.State.Equals(ConnectionState.Open))
                {
                    cn.Close();
                }

                cn.Dispose();
            }
        }


        // Criação de todos os objetos de banco para um acesso simples e os interliga
        public static void CriarCommand(string SqlSql)
        {
            cn = AbrirConexao();
            cmd = new SqlCommand(SqlSql, cn);
        }

        // Devolve o objeto de conexão armazenado nesta instância
        public SqlConnection conexao
        {
            get { return (cn); }
        }

        // Devolve o objeto command armazenado nesta instância
        public SqlCommand command
        {
            get { return (cmd); }
        }

        // Devolve o objeto adapter armazenado nesta instância
        public SqlDataAdapter DataAdapter
        {
            get { return (da); }
        }

        // Devolve o objeto DataRedaer armazenado nesta instância
        public SqlDataReader DataReader
        {
            get { return (dr); }
        }

        // Cria um DataSet Genérico
        public static DataSet MontaDataSet(string SqlSql, string tabela)
        {
            try
            {
                AbrirConexao();
                DataSet ds = new DataSet();
                da = new SqlDataAdapter(SqlSql, cn);
                da.Fill(ds, tabela);
                return ds;
            }
            catch (Exception e)
            {
                throw new ApplicationException("Erro ao tentar obter dados." + e.Message.ToString());
            }
        }

        public SqlDataReader MontaDataReader(string SqlSql)
        {
            CriarCommand(SqlSql);
            dr = (SqlDataReader)cmd.ExecuteReader();
            return dr;
        }

        public static object ManterDados(string SqlSql)
        {
            CriarCommand(SqlSql);
            object retorno = cmd.ExecuteScalar();
            if (retorno == null)
                retorno = String.Empty;

            return retorno;
        }

        public int ObterValorInteiro(string SqlSql)
        {
            return Convert.ToInt32("0" + ManterDados(SqlSql));
        }

        public decimal ObterValorDecimal(string SqlSql)
        {
            return Convert.ToDecimal("0" + ManterDados(SqlSql));
        }

        public string ObterValorString(string SqlSql)
        {
            return ManterDados(SqlSql).ToString();
        }

        public int IncluirRegistro(string SqlSql)
        {
            return ObterValorInteiro(SqlSql);
        }


        public static int ExecutarNonQuery(string SqlSql)
        {
            int count = 0;
            try
            {
                CriarCommand(SqlSql);
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro ao tentar obter dados." + ex.Message.ToString());

            }
            return count;
        }

    }
}