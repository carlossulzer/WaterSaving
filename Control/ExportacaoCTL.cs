using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterSaving
{
    class ExportacaoCTL
    {
        public string Medicoes()
        {
            ExportacaoDAO exportacaoDAO = new ExportacaoDAO();
            return exportacaoDAO.Medicoes();
        }

        public string DesvioPadrao()
        {
            ExportacaoDAO exportacaoDAO = new ExportacaoDAO();
            return exportacaoDAO.DesvioPadrao();
        }

        public string Medias()
        {
            ExportacaoDAO exportacaoDAO = new ExportacaoDAO();
            return exportacaoDAO.Medias();
        }

    }
}
