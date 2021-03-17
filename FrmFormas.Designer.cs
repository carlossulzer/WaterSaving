namespace WaterSaving
{
    partial class FrmFormas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnForma9 = new System.Windows.Forms.Button();
            this.btnForma8 = new System.Windows.Forms.Button();
            this.btnForma7 = new System.Windows.Forms.Button();
            this.btnForma3 = new System.Windows.Forms.Button();
            this.btnForma1 = new System.Windows.Forms.Button();
            this.btnForma2 = new System.Windows.Forms.Button();
            this.btnForma4 = new System.Windows.Forms.Button();
            this.btnForma5 = new System.Windows.Forms.Button();
            this.btnForma6 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFechar2 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lblTituloArea = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtMetragem = new TextMascara.TextMascara();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvAreas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(11, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1064, 17);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Clique sobre a forma que mais se assemelha com o telhado a ser usado para captaçã" +
                "o da água da chuva";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlTitulo.Controls.Add(this.btnFechar);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1150, 33);
            this.pnlTitulo.TabIndex = 23;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::WaterSaving.Properties.Resources.Sair;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(1081, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(66, 26);
            this.btnFechar.TabIndex = 23;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1150, 689);
            this.tabControl1.TabIndex = 24;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnForma9);
            this.tabPage1.Controls.Add(this.btnForma8);
            this.tabPage1.Controls.Add(this.btnForma7);
            this.tabPage1.Controls.Add(this.btnForma3);
            this.tabPage1.Controls.Add(this.btnForma1);
            this.tabPage1.Controls.Add(this.btnForma2);
            this.tabPage1.Controls.Add(this.btnForma4);
            this.tabPage1.Controls.Add(this.btnForma5);
            this.tabPage1.Controls.Add(this.btnForma6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1142, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Formas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnForma9
            // 
            this.btnForma9.Image = global::WaterSaving.Properties.Resources.Forma_09;
            this.btnForma9.Location = new System.Drawing.Point(763, 438);
            this.btnForma9.Name = "btnForma9";
            this.btnForma9.Size = new System.Drawing.Size(372, 215);
            this.btnForma9.TabIndex = 9;
            this.btnForma9.UseVisualStyleBackColor = true;
            this.btnForma9.Click += new System.EventHandler(this.btnForma9_Click);
            // 
            // btnForma8
            // 
            this.btnForma8.Image = global::WaterSaving.Properties.Resources.Forma_04;
            this.btnForma8.Location = new System.Drawing.Point(385, 438);
            this.btnForma8.Name = "btnForma8";
            this.btnForma8.Size = new System.Drawing.Size(372, 215);
            this.btnForma8.TabIndex = 8;
            this.btnForma8.UseVisualStyleBackColor = true;
            this.btnForma8.Click += new System.EventHandler(this.btnForma8_Click);
            // 
            // btnForma7
            // 
            this.btnForma7.Image = global::WaterSaving.Properties.Resources.Forma_01;
            this.btnForma7.Location = new System.Drawing.Point(7, 438);
            this.btnForma7.Name = "btnForma7";
            this.btnForma7.Size = new System.Drawing.Size(372, 215);
            this.btnForma7.TabIndex = 7;
            this.btnForma7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnForma7.UseVisualStyleBackColor = true;
            this.btnForma7.Click += new System.EventHandler(this.btnForma7_Click);
            // 
            // btnForma3
            // 
            this.btnForma3.Image = global::WaterSaving.Properties.Resources.Forma_02;
            this.btnForma3.Location = new System.Drawing.Point(763, 4);
            this.btnForma3.Name = "btnForma3";
            this.btnForma3.Size = new System.Drawing.Size(372, 215);
            this.btnForma3.TabIndex = 3;
            this.btnForma3.UseVisualStyleBackColor = true;
            this.btnForma3.Click += new System.EventHandler(this.btnForma3_Click);
            // 
            // btnForma1
            // 
            this.btnForma1.Image = global::WaterSaving.Properties.Resources.Forma_03;
            this.btnForma1.Location = new System.Drawing.Point(7, 4);
            this.btnForma1.Name = "btnForma1";
            this.btnForma1.Size = new System.Drawing.Size(372, 215);
            this.btnForma1.TabIndex = 1;
            this.btnForma1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnForma1.UseVisualStyleBackColor = true;
            this.btnForma1.Click += new System.EventHandler(this.btnForma1_Click);
            // 
            // btnForma2
            // 
            this.btnForma2.Image = global::WaterSaving.Properties.Resources.Forma_07;
            this.btnForma2.Location = new System.Drawing.Point(385, 4);
            this.btnForma2.Name = "btnForma2";
            this.btnForma2.Size = new System.Drawing.Size(372, 215);
            this.btnForma2.TabIndex = 2;
            this.btnForma2.UseVisualStyleBackColor = true;
            this.btnForma2.Click += new System.EventHandler(this.btnForma2_Click);
            // 
            // btnForma4
            // 
            this.btnForma4.Image = global::WaterSaving.Properties.Resources.Forma_06;
            this.btnForma4.Location = new System.Drawing.Point(7, 221);
            this.btnForma4.Name = "btnForma4";
            this.btnForma4.Size = new System.Drawing.Size(372, 215);
            this.btnForma4.TabIndex = 4;
            this.btnForma4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnForma4.UseVisualStyleBackColor = true;
            this.btnForma4.Click += new System.EventHandler(this.btnForma4_Click);
            // 
            // btnForma5
            // 
            this.btnForma5.Image = global::WaterSaving.Properties.Resources.Forma_08;
            this.btnForma5.Location = new System.Drawing.Point(385, 221);
            this.btnForma5.Name = "btnForma5";
            this.btnForma5.Size = new System.Drawing.Size(372, 215);
            this.btnForma5.TabIndex = 5;
            this.btnForma5.UseVisualStyleBackColor = true;
            this.btnForma5.Click += new System.EventHandler(this.btnForma5_Click);
            // 
            // btnForma6
            // 
            this.btnForma6.Image = global::WaterSaving.Properties.Resources.Forma_05;
            this.btnForma6.Location = new System.Drawing.Point(763, 221);
            this.btnForma6.Name = "btnForma6";
            this.btnForma6.Size = new System.Drawing.Size(372, 215);
            this.btnForma6.TabIndex = 6;
            this.btnForma6.UseVisualStyleBackColor = true;
            this.btnForma6.Click += new System.EventHandler(this.btnForma6_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnFechar2);
            this.tabPage2.Controls.Add(this.btnLimpar);
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Controls.Add(this.btnIncluir);
            this.tabPage2.Controls.Add(this.lblTituloArea);
            this.tabPage2.Controls.Add(this.panel17);
            this.tabPage2.Controls.Add(this.panel18);
            this.tabPage2.Controls.Add(this.panel15);
            this.tabPage2.Controls.Add(this.panel16);
            this.tabPage2.Controls.Add(this.dgvAreas);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1142, 663);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Áreas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFechar2
            // 
            this.btnFechar2.Image = global::WaterSaving.Properties.Resources.Sair;
            this.btnFechar2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechar2.Location = new System.Drawing.Point(742, 233);
            this.btnFechar2.Name = "btnFechar2";
            this.btnFechar2.Size = new System.Drawing.Size(180, 41);
            this.btnFechar2.TabIndex = 9;
            this.btnFechar2.Text = "&Fechar";
            this.btnFechar2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFechar2.UseVisualStyleBackColor = true;
            this.btnFechar2.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::WaterSaving.Properties.Resources.cancelarp;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(742, 139);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(180, 41);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar Campos";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::WaterSaving.Properties.Resources.excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(742, 186);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(180, 41);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "&Excluir Área";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = global::WaterSaving.Properties.Resources.novo;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncluir.Location = new System.Drawing.Point(742, 92);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(180, 41);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "&Incluir Área";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // lblTituloArea
            // 
            this.lblTituloArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloArea.Location = new System.Drawing.Point(179, 22);
            this.lblTituloArea.Name = "lblTituloArea";
            this.lblTituloArea.Size = new System.Drawing.Size(534, 20);
            this.lblTituloArea.TabIndex = 93;
            this.lblTituloArea.Text = "Área para captação de água da chuva";
            this.lblTituloArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Gainsboro;
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Controls.Add(this.txtMetragem);
            this.panel17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel17.Location = new System.Drawing.Point(334, 312);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(379, 32);
            this.panel17.TabIndex = 91;
            // 
            // txtMetragem
            // 
            this.txtMetragem.Location = new System.Drawing.Point(7, 5);
            this.txtMetragem.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtMetragem.MaxLength = 32767;
            this.txtMetragem.Name = "txtMetragem";
            this.txtMetragem.Size = new System.Drawing.Size(133, 20);
            this.txtMetragem.TabIndex = 2;
            this.txtMetragem.Teste = 0;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Gainsboro;
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.label3);
            this.panel18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel18.Location = new System.Drawing.Point(179, 312);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(156, 32);
            this.panel18.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "M²";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Gainsboro;
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.txtDescricao);
            this.panel15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel15.Location = new System.Drawing.Point(334, 281);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(379, 32);
            this.panel15.TabIndex = 89;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(6, 3);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(362, 23);
            this.txtDescricao.TabIndex = 1;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Gainsboro;
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.label10);
            this.panel16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel16.Location = new System.Drawing.Point(179, 281);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(156, 32);
            this.panel16.TabIndex = 90;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(80, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 57;
            this.label10.Text = "Descrição";
            // 
            // dgvAreas
            // 
            this.dgvAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreas.Location = new System.Drawing.Point(178, 45);
            this.dgvAreas.MultiSelect = false;
            this.dgvAreas.Name = "dgvAreas";
            this.dgvAreas.ReadOnly = true;
            this.dgvAreas.Size = new System.Drawing.Size(535, 232);
            this.dgvAreas.TabIndex = 85;
            // 
            // button1
            // 
            this.button1.Image = global::WaterSaving.Properties.Resources.telhado;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(742, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Escolher Outra Forma de Telhado";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmFormas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 722);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFormas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formato do Telhado";
            this.Load += new System.EventHandler(this.FrmFormas_Load);
            this.Shown += new System.EventHandler(this.FrmFormas_Shown);
            this.pnlTitulo.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnForma9;
        private System.Windows.Forms.Button btnForma8;
        private System.Windows.Forms.Button btnForma7;
        private System.Windows.Forms.Button btnForma3;
        private System.Windows.Forms.Button btnForma1;
        private System.Windows.Forms.Button btnForma2;
        private System.Windows.Forms.Button btnForma4;
        private System.Windows.Forms.Button btnForma5;
        private System.Windows.Forms.Button btnForma6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTituloArea;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvAreas;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnFechar2;
        private TextMascara.TextMascara txtMetragem;



    }
}