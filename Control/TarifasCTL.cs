using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace WaterSaving
{
    class TarifasCTL
    {
        public int ManterTarifas(EOperacao operacao, TarifasDOM dados)
        {
            TarifasDAO tarifasDAO = new TarifasDAO();
            int codTarifa = 0;

            if (operacao.Equals(EOperacao.Incluir))
            {
                codTarifa = tarifasDAO.InserirTarifas(dados);
            }
            else if (operacao.Equals(EOperacao.Alterar))
            {
                tarifasDAO.AlterarTarifas(dados);
            }
            else if (operacao.Equals(EOperacao.Excluir))
            {
                tarifasDAO.ExcluirTarifas(dados);
            }
            return codTarifa;
        }

        public DataSet ConsultarTarifas()
        {
            TarifasDAO tarifasDAO = new TarifasDAO();
            return tarifasDAO.ConsultarTarifas(0);
        }


        public void CarregarConsumo1(ref ComboBox comboboxPreenchido)
        {
            TarifasDAO tarifasDAO = new TarifasDAO();
            tarifasDAO.CarregarConsumo1(ref comboboxPreenchido);
        }

        public void CarregarConsumo2(ref ComboBox comboboxPreenchido)
        {
            TarifasDAO tarifasDAO = new TarifasDAO();
            tarifasDAO.CarregarConsumo2(ref comboboxPreenchido);
        }

    }
}
