using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace WaterSaving
{
    class TipoTelhadoCTL
    {
        public int ManterTipoTelhado(EOperacao operacao, TipoTelhadoDOM dados)
        {
            TipoTelhadoDAO tipoTelhadoDAO = new TipoTelhadoDAO();
            int codTipoTelhado = 0;

            if (operacao.Equals(EOperacao.Incluir))
            {
                codTipoTelhado = tipoTelhadoDAO.InserirTipoTelhado(dados);
            }
            else if (operacao.Equals(EOperacao.Alterar))
            {
                tipoTelhadoDAO.AlterarTipoTelhado(dados);
            }
            else if (operacao.Equals(EOperacao.Excluir))
            {
                tipoTelhadoDAO.ExcluirTipoTelhado(dados);
            }
            return codTipoTelhado;
        }


        public DataSet ConsultarTipoTelhado()
        {
            TipoTelhadoDAO tipoTelhadoDAO = new TipoTelhadoDAO();
            return tipoTelhadoDAO.ConsultarTipoTelhado(0);
        }

    }
}
