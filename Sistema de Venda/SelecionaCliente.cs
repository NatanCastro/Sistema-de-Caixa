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
        private static readonly string User = "user";
        public static SQLiteConnection Conn = new($"Data Source=C:/Users/{User}/source/repos/natan22gt/Sistema-de-Caixa/Banco de dados/caixa.sqlite3; Version=3;") { };
        public string sqlString = string.Empty;

        public Caixa caixa;
        
        public SelecionaCliente(Caixa caixa)
        {
            InitializeComponent();
            this.caixa = caixa;
        }

        private void listarClietes(string pesquisa = "")
        {
            sqlString =
                "SELECT c.id, c.nome, " +
                "c.cpf_cnpj AS 'cpf/cnpj', c.data_nascimento, " +
                "e.rua || ', ' || e.numero AS 'endereco', ativo " +
                "FROM cliente AS c " +
                "LEFT JOIN endereco AS e " +
                "ON c.id_endereco = e.id " +
                "WHERE ativo = 1 ";

            string pesquisaSql = $"AND c.nome || c.cpf_cnpj LIKE '%{pesquisa}%'";

            sqlString += pesquisa != string.Empty ? pesquisaSql : "";

            try
            {
                Conn.Open();
                SQLiteCommand command = new(sqlString, Conn);
                SQLiteDataAdapter adapter = new(command);

                DataTable table = new();
                adapter.Fill(table);

                dgCliente.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel retornar os dados dos Clientes\n\n{ex.Message}");
            }
            finally { Conn.Close(); }
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

        private void dgCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCliente = int.Parse(dgCliente.Rows[e.RowIndex].Cells["id"].Value.ToString());
            string nomeCliente = dgCliente.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            string cpfCnpj = dgCliente.Rows[e.RowIndex].Cells["cpf/cnpj"].Value.ToString();
            caixa.selecionaCliente(idCliente, nomeCliente, cpfCnpj);
            Close();
        }
    }
}
