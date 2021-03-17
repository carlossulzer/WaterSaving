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
    public partial class FrmConsumo : Form
    {
        public ArrayList AreasJardim { get; set; }
        public ArrayList AreasComuns { get; set; }
        public Consumo DadosConsumo { get; set; }


        public FrmConsumo()
        {
            InitializeComponent();
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegaM2_Click(object sender, EventArgs e)
        {
            FrmFormas areaCaptacao = new FrmFormas();
            areaCaptacao.Areas = AreasJardim;
            areaCaptacao.TituloArea = "Áreas de Jardins Que Serão Regados";
            areaCaptacao.ShowDialog();
            AreasJardim = areaCaptacao.Areas;
            txtNumRegaM2.Text = CalculaArea(AreasJardim);
        }

        private void btnLavagemM2_Click(object sender, EventArgs e)
        {
            FrmFormas areaCaptacao = new FrmFormas();
            areaCaptacao.Areas = AreasComuns;
            areaCaptacao.TituloArea = "Áreas Comuns Que Serão Lavadas";
            areaCaptacao.ShowDialog();
            AreasComuns = areaCaptacao.Areas;
            txtLavarAreaM2.Text = CalculaArea(AreasComuns);

        }

        private void FrmConsumo_Shown(object sender, EventArgs e)
        {
            CarregarDados();
            txtNumPessoas.Focus();
        }


        public string CalculaTotalM3()
        {
            double totalM3 = 0;
            int numPessoas = Conversor.ConverterParaInteiro(txtNumPessoas.Text);
            int numCarros = Conversor.ConverterParaInteiro(txtNumCarrosMes.Text);
            int numLavagemCarros = Conversor.ConverterParaInteiro(txtLavaCarrosMes.Text);
            int numRegaMes = Conversor.ConverterParaInteiro(txtNumRegaMes.Text);
            double areaRegaM2  = Conversor.ConverterParaDouble(txtNumRegaM2.Text);
            int numLavagemMes = Conversor.ConverterParaInteiro(txtLavarAreaMes.Text);
            double areaLavagemM2 = Conversor.ConverterParaDouble(txtLavarAreaM2.Text);

            if (cbxLavagemCarro.Checked)
            { 
               // numero de carros * 100 litros por carro * numero de vezes por mês
               totalM3 += (numCarros * 100 * numLavagemCarros); 
            }

            if (cbxLavagemArea.Checked)
            {
                // Area em M2 a ser lavada x 3 litros/dia/m2 x numero de lavagem no mês  
                totalM3 += (areaLavagemM2 * 3 * numLavagemMes);
            }

            if (cbxRegaJardim.Checked)
            {
                // Area em M2 do jardim x 0,8 litros/dia/m2 x numero de regas no mês  
                totalM3 += (areaRegaM2 * 0.8 * numRegaMes);
            }


            if ((cbxBaciaSanitaria.Checked) && numPessoas > 0)
            { 
                // numero de pessoas * 5 vezes ao dia * 30 dias * qtd Litros gasto por descarga
                if (rbtSanitario6l.Checked)  
                    totalM3 += numPessoas * 5 * 30 * 6;     // 6 litros a cada descarga
                else
                    totalM3 += numPessoas * 5 * 30 * 4.5;   // 3 ou 6 litros a cada descarga (média 4,5 litros)
            }

            return totalM3.ToString("#####,##0");
        }

        private void cbxLavagemCarro_CheckedChanged(object sender, EventArgs e)
        {
            txtTotalM3.Text = CalculaTotalM3();
        }

        private void txtNumPessoas_Leave(object sender, EventArgs e)
        {
            txtTotalM3.Text = CalculaTotalM3();
        }

        private void rbtSanitario6l_CheckedChanged(object sender, EventArgs e)
        {
            txtTotalM3.Text = CalculaTotalM3();
        }

        public string CalculaArea(ArrayList area)
        {
            double areaTotal = 0;
            foreach (AreaM2 item in area)
            {
                areaTotal += ((AreaM2)item).M2;
            }
            return areaTotal.ToString("###,##0.00");
        }

        private void cbxRegaJardim_CheckedChanged(object sender, EventArgs e)
        {
            txtTotalM3.Text = CalculaTotalM3();
            txtNumRegaMes.Enabled = cbxRegaJardim.Checked;
            txtNumRegaM2.Enabled = cbxRegaJardim.Checked;
            btnRegaM2.Enabled = cbxRegaJardim.Checked;
            txtNumRegaMes.Focus();
        }

        private void cbxLavagemArea_CheckedChanged(object sender, EventArgs e)
        {
            txtTotalM3.Text = CalculaTotalM3();
            txtLavarAreaMes.Enabled = cbxLavagemArea.Checked;
            txtLavarAreaM2.Enabled = cbxLavagemArea.Checked;
            btnLavagemM2.Enabled = cbxLavagemArea.Checked;
            txtLavarAreaMes.Focus();
        }

        private void cbxBaciaSanitaria_CheckedChanged(object sender, EventArgs e)
        {
            txtTotalM3.Text = CalculaTotalM3();
            rbtSanitario6l.Enabled = cbxBaciaSanitaria.Checked;
            rbtSanitario3ou6l.Enabled = cbxBaciaSanitaria.Checked;
            rbtSanitario6l.Focus();
        }

        private void cbxLavagemCarro_CheckedChanged_1(object sender, EventArgs e)
        {
            txtTotalM3.Text = CalculaTotalM3();
            txtNumCarrosMes.Enabled = cbxLavagemCarro.Checked;
            txtLavaCarrosMes.Enabled = cbxLavagemCarro.Checked;
            txtNumCarrosMes.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DadosConsumo.NumPessoas = Conversor.ConverterParaInteiro(txtNumPessoas.Text);
            DadosConsumo.LavagemdeCarro = cbxLavagemCarro.Checked;
            DadosConsumo.NumCarros = Conversor.ConverterParaInteiro(txtNumCarrosMes.Text);
            DadosConsumo.LavagemPorMes = Conversor.ConverterParaInteiro(txtLavaCarrosMes.Text);

            DadosConsumo.RegadeJardim = cbxRegaJardim.Checked;
            DadosConsumo.ReganoMes = Conversor.ConverterParaInteiro(txtNumRegaMes.Text);
            DadosConsumo.RegaM2 = Conversor.ConverterParaDouble(txtNumRegaM2.Text);

            DadosConsumo.LavagemAreaComum = cbxLavagemArea.Checked;
            DadosConsumo.LavagemAreaMes = Conversor.ConverterParaInteiro(txtLavarAreaMes.Text);
            DadosConsumo.LavagemAreaM2 = Conversor.ConverterParaDouble(txtLavarAreaM2.Text);

            DadosConsumo.BaciaSanitaria = cbxBaciaSanitaria.Checked;
            DadosConsumo.Bacia6L = rbtSanitario6l.Checked;
            DadosConsumo.Bacia3ou6L = rbtSanitario3ou6l.Checked;

            if (Conversor.ConverterParaDouble(txtTotalM3.Text) > 0)
                DadosConsumo.TotalM3Mes = Conversor.ConverterParaDouble(txtTotalM3.Text) / 1000;
            else
                DadosConsumo.TotalM3Mes = 0;

                Close();
        }

        public void CarregarDados()
        {
            if (DadosConsumo == null)
                return;

            txtNumPessoas.Text = DadosConsumo.NumPessoas.ToString();
            cbxLavagemCarro.Checked = DadosConsumo.LavagemdeCarro;
            txtNumCarrosMes.Text = DadosConsumo.NumCarros.ToString();
            txtLavaCarrosMes.Text = DadosConsumo.LavagemPorMes.ToString();

            cbxRegaJardim.Checked = DadosConsumo.RegadeJardim;
            txtNumRegaMes.Text = DadosConsumo.ReganoMes.ToString();
            txtNumRegaM2.Text = DadosConsumo.RegaM2.ToString();

            cbxLavagemArea.Checked = DadosConsumo.LavagemAreaComum;
            txtLavarAreaMes.Text = DadosConsumo.LavagemAreaMes.ToString();
            txtLavarAreaM2.Text = DadosConsumo.LavagemAreaM2.ToString();

            cbxBaciaSanitaria.Checked = DadosConsumo.BaciaSanitaria;
            rbtSanitario6l.Checked = DadosConsumo.Bacia6L;
            rbtSanitario3ou6l.Checked = DadosConsumo.Bacia3ou6L;

            txtTotalM3.Text = CalculaTotalM3();
        }

        private void txtNumRegaMes_Load(object sender, EventArgs e)
        {

        }
     
    }
}
