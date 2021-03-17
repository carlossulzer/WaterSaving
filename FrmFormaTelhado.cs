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
    public partial class FrmFormaTelhado : Form
    {
        public EFormaTelhado FormaEscolhida { get; set; }

        public Button BotaoEscolhido { get; set; }

        public double AreaM2 { get; set; }

        public FrmFormaTelhado()
        {
            InitializeComponent();
            
        }

        public void Escolhadaforma()
        {
            btnForma.Image = this.BotaoEscolhido.Image;
            InicializarCampos(this.FormaEscolhida);
            txtCampo1.Focus();
        
        }

        private void FrmFormaTelhado_Shown(object sender, EventArgs e)
        {
            Escolhadaforma();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            
            switch (FormaEscolhida)
            {
                  
                case EFormaTelhado.TrianguloEquilatero:
                    double lado1 = Conversor.ConverterParaDouble(txtCampo1.Text);
                    this.AreaM2 = Math.Round((Math.Pow(lado1,2) *  Math.Sqrt(3)) / 4, 2);
                    break;
                case EFormaTelhado.Quadrado:
                    double lado = Conversor.ConverterParaDouble(txtCampo1.Text);
                    this.AreaM2 = lado * lado;
                    break;
                case EFormaTelhado.Retangulo:
                    double baseRetangulo = Conversor.ConverterParaDouble(txtCampo1.Text);
                    double alturaRetangulo = Conversor.ConverterParaDouble(txtCampo2.Text);
                    this.AreaM2 = baseRetangulo * alturaRetangulo;
                    break;
                case EFormaTelhado.trianguloIsoceles:
                    double baseTriangulo = Conversor.ConverterParaDouble(txtCampo1.Text);
                    double alturaTriangulo = Conversor.ConverterParaDouble(txtCampo2.Text);
                    this.AreaM2 = (baseTriangulo * alturaTriangulo) / 2;
                    break;
                case EFormaTelhado.Poligono:
                    double numeroLados = Conversor.ConverterParaDouble(txtCampo1.Text);
                    double medidaLado = Conversor.ConverterParaDouble(txtCampo2.Text);
                    double apotema = Conversor.ConverterParaDouble(txtCampo3.Text);                    
                    this.AreaM2 = (numeroLados * medidaLado * apotema) / 2;
                    break;
                case EFormaTelhado.Paralelogramo:
                    double baseParalelogramo = Conversor.ConverterParaDouble(txtCampo1.Text);
                    double alturaParalelogramo = Conversor.ConverterParaDouble(txtCampo2.Text);
                    this.AreaM2 = baseParalelogramo * alturaParalelogramo;
                    break;
                case EFormaTelhado.Trapezio:
                    double baseMaior = Conversor.ConverterParaDouble(txtCampo1.Text);
                    double baseMenor = Conversor.ConverterParaDouble(txtCampo2.Text);
                    double altura = Conversor.ConverterParaDouble(txtCampo3.Text);
                    this.AreaM2 = ((baseMaior + baseMenor) * altura)/2;
                    break;
                case EFormaTelhado.TrapezioRetangulo: // verificar formula
                    double baseMaior1 = Conversor.ConverterParaDouble(txtCampo1.Text);
                    double baseMenor2 = Conversor.ConverterParaDouble(txtCampo2.Text);
                    double ladoObliquo = Conversor.ConverterParaDouble(txtCampo3.Text);
                    this.AreaM2 = ((baseMaior1 + baseMenor2) * ladoObliquo) / 2;
                    break;
                case EFormaTelhado.Circulo:
                    double raio = 0; //Conversor.ConverterParaDouble(txtCampo1.Text);
                    double diametro = Conversor.ConverterParaDouble(txtCampo1.Text);
                    
                    if (diametro > 0)
                        raio = diametro / 2;

                    this.AreaM2 = (3.14 * (raio*raio));

                    break;
                default:
                    break;
            }
            Close();
        }


        public void InicializarCampos(EFormaTelhado forma)
        {
            switch (forma)
            {
                case EFormaTelhado.TrianguloEquilatero: // verificar formula
                    HabilitarCampos(true, false, false);
                    TituloCampos("Lado ", "", "");
                    break;
                case EFormaTelhado.Quadrado:
                    HabilitarCampos(true, false, false);
                    TituloCampos("Lado", "", "");
                    break;
                case EFormaTelhado.Retangulo:
                    HabilitarCampos(true, true, false);
                    TituloCampos("Base", "Altura", "");
                    break;
                case EFormaTelhado.trianguloIsoceles:
                    HabilitarCampos(true, true, false);
                    TituloCampos("Base", "Altura", "");
                    break;
                case EFormaTelhado.Poligono:
                    HabilitarCampos(true, true, true);
                    TituloCampos("Nº de Lados", "Medida do Lado", "Apótema");
                    break;
                case EFormaTelhado.Paralelogramo:
                    HabilitarCampos(true, true, false);
                    TituloCampos("Base", "Altura", "");
                    break;
                case EFormaTelhado.Trapezio:
                    HabilitarCampos(true, true, true);
                    TituloCampos("Base Maior", "Base Menor", "Altura");
                    break;
                case EFormaTelhado.TrapezioRetangulo: // verificar formula
                    HabilitarCampos(true, true, true);
                    TituloCampos("Base Maior", "Base Menor", "Lado Oblíquo");                    
                    break;
                case EFormaTelhado.Circulo:
                    HabilitarCampos(true, false, false);
                    //TituloCampos("Raio", "Diâmetro", "");                    
                    TituloCampos("Diâmetro", "", "");                    
                    break;
                default:
                    break;
            }
        
        }
        public void HabilitarCampos(bool status1, bool status2, bool status3)
        {
            lblCampo1.Visible = status1;
            txtCampo1.Visible = status1;
            lblCampo2.Visible = status2;
            txtCampo2.Visible = status2;
            lblCampo3.Visible = status3;
            txtCampo3.Visible = status3;
        
        }

        public void TituloCampos(string titulo1, string titulo2, string titulo3)
        {
            lblCampo1.Text = titulo1;
            lblCampo2.Text = titulo2;
            lblCampo3.Text = titulo3;
        
        }
    }
}
