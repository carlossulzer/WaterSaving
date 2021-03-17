using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace WaterSaving
{
    class ContasDAO
    {
        public int InserirContas(ContasDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into contas ");
            sql.Append(" (CodProjeto, Mes, Ano, Consumo, Valor )");
            sql.Append(" values (");
            sql.Append(FormatarString.Formatar(dados.CodProjeto) + ", ");
            sql.Append(FormatarString.Formatar(dados.Mes)+", ");
            sql.Append(FormatarString.Formatar(dados.Ano) + ", ");
            sql.Append(FormatarString.Formatar(dados.Consumo) + ", ");
            sql.Append(FormatarString.Formatar(dados.Valor));
            sql.Append(")");

            BancodeDados.ManterDados(sql.ToString());


            BancodeDados dadosBD = new BancodeDados();
            int codigo = dadosBD.ObterValorInteiro("SELECT @@IDENTITY");
            return codigo;
        }


        public DataSet ConsultarContas(int codConta, int codProjeto)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" select codConta, Mes, Ano, Consumo, (Consumo*1000) as litros,  ");
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
            sql.Append("   end) as Descricao, ");
            sql.Append("   valor ");
            sql.Append(" from contas ");
            sql.Append(" where CodProjeto = "+codProjeto.ToString());

            if (codConta > 0)
            {
                sql.Append(" and CodConta = " + FormatarString.Formatar(codConta));
            }
            return BancodeDados.MontaDataSet(sql.ToString(), "contas");
        }

        public void AlterarContas(ContasDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update contas set ");
            sql.Append(" Mes = ");
            sql.Append(FormatarString.Formatar(dados.Mes)+", ");
            sql.Append(" Ano = ");
            sql.Append(FormatarString.Formatar(dados.Ano) + ", ");
            sql.Append(" Consumo = ");
            sql.Append(FormatarString.Formatar(dados.Consumo) + ", ");
            sql.Append(" Valor = ");
            sql.Append(FormatarString.Formatar(dados.Valor));

            sql.Append(" where CodProjeto = " + dados.CodProjeto.ToString());
            sql.Append(" and Codconta = " + dados.CodConta.ToString());

            BancodeDados.ManterDados(sql.ToString());
        }

        public void ExcluirContas(ContasDOM dados)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from contas ");
            sql.Append(" where CodProjeto = " + dados.CodProjeto.ToString());
            sql.Append(" and CodConta = " + dados.CodConta.ToString());

            BancodeDados.ManterDados(sql.ToString());
        }

        public void Dados(string tipo)
        {
            StringBuilder sql = new StringBuilder();
            if (tipo.Equals("R")) // residencia
            {
                for (int i = 1; i <= 12; i++)
                {
                   sql.Append("insert into contas(CodProjeto, mes, ano, consumo, valor) values("+DadosProjetoDOM.CodProjeto.ToString()+","+i.ToString()+", 2012, 7.00, 29.30) ");  
                }
                
            }
            else if (tipo.Equals("U")) // universidade
            {
                for (int i = 1; i <= 12; i++)
                {
                    sql.Append("insert into contas(CodProjeto, mes, ano, consumo, valor) values(" + DadosProjetoDOM.CodProjeto.ToString() + "," + i.ToString() + ", 2012, 296.00, 4569.10) ");
                }
            }
            BancodeDados.ManterDados(sql.ToString());
        }



    }
}
