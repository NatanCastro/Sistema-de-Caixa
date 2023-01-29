namespace Sistema_de_Caixa
{
    partial class Usuarios
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
            this.dgUsuario = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.apagar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).BeginInit();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dgUsuario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(278, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 565);
            this.panel1.TabIndex = 3;
            // 
            // dgUsuario
            // 
            this.dgUsuario.AllowUserToAddRows = false;
            this.dgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.apagar});
            this.dgUsuario.Location = new System.Drawing.Point(6, 237);
            this.dgUsuario.Name = "dgUsuario";
            this.dgUsuario.RowTemplate.Height = 25;
            this.dgUsuario.Size = new System.Drawing.Size(703, 325);
            this.dgUsuario.TabIndex = 8;
            this.dgUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuario_CellContentClick);
            this.dgUsuario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgUsuario_CellFormatting);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(5, 195);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(704, 36);
            this.txtPesquisar.TabIndex = 6;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(5, 114);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(704, 36);
            this.txtSenha.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(5, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(704, 36);
            this.txtNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(493, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Usuario";
            // 
            // Usuarios
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
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).EndInit();
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
        private Label label1;
        private DataGridView dgUsuario;
        private Label label5;
        private TextBox txtPesquisar;
        private TextBox txtSenha;
        private TextBox txtNome;
        private Label label3;
        private Label label2;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn apagar;
    }
}