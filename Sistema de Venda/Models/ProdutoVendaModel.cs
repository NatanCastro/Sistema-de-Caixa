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
        public string valor_unit { get; set; }
        public string valor_total { get; }
        public int qtd { get; set; }

        public ProdutoVendaModel(string codigo, string nome, string valor, int qtd)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.qtd = qtd;
            this.valor_unit = valor;
            this.valor_total = (float.Parse(valor) * qtd).ToString();
        }
    }
}
