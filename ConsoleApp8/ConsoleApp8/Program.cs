using System;
using System.Collections.Generic;
namespace ConsoleApp8.Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ProdutoComum> lista = new List<ProdutoComum>();
            Console.WriteLine("Digite o Numero de Produtos : ");
            int QtdeProd = int.Parse(Console.ReadLine());
            for (int i = 0; i < QtdeProd; i++)
            { 
                Console.WriteLine("Comum, Usado ou Importado (c, u, i) ? : ");
                char Tipo = char.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Nome : ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o Preço : ");
                double preco = double.Parse(Console.ReadLine());
                switch (Tipo)
                {
                                    
                    case 'u':
                         
                          DateTime datafab = DateTime.Now;
                          lista.Add(new ProdutoUsado(nome, preco, datafab));
                          
                          break;
                    case 'i':
                         Console.WriteLine("Digite a Taxa de Importação : ");
                         double taxa = double.Parse(Console.ReadLine());
                         lista.Add(new ProdutoImportado(nome, preco, taxa));
                         break;
                    case 'c':
                         lista.Add(new ProdutoComum(nome, preco));
                          break;
                    
                }
                
            }
            foreach (ProdutoComum produto in lista)
            {
                 Console.WriteLine(produto.ImprimeEtiqueta());
            }
             
        }

    }
}

