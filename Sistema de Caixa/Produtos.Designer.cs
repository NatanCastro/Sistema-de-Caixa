namespace Sistema_de_Caixa
{
    partial class Produtos
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsEditar = new System.Windows.Forms.ToolStripButton();
            this.tsCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsDeletar = new System.Windows.Forms.ToolStripButton();
            this.tsBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSair = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chInativos = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chAtivo = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.dgProduto = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.apagar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMargemLucro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pbCadCategoria = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCategoria)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1370, 25);
            this.toolStrip1.TabIndex = 3;
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
            this.tsBuscar.Size = new System.Drawing.Size(287, 25);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.chInativos);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.chAtivo);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.pbCadCategoria);
            this.panel1.Controls.Add(this.txtValorVenda);
            this.panel1.Controls.Add(this.txtValorProduto);
            this.panel1.Controls.Add(this.dgProduto);
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbCategoria);
            this.panel1.Controls.Add(this.txtQtd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMargemLucro);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCodigoBarras);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(453, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 640);
            this.panel1.TabIndex = 4;
            // 
            // chInativos
            // 
            this.chInativos.AutoSize = true;
            this.chInativos.Location = new System.Drawing.Point(504, 339);
            this.chInativos.Name = "chInativos";
            this.chInativos.Size = new System.Drawing.Size(144, 34);
            this.chInativos.TabIndex = 27;
            this.chInativos.Text = "Ver inativos";
            this.chInativos.UseVisualStyleBackColor = true;
            this.chInativos.CheckedChanged += new System.EventHandler(this.chInativos_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(575, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 30);
            this.label9.TabIndex = 26;
            this.label9.Text = "*";
            // 
            // chAtivo
            // 
            this.chAtivo.AutoSize = true;
            this.chAtivo.Checked = true;
            this.chAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chAtivo.Location = new System.Drawing.Point(504, 271);
            this.chAtivo.Name = "chAtivo";
            this.chAtivo.Size = new System.Drawing.Size(82, 34);
            this.chAtivo.TabIndex = 25;
            this.chAtivo.Text = "Ativo";
            this.chAtivo.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(123, 236);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 30);
            this.label16.TabIndex = 19;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(675, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 30);
            this.label15.TabIndex = 24;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(194, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 30);
            this.label14.TabIndex = 23;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(194, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 30);
            this.label13.TabIndex = 22;
            this.label13.Text = "*";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(226, 197);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(128, 36);
            this.txtValorVenda.TabIndex = 18;
            this.txtValorVenda.TextChanged += new System.EventHandler(this.txtValorVenda_TextChanged);
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Location = new System.Drawing.Point(41, 197);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(147, 36);
            this.txtValorProduto.TabIndex = 17;
            // 
            // dgProduto
            // 
            this.dgProduto.AllowUserToAddRows = false;
            this.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.apagar});
            this.dgProduto.Location = new System.Drawing.Point(10, 418);
            this.dgProduto.Name = "dgProduto";
            this.dgProduto.RowTemplate.Height = 25;
            this.dgProduto.Size = new System.Drawing.Size(680, 211);
            this.dgProduto.TabIndex = 16;
            this.dgProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduto_CellContentClick);
            this.dgProduto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgProduto_CellFormatting);
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
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(10, 376);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(680, 36);
            this.txtPesquisar.TabIndex = 15;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pesquisar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(10, 269);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(340, 38);
            this.cbCategoria.TabIndex = 12;
            this.cbCategoria.Click += new System.EventHandler(this.cbCategoria_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(552, 197);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(138, 36);
            this.txtQtd.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantidade";
            // 
            // txtMargemLucro
            // 
            this.txtMargemLucro.Location = new System.Drawing.Point(360, 197);
            this.txtMargemLucro.Name = "txtMargemLucro";
            this.txtMargemLucro.Size = new System.Drawing.Size(159, 36);
            this.txtMargemLucro.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Margem de Lucro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor de Venda";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 125);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(680, 36);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Produto";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(10, 53);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(680, 36);
            this.txtCodigoBarras.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Barras\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(194, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "R$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(10, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 30);
            this.label10.TabIndex = 19;
            this.label10.Text = "R$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(515, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 30);
            this.label12.TabIndex = 21;
            this.label12.Text = "%";
            // 
            // pbCadCategoria
            // 
            this.pbCadCategoria.Image = global::Sistema_de_Caixa.Properties.Resources.addIcon;
            this.pbCadCategoria.Location = new System.Drawing.Point(356, 269);
            this.pbCadCategoria.Name = "pbCadCategoria";
            this.pbCadCategoria.Size = new System.Drawing.Size(38, 38);
            this.pbCadCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCadCategoria.TabIndex = 0;
            this.pbCadCategoria.TabStop = false;
            this.pbCadCategoria.Click += new System.EventHandler(this.pbCadCategoria_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Caixa.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsSalvar;
        private ToolStripButton tsEditar;
        private ToolStripButton tsCancelar;
        private ToolStripButton tsDeletar;
        private ToolStripTextBox tsBuscar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsSair;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtCodigoBarras;
        private Label label1;
        private TextBox txtMargemLucro;
        private DataGridView dgProduto;
        private TextBox txtPesquisar;
        private Label label8;
        private Label label7;
        private ComboBox cbCategoria;
        private TextBox txtQtd;
        private Label label6;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn apagar;
        private TextBox txtValorVenda;
        private TextBox txtValorProduto;
        private Label label11;
        private Label label10;
        private Label label12;
        private Label label14;
        private Label label13;
        private Label label15;
        private Label label16;
        private Label label9;
        private CheckBox chAtivo;
        private CheckBox chInativos;
        private PictureBox pbCadCategoria;
    }
}
