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
    public partial class Usuarios : Form
    {
        private static string user = "user";
        SQLiteConnection conn = new($"Data Source=C:/Users/{user}/source/repos/natan22gt/Sistema-de-Caixa/Sistema de Caixa/banco/caixa.sqlite3; Version=3;");
        string sqlString = string.Empty;

        public Usuarios()
        {
            InitializeComponent();
        }

        private void listarUsuarios()
        {
            sqlString = "SELECT id, nome FROM usuario";

            try
            {
                conn.Open();

                SQLiteCommand command = new(sqlString, conn);
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
                conn.Close();
            }
        }

        private void limparDados()
        {
            tsBuscar.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            listarUsuarios();
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty) {
                MessageBox.Show("Insira o nome do usuario");
                return;
            }
            string nome = txtNome.Text;
            string senha = txtSenha.Text;

            sqlString = $"INSERT INTO usuario (nome, senha) " +
                $"VALUES ('{nome}', '{senha}')";

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
                MessageBox.Show($"Não fui possivel cadastrar o usuario\n\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            limparDados();
            listarUsuarios();
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            if (tsBuscar.Text == string.Empty)
            {
                MessageBox.Show("Selecione um usuario para editar");
                return;
            }

            string nome = txtNome.Text;
            string senha = txtSenha.Text;

            sqlString = $"UPDATE usuario SET nome='{nome}', senha='{senha}' " +
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
            listarUsuarios();
        }

        private void tsCancelar_Click(object sender, EventArgs e)
        {
            limparDados();
        }

        private void tsDeletar_Click(object sender, EventArgs e)
        {
            if (tsBuscar.Text == string.Empty)
            {
                MessageBox.Show("Selecione um usuario para apagar");
                return;
            }

            sqlString = $"DELETE FROM usuario WHERE id='{tsBuscar.Text}'";

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

        private void dgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgUsuario.Columns[e.ColumnIndex] == dgUsuario.Columns["editar"]
                || dgUsuario.Columns[e.ColumnIndex] == dgUsuario.Columns["apagar"])
            {
                tsBuscar.Text = dgUsuario.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtNome.Text = dgUsuario.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisar.Text;
            sqlString = $"SELECT id, nome FROM usuario WHERE nome LIKE %{pesquisa}%";

            try
            {
                conn.Open();

                SQLiteCommand command = new(sqlString, conn);
                SQLiteDataAdapter adapter = new(command);

                DataTable table = new();
                adapter.Fill(table);

                dgUsuario.DataSource = table;
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

        private void dgUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgUsuario.Rows[e.RowIndex].Cells["editar"].ToolTipText = "editar";
            dgUsuario.Rows[e.RowIndex].Cells["apagar"].ToolTipText = "apagar";
        }
    }
}
