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
    public partial class SelecionaUsuario : Form
    {
        private static readonly string User = "user";
        public static SQLiteConnection Conn = new($"Data Source={Directory.GetCurrentDirectory()}/caixa.sqlite3; Version=3;") { };
        public string sqlString = string.Empty;

        Caixa caixa;
        public SelecionaUsuario(Caixa caixa)
        {
            InitializeComponent();
            this.caixa = caixa;
        }

        public void listarUsuario(string pesquisa = "")
        {
            sqlString = "SELECT id, nome FROM usuario ";
            string pesquisaSql = $"WHERE nome LIKE '%{pesquisa}%'";
            sqlString += pesquisa != string.Empty ? pesquisaSql : "";

            try
            {
                Conn.Open();

                SQLiteCommand command = new(sqlString, Conn);
                SQLiteDataAdapter adapter = new(command);

                DataTable table = new();
                adapter.Fill(table);

                dgUsuario.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel retornar os dados dos usuarios\n\n{ex.Message}");
            }
            finally
            {
                Conn.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            caixa.cancelaVenda();
            Close();
        }

        private void SelecionaUsuario_Load(object sender, EventArgs e)
        {
            listarUsuario();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtBusca.Text;
            listarUsuario(pesquisa);
        }

        private void dgUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idUsuario = int.Parse(dgUsuario.Rows[e.RowIndex].Cells["id"].Value.ToString());
            string vendedor = dgUsuario.Rows[e.RowIndex].Cells["nome"].Value.ToString();

            caixa.selecionaUsuario(idUsuario, vendedor);
            Close();
        }
    }
}
