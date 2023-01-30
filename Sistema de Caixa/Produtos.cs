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
            sqlString = "SELECT codigo_barras AS 'Codigo de barras', nome, preco_custo AS 'Preço de custo', " +
                "preco_venda AS 'Preço de venda', margem_lucro AS 'Margem de lucro', quantidade categoria.nome AS 'categoria' "+
                "FROM produto " +
                "LEFT JOIN categoria " +
                "WHERE id_categoria = categoria.id";
            try
            {
                conn.Open();
                SQLiteCommand command = new(sqlString, conn);
                SQLiteDataAdapter adapter = new(command);

                DataTable table = new();
                adapter.Fill(table);

                dgProdutos.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel retornar os dados dos Produtos\n\n{ex.Message}");
            }
            finally { conn.Close(); }
        }

        private void listarCategorias()
        {
            sqlString = "SELECT";
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
            if (txtValorProduto.Text == string.Empty) return;

            decimal valorProduto;
            decimal valorVenda;

            Regex regex = new Regex(@"\,");
            if (regex.IsMatch(txtValorProduto.Text))
            {
                valorProduto = decimal.Parse(txtValorProduto.Text.Trim().Replace(",", "."));
            }
            else
            {
                valorProduto = decimal.Parse(txtValorProduto.Text.Trim());
            }

            if (regex.IsMatch(txtValorVenda.Text))
            {
                valorVenda = decimal.Parse(txtValorVenda.Text.Trim().Replace(",", "."));
            }
            else
            {
                valorVenda = decimal.Parse(txtValorVenda.Text.Trim());
            }

            //MessageBox.Show($"{valorProduto} {valorVenda}");

            txtMargemLucro.Text = decimal.Round(valorVenda / valorProduto * 100, 2).ToString();
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
                MessageBox.Show($"Não foi possivel dacastrar o cliente\n\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
            limparDados();
            listarProdutos();
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
        }

        private void tsSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisar.Text;

            sqlString = "";
            try
            {
                conn.Open();
                SQLiteCommand command = new(sqlString, conn);
                SQLiteDataAdapter adapter = new(command);

                DataTable table = new();
                adapter.Fill(table);

                dgCliente.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel fazer a pesquisa\n\n{ex.Message}");
            }
            finally { conn.Close(); }
        }

        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void txtMargemLucro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
