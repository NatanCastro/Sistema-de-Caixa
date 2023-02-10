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

        public void AdicionaProduto(ProdutoVendaModel produto)
        {
            listaProdutos.Add(produto);
        }
    }
}
