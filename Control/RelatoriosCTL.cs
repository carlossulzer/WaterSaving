using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WaterSaving
{
    class RelatoriosCTL
    {
        public DataSet RelatorioMunicipioAnoMes()
        {
            RelatoriosDAO relatorio = new RelatoriosDAO();
            return relatorio.RelatorioMunicipioAnoMes();
        }
    }
}
