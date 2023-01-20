using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Caixa
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void txtValorVenda_TextChanged(object sender, EventArgs e)
        {
            if (txtValorProduto.Text != string.Empty)
            {
                txtMargemLucro.Text = $"{ int.Parse(txtValorVenda.Text) / int.Parse(txtValorProduto.Text) * 100}";
            }
        }
    }
}
