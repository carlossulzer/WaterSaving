using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WaterSaving
{
    class GraficosDAO
    {
        public static DataSet DadosdoMunicipioAno(int codMunicipio, int ano)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("select ");
            sql.Append("   (case ");
            sql.Append("     when mes=1 then 'Jan' ");
            sql.Append("     when mes=2 then 'Fev' ");
            sql.Append("     when mes=3 then 'Mar' ");
            sql.Append("     when mes=4 then 'Abr' ");
            sql.Append("     when mes=5 then 'Mai' ");
            sql.Append("     when mes=6 then 'Jun' ");
            sql.Append("     when mes=7 then 'Jul' ");
            sql.Append("     when mes=8 then 'Ago' ");
            sql.Append("     when mes=9 then 'Set' ");
            sql.Append("     when mes=10 then 'Out' ");
            sql.Append("     when mes=11 then 'Nov' ");
            sql.Append("     when mes=12 then 'Dez' ");
            sql.Append("   end) as mes, ");            
            sql.Append("chuvaTotal ");
            sql.Append("from medicoes ");
            sql.Append("where codMunicipio = " + codMunicipio.ToString() + " and ");
            sql.Append("      Year(data) = " + ano.ToString());
            sql.Append(" order by mes");
            return BancodeDados.MontaDataSet(sql.ToString(), "medicoes");
        }


        public static SqlDataReader DadosdoMunicipioAnoReader(int codMunicipio, int ano)
        {
            BancodeDados dados = new BancodeDados();

            StringBuilder sql = new StringBuilder();

            sql.Append("select ");
            sql.Append("   (case ");
            sql.Append("     when mes=1 then 'Janeiro' ");
            sql.Append("     when mes=2 then 'Fevereiro' ");
            sql.Append("     when mes=3 then 'Março' ");
            sql.Append("     when mes=4 then 'Abril' ");
            sql.Append("     when mes=5 then 'Maio' ");
            sql.Append("     when mes=6 then 'Junho' ");
            sql.Append("     when mes=7 then 'Julho' ");
            sql.Append("     when mes=8 then 'Agosto' ");
            sql.Append("     when mes=9 then 'Setembro' ");
            sql.Append("     when mes=10 then 'Outubro' ");
            sql.Append("     when mes=11 then 'Novembro' ");
            sql.Append("     when mes=12 then 'Dezembro' ");
            sql.Append("   end) as mes, ");            
            sql.Append("sum(precipitacao) as precipitacao ");
            sql.Append("from medicoes ");
            sql.Append("where codMunicipio = " + codMunicipio.ToString() + " and ");
            sql.Append("      Year(data) = " + ano.ToString());
            sql.Append(" group by mes ");
            sql.Append(" order by mes ");
            return dados.MontaDataReader(sql.ToString());
        }
       

    }
}
