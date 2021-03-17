using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace WaterSaving
{
    class TipoTelhadoDAO
    {
        public int InserirTipoTelhado(TipoTelhadoDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into tipoTelhado ");
            sql.Append(" (descTipotelhado, coefRugosidade )");
            sql.Append(" values (");
            sql.Append(FormatarString.Formatar(dados.DescTipoTelhado)+", ");
            sql.Append(FormatarString.Formatar(dados.CoefRugosidade));
            sql.Append(")");

            BancodeDados.ManterDados(sql.ToString());


            BancodeDados dadosBD = new BancodeDados();
            int codigo = dadosBD.ObterValorInteiro("SELECT @@IDENTITY");
            return codigo;
        }


        public DataSet ConsultarTipoTelhado(int codTipoTelhado)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" select codTipoTelhado, descTipoTelhado, coefRugosidade  ");
            sql.Append(" from TipoTelhado ");

            if (codTipoTelhado > 0)
            {
                sql.Append(" where codTipoTelhado = " + FormatarString.Formatar(codTipoTelhado));
            }
            return BancodeDados.MontaDataSet(sql.ToString(), "TipoTelhado");
        }

        public void AlterarTipoTelhado(TipoTelhadoDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update TipoTelhado set ");
            sql.Append(" descTipoTelhado = ");
            sql.Append(FormatarString.Formatar(dados.DescTipoTelhado)+", ");
            sql.Append(" coefRugosidade = ");
            sql.Append(FormatarString.Formatar(dados.CoefRugosidade));

            sql.Append(" where CodTipoTelhado = " + dados.CodTipoTelhado.ToString());

            BancodeDados.ManterDados(sql.ToString());
        }

        public void ExcluirTipoTelhado(TipoTelhadoDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from TipoTelhado ");
            sql.Append(" where CodTipoTelhado = " + dados.CodTipoTelhado.ToString());

            BancodeDados.ManterDados(sql.ToString());
        }

    }
}
