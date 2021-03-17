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
    public partial class FrmInsumoReservatorio : Form
    {

        public EOperacao operacao;
        public int codigoInsumo = 0;
        BindingSource bsource = new BindingSource();
        DataSet dsDados = new DataSet();

        public FrmInsumoReservatorio()
        {
            InitializeComponent();
        }

        private void FrmInsumoReservatorio_Load(object sender, EventArgs e)
        {
            HabilitarDesabilitar(false);
            CarregarInsumosReservatorio();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos.Limpar(this);
            operacao = EOperacao.Incluir;
            HabilitarDesabilitar(true);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            operacao = EOperacao.Alterar;
            HabilitarDesabilitar(true);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            operacao = EOperacao.Excluir;

            if (MessageBox.Show("Deseja Excluir o Insumo?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InsumoReservatorioDOM insumosReservatorioDOM = new InsumoReservatorioDOM();
                insumosReservatorioDOM.CodInsumo = codigoInsumo;
                insumosReservatorioDOM.Descricao = txtDescricao.Text;
                insumosReservatorioDOM.Quantidade = Conversor.ConverterParaDecimal(txtQuantidade.Text);
                insumosReservatorioDOM.PrecoUnitario = Conversor.ConverterParaDecimal(txtPrecoUnitario.Text);
                insumosReservatorioDOM.Unico = Conversor.ConverterParaBoolean(cbxUnica.Checked);

                InsumoReservatorioCTL insumosReservatorioCTL = new InsumoReservatorioCTL();
                insumosReservatorioCTL.ManterInsumoReservatorio(operacao, insumosReservatorioDOM);
            }

            CarregarInsumosReservatorio();
            operacao = EOperacao.Inicial;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                InsumoReservatorioDOM insumoReservatorioDOM = new InsumoReservatorioDOM();
                insumoReservatorioDOM.CodInsumo = codigoInsumo;
                insumoReservatorioDOM.Descricao = txtDescricao.Text;
                insumoReservatorioDOM.Quantidade = Conversor.ConverterParaDecimal(txtQuantidade.Text);
                insumoReservatorioDOM.PrecoUnitario = Conversor.ConverterParaDecimal(txtPrecoUnitario.Text);
                insumoReservatorioDOM.Unico = Conversor.ConverterParaBoolean(cbxUnica.Checked);

                InsumoReservatorioCTL insumoReservatorioCTL = new InsumoReservatorioCTL();
                insumoReservatorioCTL.ManterInsumoReservatorio(operacao, insumoReservatorioDOM);

                CarregarInsumosReservatorio();
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
            CarregarInsumosReservatorio();
            HabilitarDesabilitar(false);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void HabilitarDesabilitar(bool status)
        {
            btnNovo.Enabled = !status;
            btnAlterar.Enabled = !status;
            btnExcluir.Enabled = !status;
            btnSalvar.Enabled = status;
            btnCancelar.Enabled = status;
            btnSair.Enabled = !status;

            txtDescricao.Enabled = status;
            txtQuantidade.Enabled = status;
            txtPrecoUnitario.Enabled = status;
            cbxUnica.Enabled = status;

            dgvInsumos.Enabled = !status;

            if (status)
            {
                txtDescricao.Focus();
            }
        }

        public void CarregarInsumosReservatorio()
        {
            LimparCampos.Limpar(this); // novo
            FormatarGridView.Formatar(dgvInsumos);
            InsumoReservatorioCTL insumoReservatorioCTL = new InsumoReservatorioCTL();

            dsDados = insumoReservatorioCTL.ConsultarInsumoReservatorio();
            bsource.DataSource = dsDados.Tables["InsumoReservatorio"];
            dgvInsumos.DataSource = bsource;

        }

        public void PosicionarRegistro()
        {
            if (dgvInsumos.Rows.Count > 0)
            {
                if (dgvInsumos.CurrentRow.Cells[0].Value != null)
                    codigoInsumo = Convert.ToInt32(dgvInsumos.CurrentRow.Cells[0].Value.ToString());


                txtDescricao.DataBindings.Clear();
                txtDescricao.DataBindings.Add("Text", bsource, "Descricao");

                txtQuantidade.DataBindings.Clear();
                txtQuantidade.DataBindings.Add("Text", bsource, "Quantidade");

                txtPrecoUnitario.DataBindings.Clear();
                txtPrecoUnitario.DataBindings.Add("Text", bsource, "PrecoUnitario");

                cbxUnica.DataBindings.Clear();
                cbxUnica.DataBindings.Add("Checked", bsource, "Unico");


                bsource.Position = dgvInsumos.CurrentRow.Index;
                this.BindingContext[dsDados.Tables["InsumoReservatorio"]].Position = dgvInsumos.CurrentRow.Index;

            }
            else
                LimparCampos.Limpar(this);
        }

        
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            PosicionarRegistro();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            PosicionarRegistro();
        }

       
    }
}
