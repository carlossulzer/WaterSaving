using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace WaterSaving
{
    class InsumoReservatorioDAO
    {
        public int InserirInsumoReservatorio(InsumoReservatorioDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into insumoReservatorio ");
            sql.Append(" (Descricao, Quantidade, PrecoUnitario, Unico )");
            sql.Append(" values (");
            sql.Append(FormatarString.Formatar(dados.Descricao)+", ");
            sql.Append(FormatarString.Formatar(dados.Quantidade) + ", ");
            sql.Append(FormatarString.Formatar(dados.PrecoUnitario) + ", ");
            sql.Append(FormatarString.Formatar(dados.Unico));
            sql.Append(")");

            BancodeDados.ManterDados(sql.ToString());


            BancodeDados dadosBD = new BancodeDados();
            int codigo = dadosBD.ObterValorInteiro("SELECT @@IDENTITY");
            return codigo;
        }


        public DataSet ConsultarInsumoReservatorio(int codInsumo)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" select CodInsumo, Descricao, Quantidade, PrecoUnitario, Unico  ");
            sql.Append(" from insumoReservatorio ");

            if (codInsumo > 0)
            {
                sql.Append(" where CodInsumo = " + FormatarString.Formatar(codInsumo));
            }
            return BancodeDados.MontaDataSet(sql.ToString(), "insumoReservatorio");
        }

        public void AlterarInsumoReservatorio(InsumoReservatorioDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update insumoReservatorio set ");
            sql.Append(" Descricao = ");
            sql.Append(FormatarString.Formatar(dados.Descricao)+", ");
            sql.Append(" Quantidade = ");
            sql.Append(FormatarString.Formatar(dados.Quantidade) + ", ");
            sql.Append(" PrecoUnitario = ");
            sql.Append(FormatarString.Formatar(dados.PrecoUnitario) + ", ");
            sql.Append(" Unico = ");
            sql.Append(FormatarString.Formatar(dados.Unico));


            sql.Append(" where CodInsumo = " + dados.CodInsumo.ToString());

            BancodeDados.ManterDados(sql.ToString());
        }

        public void ExcluirInsumoReservatorio(InsumoReservatorioDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from insumoReservatorio ");
            sql.Append(" where CodInsumo = " + dados.CodInsumo.ToString());

            BancodeDados.ManterDados(sql.ToString());
        }

    }
}
