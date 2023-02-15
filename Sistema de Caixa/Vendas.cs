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
            Conexao.sqlString = "SELECT v.id, c.nome AS 'cliente', u.nome AS 'vendedor', mp.nome AS 'metodo de pagamento', " +
            "v.valor_total AS 'valor total', v.desconto, v.valor_final AS 'valor final', v.data_venda AS 'data da venda' " +
            "FROM venda AS v " +
            "INNER JOIN cliente AS c ON v.id_cliente = c.id " +
            "INNER JOIN usuario AS u ON v.id_usuario = u.id " +
            "INNER JOIN metodo_pagamento AS mp ON v.id_metodo_pagamento = mp.id " +
            "INNER JOIN itens_venda AS iv ON v.id = iv.id_venda " +
            "WHERE iv.codigo_produto IN ( " +
            "	SELECT p.codigo_barras AS codigo FROM produto AS p " +
            "	INNER JOIN itens_venda AS iv ON iv.codigo_produto = p.codigo_barras " +
            "	INNER JOIN venda AS v ON v.id = iv.id_venda = v.id " +
            $"	WHERE p.nome LIKE '%{pesquisa}%' " +
            $") OR (c.nome || u.nome || LOWER(mp.nome)) LIKE '%{pesquisa}%'";

        }

        public void listarItensVenda()
        {

        }

        private void Vendas_Load(object sender, EventArgs e)
        {

        }

        private void dgVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
