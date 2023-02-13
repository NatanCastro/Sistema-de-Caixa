using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venda.Models
{
    internal class ProdutoVendaModel
    {
        public string codigo { get; set; }
        public string nome { get; set; }
        public float valorUnit { get; set; }
        public float valorTotal { get; set; }
        public int qtd { get; set; }

        public ProdutoVendaModel(string codigo, string nome, float valor, int qtd)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.qtd = qtd;
            valorUnit = valor;
            valorTotal = valor * qtd;
        }
        public void atualizaValor()
        {
            valorTotal = valorUnit * qtd;
        }
    }
}
