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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void cadastrareditarconsultarexcluirEndereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enderecos enderecos = new Enderecos();
            enderecos.ShowDialog();
        }

        private void cadastrareditarconsultarexcluirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
        }
    }
}
