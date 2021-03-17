namespace WaterSaving
{
    partial class FrmConsumo
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
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtNumPessoas = new TextMascara.TextMascara();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbxBaciaSanitaria = new System.Windows.Forms.CheckBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.rbtSanitario3ou6l = new System.Windows.Forms.RadioButton();
            this.rbtSanitario6l = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbxLavagemArea = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLavaCarrosMes = new TextMascara.TextMascara();
            this.txtNumCarrosMes = new TextMascara.TextMascara();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnLavagemM2 = new System.Windows.Forms.Button();
            this.txtLavarAreaM2 = new TextMascara.TextMascara();
            this.txtLavarAreaMes = new TextMascara.TextMascara();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxLavagemCarro = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbxRegaJardim = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRegaM2 = new System.Windows.Forms.Button();
            this.txtNumRegaM2 = new TextMascara.TextMascara();
            this.txtNumRegaMes = new TextMascara.TextMascara();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalM3 = new System.Windows.Forms.TextBox();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gainsboro;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.txtNumPessoas);
            this.panel10.Controls.Add(this.label6);
            this.panel10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel10.Location = new System.Drawing.Point(12, 12);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(777, 31);
            this.panel10.TabIndex = 0;
            // 
            // txtNumPessoas
            // 
            this.txtNumPessoas.Location = new System.Drawing.Point(145, 3);
            this.txtNumPessoas.Mascara = TextMascara.TextMascara.TipoMascara.Numero;
            this.txtNumPessoas.MaxLength = 32767;
            this.txtNumPessoas.Name = "txtNumPessoas";
            this.txtNumPessoas.Size = new System.Drawing.Size(71, 20);
            this.txtNumPessoas.TabIndex = 1;
            this.txtNumPessoas.Teste = 0;
            this.txtNumPessoas.Leave += new System.EventHandler(this.txtNumPessoas_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Número de Pessoas";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.cbxBaciaSanitaria);
            this.panel8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel8.Location = new System.Drawing.Point(12, 141);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(201, 32);
            this.panel8.TabIndex = 0;
            // 
            // cbxBaciaSanitaria
            // 
            this.cbxBaciaSanitaria.AutoSize = true;
            this.cbxBaciaSanitaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBaciaSanitaria.Location = new System.Drawing.Point(6, 3);
            this.cbxBaciaSanitaria.Name = "cbxBaciaSanitaria";
            this.cbxBaciaSanitaria.Size = new System.Drawing.Size(122, 21);
            this.cbxBaciaSanitaria.TabIndex = 13;
            this.cbxBaciaSanitaria.Text = "Bacia Sanitária";
            this.cbxBaciaSanitaria.UseVisualStyleBackColor = true;
            this.cbxBaciaSanitaria.CheckedChanged += new System.EventHandler(this.cbxBaciaSanitaria_CheckedChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gainsboro;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.rbtSanitario3ou6l);
            this.panel9.Controls.Add(this.rbtSanitario6l);
            this.panel9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel9.Location = new System.Drawing.Point(212, 141);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(577, 32);
            this.panel9.TabIndex = 0;
            // 
            // rbtSanitario3ou6l
            // 
            this.rbtSanitario3ou6l.AutoSize = true;
            this.rbtSanitario3ou6l.Enabled = false;
            this.rbtSanitario3ou6l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSanitario3ou6l.Location = new System.Drawing.Point(143, 4);
            this.rbtSanitario3ou6l.Name = "rbtSanitario3ou6l";
            this.rbtSanitario3ou6l.Size = new System.Drawing.Size(182, 21);
            this.rbtSanitario3ou6l.TabIndex = 15;
            this.rbtSanitario3ou6l.TabStop = true;
            this.rbtSanitario3ou6l.Text = "Vazão Diferenciada 3/6L";
            this.rbtSanitario3ou6l.UseVisualStyleBackColor = true;
            this.rbtSanitario3ou6l.CheckedChanged += new System.EventHandler(this.rbtSanitario6l_CheckedChanged);
            // 
            // rbtSanitario6l
            // 
            this.rbtSanitario6l.AutoSize = true;
            this.rbtSanitario6l.Checked = true;
            this.rbtSanitario6l.Enabled = false;
            this.rbtSanitario6l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSanitario6l.Location = new System.Drawing.Point(12, 4);
            this.rbtSanitario6l.Name = "rbtSanitario6l";
            this.rbtSanitario6l.Size = new System.Drawing.Size(93, 21);
            this.rbtSanitario6l.TabIndex = 14;
            this.rbtSanitario6l.TabStop = true;
            this.rbtSanitario6l.Text = "Comum 6L";
            this.rbtSanitario6l.UseVisualStyleBackColor = true;
            this.rbtSanitario6l.CheckedChanged += new System.EventHandler(this.rbtSanitario6l_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cbxLavagemArea);
            this.panel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel6.Location = new System.Drawing.Point(12, 109);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(201, 33);
            this.panel6.TabIndex = 0;
            // 
            // cbxLavagemArea
            // 
            this.cbxLavagemArea.AutoSize = true;
            this.cbxLavagemArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLavagemArea.Location = new System.Drawing.Point(6, 4);
            this.cbxLavagemArea.Name = "cbxLavagemArea";
            this.cbxLavagemArea.Size = new System.Drawing.Size(190, 21);
            this.cbxLavagemArea.TabIndex = 9;
            this.cbxLavagemArea.Text = "Lavagem de Área Comum";
            this.cbxLavagemArea.UseVisualStyleBackColor = true;
            this.cbxLavagemArea.CheckedChanged += new System.EventHandler(this.cbxLavagemArea_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtLavaCarrosMes);
            this.panel2.Controls.Add(this.txtNumCarrosMes);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(212, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 34);
            this.panel2.TabIndex = 0;
            // 
            // txtLavaCarrosMes
            // 
            this.txtLavaCarrosMes.Enabled = false;
            this.txtLavaCarrosMes.Location = new System.Drawing.Point(396, 4);
            this.txtLavaCarrosMes.Mascara = TextMascara.TextMascara.TipoMascara.Numero;
            this.txtLavaCarrosMes.MaxLength = 32767;
            this.txtLavaCarrosMes.Name = "txtLavaCarrosMes";
            this.txtLavaCarrosMes.Size = new System.Drawing.Size(64, 20);
            this.txtLavaCarrosMes.TabIndex = 4;
            this.txtLavaCarrosMes.Teste = 0;
            this.txtLavaCarrosMes.Leave += new System.EventHandler(this.txtNumPessoas_Leave);
            // 
            // txtNumCarrosMes
            // 
            this.txtNumCarrosMes.Enabled = false;
            this.txtNumCarrosMes.Location = new System.Drawing.Point(187, 5);
            this.txtNumCarrosMes.Mascara = TextMascara.TextMascara.TipoMascara.Numero;
            this.txtNumCarrosMes.MaxLength = 32767;
            this.txtNumCarrosMes.Name = "txtNumCarrosMes";
            this.txtNumCarrosMes.Size = new System.Drawing.Size(64, 20);
            this.txtNumCarrosMes.TabIndex = 3;
            this.txtNumCarrosMes.Teste = 0;
            this.txtNumCarrosMes.Leave += new System.EventHandler(this.txtNumPessoas_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(269, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 17);
            this.label13.TabIndex = 64;
            this.label13.Text = "Lavagem por Mês";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(59, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 17);
            this.label12.TabIndex = 62;
            this.label12.Text = "Número de Carros";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnLavagemM2);
            this.panel7.Controls.Add(this.txtLavarAreaM2);
            this.panel7.Controls.Add(this.txtLavarAreaMes);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label15);
            this.panel7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel7.Location = new System.Drawing.Point(212, 109);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(577, 33);
            this.panel7.TabIndex = 0;
            // 
            // btnLavagemM2
            // 
            this.btnLavagemM2.Enabled = false;
            this.btnLavagemM2.Location = new System.Drawing.Point(496, 4);
            this.btnLavagemM2.Name = "btnLavagemM2";
            this.btnLavagemM2.Size = new System.Drawing.Size(67, 23);
            this.btnLavagemM2.TabIndex = 12;
            this.btnLavagemM2.Text = "M²";
            this.btnLavagemM2.UseVisualStyleBackColor = true;
            this.btnLavagemM2.Click += new System.EventHandler(this.btnLavagemM2_Click);
            // 
            // txtLavarAreaM2
            // 
            this.txtLavarAreaM2.Enabled = false;
            this.txtLavarAreaM2.Location = new System.Drawing.Point(396, 5);
            this.txtLavarAreaM2.Mascara = TextMascara.TextMascara.TipoMascara.Numero;
            this.txtLavarAreaM2.MaxLength = 32767;
            this.txtLavarAreaM2.Name = "txtLavarAreaM2";
            this.txtLavarAreaM2.Size = new System.Drawing.Size(64, 20);
            this.txtLavarAreaM2.TabIndex = 11;
            this.txtLavarAreaM2.Teste = 0;
            this.txtLavarAreaM2.Leave += new System.EventHandler(this.txtNumPessoas_Leave);
            // 
            // txtLavarAreaMes
            // 
            this.txtLavarAreaMes.Enabled = false;
            this.txtLavarAreaMes.Location = new System.Drawing.Point(187, 4);
            this.txtLavarAreaMes.Mascara = TextMascara.TextMascara.TipoMascara.Numero;
            this.txtLavarAreaMes.MaxLength = 32767;
            this.txtLavarAreaMes.Name = "txtLavarAreaMes";
            this.txtLavarAreaMes.Size = new System.Drawing.Size(64, 20);
            this.txtLavarAreaMes.TabIndex = 10;
            this.txtLavarAreaMes.Teste = 0;
            this.txtLavarAreaMes.Leave += new System.EventHandler(this.txtNumPessoas_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(365, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 17);
            this.label17.TabIndex = 67;
            this.label17.Text = "M²";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 17);
            this.label15.TabIndex = 63;
            this.label15.Text = "Número de vezes no mês";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbxLavagemCarro);
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel3.Location = new System.Drawing.Point(12, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 34);
            this.panel3.TabIndex = 0;
            // 
            // cbxLavagemCarro
            // 
            this.cbxLavagemCarro.AutoSize = true;
            this.cbxLavagemCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLavagemCarro.Location = new System.Drawing.Point(6, 4);
            this.cbxLavagemCarro.Name = "cbxLavagemCarro";
            this.cbxLavagemCarro.Size = new System.Drawing.Size(144, 21);
            this.cbxLavagemCarro.TabIndex = 2;
            this.cbxLavagemCarro.Text = "Lavagem de Carro";
            this.cbxLavagemCarro.UseVisualStyleBackColor = true;
            this.cbxLavagemCarro.CheckedChanged += new System.EventHandler(this.cbxLavagemCarro_CheckedChanged_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbxRegaJardim);
            this.panel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel4.Location = new System.Drawing.Point(12, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 35);
            this.panel4.TabIndex = 0;
            // 
            // cbxRegaJardim
            // 
            this.cbxRegaJardim.AutoSize = true;
            this.cbxRegaJardim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRegaJardim.Location = new System.Drawing.Point(6, 6);
            this.cbxRegaJardim.Name = "cbxRegaJardim";
            this.cbxRegaJardim.Size = new System.Drawing.Size(127, 21);
            this.cbxRegaJardim.TabIndex = 5;
            this.cbxRegaJardim.Text = "Rega de Jardim";
            this.cbxRegaJardim.UseVisualStyleBackColor = true;
            this.cbxRegaJardim.CheckedChanged += new System.EventHandler(this.cbxRegaJardim_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnRegaM2);
            this.panel5.Controls.Add(this.txtNumRegaM2);
            this.panel5.Controls.Add(this.txtNumRegaMes);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label16);
            this.panel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel5.Location = new System.Drawing.Point(212, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(577, 35);
            this.panel5.TabIndex = 0;
            // 
            // btnRegaM2
            // 
            this.btnRegaM2.Enabled = false;
            this.btnRegaM2.Location = new System.Drawing.Point(496, 5);
            this.btnRegaM2.Name = "btnRegaM2";
            this.btnRegaM2.Size = new System.Drawing.Size(67, 23);
            this.btnRegaM2.TabIndex = 8;
            this.btnRegaM2.Text = "M²";
            this.btnRegaM2.UseVisualStyleBackColor = true;
            this.btnRegaM2.Click += new System.EventHandler(this.btnRegaM2_Click);
            // 
            // txtNumRegaM2
            // 
            this.txtNumRegaM2.Enabled = false;
            this.txtNumRegaM2.Location = new System.Drawing.Point(396, 7);
            this.txtNumRegaM2.Mascara = TextMascara.TextMascara.TipoMascara.Numero;
            this.txtNumRegaM2.MaxLength = 32767;
            this.txtNumRegaM2.Name = "txtNumRegaM2";
            this.txtNumRegaM2.Size = new System.Drawing.Size(64, 20);
            this.txtNumRegaM2.TabIndex = 7;
            this.txtNumRegaM2.Teste = 0;
            this.txtNumRegaM2.Leave += new System.EventHandler(this.txtNumPessoas_Leave);
            // 
            // txtNumRegaMes
            // 
            this.txtNumRegaMes.Enabled = false;
            this.txtNumRegaMes.Location = new System.Drawing.Point(187, 7);
            this.txtNumRegaMes.Mascara = TextMascara.TextMascara.TipoMascara.Numero;
            this.txtNumRegaMes.MaxLength = 32767;
            this.txtNumRegaMes.Name = "txtNumRegaMes";
            this.txtNumRegaMes.Size = new System.Drawing.Size(64, 20);
            this.txtNumRegaMes.TabIndex = 6;
            this.txtNumRegaMes.Teste = 0;
            this.txtNumRegaMes.Load += new System.EventHandler(this.txtNumRegaMes_Load);
            this.txtNumRegaMes.Leave += new System.EventHandler(this.txtNumPessoas_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 17);
            this.label14.TabIndex = 61;
            this.label14.Text = "Número de vezes no mês";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(365, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 17);
            this.label16.TabIndex = 65;
            this.label16.Text = "M²";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::WaterSaving.Properties.Resources.ok;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmar.Location = new System.Drawing.Point(591, 182);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(95, 41);
            this.btnConfirmar.TabIndex = 17;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::WaterSaving.Properties.Resources.Sair;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechar.Location = new System.Drawing.Point(692, 182);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(95, 41);
            this.btnFechar.TabIndex = 18;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Total em Litros";
            // 
            // txtTotalM3
            // 
            this.txtTotalM3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalM3.Location = new System.Drawing.Point(107, 196);
            this.txtTotalM3.Name = "txtTotalM3";
            this.txtTotalM3.ReadOnly = true;
            this.txtTotalM3.Size = new System.Drawing.Size(119, 20);
            this.txtTotalM3.TabIndex = 16;
            // 
            // FrmConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 233);
            this.Controls.Add(this.txtTotalM3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados para cálculo de Consumo Médio Mensal (m3)";
            this.Shown += new System.EventHandler(this.FrmConsumo_Shown);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private TextMascara.TextMascara txtNumPessoas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox cbxBaciaSanitaria;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton rbtSanitario3ou6l;
        private System.Windows.Forms.RadioButton rbtSanitario6l;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox cbxLavagemArea;
        private System.Windows.Forms.Panel panel2;
        private TextMascara.TextMascara txtLavaCarrosMes;
        private TextMascara.TextMascara txtNumCarrosMes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private TextMascara.TextMascara txtLavarAreaM2;
        private TextMascara.TextMascara txtLavarAreaMes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbxLavagemCarro;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox cbxRegaJardim;
        private System.Windows.Forms.Panel panel5;
        private TextMascara.TextMascara txtNumRegaM2;
        private TextMascara.TextMascara txtNumRegaMes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLavagemM2;
        private System.Windows.Forms.Button btnRegaM2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalM3;
    }
}