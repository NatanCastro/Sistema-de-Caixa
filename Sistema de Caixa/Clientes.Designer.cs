namespace Sistema_de_Caixa
{
    partial class Clientes
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
            this.tsSavar = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsCancel = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.tsBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSair = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbCadEndereco = new System.Windows.Forms.PictureBox();
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.apagar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEndereco = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoPessoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadEndereco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSavar,
            this.tsEdit,
            this.tsCancel,
            this.tsDelete,
            this.tsBuscar,
            this.toolStripSeparator1,
            this.tsSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1370, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsSavar
            // 
            this.tsSavar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSavar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsSavar.Image = global::Sistema_de_Caixa.Properties.Resources.saveIcon;
            this.tsSavar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSavar.Name = "tsSavar";
            this.tsSavar.Size = new System.Drawing.Size(23, 22);
            this.tsSavar.Text = "toolStripButton1";
            this.tsSavar.ToolTipText = "salvar";
            this.tsSavar.Click += new System.EventHandler(this.tsSavar_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEdit.Image = global::Sistema_de_Caixa.Properties.Resources.editIcon;
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(23, 22);
            this.tsEdit.Text = "toolStripButton2";
            this.tsEdit.ToolTipText = "editar";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // tsCancel
            // 
            this.tsCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCancel.Image = global::Sistema_de_Caixa.Properties.Resources.cancelIcon;
            this.tsCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCancel.Name = "tsCancel";
            this.tsCancel.Size = new System.Drawing.Size(23, 22);
            this.tsCancel.Text = "toolStripButton3";
            this.tsCancel.ToolTipText = "cancelar";
            this.tsCancel.Click += new System.EventHandler(this.tsCancel_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDelete.Image = global::Sistema_de_Caixa.Properties.Resources.deleteIcon;
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(23, 22);
            this.tsDelete.Text = "toolStripButton4";
            this.tsDelete.ToolTipText = "apagar";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
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
            this.panel1.Controls.Add(this.pbCadEndereco);
            this.panel1.Controls.Add(this.dgCliente);
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbEndereco);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDataNasc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCNPJ);
            this.panel1.Controls.Add(this.txtCPF);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbTipoPessoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(200, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 636);
            this.panel1.TabIndex = 3;
            // 
            // pbCadEndereco
            // 
            this.pbCadEndereco.Image = global::Sistema_de_Caixa.Properties.Resources.editIcon;
            this.pbCadEndereco.Location = new System.Drawing.Point(773, 275);
            this.pbCadEndereco.Name = "pbCadEndereco";
            this.pbCadEndereco.Size = new System.Drawing.Size(30, 30);
            this.pbCadEndereco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCadEndereco.TabIndex = 17;
            this.pbCadEndereco.TabStop = false;
            this.pbCadEndereco.Click += new System.EventHandler(this.pbCadEndereco_Click);
            // 
            // dgCliente
            // 
            this.dgCliente.AllowUserToAddRows = false;
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.apagar});
            this.dgCliente.Location = new System.Drawing.Point(18, 387);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.RowTemplate.Height = 25;
            this.dgCliente.Size = new System.Drawing.Size(780, 237);
            this.dgCliente.TabIndex = 16;
            this.dgCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellContentClick);
            // 
            // editar
            // 
            this.editar.HeaderText = "";
            this.editar.Image = global::Sistema_de_Caixa.Properties.Resources.editIconSmall;
            this.editar.MinimumWidth = 6;
            this.editar.Name = "editar";
            this.editar.Width = 24;
            // 
            // apagar
            // 
            this.apagar.HeaderText = "";
            this.apagar.Image = global::Sistema_de_Caixa.Properties.Resources.deleteIconSmall;
            this.apagar.MinimumWidth = 6;
            this.apagar.Name = "apagar";
            this.apagar.Width = 24;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(18, 345);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(780, 36);
            this.txtPesquisar.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pesquisar";
            // 
            // cbEndereco
            // 
            this.cbEndereco.FormattingEnabled = true;
            this.cbEndereco.Location = new System.Drawing.Point(18, 271);
            this.cbEndereco.Name = "cbEndereco";
            this.cbEndereco.Size = new System.Drawing.Size(749, 38);
            this.cbEndereco.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Endereço";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(683, 199);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(115, 36);
            this.txtDataNasc.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Nascimento";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(150, 199);
            this.txtCNPJ.Mask = "00.000.000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(160, 36);
            this.txtCNPJ.TabIndex = 9;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(18, 199);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(126, 36);
            this.txtCPF.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo";
            // 
            // cbTipoPessoa
            // 
            this.cbTipoPessoa.FormattingEnabled = true;
            this.cbTipoPessoa.Items.AddRange(new object[] {
            "Fisica",
            "Juridica"});
            this.cbTipoPessoa.Location = new System.Drawing.Point(18, 125);
            this.cbTipoPessoa.Name = "cbTipoPessoa";
            this.cbTipoPessoa.Size = new System.Drawing.Size(121, 38);
            this.cbTipoPessoa.TabIndex = 6;
            this.cbTipoPessoa.SelectedIndexChanged += new System.EventHandler(this.cbTipoPessoa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(780, 36);
            this.txtNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(497, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 30);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cadastro de Clientes";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Caixa.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadEndereco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsSavar;
        private ToolStripButton tsEdit;
        private ToolStripButton tsCancel;
        private ToolStripButton tsDelete;
        private ToolStripTextBox tsBuscar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsSair;
        private Panel panel1;
        private TextBox txtNome;
        private Label label1;
        private Label label3;
        private Label label2;
        private MaskedTextBox txtCNPJ;
        private MaskedTextBox txtCPF;
        private Label label4;
        private ComboBox cbTipoPessoa;
        private MaskedTextBox txtDataNasc;
        private Label label5;
        private ComboBox cbEndereco;
        private Label label6;
        private TextBox txtPesquisar;
        private Label label7;
        private DataGridView dgCliente;
        private PictureBox pbCadEndereco;
        private Label label8;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn apagar;
    }
}