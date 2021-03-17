using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace WaterSaving
{
    public class RelatoriosDAO
    {
        public DataSet RelatorioMunicipioAnoMes()
        { 

            StringBuilder sql = new StringBuilder();
            string[] meses = {"Janeiro", "Fevereiro", "Marco", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};

            sql.Append(" select distinct medicoes.ano, municipios.descmunicipio "); 
            
            for (int i = 0; i < 12; i++)
			{
                sql.Append(", (select ISNULL(sum(ISNULL(med.Precipitacao, 0)),0) from medicoes as med where med.codMunicipio = medicoes.codMunicipio and  med.Precipitacao > 0 and med.mes = " + i.ToString() + " and med.ano = Medicoes.ano) as " + meses[i]);


			    //sql.Append(", case (select count(med.mes) from medicoes as med where med.codMunicipio = medicoes.codMunicipio and ");
                //sql.Append(" med.Precipitacao > 0 and med.mes = "+(i+1)+" and med.ano = Medicoes.ano)  when 0 then ' ' else 'X' end as "+meses[i]);
			}

            sql.Append(" from medicoes, municipios ");
            sql.Append(" where medicoes.codmunicipio = municipios.codMunicipio ");
            sql.Append(" order by 2,1 ");
 

            return BancodeDados.MontaDataSet(sql.ToString(), "DSMunAnoMes");

        
        }




    }
}
