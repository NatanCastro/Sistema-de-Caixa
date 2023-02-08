using Banco_de_dados;
using System.Data;
using System.Data.SQLite;

namespace Sistema_de_Caixa
{
    public partial class Usuarios : Form
    {
        readonly Conexao Conexao = new();
        readonly SQLiteConnection ConexaoString = Conexao.GetConnection();

        public bool PrimeiroUsuario { get; }

        public Usuarios(bool PrimeiroUsuario)
        {
            InitializeComponent();
            this.PrimeiroUsuario = PrimeiroUsuario;
        }

        private void listarUsuarios(string pesquisa = "")
        {
            Conexao.sqlString = "SELECT id, nome FROM usuario ";
            string pesquisaSql = $"WHERE c.nome || c.cpf_cnpj LIKE '%{pesquisa}%' ";
            if (!chInativos.Checked)
            {
                Conexao.sqlString += "WHERE ativo = 1 ";
                if (pesquisa != string.Empty) pesquisaSql = pesquisaSql.Replace("WHERE", "AND");
            }
            Conexao.sqlString += pesquisa != string.Empty ? pesquisaSql : "";

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

        private bool validarDados()
        {
            if (txtNome.Text == string.Empty) {
                MessageBox.Show("Insira o nome do usuario");
                return false;
            }
            return true;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            listarUsuarios();
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            if (!validarDados()) return;
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            int ativo = chAtivo.Checked ? 1 : 0;

            Conexao.sqlString = $"INSERT INTO usuario (nome, senha, ativo) " +
                $"VALUES ('{nome}', '{senha}', {ativo})";

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
            if (PrimeiroUsuario) { Close(); }
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            if (tsBuscar.Text == string.Empty)
            {
                MessageBox.Show("Selecione um usuario para editar");
                return;
            }
            if (!validarDados()) return;

            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            int ativo = chAtivo.Checked ? 1 : 0;

            Conexao.sqlString = $"UPDATE usuario SET nome='{nome}', senha='{senha}', ativo={ativo} " +
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
                chAtivo.Checked = dgUsuario.Rows[e.RowIndex].Cells["ativo"].Value.ToString() == "1" ? true : false;
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisar.Text;
            listarUsuarios(pesquisa);
        }

        private void dgUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgUsuario.Rows[e.RowIndex].Cells["editar"].ToolTipText = "editar";
            dgUsuario.Rows[e.RowIndex].Cells["apagar"].ToolTipText = "apagar";
            if (dgUsuario.Rows[e.RowIndex].Cells["ativo"].Value.ToString() == "0")
            {
                dgUsuario.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
        }
    }
}
