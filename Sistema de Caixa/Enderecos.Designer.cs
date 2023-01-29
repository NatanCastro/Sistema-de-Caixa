namespace Sistema_de_Caixa
{
    partial class Enderecos
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
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsEditar = new System.Windows.Forms.ToolStripButton();
            this.tsCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsDeletar = new System.Windows.Forms.ToolStripButton();
            this.tsBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSair = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgEndereco = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.apagar = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(646, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar endereço";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSalvar,
            this.tsEditar,
            this.tsCancelar,
            this.tsDeletar,
            this.tsBuscar,
            this.toolStripSeparator1,
            this.tsSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1370, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsSalvar
            // 
            this.tsSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSalvar.Image = global::Sistema_de_Caixa.Properties.Resources.saveIcon;
            this.tsSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSalvar.Name = "tsSalvar";
            this.tsSalvar.Size = new System.Drawing.Size(23, 22);
            this.tsSalvar.Text = "toolStripButton1";
            this.tsSalvar.ToolTipText = "salvar";
            this.tsSalvar.Click += new System.EventHandler(this.tsSalvar_Click);
            // 
            // tsEditar
            // 
            this.tsEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEditar.Image = global::Sistema_de_Caixa.Properties.Resources.editIcon;
            this.tsEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditar.Name = "tsEditar";
            this.tsEditar.Size = new System.Drawing.Size(23, 22);
            this.tsEditar.Text = "toolStripButton2";
            this.tsEditar.ToolTipText = "editar";
            this.tsEditar.Click += new System.EventHandler(this.tsEditar_Click);
            // 
            // tsCancelar
            // 
            this.tsCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCancelar.Image = global::Sistema_de_Caixa.Properties.Resources.cancelIcon;
            this.tsCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCancelar.Name = "tsCancelar";
            this.tsCancelar.Size = new System.Drawing.Size(23, 22);
            this.tsCancelar.Text = "toolStripButton3";
            this.tsCancelar.ToolTipText = "cancelar";
            this.tsCancelar.Click += new System.EventHandler(this.tsCancelar_Click);
            // 
            // tsDeletar
            // 
            this.tsDeletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeletar.Image = global::Sistema_de_Caixa.Properties.Resources.deleteIcon;
            this.tsDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeletar.Name = "tsDeletar";
            this.tsDeletar.Size = new System.Drawing.Size(23, 22);
            this.tsDeletar.Text = "toolStripButton4";
            this.tsDeletar.ToolTipText = "apagar";
            this.tsDeletar.Click += new System.EventHandler(this.tsDeletar_Click);
            // 
            // tsBuscar
            // 
            this.tsBuscar.Name = "tsBuscar";
            this.tsBuscar.Size = new System.Drawing.Size(100, 25);
            this.tsBuscar.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsSair
            // 
            this.tsSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSair.Image = global::Sistema_de_Caixa.Properties.Resources.exitIcon;
            this.tsSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSair.Name = "tsSair";
            this.tsSair.Size = new System.Drawing.Size(23, 22);
            this.tsSair.Text = "toolStripButton5";
            this.tsSair.ToolTipText = "Sair";
            this.tsSair.Click += new System.EventHandler(this.tsSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(680, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "UF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cidade";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(18, 53);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(656, 36);
            this.txtRua.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCEP);
            this.panel1.Controls.Add(this.txtPais);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtBairro);
            this.panel1.Controls.Add(this.txtComplemento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtUF);
            this.panel1.Controls.Add(this.txtRua);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgEndereco);
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Controls.Add(this.txtCidade);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(397, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 636);
            this.panel1.TabIndex = 4;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(18, 269);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(784, 36);
            this.txtCEP.TabIndex = 11;
            this.txtCEP.TextChanged += new System.EventHandler(this.txtCEP_TextChanged);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(490, 197);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(312, 36);
            this.txtPais.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(490, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 30);
            this.label10.TabIndex = 9;
            this.label10.Text = "País";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 30);
            this.label9.TabIndex = 8;
            this.label9.Text = "Complemento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 30);
            this.label8.TabIndex = 5;
            this.label8.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(407, 125);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(395, 36);
            this.txtBairro.TabIndex = 6;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(18, 125);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(383, 36);
            this.txtComplemento.TabIndex = 7;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(407, 197);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(77, 36);
            this.txtUF.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "CEP";
            // 
            // dgEndereco
            // 
            this.dgEndereco.AllowUserToAddRows = false;
            this.dgEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.apagar});
            this.dgEndereco.Location = new System.Drawing.Point(18, 405);
            this.dgEndereco.Name = "dgEndereco";
            this.dgEndereco.RowTemplate.Height = 25;
            this.dgEndereco.Size = new System.Drawing.Size(784, 213);
            this.dgEndereco.TabIndex = 4;
            this.dgEndereco.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEndereco_CellContentClick);
            this.dgEndereco.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgEndereco_CellFormatting);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(18, 363);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(784, 36);
            this.txtPesquisar.TabIndex = 3;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(18, 197);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(383, 36);
            this.txtCidade.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Pesquisar";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(680, 53);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(122, 36);
            this.txtNumero.TabIndex = 3;
            // 
            // editar
            // 
            this.editar.HeaderText = "";
            this.editar.Image = global::Sistema_de_Caixa.Properties.Resources.editIconSmall;
            this.editar.MinimumWidth = 24;
            this.editar.Name = "editar";
            this.editar.Width = 24;
            // 
            // apagar
            // 
            this.apagar.HeaderText = "";
            this.apagar.Image = global::Sistema_de_Caixa.Properties.Resources.deleteIconSmall;
            this.apagar.MinimumWidth = 24;
            this.apagar.Name = "apagar";
            this.apagar.Width = 24;
            // 
            // Enderecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Caixa.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Enderecos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endereços";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Enderecos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEndereco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsSalvar;
        private ToolStripButton tsEditar;
        private ToolStripButton tsCancelar;
        private ToolStripButton tsDeletar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsSair;
        private ToolStripTextBox tsBuscar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtRua;
        private Panel panel1;
        private TextBox txtCidade;
        private TextBox txtNumero;
        private TextBox txtUF;
        private DataGridView dgEndereco;
        private TextBox txtPesquisar;
        private Label label6;
        private Label label7;
        private Label label9;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private Label label8;
        private TextBox txtPais;
        private Label label10;
        private MaskedTextBox txtCEP;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn apagar;
    }
}