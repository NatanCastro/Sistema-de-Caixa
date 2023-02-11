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

namespace Sistema_de_Venda
{
    public partial class SelecionaCliente : Form
    {
        private Conexao conn = new();
        private SQLiteConnection ConexaoString = Conexao.GetConnection();
        
        public SelecionaCliente()
        {
            InitializeComponent();
        }

        private void listarClietes(string pesquisa = "")
        {
            conn.sqlString =
                "SELECT c.id, c.nome, " +
                "c.cpf_cnpj AS 'cpf/cnpj', c.data_nascimento, " +
                "e.rua || ', ' || e.numero AS 'endereco', ativo " +
                "FROM cliente AS c " +
                "LEFT JOIN endereco AS e " +
                "ON c.id_endereco = e.id " +
                "WHERE ativo = 1 ";

            string pesquisaSql = $"AND c.nome || c.cpf_cnpj LIKE '%{pesquisa}%'";

            conn.sqlString += pesquisa != string.Empty ? pesquisaSql : "";

            try
            {
                ConexaoString.Open();
                SQLiteCommand command = new(conn.sqlString, ConexaoString);
                SQLiteDataAdapter adapter = new(command);

                DataTable table = new();
                adapter.Fill(table);

                dgCliente.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel retornar os dados dos Clientes\n\n{ex.Message}");
            }
            finally { ConexaoString.Close(); }
        }


        private void SelecionaCliente_Load(object sender, EventArgs e)
        {
            listarClietes();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtBusca.Text;
            listarClietes(pesquisa);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
