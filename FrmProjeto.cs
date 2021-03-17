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
    public partial class FrmProjeto : Form
    {
        public FrmProjeto()
        {
            InitializeComponent();
            CarregarProjetos();
            CarregarCategorias();
        }

        public void CarregarProjetos()
        {
            ProjetosCTL projetosCTL = new ProjetosCTL();
            projetosCTL.CarregarProjetosComboBox(ref cbxNomeProjeto);
        }

        private void cbxNomeProjeto_TextChanged(object sender, EventArgs e)
        {
            int Pos = cbxNomeProjeto.SelectionStart;
            cbxNomeProjeto.Text = cbxNomeProjeto.Text.ToUpper();
            cbxNomeProjeto.SelectionStart = Pos;

            if (!cbxNomeProjeto.Items.Contains(cbxNomeProjeto.Text))
                cbxCategoria.Enabled = true;



        }
        private void CarregarCategorias()
        {
            CategoriasCTL categoriasCTL = new CategoriasCTL();
            categoriasCTL.CarregarCategorias(ref cbxCategoria);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (cbxCategoria.SelectedValue.Equals("-1"))
            {
                MessageBox.Show("Favor selecionar a categoria.");
                cbxCategoria.Focus();
                cbxCategoria.SelectAll();
                return;
            }

            ProjetosCTL projetosCTL = new ProjetosCTL();
            if (!projetosCTL.VerificarProjeto(cbxNomeProjeto.Text, Conversor.ConverterParaInteiro(cbxCategoria.SelectedValue.ToString())))
            {
               

                if (MessageBox.Show("O projeto não existe. Deseja incluí-lo?", "Novo Projeto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (!projetosCTL.CriarProjeto(cbxNomeProjeto.Text, Conversor.ConverterParaInteiro (cbxCategoria.SelectedValue.ToString())))
                        return;
                }
                else
                {
                    cbxNomeProjeto.Focus();
                    cbxNomeProjeto.SelectAll();
                    return;
                }
            }
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DadosProjetoDOM.CodProjeto = 0;
            Close();
        }

        private void cbxNomeProjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbxNomeProjeto.SelectedValue.Equals(-1))
            {
                ProjetosCTL projetosCTL = new ProjetosCTL();
                cbxCategoria.SelectedValue = projetosCTL.ObterCategoriaProjeto(Conversor.ConverterParaInteiro(cbxNomeProjeto.SelectedValue.ToString()));
                cbxCategoria.Enabled = false;
            }
            else
            {
                cbxCategoria.Enabled = true; 
            }
        }

    }
}
