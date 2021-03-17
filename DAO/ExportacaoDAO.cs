using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;

namespace WaterSaving
{
    public class ExportacaoDAO
    {
        public string Medicoes()
        { 

            StringBuilder sql = new StringBuilder();
            string[] meses = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};

            sql.Append(" select distinct municipios.codMunicipio, municipios.descmunicipio, medicoes.ano, Municipios.Altitude, Municipios.CodClima, Municipios.CodRegiao "); 
            
            // precipitacao 12 meses
            for (int i = 1; i <= 12; i++)
			{
                sql.Append(", (select ISNULL(sum(ISNULL(med.Precipitacao, 0)),0) from medicoes as med where med.codMunicipio = medicoes.codMunicipio and med.mes = " + i.ToString() + " and med.ano = medicoes.ano) as precipitacao_" + meses[i - 1]);
            }

            // umidade relativa do ar 12 meses
            for (int i = 1; i <= 12; i++)
            {
                sql.Append(", ((select ISNULL(sum(ISNULL(med.umidade, 0)),0) from medicoes as med where med.codMunicipio = medicoes.codMunicipio and  med.umidade > 0 and med.mes = " + i.ToString() + " and med.ano = Medicoes.ano)) as umidade_" + meses[i - 1]);
            }

            // temperatura 12 meses
            for (int i = 1; i <= 12; i++)
            {
                sql.Append(", ((select ISNULL(sum(ISNULL(med.temperatura, 0)),0) from medicoes as med where med.codMunicipio = medicoes.codMunicipio and  med.temperatura > 0 and med.mes = " + i.ToString() + " and med.ano = Medicoes.ano)) as temperatura_" + meses[i - 1]);
            }
            

            sql.Append(" from medicoes, municipios ");
            sql.Append(" where medicoes.codmunicipio = municipios.codMunicipio ");
            sql.Append(" order by municipios.descmunicipio, medicoes.ano ");
 

            DataSet dados = BancodeDados.MontaDataSet(sql.ToString(), "DSMedicoes");


            string diretorio = System.AppDomain.CurrentDomain.BaseDirectory + "dados";

            if (!Directory.Exists(diretorio))
                Directory.CreateDirectory(diretorio);

            string arquivo = diretorio + "\\DADOS_TESTE.TXT";
            StreamWriter texto = new StreamWriter(arquivo, false);
            
            StringBuilder linha = new StringBuilder();


            // insere linha de cabeçalho
            linha.Append("descmunicipio;ano;altitude;CodClima;CodRegiao");

            for (int x = 1; x <= 12; x++) 
                linha.Append( ";"+"precipitacao_"+meses[x - 1] );

            
            for (int y = 1; y <= 12; y++)
                linha.Append(";" + "umidade_" + meses[y - 1]);

            for (int z = 1; z <= 12; z++) 
                linha.Append(";" + "temperatura_" + meses[z - 1]);

            texto.WriteLine(linha.ToString()); 

            // Insere linhas
            string campo = string.Empty;
            string municipio = string.Empty;
            string municipioAnterior = string.Empty;
            for (int i = 0; i < dados.Tables[0].Rows.Count ; i++)
            {

                if (linha.Length > 0)
                    linha.Remove(0, linha.Length);

                municipio = dados.Tables[0].Rows[i]["descmunicipio"].ToString();

                if (municipio != municipioAnterior)
                {
                    if (municipioAnterior != string.Empty)
                    {
                        for (int z = 0; z < 5; z++)
                        {
                            texto.WriteLine("");
                        }
                    }
                    municipioAnterior = municipio;
                }

                linha.Append(dados.Tables[0].Rows[i]["descmunicipio"].ToString()+";");
                linha.Append(dados.Tables[0].Rows[i]["ano"].ToString()+";");
                linha.Append(dados.Tables[0].Rows[i]["Altitude"].ToString()+";");
                linha.Append(dados.Tables[0].Rows[i]["CodClima"].ToString()+";");
                linha.Append(dados.Tables[0].Rows[i]["CodRegiao"].ToString());

                for (int x = 1; x <= 12; x++)
                {
                    campo = "precipitacao_"+meses[x - 1];
                    //linha.Append(dados.Tables[0].Rows[i][campo].ToString()+";");
                    linha.Append(";" + Conversor.ConverterParaDecimal(dados.Tables[0].Rows[i][campo].ToString().Replace(".", ",")).ToString("##0.0"));
                }

                
                for (int y = 1; y <= 12; y++)
                {
                    campo = "umidade_" + meses[y - 1];
                    linha.Append(";" + dados.Tables[0].Rows[i][campo].ToString());
                }

                for (int z = 1; z <= 12; z++)
                {
                    campo = "temperatura_" + meses[z - 1];
                    linha.Append(";" + Conversor.ConverterParaDecimal(dados.Tables[0].Rows[i][campo].ToString().Replace(".", ",")).ToString("##0.00"));
                }
                
                texto.WriteLine(linha.ToString()); 
            }
            
            texto.Close();
            return arquivo;
        }

        public string DesvioPadrao()
        {
            string periodo = "med.ano >= 2007 and med.ano <= 2009";
            string anoDesvio = "2007 a 2009";

            StringBuilder sql = new StringBuilder();
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            sql.Append(" select distinct municipios.codMunicipio, municipios.descmunicipio, Municipios.Altitude, Municipios.CodClima, Municipios.CodRegiao ");

            // precipitacao 12 meses
            for (int i = 1; i <= 12; i++)
            {
                sql.Append(", round((select STDEV( ISNULL((ISNULL(med.Precipitacao, 0)),0)) from medicoes as med where med.codMunicipio = medicoes.codMunicipio and med.mes = " + i.ToString() + " and "+periodo+"), 1) as " + meses[i - 1]);
            }


            sql.Append(", (select MIN(med.ano) from medicoes as med where med.codMunicipio = med.codMunicipio and " + periodo + " and med.codMunicipio = medicoes.codMunicipio) as inicio ");
            sql.Append(", (select MAX(med.ano) from medicoes as med where med.codMunicipio = med.codMunicipio and " + periodo + " and med.codMunicipio = medicoes.codMunicipio) as fim ");


            sql.Append(" from medicoes, municipios ");
            sql.Append(" where medicoes.codmunicipio = municipios.codMunicipio ");
            //sql.Append(" and medicoes.codMunicipio = 41 ");
            sql.Append(" order by municipios.descmunicipio ");


            DataSet dados = BancodeDados.MontaDataSet(sql.ToString(), "DSMedicoes");


            string diretorio = System.AppDomain.CurrentDomain.BaseDirectory + "dados";

            if (!Directory.Exists(diretorio))
                Directory.CreateDirectory(diretorio);

            string arquivo = diretorio + "\\DESVIO_PADRAO (" + anoDesvio + ").TXT";
            StreamWriter texto = new StreamWriter(arquivo, false);

            StringBuilder linha = new StringBuilder();


            // insere linha de cabeçalho
            linha.Append("MunicÍpio;Altitude;Cod.Clima;Cod.Região");

            for (int x = 1; x <= 12; x++)
                linha.Append(";" + meses[x - 1]);

            linha.Append(";Inicio;Fim");

            texto.WriteLine(linha.ToString());

            // Insere linhas
            string campo = string.Empty;
            string municipio = string.Empty;
            string municipioAnterior = string.Empty;
            for (int i = 0; i < dados.Tables[0].Rows.Count; i++)
            {

                if (linha.Length > 0)
                    linha.Remove(0, linha.Length);

                municipio = dados.Tables[0].Rows[i]["descmunicipio"].ToString();
                linha.Append(dados.Tables[0].Rows[i]["descmunicipio"].ToString() + ";");
                linha.Append(dados.Tables[0].Rows[i]["Altitude"].ToString() + ";");
                linha.Append(dados.Tables[0].Rows[i]["CodClima"].ToString() + ";");
                linha.Append(dados.Tables[0].Rows[i]["CodRegiao"].ToString());

                for (int x = 1; x <= 12; x++)
                {
                    campo = meses[x - 1];
                    //linha.Append(dados.Tables[0].Rows[i][campo].ToString()+";");
                    linha.Append(";" + Conversor.ConverterParaDecimal(dados.Tables[0].Rows[i][campo].ToString().Replace(".", ",")).ToString("##0.0"));
                }

                linha.Append(";" + dados.Tables[0].Rows[i]["inicio"].ToString());
                linha.Append(";" + dados.Tables[0].Rows[i]["fim"].ToString());
                
                texto.WriteLine(linha.ToString());
            }

            texto.Close();
            return arquivo;
        }

        public string Medias()
        {
            string anoInicio = "1981";
            string anoFim = "1990";
            string periodo = "med.ano >= "+anoInicio +" and med.ano <= "+anoFim;
            string anoMedia = anoInicio+ " a "+anoFim;

            StringBuilder sql = new StringBuilder();
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            sql.Append(" select distinct municipios.codMunicipio, municipios.descmunicipio, Municipios.Altitude, Municipios.CodClima, Municipios.CodRegiao ");

            // precipitacao 12 meses
            for (int i = 1; i <= 12; i++)
            {
                sql.Append(", round((select AVG( ISNULL((ISNULL(med.Precipitacao, 0)),0)) from medicoes as med where med.codMunicipio = medicoes.codMunicipio and med.mes = " + i.ToString() + " and " + periodo + "), 1) as " + meses[i - 1]);
            }


            sql.Append(", (select MIN(med.ano) from medicoes as med where med.codMunicipio = med.codMunicipio and " + periodo + " and med.codMunicipio = medicoes.codMunicipio) as inicio ");
            sql.Append(", (select MAX(med.ano) from medicoes as med where med.codMunicipio = med.codMunicipio and " + periodo + " and med.codMunicipio = medicoes.codMunicipio) as fim ");


            sql.Append(" from medicoes, municipios ");
            sql.Append(" where medicoes.codmunicipio = municipios.codMunicipio ");
            //sql.Append(" and medicoes.codMunicipio = 41 ");
            sql.Append(" order by municipios.descmunicipio ");


            DataSet dados = BancodeDados.MontaDataSet(sql.ToString(), "DSMedicoes");


            string diretorio = System.AppDomain.CurrentDomain.BaseDirectory + "dados";

            if (!Directory.Exists(diretorio))
                Directory.CreateDirectory(diretorio);

            string arquivo = diretorio + "\\MÉDIA (" + anoMedia + ").TXT";
            StreamWriter texto = new StreamWriter(arquivo, false);

            StringBuilder linha = new StringBuilder();

            texto.WriteLine("MÉDIAS (" + anoMedia + ")");

            // insere linha de cabeçalho
            linha.Append("MunicÍpio;Altitude;Cod.Clima;Cod.Região");

            for (int x = 1; x <= 12; x++)
                linha.Append(";" + meses[x - 1]);

            linha.Append(";Inicio;Fim");

            texto.WriteLine(linha.ToString());

            // Insere linhas
            string campo = string.Empty;
            string municipio = string.Empty;
            string municipioAnterior = string.Empty;
            for (int i = 0; i < dados.Tables[0].Rows.Count; i++)
            {

                if (linha.Length > 0)
                    linha.Remove(0, linha.Length);

                municipio = dados.Tables[0].Rows[i]["descmunicipio"].ToString();
                linha.Append(dados.Tables[0].Rows[i]["descmunicipio"].ToString() + ";");
                linha.Append(dados.Tables[0].Rows[i]["Altitude"].ToString() + ";");
                linha.Append(dados.Tables[0].Rows[i]["CodClima"].ToString() + ";");
                linha.Append(dados.Tables[0].Rows[i]["CodRegiao"].ToString());

                for (int x = 1; x <= 12; x++)
                {
                    campo = meses[x - 1];
                    linha.Append(";" + Conversor.ConverterParaDecimal(dados.Tables[0].Rows[i][campo].ToString().Replace(".", ",")).ToString("##0.0"));
                }

                linha.Append(";" + dados.Tables[0].Rows[i]["inicio"].ToString());
                linha.Append(";" + dados.Tables[0].Rows[i]["fim"].ToString());

                texto.WriteLine(linha.ToString());
            }

            texto.Close();
            return arquivo;
        }

    }
}
