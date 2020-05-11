using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Entidades
{
    class ProdutoUsado : ProdutoComum 
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado()
        {
        }
        public ProdutoUsado(string nome, double preco, DateTime datafabricacao)
                            : base(nome, preco)
        {
            DataFabricacao = datafabricacao;
        }
        public override string ImprimeEtiqueta()
        {
            return base.ImprimeEtiqueta() + "Data de Fabricação : " + DataFabricacao;
        }
    }
}
