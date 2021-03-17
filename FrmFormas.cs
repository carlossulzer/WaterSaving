using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Collections;

namespace WaterSaving
{
    public partial class FrmFormas : Form
    {
        private BindingSource bsAreas = new BindingSource();
        public ArrayList Areas { get; set; }
        public string TituloArea { get; set; }
        

        public FrmFormas()
        {
            InitializeComponent();
        }


        private void FrmFormas_Shown(object sender, EventArgs e)
        {
            lblTituloArea.Text = TituloArea;
            FormatarGridTipoTelhadoPiso();
            CarregarDadosTipoTelhadoPiso();
        }


        private void FormatarGridTipoTelhadoPiso()
        {
            FormatarGridView.Formatar(dgvAreas);
            DataGridViewTextBoxColumn colunas = new DataGridViewTextBoxColumn();

            colunas.DataPropertyName = "Descricao";
            colunas.Name = "Descricao";
            colunas.HeaderText = "Descrição";
            colunas.Width = 380;
            dgvAreas.Columns.Add(colunas);

            colunas = new DataGridViewTextBoxColumn();
            colunas.DataPropertyName = "m2";
            colunas.Name = "m2";
            colunas.HeaderText = "M2";
            colunas.Width = 90;
            dgvAreas.Columns.Add(colunas);
        }

        public void CarregarDadosTipoTelhadoPiso()
        {
            foreach (AreaM2 item in Areas)
            {
                bsAreas.Add(item);
            }
            dgvAreas.DataSource = bsAreas;
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void BotaoEscolhido(object sender, EFormaTelhado forma)
        {
            FrmFormaTelhado formaTelhado = new FrmFormaTelhado();
            formaTelhado.FormaEscolhida = forma;
            formaTelhado.BotaoEscolhido = ((Button)sender);
            formaTelhado.ShowDialog();
            tabControl1.SelectedTab = tabControl1.TabPages[1];
            txtMetragem.Text = formaTelhado.AreaM2.ToString();
            txtDescricao.Focus();
        
        }

        private void btnForma1_Click(object sender, EventArgs e)
        {
            BotaoEscolhido(sender, EFormaTelhado.TrianguloEquilatero);
        }

        private void btnForma2_Click(object sender, EventArgs e)
        {
            BotaoEscolhido(sender, EFormaTelhado.Quadrado);
        }

        private void btnForma3_Click(object sender, EventArgs e)
        {
            BotaoEscolhido(sender, EFormaTelhado.Retangulo);
        }

        private void btnForma4_Click(object sender, EventArgs e)
        {
            BotaoEscolhido(sender, EFormaTelhado.trianguloIsoceles);
        }

        private void btnForma5_Click(object sender, EventArgs e)
        {
            BotaoEscolhido(sender, EFormaTelhado.Poligono);
        }

        private void btnForma6_Click(object sender, EventArgs e)
        {
            BotaoEscolhido(sender, EFormaTelhado.Paralelogramo);
        }

        private void btnForma7_Click(object sender, EventArgs e)
        {
            BotaoEscolhido(sender, EFormaTelhado.Trapezio);
        }

        private void btnForma8_Click(object sender, EventArgs e)
        {
            BotaoEscolhido(sender, EFormaTelhado.TrapezioRetangulo);
        }

        private void btnForma9_Click(object sender, EventArgs e)
        {
            BotaoEscolhido(sender, EFormaTelhado.Circulo);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Equals(tabControl1.TabPages[0]))
            {
                lblTitulo.Text = "Clique sobre a forma que mais se assemelha com o telhado a ser usado para captação da água da chuva";
                btnFechar.Visible = true;
            }
            else
            {
                lblTitulo.Text = "Caso não tenha escolhido uma forma pré-definida você poderá informa a metragem quadrada livremente";
                btnFechar.Visible = false;
                txtDescricao.Focus();
            }
        }


        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDescricao.Text)) 
            {
                MessageBox.Show("Favor informar a descrição da área.");
                txtDescricao.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtMetragem.Text))
            {
                MessageBox.Show("Favor informar a medida em M2 da área.");
                txtMetragem.Focus();
                return;
            }

            if (AreaExiste(txtDescricao.Text))
            {
                MessageBox.Show("Esta área já está cadastrada.");
                txtDescricao.SelectAll();
                txtDescricao.Focus();
                return;
            }

            AreaM2 novaArea = new AreaM2();
            novaArea.Descricao = txtDescricao.Text;
            novaArea.M2 = Conversor.ConverterParaDouble(txtMetragem.Text);

            Areas.Add(novaArea);
            bsAreas.Add(novaArea);

            dgvAreas.DataSource = bsAreas;
            btnExcluir.Enabled = (bsAreas.Count > 0);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }

        public void LimparCampos()
        {
            txtDescricao.Text = "";
            txtMetragem.Text = "";
            txtDescricao.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if ((dgvAreas.Rows.Count > 0) && (dgvAreas.CurrentRow.Selected))
            {
                Areas.RemoveAt(dgvAreas.CurrentRow.Index);
                dgvAreas.Rows.RemoveAt(dgvAreas.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Favor selecionar a área a ser excluida.");
                dgvAreas.Focus();
            }

            btnExcluir.Enabled = (dgvAreas.Rows.Count > 0);
        }

        private bool AreaExiste(string novaArea)
        {
            bool retorno = false;
            foreach (AreaM2 item in Areas)
            {
                if (item.Descricao.Equals(novaArea))
                    retorno = true;
            }
            return retorno;
        
        }

        private void FrmFormas_Load(object sender, EventArgs e)
        {

        }
        
    }
}
