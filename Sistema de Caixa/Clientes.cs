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
        SQLiteConnection conn = new(@"Data Source=banco\caixa.sqlite3;Version=3;");
        public Clientes()
        {
            InitializeComponent();
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
            string[] dataArray = txtDataNasc.Text.Split('/');
            string ano = dataArray[2];
            string mes = dataArray[1];
            string dia = dataArray[0];
            string dataNasc = $"{ ano }-{ mes }-{ dia }";
            int idEndereco = int.Parse((string)cbEndereco.SelectedValue);
            string sqlString = $"INSERT INTO cliente (nome, cpf/cnpj, data_nascimento, id_endereco)" +
                $" VALUES ({nome}, {cpfCnpj}, DATE({dataNasc}), {idEndereco}";


        }

    }
}
