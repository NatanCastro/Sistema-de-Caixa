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
    public partial class Categorias : Form
    {
        readonly Conexao Conexao = new();
        readonly SQLiteConnection ConexaoString = Conexao.GetConnection();

        public Categorias()
        {
            InitializeComponent();
        }

        private void listarCategoria()
        {
            Conexao.sqlString = "SELECT id, nome FROM categoria";

            try
            {
                ConexaoString.Open();

                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);
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
                ConexaoString.Close();
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

            Conexao.sqlString = $"INSERT INTO categoria (nome) " +
                $"VALUES ('{nome}')"; 

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
                MessageBox.Show($"Não fui possivel cadastrar o categoria\n\n{ex.Message}");
            }
            finally
            {
                ConexaoString.Close();
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

            Conexao.sqlString = $"UPDATE categoria SET nome='{nome}'" +
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

            Conexao.sqlString = $"DELETE FROM categoria WHERE id='{tsBuscar.Text}'";

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
        }

        private void tsSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisar.Text;
            Conexao.sqlString = $"SELECT id, nome FROM categoria WHERE nome LIKE %{pesquisa}%";

            try
            {
                ConexaoString.Open();

                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);
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
                ConexaoString.Close();
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
