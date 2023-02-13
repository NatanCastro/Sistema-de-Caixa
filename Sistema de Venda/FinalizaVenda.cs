using Banco_de_dados;
using Sistema_de_Venda.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venda
{
    public partial class FinalizaVenda : Form
    {
        Conexao Conexao = new();
        SQLiteConnection ConexaoString = Conexao.GetConnection();

        Caixa caixa;
        float valor;
        public FinalizaVenda(Caixa caixa, float valor)
        {
            InitializeComponent();
            this.caixa = caixa;
            this.valor = valor;
        }

        public void calculaValor()
        {
            if (string.IsNullOrEmpty(txtDesconto.Text) || txtDesconto.Text.EndsWith(",")) return;

            float desconto;
            float.TryParse(txtDesconto.Text, out desconto);

            txtTotal.Text = (float.Parse(txtSubTotal.Text) - desconto).ToString();
        }
        
        public void listarMetodos()
        {
            Conexao.sqlString = "SELECT nome FROM metodo_pagamento";

            try
            {
                ConexaoString.Open();
                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);
                SQLiteDataAdapter adapter = new(command);
                DataTable table = new();
                adapter.Fill(table);

                dgMetodo.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel retornar os metodos de pagamento\n\n{ex.Message}");
            }
            finally
            {
                ConexaoString.Close();
            }
        }

        private void FinalizaVenda_Load(object sender, EventArgs e)
        {
            listarMetodos();
            txtSubTotal.Text = valor.ToString();
            calculaValor();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            calculaValor();
        }

        private void dgMetodo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgMetodo.Rows[e.RowIndex].Cells[e.ColumnIndex] != dgMetodo.Rows[e.RowIndex].Cells["nome"]) return;
            lblMetodo.Text = dgMetodo.Rows[e.RowIndex].Cells["nome"].Value.ToString();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblMetodo.Text))
            {
                MessageBox.Show("Selecione um metodo de pagamento");
                return;
            }
            caixa.selecionaMetodoPagamento(lblMetodo.Text);
            caixa.finalizaVenda(float.Parse(txtSubTotal.Text), float.Parse(txtDesconto.Text), float.Parse(txtTotal.Text));
            caixa.cancelaVenda();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
