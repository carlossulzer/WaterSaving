using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace WaterSaving
{
    class ProjetosCTL
    {
        public Boolean VerificarProjeto(string nomeProjeto, int categoria)
        {
            if (string.IsNullOrEmpty(nomeProjeto))
                return false;

            ProjetosDAO projetosDAO = new ProjetosDAO();
            projetosDAO.VerificarProjeto(nomeProjeto, categoria);
            return (DadosProjetoDOM.CodProjeto > 0 ? true : false);
        }


        public Boolean CriarProjeto(string nomeProjeto, int categoria)
        {
            if (string.IsNullOrEmpty(nomeProjeto))
                return false;

            ProjetosDAO projetosDAO = new ProjetosDAO();
            projetosDAO.CriarProjeto(nomeProjeto, categoria);
            return true;
        }


        public DataSet ConsultarProjetos(int codProjeto)
        {
            ProjetosDAO projetosDAO = new ProjetosDAO();
            return projetosDAO.ConsultarProjeto(codProjeto);
        }


        public int ManterProjetos(EOperacao operacao, ProjetosDOM dados)
        {
            ProjetosDAO projetosDAO = new ProjetosDAO();
            int codProjeto = 0;

            if (operacao.Equals(EOperacao.Incluir))
            {
                codProjeto = projetosDAO.InserirProjetos(dados);
            }
            else if (operacao.Equals(EOperacao.Alterar))
            {
                projetosDAO.AlterarProjetos(dados);
            }
            else if (operacao.Equals(EOperacao.Excluir))
            {
                projetosDAO.ExcluirProjetos(dados);
            }
            return codProjeto;
        }


        public void Dados(string tipo)
        {
            ContasDAO contasDAO = new ContasDAO();
            contasDAO.Dados(tipo);
        }

        public void CarregarProjetosComboBox(ref ComboBox comboboxPreenchido)
        {
            ProjetosDAO projetosDAO = new ProjetosDAO();
            projetosDAO.CarregarProjetosComboBox(ref comboboxPreenchido);
        }

        public int ObterCategoriaProjeto(int codProjeto)
        {
            ProjetosDAO projetosDAO = new ProjetosDAO();
            return projetosDAO.ObterCategoriaProjeto(codProjeto);
        }
            


    }
}
