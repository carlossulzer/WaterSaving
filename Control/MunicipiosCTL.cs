using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace WaterSaving
{
    class MunicipiosCTL
    {

        public DataSet ConsultarMunicipios()
        {
            MunicipiosDAO municipiosDAO = new MunicipiosDAO();
            return municipiosDAO.ConsultarMunicipios();
        }

    }
}
