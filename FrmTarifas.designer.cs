namespace WaterSaving
{
    partial class FrmTarifas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvTarifas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtMetros1 = new TextMascara.TextMascara();
            this.txtValorAgua = new TextMascara.TextMascara();
            this.cbxConsumo1 = new System.Windows.Forms.ComboBox();
            this.cbxConsumo2 = new System.Windows.Forms.ComboBox();
            this.mtxtMetros2 = new TextMascara.TextMascara();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorEsgoto = new TextMascara.TextMascara();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxMunicipios = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CodTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorAgua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorEsgoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consumo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "M³";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 55);
            this.panel1.TabIndex = 23;
            // 
            // btnSair
            // 
            this.btnSair.Image = global::WaterSaving.Properties.Resources.Sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(393, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnSair.Size = new System.Drawing.Size(75, 48);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sai&r";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::WaterSaving.Properties.Resources.cancelarp;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(315, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCancelar.Size = new System.Drawing.Size(75, 48);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::WaterSaving.Properties.Resources.salvarp;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(237, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnSalvar.Size = new System.Drawing.Size(75, 48);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::WaterSaving.Properties.Resources.excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(159, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnExcluir.Size = new System.Drawing.Size(75, 48);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::WaterSaving.Properties.Resources.alterar;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(81, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnAlterar.Size = new System.Drawing.Size(75, 48);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::WaterSaving.Properties.Resources.novo;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(3, 2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnNovo.Size = new System.Drawing.Size(75, 48);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvTarifas
            // 
            this.dgvTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodTarifa,
            this.DescMunicipio,
            this.Consumo1,
            this.descCategoria,
            this.descricao,
            this.ValorAgua,
            this.ValorEsgoto});
            this.dgvTarifas.Location = new System.Drawing.Point(6, 245);
            this.dgvTarifas.Name = "dgvTarifas";
            this.dgvTarifas.Size = new System.Drawing.Size(764, 204);
            this.dgvTarifas.TabIndex = 15;
            this.dgvTarifas.SelectionChanged += new System.EventHandler(this.dgvTarifas_SelectionChanged);
            this.dgvTarifas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTarifas_KeyDown);
            this.dgvTarifas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvTarifas_KeyDown);
            this.dgvTarifas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvTarifas_MouseDown);
            this.dgvTarifas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvTarifas_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Valor da Tarifa de Água R$";
            // 
            // mtxtMetros1
            // 
            this.mtxtMetros1.Location = new System.Drawing.Point(275, 122);
            this.mtxtMetros1.Mascara = TextMascara.TextMascara.TipoMascara.Numero;
            this.mtxtMetros1.MaxLength = 4;
            this.mtxtMetros1.Name = "mtxtMetros1";
            this.mtxtMetros1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mtxtMetros1.Size = new System.Drawing.Size(70, 20);
            this.mtxtMetros1.TabIndex = 10;
            this.mtxtMetros1.Teste = 0;
            // 
            // txtValorAgua
            // 
            this.txtValorAgua.Location = new System.Drawing.Point(182, 179);
            this.txtValorAgua.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtValorAgua.MaxLength = 32767;
            this.txtValorAgua.Name = "txtValorAgua";
            this.txtValorAgua.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValorAgua.Size = new System.Drawing.Size(94, 20);
            this.txtValorAgua.TabIndex = 13;
            this.txtValorAgua.Teste = 0;
            // 
            // cbxConsumo1
            // 
            this.cbxConsumo1.FormattingEnabled = true;
            this.cbxConsumo1.Location = new System.Drawing.Point(86, 121);
            this.cbxConsumo1.Name = "cbxConsumo1";
            this.cbxConsumo1.Size = new System.Drawing.Size(156, 21);
            this.cbxConsumo1.TabIndex = 9;
            this.cbxConsumo1.SelectedIndexChanged += new System.EventHandler(this.cbxConsumo1_SelectedIndexChanged);
            // 
            // cbxConsumo2
            // 
            this.cbxConsumo2.FormattingEnabled = true;
            this.cbxConsumo2.Location = new System.Drawing.Point(86, 148);
            this.cbxConsumo2.Name = "cbxConsumo2";
            this.cbxConsumo2.Size = new System.Drawing.Size(156, 21);
            this.cbxConsumo2.TabIndex = 11;
            // 
            // mtxtMetros2
            // 
            this.mtxtMetros2.Location = new System.Drawing.Point(275, 148);
            this.mtxtMetros2.Mascara = TextMascara.TextMascara.TipoMascara.Numero;
            this.mtxtMetros2.MaxLength = 4;
            this.mtxtMetros2.Name = "mtxtMetros2";
            this.mtxtMetros2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mtxtMetros2.Size = new System.Drawing.Size(70, 20);
            this.mtxtMetros2.TabIndex = 12;
            this.mtxtMetros2.Teste = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "M³";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Consumo";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(86, 94);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(259, 21);
            this.cbxCategoria.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Categoria";
            // 
            // txtValorEsgoto
            // 
            this.txtValorEsgoto.Location = new System.Drawing.Point(182, 205);
            this.txtValorEsgoto.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtValorEsgoto.MaxLength = 32767;
            this.txtValorEsgoto.Name = "txtValorEsgoto";
            this.txtValorEsgoto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValorEsgoto.Size = new System.Drawing.Size(94, 20);
            this.txtValorEsgoto.TabIndex = 14;
            this.txtValorEsgoto.Teste = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Valor da Tarifa de Esgoto R$";
            // 
            // cbxMunicipios
            // 
            this.cbxMunicipios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMunicipios.FormattingEnabled = true;
            this.cbxMunicipios.Location = new System.Drawing.Point(86, 67);
            this.cbxMunicipios.Name = "cbxMunicipios";
            this.cbxMunicipios.Size = new System.Drawing.Size(259, 21);
            this.cbxMunicipios.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Município";
            // 
            // CodTarifa
            // 
            this.CodTarifa.DataPropertyName = "CodTarifa";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CodTarifa.DefaultCellStyle = dataGridViewCellStyle1;
            this.CodTarifa.HeaderText = "Código";
            this.CodTarifa.Name = "CodTarifa";
            this.CodTarifa.Visible = false;
            // 
            // DescMunicipio
            // 
            this.DescMunicipio.DataPropertyName = "DescMunicipio";
            this.DescMunicipio.HeaderText = "Município";
            this.DescMunicipio.Name = "DescMunicipio";
            this.DescMunicipio.Width = 200;
            // 
            // Consumo1
            // 
            this.Consumo1.DataPropertyName = "Consumo1";
            this.Consumo1.HeaderText = "Consumo1";
            this.Consumo1.Name = "Consumo1";
            this.Consumo1.Visible = false;
            // 
            // descCategoria
            // 
            this.descCategoria.DataPropertyName = "descCategoria";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.descCategoria.DefaultCellStyle = dataGridViewCellStyle2;
            this.descCategoria.HeaderText = "Categoria";
            this.descCategoria.Name = "descCategoria";
            this.descCategoria.Width = 120;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.descricao.DefaultCellStyle = dataGridViewCellStyle3;
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.Width = 160;
            // 
            // ValorAgua
            // 
            this.ValorAgua.DataPropertyName = "ValorAgua";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.ValorAgua.DefaultCellStyle = dataGridViewCellStyle4;
            this.ValorAgua.HeaderText = "Valor Água R$";
            this.ValorAgua.Name = "ValorAgua";
            this.ValorAgua.Width = 110;
            // 
            // ValorEsgoto
            // 
            this.ValorEsgoto.DataPropertyName = "ValorEsgoto";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.ValorEsgoto.DefaultCellStyle = dataGridViewCellStyle5;
            this.ValorEsgoto.HeaderText = "Valor Esgoto R$";
            this.ValorEsgoto.Name = "ValorEsgoto";
            this.ValorEsgoto.Width = 110;
            // 
            // FrmTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 454);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxMunicipios);
            this.Controls.Add(this.txtValorEsgoto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtMetros2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxConsumo2);
            this.Controls.Add(this.cbxConsumo1);
            this.Controls.Add(this.txtValorAgua);
            this.Controls.Add(this.mtxtMetros1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvTarifas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTarifas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Tarifas Por Faixa de Consumo";
            this.Load += new System.EventHandler(this.FrmTarifas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvTarifas;
        private System.Windows.Forms.Label label5;
        private TextMascara.TextMascara mtxtMetros1;
        private TextMascara.TextMascara txtValorAgua;
        private System.Windows.Forms.ComboBox cbxConsumo1;
        private System.Windows.Forms.ComboBox cbxConsumo2;
        private TextMascara.TextMascara mtxtMetros2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label label2;
        private TextMascara.TextMascara txtValorEsgoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxMunicipios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodTarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consumo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorAgua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorEsgoto;
    }
}