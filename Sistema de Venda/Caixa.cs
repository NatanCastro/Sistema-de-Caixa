using Banco_de_dados;
using Sistema_de_Venda.Models;
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
    public partial class Caixa : Form
    {
        readonly Conexao Conexao = new();
        readonly SQLiteConnection ConexaoString = Conexao.GetConnection();

        VendaModel venda = new();

        public Caixa()
        {
            InitializeComponent();
        }

        public void selecionaCliente(int id, string nome, string cpfCnpj)
        {
            venda.id_cliente = id;
            lblCliente.Text = nome;
            lblCpfCnpj.Text = cpfCnpj;
        }

        public void selecionaUsuario(int id, string vendedor)
        {
            venda.id_usuario = id;
            lblVendedor.Text = vendedor;
        }

        public void cancelaVenda()
        {
            venda = new();
        }

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13) return;
            Conexao.sqlString = $"SELECT codigo_barras, nome, valor_venda FROM produto " +
                $"WHERE codigo_barras={txtCodigoBarras.Text} AND ativo=1 " +
                $"LIMIT 1";

            try
            {
                ConexaoString.Open();
                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtNomeProduto.Text = reader.GetString(1);
                    txtValorProduto.Text = reader.GetString(2);

                    int quantidade = int.Parse(numQuantidade.Value.ToString());
                    ProdutoVendaModel produto = new(reader.GetString(0), reader.GetString(1),
                                                    reader.GetString(2), quantidade);
                    venda.AdicionaProduto(produto);
                    dgVenda.DataSource = venda.listaProdutos;

                    if (venda.listaProdutos.Count == 1 )
                    {
                        SelecionaCliente cliente = new(this);
                        cliente.ShowDialog();
                        SelecionaUsuario usuario = new(this);
                        usuario.ShowDialog();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { ConexaoString.Close(); }
            e.Handled = true;
        }
    }
}
