using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WaterSaving
{
    public partial class FrmTarifas : Form
    {
        public EOperacao operacao;
        public int codigoTarifa = 0;
        BindingSource bsource = new BindingSource();
        DataSet dsDados = new DataSet();


        public FrmTarifas()
        {
            InitializeComponent();
        }

        private void FrmTarifas_Load(object sender, EventArgs e)
        {
            HabilitarDesabilitar(false);
            CarregarMunicipios();
            CarregarCategorias();
            CarregarConsumo();
            CarregarTarifas();
        }

        public void CarregarMunicipios()
        {
            MunicipiosCTL municipiosCTL = new MunicipiosCTL();

            cbxMunicipios.DisplayMember = "DescMunicipio";
            cbxMunicipios.ValueMember = "codMunicipio";
            cbxMunicipios.DataSource = municipiosCTL.ConsultarMunicipios().Tables[0];
        }

        public void CarregarConsumo()
        {
            TarifasCTL tarifasCTL = new TarifasCTL();
            tarifasCTL.CarregarConsumo1(ref cbxConsumo1);
            tarifasCTL.CarregarConsumo2(ref cbxConsumo2);
        }

        private void CarregarCategorias()
        {
            CategoriasCTL categoriasCTL = new CategoriasCTL();
            categoriasCTL.CarregarCategorias(ref cbxCategoria);
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparDados();
            operacao = EOperacao.Incluir;
            codigoTarifa = 0;
            HabilitarDesabilitar(true);

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
            cbxCategoria.Enabled = status;
            cbxConsumo1.Enabled = status;
            mtxtMetros1.Enabled = status;
            cbxConsumo2.Enabled = status;
            mtxtMetros2.Enabled = status;
            txtValorAgua.Enabled = status;
            txtValorEsgoto.Enabled = status;

            dgvTarifas.Enabled = !status;

            if (operacao.Equals(EOperacao.Alterar))
            {
                cbxConsumo2.Enabled = Conversor.ConverterParaInteiro(cbxConsumo1.SelectedValue.ToString()).Equals(2);
                mtxtMetros2.Enabled = Conversor.ConverterParaInteiro(cbxConsumo1.SelectedValue.ToString()).Equals(2);
            }



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

            if (MessageBox.Show("Deseja Excluir a Tarifa?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TarifasDOM novaTarifa = new TarifasDOM();
                novaTarifa.CodTarifa = codigoTarifa;

                TarifasCTL tarifasCTL = new TarifasCTL();
                tarifasCTL.ManterTarifas(operacao, novaTarifa);
            }
            
            CarregarTarifas();
            operacao = EOperacao.Inicial;

        }


        public void CarregarTarifas()
        {
            operacao = EOperacao.Inicial;
            FormatarGridView.Formatar(dgvTarifas);

            TarifasCTL tarifasCTL = new TarifasCTL();

            dsDados = tarifasCTL.ConsultarTarifas();
            bsource.DataSource = dsDados.Tables["tarifas"];
            dgvTarifas.DataSource = bsource;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbxMunicipios.SelectedValue.ToString().Equals("-1"))
                {
                    MessageBox.Show("Favor selecionar o município");
                    cbxMunicipios.Focus();
                    return;
                }
                else if (Conversor.ConverterParaDouble(txtValorAgua.Text) <= 0)
                {
                    MessageBox.Show("Favor informar o Valor da Água R$.");
                    txtValorAgua.Focus();
                    return;
                }
                else if (Conversor.ConverterParaDouble(txtValorAgua.Text) <= 0)
                {
                    MessageBox.Show("Favor informar o Valor do Esgoto R$.");
                    txtValorEsgoto.Focus();
                    return;
                }

                TarifasDOM tarifasDOM = new TarifasDOM();
                tarifasDOM.CodMunicipio = Conversor.ConverterParaInteiro(cbxMunicipios.SelectedValue.ToString());
                tarifasDOM.CodTarifa = codigoTarifa;
                tarifasDOM.Categoria = Conversor.ConverterParaInteiro(cbxCategoria.SelectedValue.ToString());
                tarifasDOM.Consumo1 = Conversor.ConverterParaInteiro(cbxConsumo1.SelectedValue.ToString());
                tarifasDOM.Metros1 = Conversor.ConverterParaInteiro(mtxtMetros1.Text);

                if (cbxConsumo2.SelectedValue != null)
                {
                    tarifasDOM.Consumo2 = Conversor.ConverterParaInteiro(cbxConsumo2.SelectedValue.ToString());
                    tarifasDOM.Metros2 = Conversor.ConverterParaInteiro(mtxtMetros2.Text);

                    if (tarifasDOM.Metros2 < tarifasDOM.Metros1)
                    {
                        MessageBox.Show("O valor do segundo consumo deve ser maior que o valor do primeiro consumo.");
                        cbxConsumo2.Focus();
                        return;
                    }
                }
                else
                {
                    tarifasDOM.Consumo2 = -1;
                    tarifasDOM.Metros2 = 0;                
                }


                tarifasDOM.ValorAgua = Conversor.ConverterParaDouble(txtValorAgua.Text);
                tarifasDOM.ValorEsgoto = Conversor.ConverterParaDouble(txtValorEsgoto.Text);


                TarifasCTL tarifasCTL = new TarifasCTL();
                tarifasCTL.ManterTarifas(operacao, tarifasDOM);

                CarregarTarifas();
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
            CarregarTarifas();
            HabilitarDesabilitar(false);

        }


        public void PosicionarRegistro()
        {
            if (dgvTarifas.Rows.Count > 0)
            {
                if (dgvTarifas.CurrentRow.Cells[0].Value != null)
                    codigoTarifa = Convert.ToInt32(dgvTarifas.CurrentRow.Cells[0].Value.ToString());

                cbxMunicipios.DataBindings.Clear();
                cbxMunicipios.DataBindings.Add("SelectedValue", bsource, "CodMunicipio");

                cbxCategoria.DataBindings.Clear();
                cbxCategoria.DataBindings.Add("SelectedValue", bsource, "Categoria");

                cbxConsumo1.DataBindings.Clear();
                cbxConsumo1.DataBindings.Add("SelectedValue", bsource, "Consumo1");

                mtxtMetros1.DataBindings.Clear();
                mtxtMetros1.DataBindings.Add("Text", bsource, "Metros1");

                cbxConsumo2.DataBindings.Clear();
                cbxConsumo2.DataBindings.Add("SelectedValue", bsource, "Consumo2");

                mtxtMetros2.DataBindings.Clear();
                mtxtMetros2.DataBindings.Add("Text", bsource, "Metros2");
              
                txtValorAgua.DataBindings.Clear();
                txtValorAgua.DataBindings.Add("Text", bsource, "ValorAgua");

                txtValorEsgoto.DataBindings.Clear();
                txtValorEsgoto.DataBindings.Add("Text", bsource, "ValorEsgoto");

                bsource.Position = dgvTarifas.CurrentRow.Index;
                this.BindingContext[dsDados.Tables["tarifas"]].Position = dgvTarifas.CurrentRow.Index;


            }
            else
                LimparDados();
        }

        private void dgvTarifas_KeyDown(object sender, KeyEventArgs e)
        {
            PosicionarRegistro();
        }

        private void dgvTarifas_MouseDown(object sender, MouseEventArgs e)
        {
            PosicionarRegistro();
        }

        private void dgvTarifas_SelectionChanged(object sender, EventArgs e)
        {
            PosicionarRegistro();
        }

        private void cbxConsumo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operacao.Equals(EOperacao.Incluir) || operacao.Equals(EOperacao.Alterar) )
            {
                cbxConsumo2.Enabled = Conversor.ConverterParaInteiro(cbxConsumo1.SelectedValue.ToString()).Equals(2);
                mtxtMetros2.Enabled = Conversor.ConverterParaInteiro(cbxConsumo1.SelectedValue.ToString()).Equals(2);

                if (!cbxConsumo2.Enabled)
                {
                    cbxConsumo2.SelectedValue = "-1";
                    mtxtMetros2.Text = string.Empty;
                }
                else
                    cbxConsumo2.SelectedValue = "1";
            }
        }

        public void LimparDados()
        {
            cbxMunicipios.SelectedValue = "-1";
            cbxCategoria.SelectedItem = null;
            cbxConsumo1.SelectedItem = null;
            cbxConsumo2.SelectedItem = null;
            LimparCampos.Limpar(this);
        }

    }
}