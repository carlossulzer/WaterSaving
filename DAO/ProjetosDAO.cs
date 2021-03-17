using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace WaterSaving
{
    class ProjetosDAO
    {
        public void VerificarProjeto(string nomeProjeto, int categoria)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" Select codProjeto, NomeProjeto, DataProjeto, Categoria, ");
            sql.Append("  (case when Categoria = 1 then 'RESIDENCIAL' ");
            sql.Append("        when Categoria = 2 then 'COMERCIAL' ");
            sql.Append("        when Categoria = 3 then 'INDUSTRIAL' ");
            sql.Append("        else 'PÚBLICA' ");
            sql.Append("   end) desccategoria ");
            sql.Append(" from projetos ");
            sql.Append(" where NomeProjeto = " + FormatarString.Formatar(nomeProjeto));
            sql.Append("       and categoria = "+categoria.ToString());
            DataSet dsDados = BancodeDados.MontaDataSet(sql.ToString(), "projetos");

            if (dsDados.Tables[0].Rows.Count > 0)
            {
                DadosProjetoDOM.CodProjeto = Conversor.ConverterParaInteiro(dsDados.Tables[0].Rows[0]["CodProjeto"].ToString());
                DadosProjetoDOM.NomeProjeto = dsDados.Tables[0].Rows[0]["NomeProjeto"].ToString(); 
                DadosProjetoDOM.DataProjeto = Conversor.ConverterParaDateTime(dsDados.Tables[0].Rows[0]["DataProjeto"].ToString());
                DadosProjetoDOM.Categoria =  Conversor.ConverterParaInteiro(dsDados.Tables[0].Rows[0]["Categoria"].ToString());            

            }

        }


        public void CriarProjeto(string nomeProjeto, int categoria)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("insert into projetos(nomeProjeto, dataProjeto, categoria) values(");
            sql.Append(FormatarString.Formatar(nomeProjeto) + ", ");
            sql.Append(FormatarString.Formatar(DateTime.Now.Date) + ", ");
            sql.Append(FormatarString.Formatar(categoria) + ")");
            BancodeDados.ExecutarNonQuery(sql.ToString());

            VerificarProjeto(nomeProjeto, categoria);
        }

        public DataSet ConsultarProjeto(int codProjeto)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("Select codProjeto, NomeProjeto, DataProjeto, categoria, ");
            sql.Append(" (case when Categoria = 1 then 'RESIDENCIAL' ");
            sql.Append("       when Categoria = 2 then 'COMERCIAL' ");
            sql.Append("       when Categoria = 3 then 'INDUSTRIAL' ");
            sql.Append("       else 'PÚBLICA' ");
            sql.Append("   end) descCategoria ");
            sql.Append(" from projetos ");
            if (codProjeto > 0)
                sql.Append(" where CodProjeto = " + FormatarString.Formatar(codProjeto));
            return BancodeDados.MontaDataSet(sql.ToString(), "projetos");
        }


        public int InserirProjetos(ProjetosDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into projetos(nomeProjeto, dataProjeto, categoria) values(");
            sql.Append(FormatarString.Formatar(dados.NomeProjeto) + ", ");
            sql.Append(FormatarString.Formatar(dados.DataProjeto) + ", ");
            sql.Append(FormatarString.Formatar(dados.Categoria) + ")");
            BancodeDados.ExecutarNonQuery(sql.ToString());

            BancodeDados dadosBD = new BancodeDados();
            int codigo = dadosBD.ObterValorInteiro("SELECT @@IDENTITY");
            return codigo;
        }


        
        public void AlterarProjetos(ProjetosDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update projetos set ");
            sql.Append(" dataProjeto = ");
            sql.Append(FormatarString.Formatar(dados.DataProjeto) + ", ");
            sql.Append(" NomeProjeto = ");
            sql.Append(FormatarString.Formatar(dados.NomeProjeto) + ", ");
            sql.Append(" Categoria = ");
            sql.Append(FormatarString.Formatar(dados.Categoria));

            sql.Append(" where CodProjeto = " + dados.CodProjeto.ToString());

            BancodeDados.ManterDados(sql.ToString());
        }

        public void ExcluirProjetos(ProjetosDOM dados)
        {

            StringBuilder sql = new StringBuilder();

            // exclui as contas de consumo
            sql.Append("delete from contas ");
            sql.Append(" where CodProjeto = " + dados.CodProjeto.ToString());
            BancodeDados.ManterDados(sql.ToString());

            // exclui os cálculos
            sql.Remove(0, sql.Length);
            sql.Append("delete from calculos ");
            sql.Append(" where CodProjeto = " + dados.CodProjeto.ToString());
            BancodeDados.ManterDados(sql.ToString());

            // exclui o projeto
            sql.Remove(0, sql.Length);
            sql.Append("delete from projetos ");
            sql.Append(" where CodProjeto = " + dados.CodProjeto.ToString());
            BancodeDados.ManterDados(sql.ToString());
        }


        public void CarregarProjetosComboBox(ref ComboBox comboboxPreenchido)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT CodProjeto, NomeProjeto ");
            sql.Append(" FROM projetos ");
            sql.Append(" UNION ");
            sql.Append(" SELECT '-1', '<SELECIONE O PROJETO>'");

            CarregarDropDown dropCarregar = new CarregarDropDown();
            dropCarregar.PopularBancodeDados(ref comboboxPreenchido, "NomeProjeto", "CodProjeto", sql.ToString(), "projetos");
            if (comboboxPreenchido.Items.Count > 0)
            {
                comboboxPreenchido.SelectedValue = "-1";
            }


        }


        public int ObterCategoriaProjeto(int codProjeto)
        {
            BancodeDados dadosBD = new BancodeDados();
            return dadosBD.ObterValorInteiro("SELECT categoria from projetos where codProjeto = "+codProjeto.ToString());
        }

    }
}
