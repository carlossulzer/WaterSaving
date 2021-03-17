using System;
using System.Collections.Generic;
using System.Text;

namespace WaterSaving
{
    class TipoTelhadoDOM
    {

        private int codTipoTelhado;
        private string descTipoTelahado;
        private double coefRugosidade;

        public int CodTipoTelhado
        {
            get { return codTipoTelhado; }
            set { codTipoTelhado = value; }
        }

        public string DescTipoTelhado
        {
            get { return descTipoTelahado; }
            set { descTipoTelahado = value; }
        }

        public double CoefRugosidade
        {
            get { return coefRugosidade; }
            set { coefRugosidade = value; }
        }
    }
}
