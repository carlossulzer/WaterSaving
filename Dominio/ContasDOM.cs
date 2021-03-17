using System;
using System.Collections.Generic;
using System.Text;

namespace WaterSaving
{
    class ContasDOM
    {
        private int codProjeto;
        private int codConta;
        private int mes;
        private int ano;
        private double consumo;
        private double valor;

        public int CodProjeto
        {
            get { return codProjeto; }
            set { codProjeto = value; }
        }

        public int CodConta
        {
            get { return codConta; }
            set { codConta = value; }
        }
	
        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public double Consumo
        {
            get { return consumo; }
            set { consumo = value; }
        }


        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
	

	
    }
}
