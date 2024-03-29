﻿namespace Sistema_de_Caixa
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void cadastrareditarconsultarexcluirEndereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enderecos enderecos = new();
            enderecos.ShowDialog();
        }

        private void cadastrareditarconsultarexcluirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new();
            clientes.ShowDialog();
        }

        private void cadastrareditarconsultarexcluirProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos produtos = new();
            produtos.ShowDialog();
        }

        private void cadastrareditarconsultarexcluirCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorias categorias = new();
            categorias.ShowDialog();
        }

        private void cadastrareditarconsultarexcluirUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new(false);
            usuarios.ShowDialog();
        }

        private void listarVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendas vendas = new();
            vendas.ShowDialog();
        }
    }
}
