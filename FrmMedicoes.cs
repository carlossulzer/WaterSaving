using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WaterSaving
{
    public partial class FrmMedicoes : Form
    {
        public int AnoInicial { get; set; }
        public int AnoFinal { get; set; }

        public EOperacao operacao;
        public int codigoMedicao = 0;
        BindingSource bsource = new BindingSource();
        DataSet dsDados = new DataSet();
        public FrmMedicoes()
        {
            InitializeComponent();
            CarregarMunicipios();
            CarregarMedicoes();
        }

        public void CarregarMunicipios()
        {
            MunicipiosCTL municipiosCTL = new MunicipiosCTL();

            cbxMunicipios.DisplayMember = "DescMunicipio";
            cbxMunicipios.ValueMember = "codMunicipio";
            cbxMunicipios.DataSource = municipiosCTL.ConsultarMunicipios().Tables[0];
        }

        private void FrmMedicoes_Load(object sender, EventArgs e)
        {
            HabilitarDesabilitar(false);
            CarregarMedicoes();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos.Limpar(this);
            operacao = EOperacao.Incluir;
            codigoMedicao = 0;
            HabilitarDesabilitar(true);
            nudAnoInicio.Value = (AnoInicial > 0 ? AnoInicial : nudAnoInicio.Minimum);
            nudAnoFinal.Value = (AnoFinal > 0 ? AnoFinal : nudAnoFinal.Minimum);
  
        }

        public void HabilitarDesabilitar(bool status)
        {
            btnNovo.Enabled = !status;
            btnAlterar.Enabled = !status;
            btnExcluir.Enabled = !status;
            btnSalvar.Enabled = status;
            btnCancelar.Enabled = status;
            btnSair.Enabled = !status;

            cbxMunicipios.Enabled = status;
            nudAnoInicio.Enabled = status;
            nudAnoFinal.Enabled = status;
            txtJaneiro.Enabled = status;
            txtFevereiro.Enabled = status;
            txtMarco.Enabled = status;
            txtAbril.Enabled = status;
            txtMaio.Enabled = status;
            txtJunho.Enabled = status;
            txtJulho.Enabled = status;
            txtAgosto.Enabled = status;
            txtSetembro.Enabled = status;
            txtOutubro.Enabled = status;
            txtNovembro.Enabled = status;
            txtDezembro.Enabled = status;

            dgvMedicoes.Enabled = !status;

            if (status)
            {
                cbxMunicipios.Focus();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            operacao = EOperacao.Alterar;
            HabilitarDesabilitar(true);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            operacao = EOperacao.Excluir;

            if (MessageBox.Show("Deseja Excluir a Medição?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MedicoesDOM medicoesDOM = new MedicoesDOM();
                medicoesDOM.CodMedicao = codigoMedicao;

                MedicoesCTL medicoesCTL = new MedicoesCTL();
                medicoesCTL.ManterMedicoes(operacao, medicoesDOM);
            }

            CarregarMedicoes();
            operacao = EOperacao.Inicial;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbxMunicipios.SelectedValue.ToString().Equals("-1"))
                {
                    MessageBox.Show("Favor selecionar o município");
                    return;
                }

                MedicoesDOM medicoesDOM = new MedicoesDOM();
                medicoesDOM.CodMedicao = codigoMedicao;
                medicoesDOM.CodMunicipio = Conversor.ConverterParaInteiro(cbxMunicipios.SelectedValue.ToString());
                medicoesDOM.AnoInicial = Conversor.ConverterParaInteiro(nudAnoInicio.Value.ToString());
                medicoesDOM.AnoFinal = Conversor.ConverterParaInteiro(nudAnoFinal.Value.ToString());
                medicoesDOM.Janeiro = Conversor.ConverterParaDouble(txtJaneiro.Text);
                medicoesDOM.Fevereiro = Conversor.ConverterParaDouble(txtFevereiro.Text);
                medicoesDOM.Marco = Conversor.ConverterParaDouble(txtMarco.Text);
                medicoesDOM.Abril = Conversor.ConverterParaDouble(txtAbril.Text);
                medicoesDOM.Maio = Conversor.ConverterParaDouble(txtMaio.Text);
                medicoesDOM.Junho = Conversor.ConverterParaDouble(txtJunho.Text);
                medicoesDOM.Julho = Conversor.ConverterParaDouble(txtJulho.Text);
                medicoesDOM.Agosto = Conversor.ConverterParaDouble(txtAgosto.Text);
                medicoesDOM.Setembro = Conversor.ConverterParaDouble(txtSetembro.Text);
                medicoesDOM.Outubro = Conversor.ConverterParaDouble(txtOutubro.Text);
                medicoesDOM.Novembro = Conversor.ConverterParaDouble(txtNovembro.Text);
                medicoesDOM.Dezembro = Conversor.ConverterParaDouble(txtDezembro.Text);

                MedicoesCTL medicoesCTL = new MedicoesCTL();
                medicoesCTL.ManterMedicoes(operacao, medicoesDOM);

                CarregarMedicoes();
                HabilitarDesabilitar(false);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados." + ex.Message.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            operacao = EOperacao.Inicial;
            CarregarMedicoes();
            HabilitarDesabilitar(false);
        }

        public void PosicionarRegistro()
        {
            if (dgvMedicoes.Rows.Count > 0)
            {
                if (dgvMedicoes.CurrentRow.Cells[0].Value != null)
                    codigoMedicao = Convert.ToInt32(dgvMedicoes.CurrentRow.Cells[0].Value.ToString());

                cbxMunicipios.DataBindings.Clear();
                cbxMunicipios.DataBindings.Add("SelectedValue", bsource, "CodMunicipio");

                nudAnoInicio.DataBindings.Clear();
                nudAnoInicio.DataBindings.Add("Text", bsource, "AnoInicial");
                AnoInicial = Convert.ToInt32(dgvMedicoes.CurrentRow.Cells[2].Value.ToString());

                nudAnoFinal.DataBindings.Clear();
                nudAnoFinal.DataBindings.Add("Text", bsource, "AnoFinal");
                AnoFinal = Convert.ToInt32(dgvMedicoes.CurrentRow.Cells[3].Value.ToString());

                txtJaneiro.DataBindings.Clear();
                txtJaneiro.DataBindings.Add("Text", bsource, "Janeiro");

                txtFevereiro.DataBindings.Clear();
                txtFevereiro.DataBindings.Add("Text", bsource, "Fevereiro");

                txtMarco.DataBindings.Clear();
                txtMarco.DataBindings.Add("Text", bsource, "Marco");

                txtAbril.DataBindings.Clear();
                txtAbril.DataBindings.Add("Text", bsource, "Abril");

                txtMaio.DataBindings.Clear();
                txtMaio.DataBindings.Add("Text", bsource, "Maio");

                txtJunho.DataBindings.Clear();
                txtJunho.DataBindings.Add("Text", bsource, "Junho");

                txtJulho.DataBindings.Clear();
                txtJulho.DataBindings.Add("Text", bsource, "Julho");

                txtAgosto.DataBindings.Clear();
                txtAgosto.DataBindings.Add("Text", bsource, "Agosto");

                txtSetembro.DataBindings.Clear();
                txtSetembro.DataBindings.Add("Text", bsource, "Setembro");

                txtOutubro.DataBindings.Clear();
                txtOutubro.DataBindings.Add("Text", bsource, "Outubro");

                txtNovembro.DataBindings.Clear();
                txtNovembro.DataBindings.Add("Text", bsource, "Novembro");

                txtDezembro.DataBindings.Clear();
                txtDezembro.DataBindings.Add("Text", bsource, "Dezembro");

                bsource.Position = dgvMedicoes.CurrentRow.Index;
                this.BindingContext[dsDados.Tables["medicoes"]].Position = dgvMedicoes.CurrentRow.Index;

            }
            else
                LimparCampos.Limpar(this);
        }
        public void CarregarMedicoes()
        {
            FormatarGridView.Formatar(dgvMedicoes);

            MedicoesCTL medicoesCTL = new MedicoesCTL();

            dsDados = medicoesCTL.ConsultarMedicoes();
            bsource.DataSource = dsDados.Tables["Medicoes"];
            dgvMedicoes.DataSource = bsource;

        }

        private void dgvTipoTelhado_KeyDown(object sender, KeyEventArgs e)
        {
            PosicionarRegistro();
        }

        private void dgvTipoTelhado_MouseDown(object sender, MouseEventArgs e)
        {
            PosicionarRegistro();
        }

        private void dgvTipoTelhado_SelectionChanged(object sender, EventArgs e)
        {
            PosicionarRegistro();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nudAnoInicio.Value = 1971;
            nudAnoFinal.Value = 2000;

            txtJaneiro.Text = txtGeral.Text;
            txtFevereiro.Text = txtGeral.Text;
            txtMarco.Text = txtGeral.Text;
            txtAbril.Text = txtGeral.Text;
            txtMaio.Text = txtGeral.Text;
            txtJunho.Text = txtGeral.Text;
            txtJulho.Text = txtGeral.Text;
            txtAgosto.Text = txtGeral.Text;
            txtSetembro.Text = txtGeral.Text;
            txtOutubro.Text = txtGeral.Text;
            txtNovembro.Text = txtGeral.Text;
            txtDezembro.Text = txtGeral.Text;


        }

    }
}
