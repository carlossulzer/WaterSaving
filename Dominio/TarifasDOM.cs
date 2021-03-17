using System;
using System.Collections.Generic;
using System.Text;

namespace WaterSaving
{
    class TarifasDOM
    {
        private int codMunicipio;
        private int codTarifa;
        private int consumo1;
        private int metros1;
        private int consumo2;
        private int metros2;
        private double valorAgua;
        private double valorEsgoto;
        private int categoria;


        public int CodTarifa
        {
            get { return codTarifa; }
            set { codTarifa = value; }
        }

        public int CodMunicipio
        {
            get { return codMunicipio; }
            set { codMunicipio = value; }
        }

        public int Consumo1
        {
            get { return consumo1; }
            set { consumo1 = value; }
        }

        public int Metros1
        {
            get { return metros1; }
            set { metros1 = value; }
        }

        public int Consumo2
        {
            get { return consumo2; }
            set { consumo2 = value; }
        }

        public int Metros2
        {
            get { return metros2; }
            set { metros2 = value; }
        }        

        public double ValorAgua
        {
            get { return valorAgua; }
            set { valorAgua = value; }
        }

        public double ValorEsgoto
        {
            get { return valorEsgoto; }
            set { valorEsgoto = value; }
        }

        public int Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
	
    }
}
