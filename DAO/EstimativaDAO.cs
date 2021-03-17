using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace WaterSaving
{
    public class EstimativaDAO
    {
        public ArrayList CalcularEstimativa(int codMedicao, double areaCaptacao, double demandaMensal, double tamanhoReservatorio, ref double totalChuvaMensal)
        {
            string[] MesesAno = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            ArrayList arrayEstimativa = new ArrayList();
            double mediaMensal = 0;
            double volChuva = 0;
            double volReservatorioTempoTM1 = 0;
            double volReservatorioTempoT = 0;
            double overflow = 0;
            double suprimentoAguaExt = 0;
            int linha = 0;


            StringBuilder sql = new StringBuilder();
            sql.Append(" select janeiro, fevereiro, marco, abril, maio, junho, julho, agosto, setembro, ");
            sql.Append("    outubro, novembro, dezembro ");
            sql.Append(" from medicoes ");
            sql.Append(" where CodMedicao = "+codMedicao.ToString());

            DataSet dsMedicoes =  BancodeDados.MontaDataSet(sql.ToString(), "medicoes");
            if (dsMedicoes.Tables[0].Rows.Count > 0)
            {
                foreach (string mes in MesesAno)
                {
                    linha++;
                    EstimativaDOM estimativaLinhaDOM = new EstimativaDOM();
                    mediaMensal = Math.Round(Conversor.ConverterParaDouble(dsMedicoes.Tables[0].Rows[0][Utilitarios.RetiraAcentos(mes)].ToString()), 0);
                    volChuva = Math.Round(((mediaMensal * areaCaptacao * 0.80) / 1000), 0);


                    estimativaLinhaDOM.Mes = mes;                                    // Coluna 1
                    estimativaLinhaDOM.MediaMensal = mediaMensal;                    // Coluna 2 
                    estimativaLinhaDOM.DemandaMensal = demandaMensal;                // Coluna 3
                    estimativaLinhaDOM.AreadeCaptacao = areaCaptacao;                // Coluna 4
                    estimativaLinhaDOM.VolChuvaMes = volChuva;                       // Coluna 5
                    estimativaLinhaDOM.VolReservatorioFixado = tamanhoReservatorio;  // Coluna 6

                    // Valores da Coluna 7 e 8
                    if (linha.Equals(1))
                    {
                        volReservatorioTempoTM1 = 0;
                        volReservatorioTempoT = tamanhoReservatorio;
                    }
                    else
                    {
                        if (volReservatorioTempoT < 0)
                            volReservatorioTempoTM1 = 0;
                        else
                            volReservatorioTempoTM1 = volReservatorioTempoT;

                        if ((volChuva + volReservatorioTempoTM1 - demandaMensal) > tamanhoReservatorio)
                            volReservatorioTempoT = volReservatorioTempoTM1;
                        else
                            volReservatorioTempoT = (volChuva + volReservatorioTempoTM1 - demandaMensal);
                    }

                    // Valor da Coluna 9
                    if ((volChuva + volReservatorioTempoTM1 - demandaMensal) > tamanhoReservatorio)
                        overflow = (volChuva + volReservatorioTempoTM1 - demandaMensal - tamanhoReservatorio);
                    else
                        overflow = 0;

                    // Valor da Coluna 10
                    if ((volReservatorioTempoTM1 + volChuva - demandaMensal) < 0)
                        suprimentoAguaExt = (volReservatorioTempoTM1 + volChuva - demandaMensal) * (-1);
                    else
                        suprimentoAguaExt = 0;

                    estimativaLinhaDOM.VolReservatorioTempoTM1 = volReservatorioTempoTM1;   // Coluna 7
                    estimativaLinhaDOM.VolReservatorioTempoT = volReservatorioTempoT;       // Coluna 8
                    estimativaLinhaDOM.Overflow = overflow;                                 // Coluna 9
                    estimativaLinhaDOM.SuprimentoAguaExt = suprimentoAguaExt;               // Coluna 10

                    totalChuvaMensal += volChuva;

                    arrayEstimativa.Add(estimativaLinhaDOM);
                }
            }
           
            return arrayEstimativa;
        }

        public double ValordoReservatorio(double tamanhoReservatorio)
        {
            double quantidade = 0;
            double precoUnit = 0;
            bool itemUnico = false;
            double precoTotal = 0;

            StringBuilder sql = new StringBuilder();
            
            sql.Append(" select Quantidade, PrecoUnitario, Unico  ");
            sql.Append(" from insumoReservatorio ");


            DataSet dsInsumos =  BancodeDados.MontaDataSet(sql.ToString(), "insumoReservatorio");
            if (dsInsumos.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in dsInsumos.Tables[0].Rows)
                {
                    quantidade = Conversor.ConverterParaDouble(item["Quantidade"].ToString());
                    precoUnit  = Conversor.ConverterParaDouble(item["PrecoUnitario"].ToString());
                    itemUnico = Conversor.ConverterParaBoolean(item["Unico"].ToString());

                    if ((itemUnico) && (tamanhoReservatorio > 0))
                        precoTotal += quantidade * precoUnit;
                    else
                        precoTotal += ((quantidade * precoUnit) * tamanhoReservatorio);

                }
            }

            return precoTotal;
        }


        public double ViabilidadeEconomica(double totalChuvaMensal, double demandaMensal, double custoM3Agua, int codProjeto)
        {
            double consumo = 0;
            double valor = 0;
            double consumoTotal = 0;
            double valorTotal = 0;
            double cu = 0;
            double demandaCalculada = 0;
  
            StringBuilder sql = new StringBuilder();

            sql.Append(" select Consumo, Valor  ");
            sql.Append(" from contas where CodProjeto = "+codProjeto.ToString());

            DataSet dsContas = BancodeDados.MontaDataSet(sql.ToString(), "contas");
            if (dsContas.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in dsContas.Tables[0].Rows)
                {
                    consumo = Conversor.ConverterParaDouble(item["consumo"].ToString());
                    valor   = Conversor.ConverterParaDouble(item["valor"].ToString());

                    consumoTotal += consumo;
                    valorTotal += valor;
                }
            }

            if (valorTotal > 0) // se as contas de consumo estiverem cadastradas
            {
                demandaCalculada = Math.Round((consumoTotal / dsContas.Tables[0].Rows.Count), 2);

                if ((demandaMensal != demandaCalculada) && (demandaMensal > 0))
                    demandaCalculada = demandaMensal;

                cu = Math.Round((valorTotal / dsContas.Tables[0].Rows.Count) / demandaCalculada, 2);

                return Math.Round(Math.Round((totalChuvaMensal / 12), 2) * cu * 12, 2);
            }
            else // se as contas de consumo não estiverem cadastradas
            { 
                cu = custoM3Agua;
                return Math.Round(Math.Round((totalChuvaMensal / 12), 2) * cu * 12, 2);
            
            }

        }

        public void DemandaCalculada(ref double demandaCalculada, ref double valorConsumoCalculado, int codProjeto)
        {
            double consumoTotal = 0;
            double valorTotal = 0;

            StringBuilder sql = new StringBuilder();

            sql.Append(" select Consumo, Valor  ");
            sql.Append(" from contas ");
            sql.Append(" where CodProjeto = " + codProjeto.ToString());


            DataSet dsContas = BancodeDados.MontaDataSet(sql.ToString(), "contas");
            if (dsContas.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in dsContas.Tables[0].Rows)
                {
                    consumoTotal += Conversor.ConverterParaDouble(item["consumo"].ToString());
                    valorTotal += Conversor.ConverterParaDouble(item["valor"].ToString());
                }
            }

            if (consumoTotal > 0)
                demandaCalculada = (consumoTotal / dsContas.Tables[0].Rows.Count);

            if (valorTotal > 0)
                valorConsumoCalculado = (valorTotal / dsContas.Tables[0].Rows.Count);

        }




    }
}
