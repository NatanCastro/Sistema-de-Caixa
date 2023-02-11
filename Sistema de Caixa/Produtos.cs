using System.Data;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using Banco_de_dados;

namespace Sistema_de_Caixa
{
    public partial class Produtos : Form
    {
        readonly Conexao Conexao = new();
        readonly SQLiteConnection ConexaoString = Conexao.GetConnection();

        public Produtos()
        {
            InitializeComponent();
        }

        private void listarProdutos(string pesquisa = "")
        {
            Conexao.sqlString = "SELECT p.codigo_barras AS 'Codigo', p.nome AS 'Produto', p.valor_produto AS 'Custo', " +
                "p.valor_venda AS 'Venda', p.margem_lucro AS 'Lucro/%', p.quantidade, c.nome AS 'Categoria', p.ativo " +
                "FROM produto AS p " +
                "LEFT JOIN categoria AS c " +
                "ON p.id_categoria = c.id ";

            string pesquisaSql = $"WHERE (codigo_barras || p.nome || c.nome) LIKE '%{pesquisa}%'";
            if (!chInativos.Checked)
            {
                Conexao.sqlString += "WHERE p.ativo = 1 ";
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

                dgProduto.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel retornar os dados dos Produtos\n\n{ex.Message}");
            }
            finally { ConexaoString.Close(); }
        }

        private void listarCategorias()
        {
            Conexao.sqlString = "SELECT id, nome FROM categoria WHERE ativo = 1";

            try
            {
                ConexaoString.Open();
                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);
                SQLiteDataReader reader = command.ExecuteReader();

                List<string> categorias = new();

                while (reader.Read())
                {
                    categorias.Add($"{reader.GetInt32(0)} - {reader.GetString(1)}");
                }

                cbCategoria.DataSource = categorias.AsReadOnly();
                reader.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel recuperar os dados das categorias\n\n{ex.Message}");
            }
            finally { ConexaoString.Close(); }
        }

        private void limparDados()
        {
            txtCodigoBarras.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtValorProduto.Text = string.Empty;
            txtValorVenda.Text = string.Empty;
            txtMargemLucro.Text = string.Empty;
            txtQtd.Text = string.Empty;
        }

        private bool validarDados()
        {
            Regex valor = new(@"([0-9]{2}|[1-9]{1})\,[0-9]{2}");
            if (txtCodigoBarras.Text == string.Empty || txtNome.Text == string.Empty ||
                !valor.IsMatch(txtValorProduto.Text) || !valor.IsMatch(txtValorVenda.Text) || 
                txtMargemLucro.Text == string.Empty || txtQtd.Text == string.Empty)
            {
                MessageBox.Show("Preencha os campos obrigatorios");
                return false;
            }
            return true;
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            listarProdutos();
            listarCategorias();
        }

        private void pbCadCategoria_Click(object sender, EventArgs e)
        {
            Categorias categorias = new();
            categorias.ShowDialog();
        }

        private void txtValorVenda_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new(@"([0-9]{2}|[1-9]{1})\,[0-9]{2}");
            if (txtValorProduto.Text == string.Empty
                || txtValorVenda.Text == string.Empty
                || !regex.IsMatch(txtValorProduto.Text)
                || !regex.IsMatch(txtValorVenda.Text)) return;

            decimal valorProduto = decimal.Parse(txtValorProduto.Text);
            decimal valorVenda = decimal.Parse(txtValorVenda.Text);

            txtMargemLucro.Text = (decimal.Round(((valorVenda -  valorProduto) / valorVenda * 100), 2)).ToString();
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            if (!validarDados()) return;
            string codigoBarras = txtCodigoBarras.Text;
            string nome = txtNome.Text;
            decimal valorProduto = decimal.Parse(txtValorProduto.Text);
            decimal valorVenda = decimal.Parse(txtValorVenda.Text);
            decimal margemLucro = decimal.Round(decimal.Parse(txtMargemLucro.Text), 2);
            int quantidade = int.Parse(txtQtd.Text);
            uint idCategoria;
            int ativo = chAtivo.Checked ? 1 : 0;

            if (cbCategoria.SelectedItem.ToString() != "")
            {
                idCategoria = uint.Parse(cbCategoria.SelectedItem.ToString()[..1]);
            }
            else
            {
                MessageBox.Show("Por favor cadastre uma categoria para o produto");
                return;
            }
            
            Conexao.sqlString = "INSERT INTO produto " +
                "(\"codigo_barras\", \"nome\", \"valor_produto\", \"valor_venda\", \"margem_lucro\", \"quantidade\", \"ativo\", \"id_categoria\") " +
                $"VALUES ('{codigoBarras}', '{nome}', '{valorProduto}', '{valorVenda}', '{margemLucro}', {quantidade}, {ativo}, {idCategoria})";

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
                MessageBox.Show($"Não foi possivel dacastrar o Produto\n\n{ex.Message}");
            }
            finally
            {
                ConexaoString.Close();
            }
            limparDados();
            listarProdutos();
            listarCategorias();
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            if (tsBuscar.Text == string.Empty)
            {
                MessageBox.Show("Selecione um cliente para editar");
                return;
            }
            if (!validarDados()) return;

            string codigoBarras = txtCodigoBarras.Text;
            string nome = txtNome.Text;
            decimal valorProduto = decimal.Parse(txtValorProduto.Text);
            decimal valorVenda = decimal.Parse(txtValorVenda.Text);
            decimal margemLucro = decimal.Round(decimal.Parse(txtMargemLucro.Text), 2);
            int quantidade = int.Parse(txtQtd.Text);
            uint idCategoria;
            int ativo = chAtivo.Checked ? 1 : 0;

            if (cbCategoria.SelectedItem.ToString() != "")
            {
                idCategoria = uint.Parse(cbCategoria.SelectedItem.ToString()[..1]);
            }
            else
            {
                MessageBox.Show("Por favor cadastre uma categoria para o produto");
                return;
            }
            
            Conexao.sqlString = $"UPDATE produto SET codigo_barras='{codigoBarras}', nome='{nome}', valor_produto='{valorProduto}', " +
                $"valor_venda='{valorVenda}', margem_lucro='{margemLucro}', quantidade={quantidade}, ativo={ativo}, id_categoria={idCategoria} " + 
                $"WHERE codigo_barras={tsBuscar.Text}";
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
            listarProdutos();
            listarCategorias();
        }

        private void tsCancelar_Click(object sender, EventArgs e)
        {
            limparDados();
        }

        private void tsDeletar_Click(object sender, EventArgs e)
        {
            if (tsBuscar.Text == string.Empty)
            {
                MessageBox.Show("Selecione um cliente para apagar");
                return;
            }
            
            Conexao.sqlString = $"DELETE FROM produto WHERE codigo_barras={tsBuscar.Text}";

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
                MessageBox.Show($"Não foi possivel apagar o cadastro\n\n{ex.Message}");
            }
            finally
            {
                ConexaoString.Close();
            }

            limparDados();
            listarProdutos();
            listarCategorias();
        }

        private void tsSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            listarProdutos(txtPesquisar.Text);
        }

        private void dgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProduto.Columns[e.ColumnIndex] == dgProduto.Columns["editar"]
                || dgProduto.Columns[e.ColumnIndex] == dgProduto.Columns["apagar"])
            {
                tsBuscar.Text = dgProduto.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                txtCodigoBarras.Text = dgProduto.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                txtNome.Text = dgProduto.Rows[e.RowIndex].Cells["Produto"].Value.ToString();
                txtValorProduto.Text = dgProduto.Rows[e.RowIndex].Cells["Custo"].Value.ToString();
                txtValorVenda.Text = dgProduto.Rows[e.RowIndex].Cells["Venda"].Value.ToString();
                txtMargemLucro.Text = dgProduto.Rows[e.RowIndex].Cells["Lucro/%"].Value.ToString();
                txtQtd.Text = dgProduto.Rows[e.RowIndex].Cells["quantidade"].Value.ToString();
                chAtivo.Checked = dgProduto.Rows[e.RowIndex].Cells["ativo"].Value.ToString() == "1" ? true : false;
            }
        }

        private void dgProduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgProduto.Rows[e.RowIndex].Cells["editar"].ToolTipText = "editar";
            dgProduto.Rows[e.RowIndex].Cells["apagar"].ToolTipText = "apagar";

            if (dgProduto.Rows[e.RowIndex].Cells["ativo"].Value.ToString() == "0")
            {
                dgProduto.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void cbCategoria_Click(object sender, EventArgs e)
        {
            listarCategorias();
        }

        private void chInativos_CheckedChanged(object sender, EventArgs e)
        {
            listarProdutos(txtPesquisar.Text);
        }
    }
}
