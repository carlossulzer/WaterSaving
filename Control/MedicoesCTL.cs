using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace WaterSaving
{
    class MedicoesCTL
    {
       
        public DataSet MesesdeMedicao(int ano)
        {
            MedicoesDAO medicoesDAO = new MedicoesDAO();
            return medicoesDAO.MesesdeMedicao(ano);
        }

        public DataSet AnodeMedicao(int codMicipio)
        {
            MedicoesDAO medicoesDAO = new MedicoesDAO();
            return medicoesDAO.AnodeMedicao(codMicipio);
        }

        public int ManterMedicoes(EOperacao operacao, MedicoesDOM dados)
        {
            MedicoesDAO medicoesDAO = new MedicoesDAO();
            int codMedicao = 0;

            if (operacao.Equals(EOperacao.Incluir))
            {
                codMedicao = medicoesDAO.InserirMedicoes(dados);
            }
            else if (operacao.Equals(EOperacao.Alterar))
            {
                medicoesDAO.AlterarMedicoes(dados);
            }
            else if (operacao.Equals(EOperacao.Excluir))
            {
                medicoesDAO.ExcluirMedicoes(dados);
            }
            return codMedicao;
        }


        public DataSet ConsultarMedicoes()
        {
            MedicoesDAO medicoesDAO = new MedicoesDAO();
            return medicoesDAO.ConsultarMedicoes(0);
        }

        public DataSet ConsultarPeriodoMedicao(int codMunicipio)
        {
            MedicoesDAO medicoesDAO = new MedicoesDAO();
            return medicoesDAO.ConsultarPeriodoMedicao(codMunicipio);
        }



    }
}
