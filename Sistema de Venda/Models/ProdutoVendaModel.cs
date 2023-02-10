using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venda.Models
{
    internal class ProdutoVendaModel
    {
        public string codigo_barras { get; set; }
        public string nome { get; set; }
        public string valor{ get; set; }
        public int quantidade { get; set; }

        public ProdutoVendaModel(string codigo_barras, string nome, string valor, int quantidade)
        {
            this.codigo_barras = codigo_barras;
            this.nome = nome;
            this.valor = valor;
            this.quantidade = quantidade;
        }
    }
}
