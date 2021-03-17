namespace WaterSaving
{
    partial class FrmMedicoes
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
            this.dgvMedicoes = new System.Windows.Forms.DataGridView();
            this.CodMedicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cbxMunicipios = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJaneiro = new TextMascara.TextMascara();
            this.txtFevereiro = new TextMascara.TextMascara();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarco = new TextMascara.TextMascara();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAbril = new TextMascara.TextMascara();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAgosto = new TextMascara.TextMascara();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJulho = new TextMascara.TextMascara();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJunho = new TextMascara.TextMascara();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaio = new TextMascara.TextMascara();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDezembro = new TextMascara.TextMascara();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNovembro = new TextMascara.TextMascara();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOutubro = new TextMascara.TextMascara();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSetembro = new TextMascara.TextMascara();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nudAnoInicio = new System.Windows.Forms.NumericUpDown();
            this.nudAnoFinal = new System.Windows.Forms.NumericUpDown();
            this.txtGeral = new TextMascara.TextMascara();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicoes)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicoes
            // 
            this.dgvMedicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodMedicao,
            this.DescMunicipio,
            this.anoInicial,
            this.anoFinal});
            this.dgvMedicoes.Location = new System.Drawing.Point(22, 305);
            this.dgvMedicoes.Name = "dgvMedicoes";
            this.dgvMedicoes.Size = new System.Drawing.Size(684, 189);
            this.dgvMedicoes.TabIndex = 36;
            this.dgvMedicoes.SelectionChanged += new System.EventHandler(this.dgvTipoTelhado_SelectionChanged);
            this.dgvMedicoes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTipoTelhado_KeyDown);
            this.dgvMedicoes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvTipoTelhado_KeyDown);
            this.dgvMedicoes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvTipoTelhado_MouseDown);
            this.dgvMedicoes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvTipoTelhado_MouseDown);
            // 
            // CodMedicao
            // 
            this.CodMedicao.DataPropertyName = "CodMedicao";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CodMedicao.DefaultCellStyle = dataGridViewCellStyle1;
            this.CodMedicao.HeaderText = "Código da Medicao";
            this.CodMedicao.Name = "CodMedicao";
            this.CodMedicao.Visible = false;
            // 
            // DescMunicipio
            // 
            this.DescMunicipio.DataPropertyName = "DescMunicipio";
            this.DescMunicipio.HeaderText = "Descrição do Municipio";
            this.DescMunicipio.Name = "DescMunicipio";
            this.DescMunicipio.Width = 343;
            // 
            // anoInicial
            // 
            this.anoInicial.DataPropertyName = "anoInicial";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.anoInicial.DefaultCellStyle = dataGridViewCellStyle2;
            this.anoInicial.HeaderText = "Ano Inicial";
            this.anoInicial.Name = "anoInicial";
            this.anoInicial.Width = 180;
            // 
            // anoFinal
            // 
            this.anoFinal.DataPropertyName = "anoFinal";
            this.anoFinal.HeaderText = "Ano Final";
            this.anoFinal.Name = "anoFinal";
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
            this.panel1.Size = new System.Drawing.Size(731, 55);
            this.panel1.TabIndex = 37;
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
            // cbxMunicipios
            // 
            this.cbxMunicipios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMunicipios.FormattingEnabled = true;
            this.cbxMunicipios.Location = new System.Drawing.Point(92, 65);
            this.cbxMunicipios.Name = "cbxMunicipios";
            this.cbxMunicipios.Size = new System.Drawing.Size(220, 21);
            this.cbxMunicipios.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 68;
            this.label11.Text = "Município";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Período";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Janeiro";
            // 
            // txtJaneiro
            // 
            this.txtJaneiro.Location = new System.Drawing.Point(92, 30);
            this.txtJaneiro.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtJaneiro.MaxLength = 32767;
            this.txtJaneiro.Name = "txtJaneiro";
            this.txtJaneiro.Size = new System.Drawing.Size(105, 20);
            this.txtJaneiro.TabIndex = 13;
            this.txtJaneiro.Teste = 0;
            // 
            // txtFevereiro
            // 
            this.txtFevereiro.Location = new System.Drawing.Point(92, 56);
            this.txtFevereiro.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtFevereiro.MaxLength = 32767;
            this.txtFevereiro.Name = "txtFevereiro";
            this.txtFevereiro.Size = new System.Drawing.Size(105, 20);
            this.txtFevereiro.TabIndex = 14;
            this.txtFevereiro.Teste = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "Fevereiro";
            // 
            // txtMarco
            // 
            this.txtMarco.Location = new System.Drawing.Point(92, 82);
            this.txtMarco.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtMarco.MaxLength = 32767;
            this.txtMarco.Name = "txtMarco";
            this.txtMarco.Size = new System.Drawing.Size(105, 20);
            this.txtMarco.TabIndex = 15;
            this.txtMarco.Teste = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "Março";
            // 
            // txtAbril
            // 
            this.txtAbril.Location = new System.Drawing.Point(92, 108);
            this.txtAbril.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtAbril.MaxLength = 32767;
            this.txtAbril.Name = "txtAbril";
            this.txtAbril.Size = new System.Drawing.Size(105, 20);
            this.txtAbril.TabIndex = 16;
            this.txtAbril.Teste = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 78;
            this.label5.Text = "Abril";
            // 
            // txtAgosto
            // 
            this.txtAgosto.Location = new System.Drawing.Point(322, 108);
            this.txtAgosto.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtAgosto.MaxLength = 32767;
            this.txtAgosto.Name = "txtAgosto";
            this.txtAgosto.Size = new System.Drawing.Size(105, 20);
            this.txtAgosto.TabIndex = 20;
            this.txtAgosto.Teste = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 86;
            this.label6.Text = "Agosto";
            // 
            // txtJulho
            // 
            this.txtJulho.Location = new System.Drawing.Point(322, 82);
            this.txtJulho.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtJulho.MaxLength = 32767;
            this.txtJulho.Name = "txtJulho";
            this.txtJulho.Size = new System.Drawing.Size(105, 20);
            this.txtJulho.TabIndex = 19;
            this.txtJulho.Teste = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 84;
            this.label7.Text = "Julho";
            // 
            // txtJunho
            // 
            this.txtJunho.Location = new System.Drawing.Point(322, 56);
            this.txtJunho.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtJunho.MaxLength = 32767;
            this.txtJunho.Name = "txtJunho";
            this.txtJunho.Size = new System.Drawing.Size(105, 20);
            this.txtJunho.TabIndex = 18;
            this.txtJunho.Teste = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(269, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 82;
            this.label8.Text = "Junho";
            // 
            // txtMaio
            // 
            this.txtMaio.Location = new System.Drawing.Point(322, 30);
            this.txtMaio.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtMaio.MaxLength = 32767;
            this.txtMaio.Name = "txtMaio";
            this.txtMaio.Size = new System.Drawing.Size(105, 20);
            this.txtMaio.TabIndex = 17;
            this.txtMaio.Teste = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(277, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 80;
            this.label9.Text = "Maio";
            // 
            // txtDezembro
            // 
            this.txtDezembro.Location = new System.Drawing.Point(563, 111);
            this.txtDezembro.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtDezembro.MaxLength = 32767;
            this.txtDezembro.Name = "txtDezembro";
            this.txtDezembro.Size = new System.Drawing.Size(105, 20);
            this.txtDezembro.TabIndex = 24;
            this.txtDezembro.Teste = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(484, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 94;
            this.label10.Text = "Dezembro";
            // 
            // txtNovembro
            // 
            this.txtNovembro.Location = new System.Drawing.Point(563, 82);
            this.txtNovembro.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtNovembro.MaxLength = 32767;
            this.txtNovembro.Name = "txtNovembro";
            this.txtNovembro.Size = new System.Drawing.Size(105, 20);
            this.txtNovembro.TabIndex = 23;
            this.txtNovembro.Teste = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(484, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 92;
            this.label12.Text = "Novembro";
            // 
            // txtOutubro
            // 
            this.txtOutubro.Location = new System.Drawing.Point(563, 56);
            this.txtOutubro.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtOutubro.MaxLength = 32767;
            this.txtOutubro.Name = "txtOutubro";
            this.txtOutubro.Size = new System.Drawing.Size(105, 20);
            this.txtOutubro.TabIndex = 22;
            this.txtOutubro.Teste = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(498, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 90;
            this.label13.Text = "Outubro";
            // 
            // txtSetembro
            // 
            this.txtSetembro.Location = new System.Drawing.Point(563, 30);
            this.txtSetembro.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtSetembro.MaxLength = 32767;
            this.txtSetembro.Name = "txtSetembro";
            this.txtSetembro.Size = new System.Drawing.Size(105, 20);
            this.txtSetembro.TabIndex = 21;
            this.txtSetembro.Teste = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(487, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 88;
            this.label14.Text = "Setembro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaio);
            this.groupBox1.Controls.Add(this.txtDezembro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtJaneiro);
            this.groupBox1.Controls.Add(this.txtNovembro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtFevereiro);
            this.groupBox1.Controls.Add(this.txtOutubro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtMarco);
            this.groupBox1.Controls.Add(this.txtSetembro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtAbril);
            this.groupBox1.Controls.Add(this.txtAgosto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtJulho);
            this.groupBox1.Controls.Add(this.txtJunho);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 152);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Média Mensal de Chuva";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(172, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 17);
            this.label15.TabIndex = 97;
            this.label15.Text = "a ";
            // 
            // nudAnoInicio
            // 
            this.nudAnoInicio.Location = new System.Drawing.Point(92, 92);
            this.nudAnoInicio.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.nudAnoInicio.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudAnoInicio.Name = "nudAnoInicio";
            this.nudAnoInicio.Size = new System.Drawing.Size(68, 20);
            this.nudAnoInicio.TabIndex = 11;
            this.nudAnoInicio.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // nudAnoFinal
            // 
            this.nudAnoFinal.Location = new System.Drawing.Point(198, 92);
            this.nudAnoFinal.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.nudAnoFinal.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudAnoFinal.Name = "nudAnoFinal";
            this.nudAnoFinal.Size = new System.Drawing.Size(68, 20);
            this.nudAnoFinal.TabIndex = 12;
            this.nudAnoFinal.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // txtGeral
            // 
            this.txtGeral.Location = new System.Drawing.Point(344, 92);
            this.txtGeral.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtGeral.MaxLength = 32767;
            this.txtGeral.Name = "txtGeral";
            this.txtGeral.Size = new System.Drawing.Size(105, 20);
            this.txtGeral.TabIndex = 95;
            this.txtGeral.Teste = 0;
            this.txtGeral.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 98;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMedicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGeral);
            this.Controls.Add(this.nudAnoFinal);
            this.Controls.Add(this.nudAnoInicio);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxMunicipios);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvMedicoes);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMedicoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medições";
            this.Load += new System.EventHandler(this.FrmMedicoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicoes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cbxMunicipios;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TextMascara.TextMascara txtJaneiro;
        private TextMascara.TextMascara txtFevereiro;
        private System.Windows.Forms.Label label3;
        private TextMascara.TextMascara txtMarco;
        private System.Windows.Forms.Label label4;
        private TextMascara.TextMascara txtAbril;
        private System.Windows.Forms.Label label5;
        private TextMascara.TextMascara txtAgosto;
        private System.Windows.Forms.Label label6;
        private TextMascara.TextMascara txtJulho;
        private System.Windows.Forms.Label label7;
        private TextMascara.TextMascara txtJunho;
        private System.Windows.Forms.Label label8;
        private TextMascara.TextMascara txtMaio;
        private System.Windows.Forms.Label label9;
        private TextMascara.TextMascara txtDezembro;
        private System.Windows.Forms.Label label10;
        private TextMascara.TextMascara txtNovembro;
        private System.Windows.Forms.Label label12;
        private TextMascara.TextMascara txtOutubro;
        private System.Windows.Forms.Label label13;
        private TextMascara.TextMascara txtSetembro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudAnoInicio;
        private System.Windows.Forms.NumericUpDown nudAnoFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodMedicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoFinal;
        private TextMascara.TextMascara txtGeral;
        private System.Windows.Forms.Button button1;
    }
}