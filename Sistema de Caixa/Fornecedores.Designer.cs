namespace Sistema_de_Caixa
{
    partial class Fornecedores
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
            this.toolStrip1.SuspendLayout();
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
            // Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Caixa.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Fornecedores";
            this.Text = "Fornecedores";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
    }
}