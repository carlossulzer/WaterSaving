using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace WaterSaving
{
    public class EstimativaCTL
    {
        public ArrayList CalcularEstimativa(int codMedicao, double areaCaptacao, double demandaMensal, double tamanhoReservatorio, ref double totalChuvaMensal)
        {
            EstimativaDAO estimativaDAO = new EstimativaDAO();
            return estimativaDAO.CalcularEstimativa(codMedicao, areaCaptacao, demandaMensal, tamanhoReservatorio, ref totalChuvaMensal);
        }

        public double ValordoReservatorio(double tamanhoReservatorio)
        {
            EstimativaDAO estimativaDAO = new EstimativaDAO();
            return estimativaDAO.ValordoReservatorio(tamanhoReservatorio);
        }

        public double ViabilidadeEconomica(double totalChuvaMensal, double demandaMensal, double custoM3Agua, int codProjeto)
        {
            EstimativaDAO estimativaDAO = new EstimativaDAO();
            return estimativaDAO.ViabilidadeEconomica(totalChuvaMensal, demandaMensal, custoM3Agua, codProjeto);
        }


        public void DemandaCalculada(ref double demandaCalculada, ref double valorConsumoCalculado, int codProjeto)
        {
            EstimativaDAO estimativaDAO = new EstimativaDAO();
            estimativaDAO.DemandaCalculada(ref demandaCalculada, ref valorConsumoCalculado, codProjeto);
        }


    }
}
