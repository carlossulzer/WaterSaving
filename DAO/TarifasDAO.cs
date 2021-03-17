using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace WaterSaving
{
    class TarifasDAO
    {
        public int InserirTarifas(TarifasDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into tarifas ");
            sql.Append(" (CodMunicipio, Categoria, Consumo1, Metros1, Consumo2, Metros2, ValorAgua, ValorEsgoto )");
            sql.Append(" values (");
            sql.Append(FormatarString.Formatar(dados.CodMunicipio) + ", ");
            sql.Append(FormatarString.Formatar(dados.Categoria) + ", ");
            sql.Append(FormatarString.Formatar(dados.Consumo1) + ", ");
            sql.Append(FormatarString.Formatar(dados.Metros1)+", ");
            sql.Append(FormatarString.Formatar(dados.Consumo2) + ", ");
            sql.Append(FormatarString.Formatar(dados.Metros2) + ", ");
            sql.Append(FormatarString.Formatar(dados.ValorAgua) + ", ");
            sql.Append(FormatarString.Formatar(dados.ValorEsgoto));
            sql.Append(")");

            BancodeDados.ManterDados(sql.ToString());


            BancodeDados dadosBD = new BancodeDados();
            int codigo = dadosBD.ObterValorInteiro("SELECT @@IDENTITY");
            return codigo;
        }


        public DataSet ConsultarTarifas(int codTarifa)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" SELECT t.codmunicipio ");
            sql.Append("       ,t.codtarifa ");
            sql.Append("       , t.categoria ");
            sql.Append("       , t.descCategoria ");
            sql.Append("       , t.consumo1 ");
            sql.Append("       , t.descConsumo1 ");
            sql.Append("       , t.metros1 ");
            sql.Append("       , t.consumo2 ");
            sql.Append("       , t.descConsumo2 ");
            sql.Append("       , t.metros2 ");
            sql.Append("       ,(case when t.consumo2 > 0 then ");   
            sql.Append("            t.descConsumo1+' '+cast(t.metros1 as varchar(5))+' '+t.descConsumo2+' '+cast(t.metros2 as varchar(5))  ");
            sql.Append("         else ");  
            sql.Append("            t.descConsumo1+' '+cast(t.metros1  as varchar(5)) "); 
            sql.Append("         end) as descricao  ");
            sql.Append("       , t.valorAgua");
            sql.Append("       , t.valorEsgoto");
            sql.Append("       , t.DescMunicipio");
            sql.Append(" FROM (select tarifas.CodMunicipio ");
            sql.Append("        , codTarifa ");
            sql.Append("        , categoria ");
            sql.Append("        , (case when Categoria = 1 then 'RESIDENCIAL' ");
            sql.Append("                when Categoria = 2 then 'COMERCIAL' ");
            sql.Append("                when Categoria = 3 then 'INDUSTRIAL' ");
            sql.Append("                else 'PÚBLICA' ");
            sql.Append("           end) descCategoria ");
            sql.Append("        , Consumo1 "); 
            sql.Append("        , (case when Consumo1 = 1 then 'ATÉ' ");
            sql.Append("                when Consumo1 = 2 then 'ENTRE' ");
            sql.Append("                else 'ACIMA DE' ");
            sql.Append("           end) descConsumo1 "); 
            sql.Append("        , Metros1 ");
            sql.Append("        , Consumo2 "); 
            sql.Append("        , (case when Consumo2 = 1 then 'ATÉ' ");
            sql.Append("                when Consumo2 = 2 then 'E' ");
            sql.Append("                else '' ");
            sql.Append("           end) descConsumo2 ");    
            sql.Append("        , Metros2 ");
            sql.Append("        , ValorAgua ");
            sql.Append("        , ValorEsgoto ");
            sql.Append("        , DescMunicipio ");
            sql.Append("      from tarifas, municipios");
            sql.Append("      where tarifas.codmunicipio = municipios.codmunicipio ) t ");


            if (codTarifa > 0)
            {
                sql.Append(" where CodTarifa = " + FormatarString.Formatar(codTarifa));
            }
            return BancodeDados.MontaDataSet(sql.ToString(), "tarifas");
        }

        public void AlterarTarifas(TarifasDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update tarifas set ");
            sql.Append(" CodMunicipio = ");
            sql.Append(FormatarString.Formatar(dados.CodMunicipio) + ", ");
            sql.Append(" Categoria = ");
            sql.Append(FormatarString.Formatar(dados.Categoria) + ", ");
            sql.Append(" Consumo1 = ");
            sql.Append(FormatarString.Formatar(dados.Consumo1) + ", ");
            sql.Append(" Metros1 = ");
            sql.Append(FormatarString.Formatar(dados.Metros1) + ", ");
            sql.Append(" Consumo2 = ");
            sql.Append(FormatarString.Formatar(dados.Consumo2) + ", ");
            sql.Append(" Metros2 = ");
            sql.Append(FormatarString.Formatar(dados.Metros2) + ", ");
            sql.Append(" ValorAgua = ");
            sql.Append(FormatarString.Formatar(dados.ValorAgua) + ", ");
            sql.Append(" ValorEsgoto = ");
            sql.Append(FormatarString.Formatar(dados.ValorEsgoto));

            sql.Append(" where CodTarifa = " + dados.CodTarifa.ToString());

            BancodeDados.ManterDados(sql.ToString());
        }

        public void ExcluirTarifas(TarifasDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from tarifas ");
            sql.Append(" where CodTarifa = " + dados.CodTarifa.ToString());

            BancodeDados.ManterDados(sql.ToString());
        }

        public void CarregarConsumo1(ref ComboBox comboboxPreenchido)
        {
            CarregarDropDown dropCarregar = new CarregarDropDown();
            dropCarregar.PopularEnumeracao(ref comboboxPreenchido, typeof(EConsumo1), "", "-1");

        }

        public void CarregarConsumo2(ref ComboBox comboboxPreenchido)
        {
            CarregarDropDown dropCarregar = new CarregarDropDown();
            dropCarregar.PopularEnumeracao(ref comboboxPreenchido, typeof(EConsumo2), "", "-1");

        }
    }
}
