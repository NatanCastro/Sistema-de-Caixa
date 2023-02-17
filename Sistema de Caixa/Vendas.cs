using Banco_de_dados;
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

namespace Sistema_de_Caixa
{
    public partial class Vendas : Form
    {
        readonly Conexao Conexao = new();
        readonly SQLiteConnection ConexaoString = Conexao.GetConnection();

        public Vendas()
        {
            InitializeComponent();
        }

        public void listarVendas(string pesquisa = "")
        {
            Conexao.sqlString = "SELECT DISTINCT v.id AS 'id', c.nome AS 'cliente', u.nome AS 'vendedor', mp.nome AS 'metodo de pagamento', " +
            "v.valor_total AS 'valor total', v.desconto, " +
            "v.valor_final AS 'valor final', strftime('%d/%m/%Y', v.data_venda) AS 'data da venda' " +
            "FROM venda AS v " +
            "INNER JOIN cliente AS c ON v.id_cliente = c.id " +
            "INNER JOIN usuario AS u ON v.id_usuario = u.id " +
            "INNER JOIN metodo_pagamento AS mp ON v.id_metodo_pagamento = mp.id ";

            if (!string.IsNullOrEmpty(pesquisa))
            {
                Conexao.sqlString += 
                    "INNER JOIN itens_venda AS iv ON v.id = iv.id_venda " +
                    "WHERE iv.codigo_produto IN ( " +
                    "	SELECT p.codigo_barras AS codigo FROM produto AS p " +
                    "	INNER JOIN itens_venda AS iv ON iv.codigo_produto = p.codigo_barras " +
                    "	INNER JOIN venda AS v ON v.id = iv.id_venda = v.id " +
                    $"	WHERE p.nome LIKE '%{pesquisa}%' " +
                    $") OR (c.nome || u.nome || LOWER(mp.nome)) LIKE '%{pesquisa}%'";
            }

            try
            {
                ConexaoString.Open();

                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);
                SQLiteDataAdapter adapter = new(command);

                DataTable table = new();
                adapter.Fill(table);

                dgVenda.DataSource = null;
                dgVenda.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel retornar os dados das vendas\n\n{ex.Message}");
            }
            finally
            {
                ConexaoString.Close();
            }
        }

        public void listarItensVenda(int id_venda)
        {
            Conexao.sqlString = "SELECT p.nome, iv.quantidade, " +
                "iv.valor_unit AS 'valor unidade', iv.valor_total AS 'valor total' " +
                "FROM itens_venda AS iv " +
                "INNER JOIN produto AS p ON iv.codigo_produto = p.codigo_barras " +
                $"WHERE iv.id_venda = {id_venda}";

            try
            {
                ConexaoString.Open();

                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);
                SQLiteDataAdapter adapter = new(command);

                DataTable table = new();
                adapter.Fill(table);

                dgItensVenda.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel retornar os dados das vendas\n\n{ex.Message}");
            }
            finally
            {
                ConexaoString.Close();
            }
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            listarVendas();
        }

        private void dgVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _ = int.TryParse(dgVenda.Rows[e.RowIndex].Cells["id"].Value.ToString(), out int id_venda);
            listarItensVenda(id_venda);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            listarVendas(txtPesquisa.Text);
        }
    }
}
