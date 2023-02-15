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
    public partial class SelecionaProduto : Form
    {
        Caixa caixa;
        public static SQLiteConnection Conn = new($"Data Source={Directory.GetCurrentDirectory()}/caixa.sqlite3; Version=3;") { };
        public string sqlString = string.Empty;

        public SelecionaProduto(Caixa caixa)
        {
            InitializeComponent();
            this.caixa = caixa;
        }

        public void listarProdutos(string pesquisa = "")
        {
            sqlString = "SELECT codigo_barras AS 'codigo', nome, valor_venda AS 'preço' " +
                "FROM produto WHERE ativo=1 ";

            string pesquisaSql = $"AND c.nome || c.cpf_cnpj LIKE '%{pesquisa}%'";

            sqlString += pesquisa != string.Empty ? pesquisaSql : "";

            try
            {
                Conn.Open();
                SQLiteCommand command = new(sqlString, Conn);
                SQLiteDataAdapter adapter = new(command);

                DataTable table = new();
                adapter.Fill(table);

                dgProduto.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel retornar os dados dos Clientes\n\n{ex.Message}");
            }
            finally { Conn.Close(); }
        }

        private void SelecionaProduto_Load(object sender, EventArgs e)
        {
            listarProdutos();
        }

        private void dgProduto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string? codigo = dgProduto.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
            caixa.selecionaProduto(codigo);
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            listarProdutos(txtBusca.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
