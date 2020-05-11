using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Entidades
{
    class ProdutoComum
    {
        public string Nome { get; set; }
        public Double Preco { get; set; }

        public ProdutoComum()
        {
        }

        public ProdutoComum(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public virtual string ImprimeEtiqueta()
        {
            return "Nome :" + Nome + "Preço : " + Preco;
        }
    }
}
