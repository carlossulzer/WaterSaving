using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WaterSaving
{
    public partial class FrmPrincipal : Form
    {
        
        ArrayList areasTelhado = new ArrayList();
        ArrayList areasJardim = new ArrayList();
        ArrayList areasComuns = new ArrayList();
        DataGridViewTextBoxColumn colunaGridModelo = new DataGridViewTextBoxColumn();

        public Consumo dadosConsumo { get; set; }

        public FrmPrincipal()
        {
            InitializeComponent();
            dadosConsumo = new Consumo(); 
            CarregarMunicipios();
            CarregarProjetos();


            txtCotacaoDolar.Text = Moedas.Cotacao().ToString("###,##0.00");
            txtTMA.Text = "15,00";
            txtDespesaAnual.Text = "100,00";
            txtRetornoAnos.Text = "20";

            dgvDados.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dgvDados.AlternatingRowsDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dgvDados.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dgvDados.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
        }

        public void CarregarMunicipios()
        {
            MunicipiosCTL municipiosCTL = new MunicipiosCTL();

            cbxMunicipios.DisplayMember = "DescMunicipio";
            cbxMunicipios.ValueMember = "codMunicipio";
            cbxMunicipios.DataSource = municipiosCTL.ConsultarMunicipios().Tables[0];
        }

        private void cbxCotacaoDolar_CheckedChanged(object sender, EventArgs e)
        {
            txtCotacaoDolar.Enabled = !cbxCotacaoDolar.Checked;

            if (cbxCotacaoDolar.Checked)
                txtCotacaoDolar.Text = Moedas.Cotacao().ToString("###,##0.00");
            else
                txtCotacaoDolar.Focus();
        }

        private void btnViabilidadeEconomica_Click(object sender, EventArgs e)
        {
            CalcularViabilidadeEconomica();
        }

        private void contasDeConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DadosProjetoDOM.CodProjeto > 0)
            {
                FrmContas contas = new FrmContas();
                contas.ShowDialog();
            }
            else
                MessageBox.Show("Favor selecionar o projeto antes de cadastrar as contas de consumo.");
        }

        private void insumosDoReservatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsumoReservatorio insumo = new FrmInsumoReservatorio();
            insumo.ShowDialog();
        }

        private void mediçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicoes medicoes = new FrmMedicoes();
            medicoes.ShowDialog();
        }

        private void btnProjetos_Click(object sender, EventArgs e)
        {
            
            FrmManterProjetos manterProjetos = new FrmManterProjetos();
            manterProjetos.ShowDialog();
            CarregarProjetos();
            cbxNomeProjeto.SelectedValue = DadosProjetoDOM.CodProjeto;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAreaCaptacao_Click(object sender, EventArgs e)
        {
            double areaTotal = 0;
            FrmFormas areaCaptacao = new FrmFormas();
            areaCaptacao.TituloArea = "Áreas Para Captação de Água de Chuva";
            areaCaptacao.Areas = areasTelhado;
            areaCaptacao.ShowDialog();
            areasTelhado = areaCaptacao.Areas;
            areaTotal = CalculaAreaTotal(areasTelhado);
            txtAreaCaptacao.Text = areaTotal.ToString("###0.00");

            if (areaTotal > 0)
                txtDemandaMensal.Focus();
            else
                txtAreaCaptacao.Focus();
        }

        private void btnConsumoMedio_Click(object sender, EventArgs e)
        {
            FrmConsumo consumo = new FrmConsumo();
            consumo.AreasJardim = areasJardim;
            consumo.AreasComuns = areasComuns;
            consumo.DadosConsumo = dadosConsumo;
            consumo.ShowDialog();
            areasJardim = consumo.AreasJardim;
            areasComuns = consumo.AreasComuns;
            dadosConsumo = consumo.DadosConsumo;

            txtDemandaMensal.Text = dadosConsumo.TotalM3Mes.ToString("#####,##0.00");

            if (dadosConsumo.TotalM3Mes > 0)
                cbxCotacaoDolar.Focus();
            else
                txtDemandaMensal.Focus();
        }

        public double CalculaAreaTotal(ArrayList area)
        {
            double areaTotal = 0;
            foreach (AreaM2 item in area)
            {
                areaTotal += ((AreaM2)item).M2;
            }
            return areaTotal;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularProjeto();
        }

        public void CarregarPeriodos()
        {
            if (!cbxMunicipios.Text.Trim().Equals(string.Empty))
            {
                cbxPeriodo.Enabled = true;
                int codMunicipio = Conversor.ConverterParaInteiro(cbxMunicipios.SelectedValue);
                MedicoesCTL medicoesCTL = new MedicoesCTL();

                cbxPeriodo.DisplayMember = "Periodo";
                cbxPeriodo.ValueMember = "codMedicao";
                cbxPeriodo.DataSource = medicoesCTL.ConsultarPeriodoMedicao(codMunicipio).Tables[0];
            }
            else
                cbxPeriodo.Enabled = false;
        }

        private void cbxMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarPeriodos();
        }

        private void btnViabilidade_Click(object sender, EventArgs e)
        {
            tabCtrlCalculos.SelectedTab = tabCtrlCalculos.TabPages[1]; 
        }

        private void FrmPrincipal_Shown(object sender, EventArgs e)
        {
            FrmProjeto projeto = new FrmProjeto();
            projeto.ShowDialog();
            if (DadosProjetoDOM.CodProjeto > 0)
            {
                CarregarProjetos();
                cbxNomeProjeto.SelectedValue = Conversor.ConverterParaInteiro(DadosProjetoDOM.CodProjeto.ToString());
                CarregarDadosCalculos();
                cbxMunicipios.Focus();
            }
            else
            {
                this.Close();
            }
        }

        public void CarregarProjetos()
        {
            ProjetosCTL projetosCTL = new ProjetosCTL();
            projetosCTL.CarregarProjetosComboBox(ref cbxNomeProjeto);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                CalculosDOM calculosDOM = new CalculosDOM();

                calculosDOM.CodProjeto = DadosProjetoDOM.CodProjeto;
                calculosDOM.CodMunicipio = Conversor.ConverterParaInteiro(cbxMunicipios.SelectedValue.ToString());
                calculosDOM.CodMedicao = Conversor.ConverterParaInteiro(cbxPeriodo.SelectedValue.ToString());
                calculosDOM.CustoM3Agua = Conversor.ConverterParaDouble(txtCustoM3Agua.Text);
                calculosDOM.AreaCaptacao = Conversor.ConverterParaDouble(txtAreaCaptacao.Text);
                calculosDOM.DemandaMensal = Conversor.ConverterParaDouble(txtDemandaMensal.Text);
                calculosDOM.CotacaoDollar = Conversor.ConverterParaDouble(txtCotacaoDolar.Text);
                calculosDOM.VolReservatorio = Conversor.ConverterParaDouble(txtTamanhoReservatorio.Text);
                calculosDOM.EconomiaAnual = Conversor.ConverterParaDouble(txtEconomiaAnual.Text);
                calculosDOM.DespesaAnual = Conversor.ConverterParaDouble(txtDespesaAnual.Text);
                calculosDOM.TaxaAtratividade = Conversor.ConverterParaDouble(txtTMA.Text);
                calculosDOM.AnosRetorno = Conversor.ConverterParaInteiro(txtRetornoAnos.Text);

                CalculosCTL calculosCTL = new CalculosCTL();
                calculosCTL.ManterCalculos(EOperacao.Incluir, calculosDOM);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados." + ex.Message.ToString());
            }

        }

        private void cbxNomeProjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbxNomeProjeto.SelectedValue != null) && (!cbxNomeProjeto.SelectedValue.Equals(-1)))
            {
                ProjetosCTL projetosCTL = new ProjetosCTL();
                int categoria = projetosCTL.ObterCategoriaProjeto(Conversor.ConverterParaInteiro(cbxNomeProjeto.SelectedValue.ToString()));


                if (projetosCTL.VerificarProjeto(cbxNomeProjeto.Text, categoria))
                    CarregarDadosCalculos();
            }
        }

        public void CarregarDadosCalculos()
        {
            CalculosDOM calculosDOM = new CalculosDOM();
            CalculosCTL calculosCTL = new CalculosCTL();
            calculosDOM = calculosCTL.ConsultarCalculos();

            if (calculosDOM.CodMunicipio > 0)
                cbxMunicipios.SelectedValue = calculosDOM.CodMunicipio;
            else
                cbxMunicipios.SelectedValue = -1;

            if (calculosDOM.CodMedicao > 0)
                cbxPeriodo.SelectedValue = calculosDOM.CodMedicao;
            else
                cbxPeriodo.SelectedValue = -1;

            txtCustoM3Agua.Text = calculosDOM.CustoM3Agua.ToString("###,##0.00");
            txtAreaCaptacao.Text = calculosDOM.AreaCaptacao.ToString("###,##0.00");
            txtDemandaMensal.Text = calculosDOM.DemandaMensal.ToString("###,##0.00");
            txtCotacaoDolar.Text = calculosDOM.CotacaoDollar.ToString("###,##0.00");
            txtTamanhoReservatorio.Text = calculosDOM.VolReservatorio.ToString("###,##0.00");
            txtEconomiaAnual.Text = calculosDOM.EconomiaAnual.ToString("###,##0.00");
            txtDespesaAnual.Text = calculosDOM.DespesaAnual.ToString("###,##0.00");
            txtTMA.Text = calculosDOM.TaxaAtratividade.ToString("###,##0.00");
            txtRetornoAnos.Text = calculosDOM.AnosRetorno.ToString();

            if (calculosDOM.CodMunicipio > 0 && calculosDOM.CodMedicao > 0)
            {
                CalcularProjeto();
                CalcularViabilidadeEconomica();
                FormatarGridCalculo();
                FormatarGridViabilidade();
            }
            else
            {
                dgvDados.DataSource = null;
                FormatarGridCalculo();
                dgvViabilidade.DataSource = null;
                FormatarGridViabilidade();

                txtVolChuvaTotal.Text = "0,00";
                txtCustoDolar.Text = "0,00";
                txtCustoReal.Text = "0,00";
                txtInvestInicial.Text = "0,00";
                txtResultado.Text = string.Empty;
            }
        }

        public void CalcularProjeto()
        {
            double tamanhoReservatorio = Conversor.ConverterParaDouble(txtTamanhoReservatorio.Text); 
            double totalChuvaMensal = 0;
            int codMedicao = Conversor.ConverterParaInteiro(cbxPeriodo.SelectedValue);
            double areaCaptacao = Conversor.ConverterParaDouble(txtAreaCaptacao.Text);
            double demandaMensal = Conversor.ConverterParaDouble(txtDemandaMensal.Text);
            double custoReservatorioDolar = 0;
            double dolar = Conversor.ConverterParaDouble(txtCotacaoDolar.Text);
            int codProjeto = DadosProjetoDOM.CodProjeto;
            double demandaCalculada = 0;
            double valorConsumoCalculado = 0;
            double custoM3Agua = Conversor.ConverterParaDouble(txtCustoM3Agua.Text);

            EstimativaCTL estimativaCTL = new EstimativaCTL();
            estimativaCTL.DemandaCalculada(ref demandaCalculada, ref valorConsumoCalculado, DadosProjetoDOM.CodProjeto);

            if (Conversor.ConverterParaDouble(txtTamanhoReservatorio.Text) <= 0)
            {
                MessageBox.Show("Favor informar o volume do Reservatório Fixado (m³).");
                txtTamanhoReservatorio.Focus();
                return;
            }

            else if ((demandaCalculada > 0) && (valorConsumoCalculado > 0))
            {
                txtCustoM3Agua.Enabled = false;
                txtCustoM3Agua.Text = string.Empty;
            }

            if ((valorConsumoCalculado <= 0) && (!txtCustoM3Agua.Enabled) && (custoM3Agua.Equals(0)))
            {
                CalculosCTL calculosCTL = new CalculosCTL();
                valorConsumoCalculado = calculosCTL.CalcularCustodaAgua(tamanhoReservatorio) / demandaMensal;
                if (valorConsumoCalculado <= 0)
                {
                    MessageBox.Show("Informe o Custo do (m³) da água consumida, ou cadastre as contas de consumo.");
                    txtCustoM3Agua.Enabled = true;
                    txtCustoM3Agua.Focus();
                    return;
                }

            }
            else if (custoM3Agua > 0) 
            { 
                txtCustoM3Agua.Enabled = false;
                valorConsumoCalculado = Conversor.ConverterParaDouble(txtCustoM3Agua.Text);
            }

            if (cbxMunicipios.SelectedValue.Equals(-1))
            {
                MessageBox.Show("Favor selecionar o Município.");
                cbxMunicipios.Focus();
            }
            else if (codMedicao <= 0)
            {
                MessageBox.Show("Favor selecionar o período.");
                cbxPeriodo.Focus();
            }
            else if (areaCaptacao <= 0)
            {
                MessageBox.Show("Favor informar a Área de Captação em (m2).");
                txtAreaCaptacao.Focus();
            }
            else if (demandaMensal <= 0)
            {
                if (demandaCalculada > 0)
                {
                    if (MessageBox.Show("Demanda Constante Mensal não informada.Deseja usar a demanda mensal das contas cadastradas?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
                        txtDemandaMensal.Text = demandaCalculada.ToString("###,##0.00");
                }
                else
                {
                    MessageBox.Show("Favor cadastrar as contas de consumo para o projeto, e informar a Demanda Constante Mensal (m3).");
                    txtDemandaMensal.Focus();
                }
            }
            else if (valorConsumoCalculado <= 0)
            {
                MessageBox.Show("Não foi possível obter o custo do metro cúbico da água consumida mensalmente.");


            }
            else if (dolar <= 0)
            {
                cbxCotacaoDolar.Checked = true;
                dolar = Conversor.ConverterParaDouble(txtCotacaoDolar.Text);

                if (dolar <= 0)
                {
                    MessageBox.Show("Favor informar a cotação do dolar.");
                    cbxCotacaoDolar.Checked = false;
                }
            }
           
            else
            {
                ArrayList arrayEstimativa = estimativaCTL.CalcularEstimativa(codMedicao, areaCaptacao, demandaMensal, tamanhoReservatorio, ref totalChuvaMensal);

                if (arrayEstimativa != null)
                {
                    dgvDados.DataSource = arrayEstimativa;
                }

                custoReservatorioDolar = estimativaCTL.ValordoReservatorio(tamanhoReservatorio);
                txtCustoDolar.Text = custoReservatorioDolar.ToString("#,###,##0.00");

                txtCustoReal.Text = (Conversor.ConverterParaDouble(txtCustoDolar.Text) * dolar).ToString("#,###,##0.00");
                txtInvestInicial.Text = (Conversor.ConverterParaDouble(txtCustoDolar.Text) * dolar).ToString("#,###,##0.00");
                txtEconomiaAnual.Text = estimativaCTL.ViabilidadeEconomica(totalChuvaMensal, demandaMensal, custoM3Agua, codProjeto).ToString("#,###,##0.00");
                btnViabilidadeEconomica.Enabled = (custoReservatorioDolar > 0);
                txtVolChuvaTotal.Text = totalChuvaMensal.ToString("#,###,##0");
            }
        }

        public void CalcularViabilidadeEconomica()
        {
            int anos = Conversor.ConverterParaInteiro(txtRetornoAnos.Text);
            ArrayList arrayVpl = new ArrayList();
            int anoAtual = DateTime.Now.Year;
            double investimentoInicial = Conversor.ConverterParaDouble(txtInvestInicial.Text);
            double tma = 1 + (Conversor.ConverterParaDouble(txtTMA.Text) / 100);
            double economiaAnual = Conversor.ConverterParaDouble(txtEconomiaAnual.Text);
            double despesaAnual = 0; // Conversor.ConverterParaDouble(txtDespesaAnual.Text);
            double totalViabilidade = 0;

            if (!investimentoInicial.Equals(0))
                despesaAnual = investimentoInicial * 0.10;

            txtDespesaAnual.Text = despesaAnual.ToString("###,##0.00");


            for (int i = 0; i <= anos; i++)
            {
                VplDOM novoVpl = new VplDOM();

                novoVpl.Ano = i;

                if (i.Equals(0))
                    novoVpl.ValorVPL = (investimentoInicial * (-1)) / Math.Pow(tma, i);
                else
                    novoVpl.ValorVPL = (economiaAnual - despesaAnual) / Math.Pow(tma, i);

                totalViabilidade += novoVpl.ValorVPL;

                arrayVpl.Add(novoVpl);
            }

            if (totalViabilidade > 0)
                txtResultado.Text = "VPL = " + totalViabilidade.ToString("###,###,##0.00") + " - Projeto viável.";
            else if (totalViabilidade < 0)
                txtResultado.Text = "VPL = " + totalViabilidade.ToString("###,###,##0.00") + " - Projeto inviável.";

            dgvViabilidade.DataSource = arrayVpl;
        
        }


        public void FormatarGridCalculo()
        {
            dgvDados.Columns.Clear();
            System.Windows.Forms.DataGridViewCellStyle dgvEstilo = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvEstilo2 = new System.Windows.Forms.DataGridViewCellStyle();


            // mes
            
            colunaGridModelo = new DataGridViewTextBoxColumn();
            colunaGridModelo.DataPropertyName = "mes";
            colunaGridModelo.HeaderText = "Meses";
            colunaGridModelo.Name = "mes";
            colunaGridModelo.Width = 100;
            colunaGridModelo.Visible = true;
            colunaGridModelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colunaGridModelo.Resizable = DataGridViewTriState.False;

            dgvEstilo.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvEstilo.NullValue = null;
            colunaGridModelo.DefaultCellStyle = dgvEstilo;
            dgvDados.Columns.Add(colunaGridModelo);

            // formatação das demais colunas
            dgvEstilo2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgvEstilo2.Format = "####0.0";
            dgvEstilo2.NullValue = null;


            // MediaMensal
            colunaGridModelo = new DataGridViewTextBoxColumn();
            colunaGridModelo.DataPropertyName = "MediaMensal";
            colunaGridModelo.HeaderText = "Chuva Média Mensal (mm)";
            colunaGridModelo.Name = "MediaMensal";
            colunaGridModelo.Width = 110;
            colunaGridModelo.Visible = true;
            colunaGridModelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colunaGridModelo.Resizable = DataGridViewTriState.False;
            colunaGridModelo.DefaultCellStyle = dgvEstilo2;
            dgvDados.Columns.Add(colunaGridModelo);


            // DemandaMensal
            colunaGridModelo = new DataGridViewTextBoxColumn();
            colunaGridModelo.DataPropertyName = "DemandaMensal";
            colunaGridModelo.HeaderText = "Demanda Constante Mensal (m³)";
            colunaGridModelo.Name = "DemandaMensal";
            colunaGridModelo.Width = 110;
            colunaGridModelo.Visible = true;
            colunaGridModelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colunaGridModelo.Resizable = DataGridViewTriState.False;
            colunaGridModelo.DefaultCellStyle = dgvEstilo2;
            dgvDados.Columns.Add(colunaGridModelo);

            // AreadeCaptacao
            colunaGridModelo = new DataGridViewTextBoxColumn();
            colunaGridModelo.DataPropertyName = "AreadeCaptacao";
            colunaGridModelo.HeaderText = "Área de Captação (m²)";
            colunaGridModelo.Name = "AreadeCaptacao";
            colunaGridModelo.Width = 120;
            colunaGridModelo.Visible = true;
            colunaGridModelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colunaGridModelo.Resizable = DataGridViewTriState.False;
            colunaGridModelo.DefaultCellStyle = dgvEstilo2;
            dgvDados.Columns.Add(colunaGridModelo);

            // VolChuvaMes
            colunaGridModelo = new DataGridViewTextBoxColumn();
            colunaGridModelo.DataPropertyName = "VolChuvaMes";
            colunaGridModelo.HeaderText = "Volume de Chuva Mensal C=0,80 (m³)";
            colunaGridModelo.Name = "VolChuvaMes";
            colunaGridModelo.Width = 110;
            colunaGridModelo.Visible = true;
            colunaGridModelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colunaGridModelo.Resizable = DataGridViewTriState.False;
            colunaGridModelo.DefaultCellStyle = dgvEstilo2;
            dgvDados.Columns.Add(colunaGridModelo);
 
            
            // VolReservatorioFixado
            colunaGridModelo = new DataGridViewTextBoxColumn();
            colunaGridModelo.DataPropertyName = "VolReservatorioFixado";
            colunaGridModelo.HeaderText = "Volume do Reservatório fixado (m³)";
            colunaGridModelo.Name = "VolReservatorioFixado";
            colunaGridModelo.Width = 110;
            colunaGridModelo.Visible = true;
            colunaGridModelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colunaGridModelo.Resizable = DataGridViewTriState.False;
            colunaGridModelo.DefaultCellStyle = dgvEstilo2;
            dgvDados.Columns.Add(colunaGridModelo);


            // VolReservatorioTempoTM1
            colunaGridModelo = new DataGridViewTextBoxColumn();
            colunaGridModelo.DataPropertyName = "VolReservatorioTempoTM1";
            colunaGridModelo.HeaderText = "Volume do Reservatório no tempo t-1 (m³)";
            colunaGridModelo.Name = "VolReservatorioTempoTM1";
            colunaGridModelo.Width = 120;
            colunaGridModelo.Visible = true;
            colunaGridModelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colunaGridModelo.Resizable = DataGridViewTriState.False;
            colunaGridModelo.DefaultCellStyle = dgvEstilo2;
            dgvDados.Columns.Add(colunaGridModelo);


            // VolReservatorioTempoT
            colunaGridModelo = new DataGridViewTextBoxColumn();
            colunaGridModelo.DataPropertyName = "VolReservatorioTempoT";
            colunaGridModelo.HeaderText = "Volume do Reservatório no tempo t. (m³)";
            colunaGridModelo.Name = "VolReservatorioTempoT";
            colunaGridModelo.Width = 120;
            colunaGridModelo.Visible = true;
            colunaGridModelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colunaGridModelo.Resizable = DataGridViewTriState.False;
            colunaGridModelo.DefaultCellStyle = dgvEstilo2;
            dgvDados.Columns.Add(colunaGridModelo);
 
            // Overflow
            colunaGridModelo = new DataGridViewTextBoxColumn();
            colunaGridModelo.DataPropertyName = "Overflow";
            colunaGridModelo.HeaderText = "Overflow (m³)";
            colunaGridModelo.Name = "Overflow";
            colunaGridModelo.Width = 110;
            colunaGridModelo.Visible = true;
            colunaGridModelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colunaGridModelo.Resizable = DataGridViewTriState.False;
            colunaGridModelo.DefaultCellStyle = dgvEstilo2;
            dgvDados.Columns.Add(colunaGridModelo);


            // SuprimentoAguaExt
            colunaGridModelo = new DataGridViewTextBoxColumn();
            colunaGridModelo.DataPropertyName = "SuprimentoAguaExt";
            colunaGridModelo.HeaderText = "Suprimento de Água Externo (m³)";
            colunaGridModelo.Name = "SuprimentoAguaExt";
            colunaGridModelo.Width = 120;
            colunaGridModelo.Visible = true;
            colunaGridModelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colunaGridModelo.Resizable = DataGridViewTriState.False;
            colunaGridModelo.DefaultCellStyle = dgvEstilo2;
            dgvDados.Columns.Add(colunaGridModelo);

        
        }



        public void FormatarGridViabilidade()
        {
            dgvViabilidade.Columns.Clear();
            System.Windows.Forms.DataGridViewCellStyle dgvEstilo1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvEstilo2 = new System.Windows.Forms.DataGridViewCellStyle();


            // Ano
            colunaGridModelo = new DataGridViewTextBoxColumn();
            colunaGridModelo.DataPropertyName = "Ano";
            colunaGridModelo.HeaderText = "Ano";
            colunaGridModelo.Name = "Ano";
            colunaGridModelo.Width = 100;
            colunaGridModelo.Visible = true;
            colunaGridModelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colunaGridModelo.Resizable = DataGridViewTriState.False;
            dgvEstilo1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgvEstilo1.Format = "####0";
            dgvEstilo1.NullValue = null;
            colunaGridModelo.DefaultCellStyle = dgvEstilo1;
            dgvViabilidade.Columns.Add(colunaGridModelo);

            // Valor Presente Liquido
            colunaGridModelo = new DataGridViewTextBoxColumn();
            colunaGridModelo.DataPropertyName = "ValorVPL";
            colunaGridModelo.HeaderText = "Valor Presente";
            colunaGridModelo.Name = "ValorVPL";
            colunaGridModelo.Width = 228;
            colunaGridModelo.Visible = true;
            colunaGridModelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colunaGridModelo.Resizable = DataGridViewTriState.False;
            dgvEstilo2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgvEstilo2.Format = "N2";
            dgvEstilo2.NullValue = "0";
            colunaGridModelo.DefaultCellStyle = dgvEstilo2;
            dgvViabilidade.Columns.Add(colunaGridModelo);
        
        }

        private void btnTarifas_Click(object sender, EventArgs e)
        {
            FrmTarifas tarifas = new FrmTarifas();
            tarifas.ShowDialog();

        }

        private void cbxNomeProjeto_TextChanged(object sender, EventArgs e)
        {
            int Pos = cbxNomeProjeto.SelectionStart;
            cbxNomeProjeto.Text = cbxNomeProjeto.Text.ToUpper();
            cbxNomeProjeto.SelectionStart = Pos;
        }

    }
}
