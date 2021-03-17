using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace WaterSaving
{
    class MunicipiosDAO
    {
      
        public DataSet ConsultarMunicipios()
        {
            StringBuilder sql = new StringBuilder();

            
            sql.Append("select codMunicipio, DescMunicipio ");
            sql.Append("from municipios ");
            sql.Append("union ");
            sql.Append("select -1, ' SELECIONE O MUNICÍPIO' ");
            sql.Append("order by 2 ");


            return BancodeDados.MontaDataSet(sql.ToString(), "municipios");
        }

    }
}
