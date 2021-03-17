using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;

namespace WaterSaving
{
    class ImportacaoDAO
    {

        public void Importar(string arquivo)
        {
            int totalDeLinhas = 0;
            string linha = string.Empty;
            char[] delimiterChars = { ';' };

            string sqlFixo = "insert into precipitacao(CodMunicipio, Ano, Mes, ValorPrecipitacao) values("; 
            StringBuilder sql = new StringBuilder();
            string[] textovirg = null;
            BancodeDados dados = new BancodeDados();

            StreamReader readerTXT = new StreamReader(arquivo, Encoding.GetEncoding("windows-1250"));
            linha = readerTXT.ReadLine();
            while (linha != null)
            {
 
                totalDeLinhas++;
                if (totalDeLinhas.Equals(1))
                    continue;
                else
                    linha = readerTXT.ReadLine();

                if (linha == null)
                    continue;
                else
                    textovirg = linha.Split(delimiterChars);

                if (textovirg[0].Trim().Equals(string.Empty))
                    continue;


                //if (textovirg.Length < 5) // layout do INMET
                //    break;

                if (sql.Length > 0)
                    sql.Remove(0, sql.Length);

                sql.Append(sqlFixo);
                sql.Append(textovirg[0] + ", ");
                sql.Append(textovirg[1] + ", ");
                sql.Append(textovirg[2] + ", ");
                if (!textovirg[3].Trim().Equals(string.Empty))
                {
                    sql.Append(FormatarString.Formatar(Conversor.ConverterParaDecimal(textovirg[3])) + ") ");
                    BancodeDados.ManterDados(sql.ToString());
                }
            }
            readerTXT.Close();
        }




        public void ImportarINMET(string arquivo)
        {
            int totalDeLinhas = 0;
            string linha = string.Empty;
            char[] delimiterChars = { ';' };

           
            string sqlFixo = "insert into medicoes(CodMunicipio, Data, Precipitacao, Ano, Mes, Umidade) values(";
            StringBuilder sql = new StringBuilder();
            StringBuilder sqlMedicao = new StringBuilder();
            StringBuilder sqlMunicipio = new StringBuilder();
            string[] textovirg = null;
            int codMunicipio = 0;
            string codMunicipioOriginal = string.Empty;
            BancodeDados dados = new BancodeDados();

            StreamReader readerTXT = new StreamReader(arquivo, Encoding.GetEncoding("windows-1250"));
            linha = readerTXT.ReadLine();
            while (linha != null)
            {
                totalDeLinhas++;
                if (totalDeLinhas.Equals(1))
                    continue;
                else
                    linha = readerTXT.ReadLine();

                if (linha == null)
                    continue;
                else
                    textovirg = linha.Split(delimiterChars);

                if (textovirg[0].Trim().Equals(string.Empty))
                    continue;

                if (totalDeLinhas.Equals(2))
                {
                    codMunicipioOriginal = textovirg[0];
                    if (sqlMunicipio.Length > 0)
                        sqlMunicipio.Remove(0, sqlMunicipio.Length);

                    sqlMunicipio.Append("Select CodMunicipio From Municipios Where CodOriginal = " + codMunicipioOriginal);

                    codMunicipio = dados.ObterValorInteiro(sqlMunicipio.ToString());
                    if (codMunicipio.Equals(0))
                    {
                        sqlMunicipio.Remove(0, sqlMunicipio.Length);
                        sqlMunicipio.Append("insert into municipios(DescMunicipio, CodOriginal) values( ");
                        sqlMunicipio.Append(FormatarString.Formatar(textovirg[1]) + ", ");
                        sqlMunicipio.Append(FormatarString.Formatar(codMunicipioOriginal));
                        sqlMunicipio.Append(")");

                        sqlMunicipio.Append("SELECT @@IDENTITY");
                        codMunicipio = dados.ObterValorInteiro(sqlMunicipio.ToString());

                    }
                }

                if (sql.Length > 0)
                    sql.Remove(0, sql.Length);

                if (sqlMedicao.Length > 0)
                    sqlMedicao.Remove(0, sqlMedicao.Length);


                sqlMedicao.Append("Select CodMedicao From Medicoes Where CodMunicipio = " + codMunicipio);
                sqlMedicao.Append(" and Data = " + FormatarString.Formatar(Convert.ToDateTime(textovirg[2])));

                if (dados.ObterValorInteiro(sqlMedicao.ToString()).Equals(0))
                {

                    /*
                    CodMunicipio, Data, Precipitacao

                    00 CodMunicipio, 
                    01 Data, 
                    02 Precipitacao, 
                    03 Ano, 
                    04 Mes
                    05 Umidade
                     
                    */

                    sql.Append(sqlFixo);
                    sql.Append(Convert.ToInt32(codMunicipio) + ", ");
                    sql.Append(FormatarString.Formatar(Convert.ToDateTime(textovirg[02])) + ", ");
                    sql.Append(FormatarString.Formatar(Conversor.ConverterParaDouble(textovirg[03])) + ", ");
                    sql.Append(FormatarString.Formatar(Conversor.ConverterParaDouble(Convert.ToDateTime(textovirg[02]).Year)) + ", ");
                    sql.Append(FormatarString.Formatar(Conversor.ConverterParaDouble(Convert.ToDateTime(textovirg[02]).Month)) + ", ");
                    sql.Append(FormatarString.Formatar(Conversor.ConverterParaInteiro(textovirg[04]))+ ") ");

                    BancodeDados.ManterDados(sql.ToString());
                }
                else
                {
                    if (sqlMedicao.Length > 0)
                        sqlMedicao.Remove(0, sqlMedicao.Length);

                    sqlMedicao.Append(" update Medicoes set umidade = " + FormatarString.Formatar(Conversor.ConverterParaInteiro(textovirg[04])));
                    sqlMedicao.Append(" Where CodMunicipio = " + codMunicipio);
                    sqlMedicao.Append(" and Data = " + FormatarString.Formatar(Convert.ToDateTime(textovirg[2])));
                    BancodeDados.ManterDados(sqlMedicao.ToString());
                }
            }
            readerTXT.Close();
        }

        public void ImportarINMETTemperatura_antigo(string arquivo)
        {
            int totalDeLinhas = 0;
            string linha = string.Empty;
            char[] delimiterChars = { ';' };

            StringBuilder sqlMedicao = new StringBuilder();
            StringBuilder sqlMunicipio = new StringBuilder();
            string[] textovirg = null;
            int codMunicipio = 0;
            string codMunicipioOriginal = string.Empty;
            BancodeDados dados = new BancodeDados();

            StreamReader readerTXT = new StreamReader(arquivo, Encoding.GetEncoding("windows-1250"));
            linha = readerTXT.ReadLine();
            while (linha != null)
            {
                totalDeLinhas++;
                if (totalDeLinhas.Equals(1))
                    continue;
                else
                    linha = readerTXT.ReadLine();

                if (linha == null)
                    continue;
                else
                    textovirg = linha.Split(delimiterChars);

                if (textovirg[0].Trim().Equals(string.Empty))
                    continue;

                if (totalDeLinhas.Equals(2))
                {
                    codMunicipioOriginal = textovirg[0];
                    if (sqlMunicipio.Length > 0)
                        sqlMunicipio.Remove(0, sqlMunicipio.Length);

                    sqlMunicipio.Append("Select CodMunicipio From Municipios Where CodOriginal = " + codMunicipioOriginal);
                    codMunicipio = dados.ObterValorInteiro(sqlMunicipio.ToString());
                }

                if (codMunicipio > 0)
                {
                    if (sqlMedicao.Length > 0)
                        sqlMedicao.Remove(0, sqlMedicao.Length);

                    sqlMedicao.Append("Select CodMedicao From Medicoes Where CodMunicipio = " + codMunicipio);
                    sqlMedicao.Append(" and Data = " + FormatarString.Formatar(Convert.ToDateTime(textovirg[2])));

                    if (!dados.ObterValorInteiro(sqlMedicao.ToString()).Equals(0))
                    {
                        if (sqlMedicao.Length > 0)
                            sqlMedicao.Remove(0, sqlMedicao.Length);

                        sqlMedicao.Append(" update Medicoes set Temperatura = " + FormatarString.Formatar(Conversor.ConverterParaDouble(textovirg[03])));
                        sqlMedicao.Append(" Where CodMunicipio = " + codMunicipio);
                        sqlMedicao.Append(" and Data = " + FormatarString.Formatar(Convert.ToDateTime(textovirg[2])));
                        BancodeDados.ManterDados(sqlMedicao.ToString());
                    }
                }
            }
            readerTXT.Close();
        }


        public void ImportarINMET_PrecipitacaoUmidade(string arquivo)
        {
            int totalDeLinhas = 0;
            string linha = string.Empty;
            char[] delimiterChars = { ';' };


            StringBuilder sqlFixo = new StringBuilder();
            sqlFixo.Append("insert into PrecipitacaoUmidade(CodMunicipio, Data, Precipitacao, Umidade, Ano, Mes) values(");

            StringBuilder sql = new StringBuilder();
            string[] textovirg = null;
            BancodeDados dados = new BancodeDados();

            StreamReader readerTXT = new StreamReader(arquivo, Encoding.GetEncoding("windows-1250"));
            linha = readerTXT.ReadLine();
            while (linha != null)
            {
                totalDeLinhas++;
                if (totalDeLinhas.Equals(1))
                    continue;
                else
                    linha = readerTXT.ReadLine();

                if (linha == null)
                    continue;
                else
                    textovirg = linha.Split(delimiterChars);

                if (textovirg[0].Trim().Equals(string.Empty))
                    continue;

                if (sql.Length > 0)
                    sql.Remove(0, sql.Length);


                /*
                CodMunicipio, Data, Precipitacao

                00 CodMunicipio, 
                01 Data, 
                02 Precipitacao, 
                   Ano, 
                   Mes
                03 Umidade 00..23
                26 Unidade 23
                     
                */

                sql.Append(sqlFixo.ToString());
                sql.Append(Conversor.ConverterParaInteiro(textovirg[00]) + ", ");
                sql.Append(FormatarString.Formatar(Convert.ToDateTime(textovirg[01])) + ", ");
                sql.Append(FormatarString.Formatar(Conversor.ConverterParaDouble(textovirg[02])) + ", ");

                if (textovirg[03].ToString() == "#DIV/0!" || textovirg[03] == "0")
                    sql.Append("null, ");
                else
                    sql.Append(FormatarString.Formatar(Conversor.ConverterParaInteiro(textovirg[03])) + ", ");

                sql.Append(FormatarString.Formatar(Conversor.ConverterParaDouble(Convert.ToDateTime(textovirg[01]).Year)) + ", ");
                sql.Append(FormatarString.Formatar(Conversor.ConverterParaDouble(Convert.ToDateTime(textovirg[01]).Month))+")");
                BancodeDados.ManterDados(sql.ToString());

            }
            readerTXT.Close();
        }

        public void ImportarINMETTemperatura(string arquivo)
        {
            int totalDeLinhas = 0;
            string linha = string.Empty;
            char[] delimiterChars = { ';' };


            StringBuilder sqlFixo = new StringBuilder();
            sqlFixo.Append("insert into Temperatura(CodMunicipio, Temperatura, Ano, Mes) values(");

            StringBuilder sql = new StringBuilder();
            string[] textovirg = null;
            BancodeDados dados = new BancodeDados();

            StreamReader readerTXT = new StreamReader(arquivo, Encoding.GetEncoding("windows-1250"));
            linha = readerTXT.ReadLine();
            while (linha != null)
            {
                totalDeLinhas++;
                if (totalDeLinhas.Equals(1))
                    continue;
                else
                    linha = readerTXT.ReadLine();

                if (linha == null)
                    continue;
                else
                    textovirg = linha.Split(delimiterChars);

                if (textovirg[0].Trim().Equals(string.Empty))
                    continue;

                if (sql.Length > 0)
                    sql.Remove(0, sql.Length);


                /*
                CodMunicipio, Data, Precipitacao

                00 CodMunicipio, 
                01 Data, 
                02 Temperatura, 
                   Ano, 
                   Mes
               
                */

                sql.Append(sqlFixo.ToString());
                sql.Append(Conversor.ConverterParaInteiro(textovirg[00]) + ", ");


                if (!(textovirg[02].ToString() == "#DIV/0!" || textovirg[02] == "0,0"))
                {
                    sql.Append(FormatarString.Formatar(Conversor.ConverterParaDouble(textovirg[02])) + ", ");

                    sql.Append(FormatarString.Formatar(Conversor.ConverterParaDouble(Convert.ToDateTime(textovirg[01]).Year)) + ", ");
                    sql.Append(FormatarString.Formatar(Conversor.ConverterParaDouble(Convert.ToDateTime(textovirg[01]).Month)) + ")");
                    BancodeDados.ManterDados(sql.ToString());
                }

            }
            readerTXT.Close();
        }

        public void ImportarINMET_PrecUmidadeTemp(string arquivo)
        {
            int totalDeLinhas = 0;
            int existePrecipitacao  = 0;
            int existeUmidade = 0;
            string linha = string.Empty;
            char[] delimiterChars = { ';' };


            StringBuilder sqlFixo = new StringBuilder();
            sqlFixo.Append("insert into PrecUmidadeTemp(CodMunicipio, Data ");

            for (int i = 1; i < 25; i++)
            {
                sqlFixo.Append(", precipitacao" + i.ToString("00"));
            }

            for (int i = 1; i < 25; i++)
            {
                sqlFixo.Append(", Umidade" + i.ToString("00"));
            }
            
            sqlFixo.Append(", Ano, Mes) values(");


            StringBuilder sql = new StringBuilder();
            string[] textovirg = null;
            BancodeDados dados = new BancodeDados();

            StreamReader readerTXT = new StreamReader(arquivo, Encoding.GetEncoding("windows-1250"));
            linha = readerTXT.ReadLine();
            while (linha != null)
            {
                totalDeLinhas++;
                existePrecipitacao = 0;
                existeUmidade = 0;
                if (totalDeLinhas == 1)
                    continue;
                else if (totalDeLinhas == 2)
                {
                    linha = readerTXT.ReadLine();
                    continue;
                }
                else
                    linha = readerTXT.ReadLine();

                if (linha == null)
                    continue;
                else
                    textovirg = linha.Split(delimiterChars);

                if (textovirg[0].Trim().Equals(string.Empty))
                    continue;

                if (sql.Length > 0)
                    sql.Remove(0, sql.Length);


                /*
                CodMunicipio, Data, Precipitacao

                00 CodMunicipio, 
                01 Data, 
                02 Precipitacao, 
                   Ano, 
                   Mes
                03 Umidade 00..23
                26 Unidade 23
                     
                */

                sql.Append(sqlFixo.ToString());
                sql.Append(Conversor.ConverterParaInteiro(textovirg[00]) + ", ");
                sql.Append(FormatarString.Formatar(Convert.ToDateTime(textovirg[01])) + ", ");


                //precipitação
                for (int i = 2; i < 26; i++)
                {
                    existePrecipitacao++;
                    if (textovirg[i].ToString().Trim().Equals(string.Empty) || textovirg[i].ToUpper().Equals("NULL"))
                        sql.Append("null, ");
                    else
                        sql.Append(FormatarString.Formatar(Conversor.ConverterParaDouble(textovirg[i])) + ", ");
                }
                

                // Umidade
                for (int i = 26; i < 50; i++)
                {
                    existeUmidade++;
                    if (textovirg[i].ToString().Trim().Equals(string.Empty) || textovirg[i].ToUpper().Equals("NULL"))
                        sql.Append("null, ");
                    else
                        sql.Append(FormatarString.Formatar(Conversor.ConverterParaInteiro(textovirg[i])) + ", ");
                }
                
                sql.Append(FormatarString.Formatar(Conversor.ConverterParaDouble(Convert.ToDateTime(textovirg[01]).Year)) + ", ");
                sql.Append(FormatarString.Formatar(Conversor.ConverterParaDouble(Convert.ToDateTime(textovirg[01]).Month)) + ")");

                if (existePrecipitacao > 0 && existeUmidade > 0)
                    BancodeDados.ManterDados(sql.ToString());

            }
            readerTXT.Close();
        }


        // verificação por dia - Verifica todos os horários para saber se tem null ou não
        public void TratarINMET_PrecUmidadeTemp()
        {

            StringBuilder sqlFixo = new StringBuilder();
            sqlFixo.Append("select CodMunicipio, Data ");

            for (int i = 1; i < 25; i++)
            {
                sqlFixo.Append(", precipitacao" + i.ToString("00"));
            }

            for (int i = 1; i < 25; i++)
            {
                sqlFixo.Append(", Umidade" + i.ToString("00"));
            }

            sqlFixo.Append(", Ano, Mes from precUmidadeTemp where codMunicipio = 90");

            DataSet ds =  BancodeDados.MontaDataSet(sqlFixo.ToString(), "precUmidadeTemp");

            int precipitacao = 0;
            int umidade = 0;
            double totPrecipitacao = 0;
            int totUmidade = 0;
            StringBuilder sql = new StringBuilder();
            int codMunicipio = 0;
            DateTime data = DateTime.Now.Date;
            foreach (DataRow item in ds.Tables[0].Rows )
            {
                precipitacao = 0;
                umidade = 0;
                totPrecipitacao = 0;
                totUmidade = 0;
                if (sql.Length > 0)
                    sql.Remove(0, sql.Length);

                sql.Append("Update precUmidadeTemp set precipitacao = ");


                codMunicipio = Conversor.ConverterParaInteiro(item["codMunicipio"].ToString());
                data = Conversor.ConverterParaDateTime(item["data"].ToString());

                // Precipitacao
                for (int i = 1; i < 25; i++)
                {
                    if ((!item["Precipitacao" + i.ToString("00")].ToString().ToUpper().Equals("NULL")) && (!item["Precipitacao" + i.ToString("00")].ToString().Trim().Equals(string.Empty)))
                    {
                        precipitacao++;
                        totPrecipitacao += Conversor.ConverterParaDouble(item["Precipitacao" + i.ToString("00")].ToString());
                    }
                }

                if (precipitacao > 0)
                    sql.Append(FormatarString.Formatar(totPrecipitacao)+", umidade = ");
                else
                    sql.Append(" null, umidade = ");


                // Umidade
                for (int i = 1; i < 25; i++)
                {
                    if ((!item["Umidade" + i.ToString("00")].ToString().ToUpper().Equals("NULL")) && (!item["Umidade" + i.ToString("00")].ToString().Trim().Equals(string.Empty)))
                    {
                        umidade++;
                        totUmidade += Conversor.ConverterParaInteiro(item["Umidade" + i.ToString("00")].ToString());
                    }
                }

                if (umidade > 0)
                {
                    totUmidade = totUmidade / umidade;
                    sql.Append(FormatarString.Formatar(totUmidade));
                }
                else
                    sql.Append(" null ");


                sql.Append("where codMunicipio = " + codMunicipio.ToString() + " and data = " + FormatarString.Formatar(data));
                BancodeDados.ManterDados(sql.ToString());
            }

 
        }



    }
}
