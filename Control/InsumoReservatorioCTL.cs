using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace WaterSaving
{
    class InsumoReservatorioCTL
    {
        public int ManterInsumoReservatorio(EOperacao operacao, InsumoReservatorioDOM dados)
        {
            InsumoReservatorioDAO insumoReservatorioDAO = new InsumoReservatorioDAO();
            int codInsumo = 0;

            if (operacao.Equals(EOperacao.Incluir))
            {
                codInsumo = insumoReservatorioDAO.InserirInsumoReservatorio(dados);
            }
            else if (operacao.Equals(EOperacao.Alterar))
            {
                insumoReservatorioDAO.AlterarInsumoReservatorio(dados);
            }
            else if (operacao.Equals(EOperacao.Excluir))
            {
                insumoReservatorioDAO.ExcluirInsumoReservatorio(dados);
            }
            return codInsumo;
        }


        public DataSet ConsultarInsumoReservatorio()
        {
            InsumoReservatorioDAO insumoReservatorioDAO = new InsumoReservatorioDAO();
            return insumoReservatorioDAO.ConsultarInsumoReservatorio(0);
        }

    }
}
