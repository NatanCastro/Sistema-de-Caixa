using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Caixa
{
    public partial class Clientes : Form
    {
        SQLiteConnection conn = new(@"Data Source=C:\Users\User\source\repos\Sistema-de-Caixa\Sistema de Caixa\banco\caixa.sqlite3;Version=3;");
        string sqlString = string.Empty;

        public Clientes()
        {
            InitializeComponent();
        }

        private void listarClietes()
        {
            sqlString =
                "SELECT cliente.id, cliente.nome, cliente.cpf_cnpj, cliente.data_nascimento," +
                "endereco.rua || ', ' || endereco.numero AS 'endereco'" +
                "FROM cliente" +
                "INNER JOIN endereco" +
                "WHERE cliente.id_endereco = endereco.id";
            MessageBox.Show(sqlString);
            conn.Open();
            SQLiteCommand command = new(sqlString, conn);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show(reader.ToString());
            }
        }

        private void listarEnderecos()
        {
            conn.Open();

            sqlString = "SELECT id, rua, numero FROM endereco";
            SQLiteCommand command = new(sqlString, conn);
            SQLiteDataReader reader = command.ExecuteReader();

            List<string> enderecos = new List<string>();

            while (reader.Read())
            {
                enderecos.Add($"{reader.GetInt32(0)} - {reader.GetString(1)} {reader.GetString(2)}");
            }
            cbEndereco.DataSource = enderecos.AsReadOnly();
            reader.Close();
            conn.Close();

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
        }

        private void tsSavar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string nome = txtNome.Text;
            string cpfCnpj = txtCPF.Text != "" ? txtCPF.Text : txtCNPJ.Text;
            cpfCnpj = cpfCnpj.Replace(',', '.');
            string[] dataArray = txtDataNasc.Text.Split('/');
            string ano = dataArray[2];
            string mes = dataArray[1];
            string dia = dataArray[0];
            string dataNasc = $"{ano}-{mes}-{dia}";
            int idEndereco = int.Parse(cbEndereco.Text.Substring(0,1));

            sqlString = $"INSERT INTO cliente (\"nome\", \"cpf_cnpj\", \"data_nascimento\", \"id_endereco\")" +
                $" VALUES ('{nome}', '{cpfCnpj}', DATE('{dataNasc}'), {idEndereco})";
            MessageBox.Show(sqlString);
            using (SQLiteTransaction transaction = conn.BeginTransaction())
            {
                SQLiteCommand command = new(sqlString, conn);
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            conn.Close();
            
            txtNome.Text = string.Empty;
            txtPesquisar.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            txtDataNasc.Text = string.Empty;
            txtDataNasc.Text = string.Empty;
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {

        }

        private void tsCancel_Click(object sender, EventArgs e)
        {

        }

        private void tsDelete_Click(object sender, EventArgs e)
        {

        }

        private void tsSair_Click(object sender, EventArgs e)
        {

        }
    }
}
