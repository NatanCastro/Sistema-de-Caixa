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
using System.Text.RegularExpressions;

namespace Sistema_de_Caixa
{
    public partial class Produtos : Form
    {
        private static string user = "user";
        SQLiteConnection conn = new($"Data Source=C:/Users/{user}/source/repos/natan22gt/Sistema-de-Caixa/Sistema de Caixa/banco/caixa.sqlite3; Version=3;");
        string sqlString = string.Empty;

        public Produtos()
        {
            InitializeComponent();
        }

        private void listarProdutos()
        {
            sqlString = "SELECT p.codigo_barras AS 'Codigo', p.nome AS 'Produto', p.preco_custo AS 'Custo', " +
                "p.preco_venda AS 'Venda', p.margem_lucro AS 'Lucro/%', p.quantidade, c.nome AS 'Categoria' "+
                "FROM produto AS p " +
                "LEFT JOIN categoria AS c " +
                "ON p.id_categoria = c.id";
            try
            {
                conn.Open();
                SQLiteCommand command = new(sqlString, conn);
                SQLiteDataAdapter adapter = new(command);

                DataTable table = new();
                adapter.Fill(table);

                dgProduto.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel retornar os dados dos Produtos\n\n{ex.Message}");
            }
            finally { conn.Close(); }
        }

        private void listarCategorias()
        {
            sqlString = "SELECT (id || ' - ' || nome) FROM categoria";

            try
            {
                conn.Open();
                SQLiteCommand command = new(sqlString, conn);
                SQLiteDataAdapter adapter = new(command);

                DataTable table = new();
                adapter.Fill(table);
                cbCategoria.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel recuperar os dados das categorias\n\n{ex.Message}");
            }
            finally { conn.Close(); }
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

        private void Produtos_Load(object sender, EventArgs e)
        {
            listarProdutos();
        }

        private void txtValorVenda_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new(@"[0-9]{1}\,[0-9]{2}");
            if (txtValorProduto.Text == string.Empty
                || txtValorVenda.Text == string.Empty
                || !regex.IsMatch(txtValorProduto.Text)
                || !regex.IsMatch(txtValorVenda.Text)) return;

            decimal valorProduto = decimal.Parse(txtValorProduto.Text);
            decimal valorVenda = decimal.Parse(txtValorVenda.Text);

            MessageBox.Show($"{valorProduto} {valorVenda}");

            txtMargemLucro.Text = (decimal.Round(((valorVenda -  valorProduto) / valorVenda * 100), 2)).ToString();
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            string codigoBarras = txtCodigoBarras.Text;
            string nome = txtNome.Text;
            decimal valorProduto = decimal.Parse(txtValorProduto.Text.Replace(",", "."));
            decimal valorVenda = decimal.Parse(txtValorVenda.Text.Replace(",", "."));
            decimal margemLucro = decimal.Round(decimal.Parse(txtMargemLucro.Text), 2);
            int quantidade = int.Parse(txtQtd.Text);
            int idCategoria = int.Parse(cbCategoria.SelectedText.Substring(0, 1));

            sqlString = "INSERT INTO produto " +
                "(\"codigo_barras\", \"nome\", \"preco_custo\", \"preco_venda\",\"margem_lucro\", \"quantidade\", \"id_categoria\") " +
                $"VALUES ('{codigoBarras}', '{nome}', {valorProduto}, {valorVenda}, {margemLucro}, {quantidade}, {idCategoria})";

            MessageBox.Show(sqlString);

            try
            {
                conn.Open();

                using SQLiteTransaction transaction = conn.BeginTransaction();
                SQLiteCommand command = new(sqlString, conn);

                MessageBox.Show(sqlString);

                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel dacastrar o Produto\n\n{ex.Message}");
            }
            finally
            {
                conn.Close();
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
            
            string codigoBarras = txtCodigoBarras.Text;
            string nome = txtNome.Text;
            decimal valorProduto = decimal.Parse(txtValorProduto.Text.Replace(",", "."));
            decimal valorVenda = decimal.Parse(txtValorVenda.Text.Replace(",", "."));
            decimal margemLucro = decimal.Round(decimal.Parse(txtMargemLucro.Text), 2);
            int quantidade = int.Parse(txtQtd.Text);
            int idCategoria = int.Parse(cbCategoria.SelectedText.Substring(0, 1));

            sqlString = $"UPDATE produto SET codigo_barras='{codigoBarras}', nome='{nome}', valor_custo={valorProduto}, " +
                $"valor_venda={valorVenda}, margem_lucro={margemLucro}, quantidade={quantidade}, id_caregoria={idCategoria} " + 
                $"WHERE codigo_barras={tsBuscar.Text}";

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
            
            sqlString = $"DELETE FROM produto WHERE id={tsBuscar.Text}";

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
                MessageBox.Show($"Não foi possivel apagar o cadastro\n\n{ex.Message}");
            }
            finally
            {
                conn.Close();
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
            string pesquisa = txtPesquisar.Text;

            sqlString = "SELECT p.codigo_barras AS 'Codigo', p.nome AS 'Produto', p.preco_custo AS 'Custo', " +
                "p.preco_venda AS 'Venda', p.margem_lucro AS 'Lucro/%', p.quantidade, c.nome AS 'Categoria' "+
                "FROM produto AS p " +
                "LEFT JOIN categoria AS c " +
                $"WHERE (codigo_barras || nome || c.nome) LIKE %{pesquisa}%";

            try
            {
                conn.Open();
                SQLiteCommand command = new(sqlString, conn);
                SQLiteDataAdapter adapter = new(command);

                DataTable table = new();
                adapter.Fill(table);

                dgProduto.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel fazer a pesquisa\n\n{ex.Message}");
            }
            finally { conn.Close(); }
        }

        private void dgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProduto.Columns[e.ColumnIndex] == dgProduto.Columns["editar"]
                || dgProduto.Columns[e.ColumnIndex] == dgProduto.Columns["apagar"])
            {
                txtCodigoBarras.Text = dgProduto.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                txtNome.Text = dgProduto.Rows[e.RowIndex].Cells["Produto"].Value.ToString();
                txtValorProduto.Text = dgProduto.Rows[e.RowIndex].Cells["Custo"].Value.ToString();
                txtValorVenda.Text = dgProduto.Rows[e.RowIndex].Cells["Venda"].Value.ToString();
                txtMargemLucro.Text = dgProduto.Rows[e.RowIndex].Cells["Lucro/%"].Value.ToString();
                txtQtd.Text = dgProduto.Rows[e.RowIndex].Cells["quantidade"].Value.ToString();
            }
        }

        private void dgProduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgProduto.Rows[e.RowIndex].Cells["editar"].ToolTipText = "editar";
            dgProduto.Rows[e.RowIndex].Cells["apagar"].ToolTipText = "apagar";
        }
    }
}
