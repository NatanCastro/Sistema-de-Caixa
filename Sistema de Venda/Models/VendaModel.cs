using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venda.Models
{
    internal class VendaModel
    {
        public List<ProdutoVendaModel> listaProdutos = new();
        public int id_cliente { get; set; }

        public void AdicionaProduto(ProdutoVendaModel produto)
        {
            listaProdutos.Add(produto);
        }
        public void removeProduto(string codigo)
        {
            ProdutoVendaModel? produto = listaProdutos.Find(produto => produto.codigo == codigo);
            if (produto == null)
            {
                MessageBox.Show("Não foi possivel achar o produto nos itens da venda");
                return;
            }
            listaProdutos.Remove(produto);
        }
    }
}
