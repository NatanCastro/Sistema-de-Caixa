using Sistema_de_Caixa.Controller;
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
        readonly Conexao Conexao = new();
        readonly SQLiteConnection ConexaoString = Conexao.GetConnection();

        public Usuarios()
        {
            InitializeComponent();
        }

        private void listarUsuarios()
        {
            Conexao.sqlString = "SELECT id, nome FROM usuario";

            try
            {
                ConexaoString.Open();

                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);
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
                ConexaoString.Close();
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

            Conexao.sqlString = $"INSERT INTO usuario (nome, senha) " +
                $"VALUES ('{nome}', '{senha}')";

            try
            {
                ConexaoString.Open();

                using SQLiteTransaction transaction = ConexaoString.BeginTransaction();
                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);

                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não fui possivel cadastrar o usuario\n\n{ex.Message}");
            }
            finally
            {
                ConexaoString.Close();
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

            Conexao.sqlString = $"UPDATE usuario SET nome='{nome}', senha='{senha}' " +
                $"WHERE id={tsBuscar.Text}";

            try
            {
                ConexaoString.Open();

                using SQLiteTransaction transaction = ConexaoString.BeginTransaction();
                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);

                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel atualizar o cadastro\n\n{ex.Message}");
            }
            finally
            {
                ConexaoString.Close();
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

            Conexao.sqlString = $"DELETE FROM usuario WHERE id='{tsBuscar.Text}'";

            try
            {
                ConexaoString.Open();
                using SQLiteTransaction transaction = ConexaoString.BeginTransaction();

                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possivel apagar o cadastro\n\n{ex.Message}");
            }
            finally
            {
                ConexaoString.Close();
            }

            limparDados();
            listarUsuarios();
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
            Conexao.sqlString = $"SELECT id, nome FROM usuario WHERE nome LIKE %{pesquisa}%";

            try
            {
                ConexaoString.Open();

                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);
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
                ConexaoString.Close();
            }
        }

        private void dgUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgUsuario.Rows[e.RowIndex].Cells["editar"].ToolTipText = "editar";
            dgUsuario.Rows[e.RowIndex].Cells["apagar"].ToolTipText = "apagar";
        }
    }
}
