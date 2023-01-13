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
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsCancel = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.tsBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSair = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.deletar = new System.Windows.Forms.DataGridViewImageColumn();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(688, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar endereço";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSave,
            this.tsEdit,
            this.tsCancel,
            this.tsDelete,
            this.tsBuscar,
            this.toolStripSeparator1,
            this.tsSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1604, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsSave
            // 
            this.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSave.Image = global::Sistema_de_Caixa.Properties.Resources.saveIcon;
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(23, 22);
            this.tsSave.Text = "toolStripButton1";
            this.tsSave.ToolTipText = "salvar";
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
            this.label4.Location = new System.Drawing.Point(18, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cidade";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(459, 204);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(656, 36);
            this.txtStreet.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(441, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 636);
            this.panel1.TabIndex = 4;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.deletar});
            this.dataGridView1.Location = new System.Drawing.Point(18, 405);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(784, 213);
            this.dataGridView1.TabIndex = 4;
            // 
            // editar
            // 
            this.editar.HeaderText = "";
            this.editar.MinimumWidth = 6;
            this.editar.Name = "editar";
            this.editar.Width = 6;
            // 
            // deletar
            // 
            this.deletar.HeaderText = "";
            this.deletar.MinimumWidth = 6;
            this.deletar.Name = "deletar";
            this.deletar.Width = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(18, 363);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(784, 36);
            this.textBox5.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(18, 269);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(784, 36);
            this.textBox6.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(18, 197);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(784, 36);
            this.textBox4.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(18, 125);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(784, 36);
            this.txtCity.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Pesquisar";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(680, 53);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(122, 36);
            this.txtNum.TabIndex = 3;
            // 
            // Enderecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Caixa.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.txtStreet);
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsSave;
        private ToolStripButton tsEdit;
        private ToolStripButton tsCancel;
        private ToolStripButton tsDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsSair;
        private ToolStripTextBox tsBuscar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtStreet;
        private Panel panel1;
        private TextBox txtCity;
        private TextBox txtNum;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn deletar;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
        private TextBox textBox6;
    }
}