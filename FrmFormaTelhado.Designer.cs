namespace WaterSaving
{
    partial class FrmFormaTelhado
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
            this.btnForma = new System.Windows.Forms.Button();
            this.lblCampo2 = new System.Windows.Forms.Label();
            this.lblCampo1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnCentimetro = new System.Windows.Forms.RadioButton();
            this.rbtMetro = new System.Windows.Forms.RadioButton();
            this.txtCampo1 = new TextMascara.TextMascara();
            this.txtCampo2 = new TextMascara.TextMascara();
            this.txtCampo3 = new TextMascara.TextMascara();
            this.lblCampo3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnForma
            // 
            this.btnForma.CausesValidation = false;
            this.btnForma.Location = new System.Drawing.Point(12, 12);
            this.btnForma.Name = "btnForma";
            this.btnForma.Size = new System.Drawing.Size(372, 215);
            this.btnForma.TabIndex = 12;
            this.btnForma.UseVisualStyleBackColor = true;
            // 
            // lblCampo2
            // 
            this.lblCampo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCampo2.Location = new System.Drawing.Point(401, 83);
            this.lblCampo2.Name = "lblCampo2";
            this.lblCampo2.Size = new System.Drawing.Size(135, 16);
            this.lblCampo2.TabIndex = 8;
            this.lblCampo2.Text = "Altura";
            this.lblCampo2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCampo1
            // 
            this.lblCampo1.Location = new System.Drawing.Point(401, 51);
            this.lblCampo1.Name = "lblCampo1";
            this.lblCampo1.Size = new System.Drawing.Size(135, 13);
            this.lblCampo1.TabIndex = 7;
            this.lblCampo1.Text = "Base";
            this.lblCampo1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::WaterSaving.Properties.Resources.Sair;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechar.Location = new System.Drawing.Point(596, 188);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(95, 39);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = global::WaterSaving.Properties.Resources.novo;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncluir.Location = new System.Drawing.Point(480, 188);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(98, 39);
            this.btnIncluir.TabIndex = 11;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnCentimetro
            // 
            this.btnCentimetro.AutoSize = true;
            this.btnCentimetro.Location = new System.Drawing.Point(651, 47);
            this.btnCentimetro.Name = "btnCentimetro";
            this.btnCentimetro.Size = new System.Drawing.Size(107, 17);
            this.btnCentimetro.TabIndex = 14;
            this.btnCentimetro.Text = "Centrimetro ( cm )";
            this.btnCentimetro.UseVisualStyleBackColor = true;
            this.btnCentimetro.Visible = false;
            // 
            // rbtMetro
            // 
            this.rbtMetro.AutoSize = true;
            this.rbtMetro.Checked = true;
            this.rbtMetro.Location = new System.Drawing.Point(651, 73);
            this.rbtMetro.Name = "rbtMetro";
            this.rbtMetro.Size = new System.Drawing.Size(75, 17);
            this.rbtMetro.TabIndex = 15;
            this.rbtMetro.TabStop = true;
            this.rbtMetro.Text = "Metro ( m )";
            this.rbtMetro.UseVisualStyleBackColor = true;
            this.rbtMetro.Visible = false;
            // 
            // txtCampo1
            // 
            this.txtCampo1.Location = new System.Drawing.Point(542, 48);
            this.txtCampo1.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtCampo1.MaxLength = 32767;
            this.txtCampo1.Name = "txtCampo1";
            this.txtCampo1.Size = new System.Drawing.Size(89, 20);
            this.txtCampo1.TabIndex = 16;
            this.txtCampo1.Teste = 0;
            // 
            // txtCampo2
            // 
            this.txtCampo2.Location = new System.Drawing.Point(542, 79);
            this.txtCampo2.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtCampo2.MaxLength = 32767;
            this.txtCampo2.Name = "txtCampo2";
            this.txtCampo2.Size = new System.Drawing.Size(89, 20);
            this.txtCampo2.TabIndex = 17;
            this.txtCampo2.Teste = 0;
            // 
            // txtCampo3
            // 
            this.txtCampo3.Location = new System.Drawing.Point(542, 110);
            this.txtCampo3.Mascara = TextMascara.TextMascara.TipoMascara.Moeda;
            this.txtCampo3.MaxLength = 32767;
            this.txtCampo3.Name = "txtCampo3";
            this.txtCampo3.Size = new System.Drawing.Size(89, 20);
            this.txtCampo3.TabIndex = 19;
            this.txtCampo3.Teste = 0;
            // 
            // lblCampo3
            // 
            this.lblCampo3.Location = new System.Drawing.Point(401, 113);
            this.lblCampo3.Name = "lblCampo3";
            this.lblCampo3.Size = new System.Drawing.Size(135, 13);
            this.lblCampo3.TabIndex = 18;
            this.lblCampo3.Text = "Altura";
            this.lblCampo3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmFormaTelhado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 241);
            this.Controls.Add(this.txtCampo3);
            this.Controls.Add(this.lblCampo3);
            this.Controls.Add(this.txtCampo2);
            this.Controls.Add(this.txtCampo1);
            this.Controls.Add(this.rbtMetro);
            this.Controls.Add(this.btnCentimetro);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnForma);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.lblCampo2);
            this.Controls.Add(this.lblCampo1);
            this.Name = "FrmFormaTelhado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados da Forma do Telhado";
            this.Shown += new System.EventHandler(this.FrmFormaTelhado_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForma;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label lblCampo2;
        private System.Windows.Forms.Label lblCampo1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.RadioButton btnCentimetro;
        private System.Windows.Forms.RadioButton rbtMetro;
        private TextMascara.TextMascara txtCampo1;
        private TextMascara.TextMascara txtCampo2;
        private TextMascara.TextMascara txtCampo3;
        private System.Windows.Forms.Label lblCampo3;
    }
}