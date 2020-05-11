using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Entidades
{
    class ProdutoImportado : ProdutoComum
    {
        public double Taxa { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double taxa) 
               : base(nome, preco)
        {
            Taxa = taxa;
        }


        public override string ImprimeEtiqueta()
        {
            return base.ImprimeEtiqueta() + "Taxa : " + Taxa;
        }
    }
}
