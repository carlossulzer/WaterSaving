using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WaterSaving
{
    class CalculosCTL
    {

        public void ManterCalculos(EOperacao operacao, CalculosDOM dados)
        {
            CalculosDAO calculosDAO = new CalculosDAO();

            if (operacao.Equals(EOperacao.Incluir))
            {
                calculosDAO.InserirCalculos(dados);
            }
            else if (operacao.Equals(EOperacao.Excluir))
            {
                calculosDAO.ExcluirCalculos(dados);
            }
        }


        public CalculosDOM ConsultarCalculos()
        {
            CalculosDAO calculosDAO = new CalculosDAO();
            return calculosDAO.ConsultarCalculos(DadosProjetoDOM.CodProjeto);
        }


        public double CalcularCustodaAgua(double tamanhoReservatorio)
        {
            CalculosDAO calculosDAO = new CalculosDAO();
            return calculosDAO.CalcularCustodaAgua(tamanhoReservatorio);
        }
    }
   

}
