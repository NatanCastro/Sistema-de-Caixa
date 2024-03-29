﻿using Refit;
using Sistema_de_Caixa.Controller;
using Sistema_de_Caixa.Models;
using Banco_de_dados;
using System.Data;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace Sistema_de_Caixa
{
    public partial class Enderecos : Form
    {
        readonly Conexao Conexao = new();
        readonly SQLiteConnection ConexaoString = Conexao.GetConnection();

        public Enderecos()
        {
            InitializeComponent();
        }

        private void listarEnderecos()
        {
            Conexao.sqlString = "SELECT id, rua, numero, bairro, complemento, cidade, UF, pais, CEP FROM endereco";

            try
            {
                ConexaoString.Open();

                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);
                SQLiteDataAdapter adapter = new(command);

                DataTable table = new();
                adapter.Fill(table);

                dgEndereco.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel retornar os dados dos endereços\n\n{ex.Message}");
            }
            finally
            {
                ConexaoString.Close();
            }
        }

        private void limparDados()
        {
            tsBuscar.Text = string.Empty;
            txtRua.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtUF.Text = string.Empty;
            txtPais.Text = string.Empty;
            txtCEP.Text = string.Empty;
        }

        private static async Task<CepResponse?> getAddress(string cep)
        {
            try
            {
                CepApiService cepClient = RestService.For<CepApiService>("https://viacep.com.br/");

                CepResponse address = await cepClient.GetAddressAsync(cep);
                return address;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na consulta do CEP\n\n{ex.Message}");
                return null;
            }
        }

        private bool validarDados()
        {
            if (txtRua.Text == string.Empty || txtNumero.Text == string.Empty || 
                txtBairro.Text == string.Empty || txtCidade.Text == string.Empty ||
                txtUF.Text == string.Empty)
            {
                MessageBox.Show("Preencha os campos obrigatorios");
                return false;
            }
            return true;
        }

        private void Enderecos_Load(object sender, EventArgs e)
        {
            listarEnderecos();
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            if (!validarDados()) return;

            string rua = txtRua.Text;
            string numero = txtNumero.Text;
            string complemento = txtComplemento.Text;
            string bairro = txtBairro.Text;
            string cidade = txtCidade.Text;
            string UF = txtUF.Text;
            string pais = txtPais.Text;
            string CEP = txtCEP.Text;

            Conexao.sqlString = $"INSERT INTO endereco (rua, numero, complemento, " +
                $"bairro, cidade, UF, pais, CEP) " +
                $"VALUES ('{rua}', '{numero}', '{complemento}', '{bairro}', " +
                $"'{cidade}', '{UF}', '{pais}', '{CEP}')";

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
                MessageBox.Show($"Não fui possivel cadastrar o Endereço\n\n{ex.Message}");
            }
            finally
            {
                ConexaoString.Close();
            }

            limparDados();
            listarEnderecos();
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            if (tsBuscar.Text == string.Empty)
            {
                MessageBox.Show("Selecione um endereço para editar");
                return;
            }
            if (!validarDados()) return;

            string rua = txtRua.Text;
            string numero = txtNumero.Text;
            string complemento = txtComplemento.Text;
            string bairro = txtBairro.Text;
            string cidade = txtCidade.Text;
            string UF = txtUF.Text;
            string pais = txtPais.Text;

            Conexao.sqlString = $"UPDATE endereco SET rua='{rua}', numero='{numero}', complemento='{complemento}', " +
                $"bairro='{bairro}', cidade='{cidade}', UF='{UF}', pais='{pais}' " +
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
            listarEnderecos();

        }

        private void tsCancelar_Click(object sender, EventArgs e)
        {
            limparDados();
        }

        private void tsDeletar_Click(object sender, EventArgs e)
        {
            if (tsBuscar.Text == string.Empty)
            {
                MessageBox.Show("Selecione um endereço para apagar");
                return;
            }

            Conexao.sqlString = $"DELETE FROM endereco WHERE id='{tsBuscar.Text}'";

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
            listarEnderecos();
        }

        private void tsSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgEndereco.Columns[e.ColumnIndex] == dgEndereco.Columns["editar"]
                || dgEndereco.Columns[e.ColumnIndex] == dgEndereco.Columns["apagar"])
            {
                tsBuscar.Text = dgEndereco.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtRua.Text = dgEndereco.Rows[e.RowIndex].Cells["rua"].Value.ToString();
                txtNumero.Text = dgEndereco.Rows[e.RowIndex].Cells["numero"].Value.ToString();
                txtBairro.Text = dgEndereco.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
                txtComplemento.Text = dgEndereco.Rows[e.RowIndex].Cells["complemento"].Value.ToString();
                txtCidade.Text = dgEndereco.Rows[e.RowIndex].Cells["cidade"].Value.ToString();
                txtUF.Text = dgEndereco.Rows[e.RowIndex].Cells["UF"].Value.ToString();
                txtPais.Text = dgEndereco.Rows[e.RowIndex].Cells["pais"].Value.ToString();
                txtCEP.Text = dgEndereco.Rows[e.RowIndex].Cells["CEP"].Value.ToString();
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisar.Text;
            Conexao.sqlString = $"SELECT id, rua, numero, bairro, complemento, cidade, UF, pais, CEP FROM endereco " +
                $"WHERE (rua || numero || bairro || cidade || UF || pais || CEP) LIKE %{pesquisa}%";

            try
            {
                ConexaoString.Open();

                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);
                SQLiteDataAdapter adapter = new(command);

                DataTable table = new();
                adapter.Fill(table);

                dgEndereco.DataSource = table;
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

        private async void txtCEP_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[0-9]{5}\-[0-9]{3}");

            if (!regex.IsMatch(txtCEP.Text) || tsBuscar.Text != string.Empty) return;

            string cep = $"{txtCEP.Text.Split('-')[0]}{txtCEP.Text.Split('-')[1]}";

            CepResponse? address = await getAddress(cep);


            txtRua.Text = address.Logradouro == null ? "" : address.Logradouro.ToString();
            txtComplemento.Text = address.Complemento == null ? "" : address.Complemento.ToString();
            txtBairro.Text = address.Bairro == null ? "" : address.Bairro.ToString();
            txtCidade.Text = address.Localidade == null ? "" : address.Localidade.ToString();
            txtUF.Text = address.Uf == null ? "" : address.Uf.ToString();
        }

        private void dgEndereco_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgEndereco.Rows[e.RowIndex].Cells["editar"].ToolTipText = "editar";
            dgEndereco.Rows[e.RowIndex].Cells["apagar"].ToolTipText = "apagar";
        }
    }
}
