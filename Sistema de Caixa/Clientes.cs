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

        public Clientes()
        {
            InitializeComponent();
        }

        private void listarEnderecos()
        {
            conn.Open();

            string sqlString = "SELECT id, rua, numero FROM endereco";
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
            listarEnderecos();
        }


        private void pbCadEndereco_Click(object sender, EventArgs e)
        {
            Enderecos enderecos = new();
            enderecos.ShowDialog();
        }

        private void tsSavar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string nome = txtNome.Text;
            string cpfCnpj = txtCPF.Text != "" ? txtCPF.Text : txtCNPJ.Text;
            cpfCnpj.Replace(',', '.');
            string[] dataArray = txtDataNasc.Text.Split('/');
            string ano = dataArray[2];
            string mes = dataArray[1];
            string dia = dataArray[0];
            string dataNascText = $"{ano}-{mes}-{dia}";
            SQLiteDateFormats dataNasc = new();
            int idEndereco = int.Parse(cbEndereco.Text.Substring(0,1));
            string sqlString = $"INSERT INTO cliente (nome, cpf/cnpj, data_nascimento, id_endereco)" +
                $" VALUES ({nome}, {cpfCnpj}, , {idEndereco}";

            conn.Close();
        }
    }
}
