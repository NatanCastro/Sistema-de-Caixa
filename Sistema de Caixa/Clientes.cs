using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Sistema_de_Caixa.Controller;

namespace Sistema_de_Caixa
{
    public partial class Clientes : Form
    {
        readonly Conexao Conexao = new();
        readonly SQLiteConnection ConexaoString = Conexao.GetConnection();

        public Clientes()
        {
            InitializeComponent();
        }

        private void listarClietes()
        {
            Conexao.sqlString =
                "SELECT cliente.id, cliente.nome, " +
                "cliente.cpf_cnpj AS 'cpf/cnpj', cliente.data_nascimento," +
                "endereco.rua || ', ' || endereco.numero AS 'endereco' " +
                "FROM cliente " +
                "LEFT JOIN endereco " +
                "WHERE cliente.id_endereco = endereco.id";
            try
            {
                ConexaoString.Open();
                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);
                SQLiteDataAdapter adapter = new(command);

                DataTable table = new();
                adapter.Fill(table);

                dgCliente.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel retornar os dados dos Clientes\n\n{ex.Message}");
            }
            finally { ConexaoString.Close(); }
        }

        private void listarEnderecos()
        {
            Conexao.sqlString = "SELECT id, rua, numero FROM endereco";
            try
            {
                ConexaoString.Open();
                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);
                SQLiteDataReader reader = command.ExecuteReader();

                List<string> enderecos = new List<string>();

                while (reader.Read())
                {
                    enderecos.Add($"{reader.GetInt32(0)} - {reader.GetString(1)}, {reader.GetString(2)}");
                }
                cbEndereco.DataSource = enderecos.AsReadOnly();
                reader.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel retornar os endereços cadastrados\n\n{ex.Message}");
            }
            finally{ ConexaoString.Close(); }
        }

        private void limparDados()
        {
            tsBuscar.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtPesquisar.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            txtDataNasc.Text = string.Empty;
            txtDataNasc.Text = string.Empty;
        }

        private void verificaDados()
        {
            Regex RegexCpf = new(@"[0-9]{3}\.[0-9]{3}\.[0-9]{3}\-[0-9]{2}");
            Regex RegexCnpj = new(@"[0-9]{2}\.[0-9]{3}\.[0-9]{3}\/[0-9]{4}\-[0-9]{2}");
            Regex RegexDataNasc = new(@"([0-2][0-9]|3[0-1])\/(0[0-9]|1[0-2])\/[0-9]{4}");

            if (txtNome.Text == string.Empty ||
                !RegexCpf.IsMatch(txtCPF.Text) || !RegexCnpj.IsMatch(txtCNPJ.Text) ||
                !RegexDataNasc.IsMatch(txtDataNasc.Text))
            {
                MessageBox.Show("Preencha os campos obrigatorios");
                return;
            }

            if (!ValidaCPF.IsCPF(txtCPF.Text) && txtCPF.Enabled)
            {
                MessageBox.Show("CPF não valido");
                return;
            }
            if (!ValidaCNPJ.IsCnpj(txtCNPJ.Text) && txtCNPJ.Enabled)
            {
                MessageBox.Show("CNPJ não valido");
                return;
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            listarClietes();
            listarEnderecos();
        }


        private void pbCadEndereco_Click(object sender, EventArgs e)
        {
            Enderecos enderecos = new();
            enderecos.ShowDialog();
        }
        private void cbTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCPF.Enabled = cbTipoPessoa.Text == "Fisica";
            txtCNPJ.Enabled = cbTipoPessoa.Text == "Juridica";
            txtCPF.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
        }

        private void tsSavar_Click(object sender, EventArgs e)
        {
            verificaDados();
            string nome = txtNome.Text;
            string cpfCnpj = cbTipoPessoa.SelectedItem.ToString() == "Fisica"
                ? txtCPF.Text : txtCNPJ.Text;


            
            string[] dataArray = txtDataNasc.Text.Split('/');
            string ano = dataArray[2];
            string mes = dataArray[1];
            string dia = dataArray[0];
            string dataNasc = $"{ano}-{mes}-{dia}";
            int idEndereco = int.Parse(cbEndereco.Text.Substring(0,1));

            Conexao.sqlString = "INSERT INTO cliente (\"nome\", \"cpf_cnpj\", \"data_nascimento\", \"id_endereco\")" +
                $" VALUES ('{nome}', '{cpfCnpj}', DATE('{dataNasc}'), {idEndereco})";

            try
            {
                ConexaoString.Open();

                using SQLiteTransaction transaction = ConexaoString.BeginTransaction();
                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);

                MessageBox.Show(Conexao.sqlString);

                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel dacastrar o cliente\n\n{ex.Message}");
            }
            finally
            {
                ConexaoString.Close();
            }
            limparDados();
            listarClietes();
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            if (tsBuscar.Text == string.Empty)
            {
                MessageBox.Show("Selecione um cliente para editar");
                return;
            }

            verificaDados();
            
            string nome = txtNome.Text;

            string cpfCnpj = cbTipoPessoa.SelectedItem.ToString() == "Fisica"
                ? txtCPF.Text : txtCNPJ.Text;

            string[] dataArray = txtDataNasc.Text.Split('/');
            string ano = dataArray[2];
            string mes = dataArray[1];
            string dia = dataArray[0];
            string dataNasc = $"{ano}-{mes}-{dia}";
            int idEndereco = int.Parse(cbEndereco.Text.Substring(0,1));

            Conexao.sqlString = $"UPDATE cliente SET nome={nome}, cpf_cnpj={cpfCnpj}, " +
                $"data_nascimento={dataNasc}, id_endereco={idEndereco} " +
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
            listarClietes();
        }

        private void tsCancel_Click(object sender, EventArgs e)
        {
            limparDados();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (tsBuscar.Text == string.Empty)
            {
                MessageBox.Show("Selecione um cliente para apagar");
                return;
            }
            
            Conexao.sqlString = $"DELETE FROM cliente WHERE id={tsBuscar.Text}";

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
            listarClietes();
        }

        private void tsSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCliente.Columns[e.ColumnIndex] == dgCliente.Columns["editar"]
                || dgCliente.Columns[e.ColumnIndex] == dgCliente.Columns["apagar"])
            {
                tsBuscar.Text = dgCliente.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtNome.Text = dgCliente.Rows[e.RowIndex].Cells["nome"].Value.ToString();

                string cpfCnpj = dgCliente.Rows[e.RowIndex].Cells["cpf/cnpj"].Value.ToString();
                cpfCnpj = cpfCnpj.Replace(".", ",");
                string pattern = @"[0-9]{3}\.[0-9]{3}\.[0-9]{3}\-[0-9]{2}";

                Regex regex = new Regex(pattern);

                if (regex.IsMatch(cpfCnpj))
                {
                    cbTipoPessoa.SelectedItem = "Fisica";
                    txtCPF.Text = dgCliente.Rows[e.RowIndex]
                        .Cells["cpf/cnpj"].Value.ToString();
                }
                else
                {
                    cbTipoPessoa.SelectedItem = "Juridica";
                    txtCNPJ.Text = dgCliente.Rows[e.RowIndex]
                        .Cells["cpf/cnpj"].Value.ToString();
                }

                string[] dataNascArray = dgCliente.Rows[e.RowIndex]
                    .Cells["data_nascimento"].Value.ToString().Split("-");
                txtDataNasc.Text = $"{dataNascArray[2]}/{dataNascArray[1]}/{dataNascArray[0]}";
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisar.Text;

            Conexao.sqlString = 
                "SELECT cliente.id, cliente.nome, " +
                "cliente.cpf_cnpj AS 'cpf/cnpj', cliente.data_nascimento," +
                "endereco.rua || ', ' || endereco.numero AS 'endereco' " +
                "FROM cliente " +
                "LEFT JOIN endereco " +
                "WHERE cliente.id_endereco = endereco.id " +
                $"AND cliente.nome LIKE '%{pesquisa}%'";

            try
            {
                ConexaoString.Open();
                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);
                SQLiteDataAdapter adapter = new(command);

                DataTable table = new();
                adapter.Fill(table);

                dgCliente.DataSource = table;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel fazer a pesquisa\n\n{ex.Message}");
            }
            finally { ConexaoString.Close(); }
        }

        private void dgCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgCliente.Rows[e.RowIndex].Cells["editar"].ToolTipText = "editar";
            dgCliente.Rows[e.RowIndex].Cells["apagar"].ToolTipText = "apagar";
        }

        private void cbEndereco_Click(object sender, EventArgs e)
        {
            listarEnderecos();
        }
    }
}
