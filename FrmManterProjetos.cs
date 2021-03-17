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
    public partial class FrmManterProjetos : Form
    {
        public EOperacao operacao;
        public int codigoProjeto = 0;
        BindingSource bsource = new BindingSource();
        DataSet dsDados = new DataSet();

        public FrmManterProjetos()
        {
            InitializeComponent();
            CarregarProjetos();
            CarregarCategorias();
        }

        public void CarregarProjetos()
        {
            FormatarGridView.Formatar(dgvProjetos);

            ProjetosCTL projetosCTL = new ProjetosCTL();
            dsDados = projetosCTL.ConsultarProjetos(0);
            bsource.DataSource = dsDados.Tables["Projetos"];
            dgvProjetos.DataSource = bsource;

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
            LimparCampos.Limpar(this);
            operacao = EOperacao.Incluir;
            codigoProjeto = 0;
            HabilitarDesabilitar(true);
            txtData.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");

        }

        public void HabilitarDesabilitar(bool status)
        {
            btnNovo.Enabled = !status;
            btnAlterar.Enabled = !status;
            btnExcluir.Enabled = !status;
            btnSalvar.Enabled = status;
            btnCancelar.Enabled = status;
            btnSair.Enabled = !status;

            txtData.Enabled = status;
            txtNomeProjeto.Enabled = status;
            cbxCategoria.Enabled = status;
           
            dgvProjetos.Enabled = !status;

            if (status)
            {
                txtNomeProjeto.Focus();
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

            if (MessageBox.Show("Deseja Excluir o Projeto, as contas de consumo e os cálculo associados ?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProjetosDOM projetosDOM = new ProjetosDOM();
                projetosDOM.CodProjeto = codigoProjeto;

                ProjetosCTL projetosCTL = new ProjetosCTL();
                projetosCTL.ManterProjetos(operacao, projetosDOM);
            }

            CarregarProjetos();
            operacao = EOperacao.Inicial;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNomeProjeto.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Favor informar o nome do projeto");
                    return;
                }

                ProjetosDOM projetosDOM = new ProjetosDOM();
                projetosDOM.CodProjeto = codigoProjeto;
                projetosDOM.DataProjeto = Conversor.ConverterParaDateTime(txtData.Text);
                projetosDOM.NomeProjeto = txtNomeProjeto.Text;
                projetosDOM.Categoria =  Conversor.ConverterParaInteiro(cbxCategoria.SelectedValue.ToString());

                ProjetosCTL projetosCTL = new ProjetosCTL();
                projetosCTL.ManterProjetos(operacao, projetosDOM);

                CarregarProjetos();
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
            CarregarProjetos();
            HabilitarDesabilitar(false);
        }

        public void PosicionarRegistro()
        {
            if (dgvProjetos.Rows.Count > 0)
            {
                if (dgvProjetos.CurrentRow.Cells[0].Value != null)
                    codigoProjeto = Convert.ToInt32(dgvProjetos.CurrentRow.Cells[0].Value.ToString());

                txtData.DataBindings.Clear();

                txtData.DataBindings.Add("Text", bsource, "DataProjeto", true ); 

                txtNomeProjeto.DataBindings.Clear();
                txtNomeProjeto.DataBindings.Add("Text", bsource, "NomeProjeto");

                cbxCategoria.DataBindings.Clear();
                cbxCategoria.DataBindings.Add("SelectedValue", bsource, "Categoria");
               
                bsource.Position = dgvProjetos.CurrentRow.Index;
                this.BindingContext[dsDados.Tables["projetos"]].Position = dgvProjetos.CurrentRow.Index;

            }
            else
                LimparCampos.Limpar(this);
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

        private void FrmManterProjetos_Load(object sender, EventArgs e)
        {
            HabilitarDesabilitar(false);
            CarregarProjetos();
        }



    }
}
