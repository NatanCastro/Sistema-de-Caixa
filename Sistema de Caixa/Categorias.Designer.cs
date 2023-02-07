namespace Sistema_de_Caixa
{
    partial class Categorias
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
            this.label4 = new System.Windows.Forms.Label();
            this.chAtivo = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgCategoria = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.apagar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).BeginInit();
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
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1370, 25);
            this.toolStrip1.TabIndex = 2;
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
            this.tsBuscar.Size = new System.Drawing.Size(169, 25);
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
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.chAtivo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dgCategoria);
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(400, 142);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 425);
            this.panel1.TabIndex = 3;
            // 
            // chInativos
            // 
            this.chInativos.AutoSize = true;
            this.chInativos.Location = new System.Drawing.Point(446, 137);
            this.chInativos.Name = "chInativos";
            this.chInativos.Size = new System.Drawing.Size(144, 34);
            this.chInativos.TabIndex = 21;
            this.chInativos.Text = "Ver inativos";
            this.chInativos.UseVisualStyleBackColor = true;
            this.chInativos.CheckedChanged += new System.EventHandler(this.chInativos_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(91, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 30);
            this.label4.TabIndex = 20;
            this.label4.Text = "*";
            // 
            // chAtivo
            // 
            this.chAtivo.AutoSize = true;
            this.chAtivo.Location = new System.Drawing.Point(10, 95);
            this.chAtivo.Name = "chAtivo";
            this.chAtivo.Size = new System.Drawing.Size(82, 34);
            this.chAtivo.TabIndex = 5;
            this.chAtivo.Text = "Ativo";
            this.chAtivo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(75, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 30);
            this.label9.TabIndex = 19;
            this.label9.Text = "*";
            // 
            // dgCategoria
            // 
            this.dgCategoria.AllowUserToAddRows = false;
            this.dgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.apagar});
            this.dgCategoria.Location = new System.Drawing.Point(10, 219);
            this.dgCategoria.Name = "dgCategoria";
            this.dgCategoria.RowTemplate.Height = 25;
            this.dgCategoria.Size = new System.Drawing.Size(580, 199);
            this.dgCategoria.TabIndex = 4;
            this.dgCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategoria_CellContentClick);
            this.dgCategoria.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgCategoria_CellFormatting);
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
            this.txtPesquisar.Location = new System.Drawing.Point(10, 177);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(580, 36);
            this.txtPesquisar.TabIndex = 3;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pesquisar";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(580, 36);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(585, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadastrar Categorias";
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Caixa.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Categorias_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).EndInit();
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
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private TextBox txtPesquisar;
        private Label label3;
        private DataGridView dgCategoria;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn apagar;
        private Label label9;
        private CheckBox chAtivo;
        private Label label4;
        private CheckBox chInativos;
    }
}