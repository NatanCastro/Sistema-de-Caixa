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
        private static readonly string User = "user";
        public static SQLiteConnection Conn = new($"Data Source={Directory.GetCurrentDirectory()}; Version=3;") { };
        public string sqlString = string.Empty;

        VendaModel venda = new();

        public Caixa()
        {
            InitializeComponent();
        }

        public void selecionaCliente(int id, string nome, string cpfCnpj)
        {
            venda.idCliente = id;
            lblCliente.Text = nome;
            lblCpfCnpj.Text = cpfCnpj;
        }

        public void selecionaUsuario(int id, string vendedor)
        {
            venda.idUsuario = id;
            lblVendedor.Text = vendedor;
        }

        public void selecionaMetodoPagamento(string metodo)
        {
            sqlString = $"SELECT id FROM metodo_pagamento " +
                $"WHERE nome='{metodo}' LIMIT 1";

            try
            {
                Conn.Open();
                SQLiteCommand command = new(sqlString, Conn);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    venda.idMetodoPagamento = reader.GetInt32(0);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }

        public void cadastraVenda()
        {
            sqlString = $"INSERT INTO venda " +
                $"(id_cliente, id_usuario, id_metodo_pagamento, valor_total, desconto, valor_final, data_venda)" +
                $"VALUES ({venda.idCliente}, {venda.idUsuario}, {venda.idMetodoPagamento}, '{venda.valorTotal}', " +
                $"'{venda.desconto}', '{venda.valorFinal}', DATE())";

            try
            {
                Conn.Open();
                using SQLiteTransaction transaction = Conn.BeginTransaction();
                SQLiteCommand command = new(sqlString, Conn);

                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }

        private void cadastraItensVenda()
        {
            venda.listaProdutos.ForEach(produto =>
            {
                sqlString = "INSERT INTO itens_venda " +
                    "(id_venda, codigo_produto, quantidade, valor_unit, valor_total) " +
                    $"VALUES ((SELECT id FROM venda ORDER BY data_venda DESC LIMIT 1), " +
                    $"'{produto.codigo}', {produto.qtd}, '{produto.valorUnit}', '{produto.valorTotal}'); " +
                    $"UPDATE produto SET quantidade=quantidade-{produto.qtd} WHERE codigo_barras='{produto.codigo}';";

                try
                {
                    Conn.Open();
                    using SQLiteTransaction transaction = Conn.BeginTransaction();
                    SQLiteCommand command = new(sqlString, Conn);

                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conn.Close();
                }
            });
        }

        public void finalizaVenda(float valorTotal, float desconto, float valorFinal)
        {
            venda.valorTotal = valorTotal;
            venda.desconto = desconto;
            venda.valorFinal = valorFinal;

            if (venda.desconto != 0)
            {
                float disconto_unit = venda.desconto / venda.listaProdutos.Count;
                venda.listaProdutos.ForEach(produto =>
                {
                    produto.valorUnit -= (disconto_unit / produto.qtd);
                    produto.atualizaValor();
                });
            }

            cadastraVenda();
            cadastraItensVenda();

        }

        public void atualizaItens()
        {
            dgVenda.DataSource = null;
            dgVenda.DataSource = venda.listaProdutos;
        }

        public void cancelaVenda()
        {
            venda = new();
            lblCliente.Text = string.Empty;
            lblCpfCnpj.Text = string.Empty;
            lblVendedor.Text = string.Empty;
            lblTotal.Text = "0,00";
            txtCodigoBarras.Text = string.Empty;
            txtNomeProduto.Text = string.Empty;
            txtValorProduto.Text = string.Empty;
            dgVenda.DataSource = null;
        }

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13) return;
            sqlString = $"SELECT codigo_barras, nome, valor_venda FROM produto " +
                $"WHERE codigo_barras={txtCodigoBarras.Text} AND ativo=1 " +
                $"LIMIT 1";

            try
            {
                Conn.Open();
                SQLiteCommand command = new(sqlString, Conn);
                SQLiteDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("Produto não cadastrado ou inativo");
                }

                while (reader.Read())
                {
                    bool produtoDuplicado = false;
                    venda.listaProdutos.ForEach(produto => {
                        if (produto.codigo == txtCodigoBarras.Text)
                        {
                            MessageBox.Show("Não é possivel selecionar o mesmo item");
                            produtoDuplicado = true;
                        }
                    });

                    txtCodigoBarras.Text = string.Empty;
                    if (produtoDuplicado) return;
                    txtNomeProduto.Text = reader.GetString(1);
                    txtValorProduto.Text = reader.GetString(2);

                    int quantidade = int.Parse(numQuantidade.Value.ToString());
                    ProdutoVendaModel produto = new(reader.GetString(0), reader.GetString(1),
                                                    float.Parse(reader.GetString(2)), quantidade);
                    venda.AdicionaProduto(produto);

                    venda.valorTotal = 0;
                    venda.listaProdutos.ForEach(produto => venda.valorTotal += produto.valorTotal);
                    lblTotal.Text = venda.valorTotal.ToString();

                    atualizaItens();

                    if (venda.listaProdutos.Count == 1)
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
            finally { Conn.Close(); }
            e.Handled = true;
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            cancelaVenda();
        }

        private void dgVenda_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgVenda.Rows[e.RowIndex].Cells[e.RowIndex] != dgVenda.Rows[e.RowIndex].Cells["Cancelar"]) return;
            string? codigo = dgVenda.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
            venda.RemoveProduto(codigo);

            atualizaItens();
        }

        private void dgVenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgVenda.Rows[e.RowIndex].Cells["Cancelar"].ToolTipText = "Cancelar item";
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (venda.listaProdutos.Count < 1) return;
            FinalizaVenda finaliza = new(this, float.Parse(lblTotal.Text));
            finaliza.ShowDialog();
        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            DateOnly date = DateOnly.FromDateTime(DateTime.Now);
            lblData.Text = date.ToString();
        }
    }
}
