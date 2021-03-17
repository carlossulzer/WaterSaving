using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace WaterSaving
{
    class CalculosDAO
    {
      
        public void InserirCalculos(CalculosDOM dados)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("Select codProjeto from calculos where CodProjeto = "+dados.CodProjeto.ToString());

            BancodeDados projetoExiste = new BancodeDados();
            int codigo = projetoExiste.ObterValorInteiro(sql.ToString());

            if (codigo.Equals(0)) // se não existir, inclui o cálculo
            {
                sql.Remove(0, sql.Length);
                sql.Append("insert into calculos ");
                sql.Append(" (CodProjeto, CodMunicipio, CodMedicao, CustoM3Agua, AreaCaptacao, ");
                sql.Append(" DemandaMensal, CotacaoDollar, VolReservatorio, ");
                sql.Append(" EconomiaAnual, DespesaAnual, TaxaAtratividade, AnosRetorno)");
                sql.Append(" values (");
                sql.Append(FormatarString.Formatar(dados.CodProjeto) + ", ");
                sql.Append(FormatarString.Formatar(dados.CodMunicipio) + ", ");
                sql.Append(FormatarString.Formatar(dados.CodMedicao) + ", ");
                sql.Append(FormatarString.Formatar(dados.CustoM3Agua) + ", ");
                sql.Append(FormatarString.Formatar(dados.AreaCaptacao) + ", ");
                sql.Append(FormatarString.Formatar(dados.DemandaMensal) + ", ");
                sql.Append(FormatarString.Formatar(dados.CotacaoDollar) + ", ");
                sql.Append(FormatarString.Formatar(dados.VolReservatorio) + ", ");
                sql.Append(FormatarString.Formatar(dados.EconomiaAnual) + ", ");
                sql.Append(FormatarString.Formatar(dados.DespesaAnual) + ", ");
                sql.Append(FormatarString.Formatar(dados.TaxaAtratividade) + ", ");
                sql.Append(FormatarString.Formatar(dados.AnosRetorno));
                sql.Append(")");

                BancodeDados.ManterDados(sql.ToString());
            }
            else // se já existir altera os cálculos
            {
                sql.Remove(0, sql.Length);
                sql.Append("update calculos set ");
                sql.Append(" CodMunicipio = ");
                sql.Append(FormatarString.Formatar(dados.CodMunicipio) + ", ");
                sql.Append(" CodMedicao = ");
                sql.Append(FormatarString.Formatar(dados.CodMedicao) + ", ");
                sql.Append(" CustoM3Agua = ");
                sql.Append(FormatarString.Formatar(dados.CustoM3Agua) + ", ");
                sql.Append(" AreaCaptacao = ");
                sql.Append(FormatarString.Formatar(dados.AreaCaptacao) + ", ");
                sql.Append(" DemandaMensal = ");
                sql.Append(FormatarString.Formatar(dados.DemandaMensal) + ", ");
                sql.Append(" CotacaoDollar = ");
                sql.Append(FormatarString.Formatar(dados.CotacaoDollar) + ", ");
                sql.Append(" VolReservatorio = ");
                sql.Append(FormatarString.Formatar(dados.VolReservatorio) + ", ");
                sql.Append(" EconomiaAnual = ");
                sql.Append(FormatarString.Formatar(dados.EconomiaAnual) + ", ");
                sql.Append(" DespesaAnual = ");
                sql.Append(FormatarString.Formatar(dados.DespesaAnual) + ", ");
                sql.Append(" TaxaAtratividade = ");
                sql.Append(FormatarString.Formatar(dados.TaxaAtratividade) + ", ");
                sql.Append(" AnosRetorno = ");
                sql.Append(FormatarString.Formatar(dados.AnosRetorno));
                sql.Append(" where CodProjeto = " + dados.CodProjeto.ToString());

                BancodeDados.ManterDados(sql.ToString());            

            }
        }


        public CalculosDOM ConsultarCalculos(int codProjeto)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" Select CodProjeto, CodMunicipio, CodMedicao, CustoM3Agua, AreaCaptacao, ");
            sql.Append(" DemandaMensal, CotacaoDollar, VolReservatorio, ");
            sql.Append(" EconomiaAnual, DespesaAnual, TaxaAtratividade, AnosRetorno ");
            sql.Append(" from calculos ");

            if (codProjeto > 0)
            {
                sql.Append(" where CodProjeto = " + FormatarString.Formatar(codProjeto));
            }

            CalculosDOM calculosDOM = new CalculosDOM();
            DataSet dsDados = BancodeDados.MontaDataSet(sql.ToString(), "calculos");
            if (dsDados.Tables[0].Rows.Count > 0)
            {

                calculosDOM.CodProjeto = DadosProjetoDOM.CodProjeto;
                calculosDOM.CodMunicipio = Conversor.ConverterParaInteiro(dsDados.Tables[0].Rows[0]["CodMunicipio"].ToString());
                calculosDOM.CodMedicao = Conversor.ConverterParaInteiro(dsDados.Tables[0].Rows[0]["CodMedicao"].ToString());
                calculosDOM.CustoM3Agua = Conversor.ConverterParaDouble(dsDados.Tables[0].Rows[0]["CustoM3Agua"].ToString());
                calculosDOM.AreaCaptacao = Conversor.ConverterParaDouble(dsDados.Tables[0].Rows[0]["AreaCaptacao"].ToString());
                calculosDOM.DemandaMensal = Conversor.ConverterParaDouble(dsDados.Tables[0].Rows[0]["DemandaMensal"].ToString());
                calculosDOM.CotacaoDollar = Conversor.ConverterParaDouble(dsDados.Tables[0].Rows[0]["CotacaoDollar"].ToString());
                calculosDOM.VolReservatorio = Conversor.ConverterParaDouble(dsDados.Tables[0].Rows[0]["VolReservatorio"].ToString());
                calculosDOM.EconomiaAnual = Conversor.ConverterParaDouble(dsDados.Tables[0].Rows[0]["EconomiaAnual"].ToString());
                calculosDOM.DespesaAnual = Conversor.ConverterParaDouble(dsDados.Tables[0].Rows[0]["DespesaAnual"].ToString());
                calculosDOM.TaxaAtratividade = Conversor.ConverterParaDouble(dsDados.Tables[0].Rows[0]["TaxaAtratividade"].ToString());
                calculosDOM.AnosRetorno = Conversor.ConverterParaInteiro(dsDados.Tables[0].Rows[0]["AnosRetorno"].ToString());

            }

            return calculosDOM;
        }

        public void ExcluirCalculos(CalculosDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from calculos ");
            sql.Append(" where CodProjeto = " + dados.CodProjeto.ToString());

            BancodeDados.ManterDados(sql.ToString());
        }


        public double CalcularCustodaAgua(double tamanhoReservatorio)
        {

            double valorAgua = 0;
            StringBuilder sql = new StringBuilder();
            sql.Append("select (ValorAgua+ValorEsgoto) as valorAgua from tarifas where Categoria = " + DadosProjetoDOM.Categoria.ToString());
            sql.Append(" and Consumo1 = 1 and Metros1 <= " + tamanhoReservatorio.ToString());

            BancodeDados dados = new BancodeDados();
            valorAgua = (double)dados.ObterValorDecimal(sql.ToString());

            if (valorAgua <= 0)
            {
                sql.Append("select (ValorAgua+ValorEsgoto) as valorAgua from tarifas where Categoria = " + DadosProjetoDOM.Categoria.ToString());
                sql.Append(" and Consumo1 = 2 and Metros1 <= " + tamanhoReservatorio.ToString());
                sql.Append(" and Metros2 >= " + tamanhoReservatorio.ToString());
                valorAgua = (double)dados.ObterValorDecimal(sql.ToString());
                if (valorAgua <= 0)
                {
                    sql.Append("select (ValorAgua+ValorEsgoto) as valorAgua from tarifas where Categoria = " + DadosProjetoDOM.Categoria.ToString());
                    sql.Append(" and Consumo1 = 3 and Metros1 > " + tamanhoReservatorio.ToString());
                    valorAgua = (double)dados.ObterValorDecimal(sql.ToString());
                }
            }
            return valorAgua;
        }

    }
}
