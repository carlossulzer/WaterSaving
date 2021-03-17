using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WaterSaving
{
    public partial class FrmContas : Form
    {
        public EOperacao operacao;
        public int codigoConta = 0;
        BindingSource bsource = new BindingSource();
        DataSet dsDados = new DataSet();


        public FrmContas()
        {
            InitializeComponent();
        }

        private void FrmContas_Load(object sender, EventArgs e)
        {
            CarregarMes();
            mtxtAno.Text = DateTime.Now.Year.ToString();
            HabilitarDesabilitar(false);
            CarregarContas();
        }

        private void mtxtConsumo_TextChanged(object sender, EventArgs e)
        {
            txtLitros.Text = Convert.ToString(Conversor.ConverterParaInteiro(mtxtConsumo.Text) * 100);
        }


        public void CarregarMes()
        {
            cbxMes.DisplayMember = "Descricao";
            cbxMes.ValueMember = "Mes";
            cbxMes.DataSource = Meses.CarregaMeses().Tables[0];
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos.Limpar(this);
            operacao = EOperacao.Incluir;
            codigoConta = 0;
            HabilitarDesabilitar(true);

            cbxMes.SelectedValue = DateTime.Now.Month.ToString();
            mtxtAno.Text = DateTime.Now.Year.ToString();

        }

        public void HabilitarDesabilitar(bool status)
        {
            btnNovo.Enabled = !status;
            btnAlterar.Enabled = !status;
            btnExcluir.Enabled = !status;
            btnSalvar.Enabled = status;
            btnCancelar.Enabled = status;
            btnSair.Enabled = !status;

            cbxMes.Enabled = status;
            mtxtAno.Enabled = status;
            mtxtConsumo.Enabled = status;
            txtValor.Enabled = status;

            dgvContas.Enabled = !status;

            if (status)
            {
                cbxMes.Focus();
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

            if (MessageBox.Show("Deseja Excluir a Conta?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ContasDOM novaConta = new ContasDOM();
                novaConta.CodConta = codigoConta;

                ContasCTL contasCTL = new ContasCTL();
                contasCTL.ManterContas(operacao, novaConta);
            }

            CarregarContas();
            operacao = EOperacao.Inicial;

        }


        public void CarregarContas()
        {
            FormatarGridView.Formatar(dgvContas);

            ContasCTL contasCTL = new ContasCTL();

            dsDados = contasCTL.ConsultarContas();
            bsource.DataSource = dsDados.Tables["contas"];
            dgvContas.DataSource = bsource;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ContasDOM contasDOM = new ContasDOM();
                contasDOM.CodProjeto = DadosProjetoDOM.CodProjeto;
                contasDOM.CodConta = codigoConta;
                contasDOM.Mes = cbxMes.SelectedValue == null ? DateTime.Now.Month : Conversor.ConverterParaInteiro(cbxMes.SelectedValue);
                contasDOM.Ano = Conversor.ConverterParaInteiro(mtxtAno.Text);
                contasDOM.Consumo = Conversor.ConverterParaDouble(mtxtConsumo.Text);
                contasDOM.Valor = Conversor.ConverterParaDouble(txtValor.Text);

                ContasCTL contasCTL = new ContasCTL();
                contasCTL.ManterContas(operacao, contasDOM);

                CarregarContas();
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
            CarregarContas();
            HabilitarDesabilitar(false);

        }


        public void PosicionarRegistro()
        {
            if (dgvContas.Rows.Count > 0)
            {
                if (dgvContas.CurrentRow.Cells[0].Value != null)
                    codigoConta = Convert.ToInt32(dgvContas.CurrentRow.Cells[0].Value.ToString());

                cbxMes.DataBindings.Clear();
                cbxMes.DataBindings.Add("SelectedValue", bsource, "Mes");

                mtxtAno.DataBindings.Clear();
                mtxtAno.DataBindings.Add("Text", bsource, "Ano");

                mtxtConsumo.DataBindings.Clear();
                mtxtConsumo.DataBindings.Add("Text", bsource, "Consumo");

                txtValor.DataBindings.Clear();
                txtValor.DataBindings.Add("Text", bsource, "Valor");


                bsource.Position = dgvContas.CurrentRow.Index;
                this.BindingContext[dsDados.Tables["contas"]].Position = dgvContas.CurrentRow.Index;

                txtLitros.Text = Convert.ToString(Conversor.ConverterParaDouble(mtxtConsumo.Text) * 1000);

            }
            else
                LimparCampos.Limpar(this);
        }

        private void dgvContas_KeyDown(object sender, KeyEventArgs e)
        {
            PosicionarRegistro();
        }

        private void dgvContas_MouseDown(object sender, MouseEventArgs e)
        {
            PosicionarRegistro();
        }

        private void dgvContas_SelectionChanged(object sender, EventArgs e)
        {
            PosicionarRegistro();
        }

        private void mtxtConsumo_Leave(object sender, EventArgs e)
        {
            txtLitros.Text = Convert.ToString(Conversor.ConverterParaDouble(mtxtConsumo.Text) * 1000);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ContasCTL contasCTL = new ContasCTL();
            contasCTL.Dados("R");
            CarregarContas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContasCTL contasCTL = new ContasCTL();
            contasCTL.Dados("U");
            CarregarContas();
        }



    }
}