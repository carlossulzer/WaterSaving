using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace WaterSaving
{
    class MedicoesDAO
    {

        public DataSet MesesdeMedicao(int ano)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("select distinct Month(data) as mes,  ");
            sql.Append("   (case ");
            sql.Append("     when mes=1 then 'Janeiro' ");
            sql.Append("     when mes=2 then 'Fevereiro' ");
            sql.Append("     when mes=3 then 'Março' ");
            sql.Append("     when mes=4 then 'Abril' ");
            sql.Append("     when mes=5 then 'Maio' ");
            sql.Append("     when mes=6 then 'Junho' ");
            sql.Append("     when mes=7 then 'Julho' ");
            sql.Append("     when mes=8 then 'Agosto' ");
            sql.Append("     when mes=9 then 'Setembro' ");
            sql.Append("     when mes=10 then 'Outubro' ");
            sql.Append("     when mes=11 then 'Novembro' ");
            sql.Append("     when mes=12 then 'Dezembro' ");
            sql.Append("   end) as Descricao ");
            sql.Append("from medicoes ");
            sql.Append("where Year(data) = "+ano.ToString());
            sql.Append(" order by 1");

            return BancodeDados.MontaDataSet(sql.ToString(), "medicoes");
        }

        public DataSet AnodeMedicao(int codMunicipio)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" select distinct Year(data) as ano ");
            sql.Append(" from medicoes ");
            if (codMunicipio > 0)
                sql.Append("where codMunicipio = " + codMunicipio.ToString());
            sql.Append(" order by 1 ");

            return BancodeDados.MontaDataSet(sql.ToString(), "medicoes");
        }

        //------------------------------------------------------------------------------------

        public int InserirMedicoes(MedicoesDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into medicoes ");
            sql.Append(" (codMunicipio, AnoInicial, AnoFinal, Janeiro, Fevereiro, Marco, Abril, Maio, Junho, Julho, ");
            sql.Append(" Agosto, Setembro, Outubro, Novembro, Dezembro)");
            sql.Append(" values (");
            sql.Append(FormatarString.Formatar(dados.CodMunicipio) + ", ");
            sql.Append(FormatarString.Formatar(dados.AnoInicial) + ", ");
            sql.Append(FormatarString.Formatar(dados.AnoFinal) + ", ");
            sql.Append(FormatarString.Formatar(dados.Janeiro) + ", ");
            sql.Append(FormatarString.Formatar(dados.Fevereiro) + ", ");
            sql.Append(FormatarString.Formatar(dados.Marco) + ", ");
            sql.Append(FormatarString.Formatar(dados.Abril) + ", ");
            sql.Append(FormatarString.Formatar(dados.Maio) + ", ");
            sql.Append(FormatarString.Formatar(dados.Junho) + ", ");
            sql.Append(FormatarString.Formatar(dados.Julho) + ", ");
            sql.Append(FormatarString.Formatar(dados.Agosto) + ", ");
            sql.Append(FormatarString.Formatar(dados.Setembro) + ", ");
            sql.Append(FormatarString.Formatar(dados.Outubro) + ", ");
            sql.Append(FormatarString.Formatar(dados.Novembro) + ", ");
            sql.Append(FormatarString.Formatar(dados.Dezembro));
            sql.Append(")");

            BancodeDados.ManterDados(sql.ToString());


            BancodeDados dadosBD = new BancodeDados();
            int codigo = dadosBD.ObterValorInteiro("SELECT @@IDENTITY");
            return codigo;
        }


        public DataSet ConsultarMedicoes(int codMedicao)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" select me.codMedicao, me.codMunicipio, me.AnoInicial, me.AnoFinal, me.Janeiro, me.Fevereiro, ");
            sql.Append(" me.Marco, me.Abril, me.Maio, me.Junho, me.Julho, ");
            sql.Append(" me.Agosto, me.Setembro, me.Outubro, me.Novembro, me.Dezembro, ");
            sql.Append(" mu.DescMunicipio ");
            sql.Append(" from medicoes me, municipios mu ");
            sql.Append(" where me.codMunicipio = mu.codMunicipio ");

            if (codMedicao > 0)
            {
                sql.Append(" and  medicoes.codMedicao = " + FormatarString.Formatar(codMedicao));
            }
            sql.Append(" order by mu.DescMunicipio, me.AnoInicial, me.AnoFinal ");
            return BancodeDados.MontaDataSet(sql.ToString(), "Medicoes");
        }

        public void AlterarMedicoes(MedicoesDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update medicoes set ");
            sql.Append(" codMunicipio = ");
            sql.Append(FormatarString.Formatar(dados.CodMunicipio) + ", ");

            sql.Append(" AnoInicial = ");
            sql.Append(FormatarString.Formatar(dados.AnoInicial) + ", ");
            sql.Append(" AnoFinal = ");
            sql.Append(FormatarString.Formatar(dados.AnoFinal) + ", ");
            sql.Append(" Janeiro = ");
            sql.Append(FormatarString.Formatar(dados.Janeiro) + ", ");
            sql.Append(" Fevereiro = ");
            sql.Append(FormatarString.Formatar(dados.Fevereiro) + ", ");
            sql.Append(" Marco = ");
            sql.Append(FormatarString.Formatar(dados.Marco) + ", ");
            sql.Append(" Abril = ");
            sql.Append(FormatarString.Formatar(dados.Abril) + ", ");
            sql.Append(" Maio = ");
            sql.Append(FormatarString.Formatar(dados.Maio) + ", ");
            sql.Append(" Junho = ");
            sql.Append(FormatarString.Formatar(dados.Junho) + ", ");
            sql.Append(" Julho = ");
            sql.Append(FormatarString.Formatar(dados.Julho) + ", ");
            sql.Append(" Agosto = ");
            sql.Append(FormatarString.Formatar(dados.Agosto) + ", ");
            sql.Append(" Setembro = ");
            sql.Append(FormatarString.Formatar(dados.Setembro) + ", ");
            sql.Append(" Outubro = ");
            sql.Append(FormatarString.Formatar(dados.Outubro) + ", ");
            sql.Append(" Novembro = ");
            sql.Append(FormatarString.Formatar(dados.Novembro) + ", ");
            sql.Append(" Dezembro = ");
            sql.Append(FormatarString.Formatar(dados.Dezembro));

            sql.Append(" where CodMedicao = " + dados.CodMedicao.ToString());

            BancodeDados.ManterDados(sql.ToString());
        }

        public void ExcluirMedicoes(MedicoesDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from Medicoes ");
            sql.Append(" where CodMedicao = " + dados.CodMedicao.ToString());

            BancodeDados.ManterDados(sql.ToString());
        }


        public DataSet ConsultarPeriodoMedicao(int codMunicipio)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" select CodMedicao, cast(AnoInicial as nvarchar(4))+' a '+cast(AnoFinal as nvarchar(4)) as Periodo ");
            sql.Append(" from medicoes ");
            sql.Append(" where CodMunicipio = " + codMunicipio.ToString());
            sql.Append("UNION ");
            sql.Append("select -1, ' SELECIONE O PERÍODO' ");
            sql.Append("order by 2 ");

            return BancodeDados.MontaDataSet(sql.ToString(), "medicoes");
        }


    }
}
