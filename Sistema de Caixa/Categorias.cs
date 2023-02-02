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
    public partial class Categorias : Form
    {
        private static string user = "natan.gacastro";
        private SQLiteConnection conn = new($"Data Source=C:/Users/{user}/source/repos/natan22gt/Sistema-de-Caixa/Sistema de Caixa/banco/caixa.sqlite3; Version=3;");
        string sqlString = string.Empty;

        public Categorias()
        {
            InitializeComponent();
        }

        private void listarCategoria()
        {
            sqlString = "SELECT id, nome FROM categoria";

            try
            {
                conn.Open();

                SQLiteCommand command = new(sqlString, conn);
                SQLiteDataAdapter adapter = new(command);
                DataTable table = new();
                adapter.Fill(table);

                dgCategoria.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel retornar os dados dos categorias\n\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void limparDados()
        {
            tsBuscar.Text = string.Empty;
            txtNome.Text = string.Empty;
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            listarCategoria();
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty) {
                MessageBox.Show("Insira o nome do categoria");
                return;
            }
            string nome = txtNome.Text;

            sqlString = $"INSERT INTO categoria (nome) " +
                $"VALUES ('{nome}')"; 

            try
            {
                conn.Open();

                using SQLiteTransaction transaction = conn.BeginTransaction();
                SQLiteCommand command = new(sqlString, conn);

                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não fui possivel cadastrar o categoria\n\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            limparDados();
            listarCategoria();
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            if (tsBuscar.Text == string.Empty)
            {
                MessageBox.Show("Selecione um categoria para editar");
                return;
            }

            string nome = txtNome.Text;

            sqlString = $"UPDATE categoria SET nome='{nome}'" +
                $"WHERE id={tsBuscar.Text}";

            try
            {
                conn.Open();

                using SQLiteTransaction transaction = conn.BeginTransaction();
                SQLiteCommand command = new(sqlString, conn);

                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel atualizar o cadastro\n\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            limparDados();
            listarCategoria();
        }

        private void tsCancelar_Click(object sender, EventArgs e)
        {
            limparDados();
        }

        private void tsDeletar_Click(object sender, EventArgs e)
        {
            if (tsBuscar.Text == string.Empty)
            {
                MessageBox.Show("Selecione um categoria para apagar");
                return;
            }

            sqlString = $"DELETE FROM categoria WHERE id='{tsBuscar.Text}'";

            try
            {
                conn.Open();
                using SQLiteTransaction transaction = conn.BeginTransaction();

                SQLiteCommand command = new(sqlString, conn);
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possivel apagar o cadastro\n\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void tsSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisar.Text;
            sqlString = $"SELECT id, nome FROM categoria WHERE nome LIKE %{pesquisa}%";

            try
            {
                conn.Open();

                SQLiteCommand command = new(sqlString, conn);
                SQLiteDataAdapter adapter = new(command);

                DataTable table = new();
                adapter.Fill(table);

                dgCategoria.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel fazer a pesquisa\n\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCategoria.Columns[e.ColumnIndex] == dgCategoria.Columns["editar"]
                || dgCategoria.Columns[e.ColumnIndex] == dgCategoria.Columns["apagar"])
            {
                tsBuscar.Text = dgCategoria.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtNome.Text = dgCategoria.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            }
        }

        private void dgCategoria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgCategoria.Rows[e.RowIndex].Cells["editar"].ToolTipText = "editar";
            dgCategoria.Rows[e.RowIndex].Cells["apagar"].ToolTipText = "apagar";
        }
    }
}
