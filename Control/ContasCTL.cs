using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace WaterSaving
{
    class ContasCTL
    {
        public int ManterContas(EOperacao operacao, ContasDOM dados)
        {
            ContasDAO contasDAO = new ContasDAO();
            int codConta = 0;

            if (operacao.Equals(EOperacao.Incluir))
            {
                codConta = contasDAO.InserirContas(dados);
            }
            else if (operacao.Equals(EOperacao.Alterar))
            {
                contasDAO.AlterarContas(dados);
            }
            else if (operacao.Equals(EOperacao.Excluir))
            {
                contasDAO.ExcluirContas(dados);
            }
            return codConta;
        }


        public DataSet ConsultarContas()
        {
            ContasDAO contasDAO = new ContasDAO();
            return contasDAO.ConsultarContas(0, DadosProjetoDOM.CodProjeto);
        }


        public void Dados(string tipo)
        {
            ContasDAO contasDAO = new ContasDAO();
            contasDAO.Dados(tipo);
        }
    }
}
