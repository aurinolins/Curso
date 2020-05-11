using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            var origem = @"c:\Arquivos Angioline\DOCUMENTAÇÃO";
            var diretorio = @"c:\Arquivos Angioline";
            try
            {
                
                DirectoryInfo Di = new DirectoryInfo(origem);
                DirectoryInfo Di2 = new DirectoryInfo(diretorio);
                IEnumerable<FileInfo> list = Di.EnumerateFiles();
                
                foreach (FileInfo file in list)
                {
                    Console.WriteLine(file);
                }
                Console.WriteLine("Segunda Parte do Programa :");
                var v1 = Console.ReadLine();
                IEnumerable<DirectoryInfo> listadir = Di2.GetDirectories();
                    
                foreach (DirectoryInfo dir in listadir)
                {
                    Console.WriteLine(dir);
                }
            }
            catch
            {

                Console.WriteLine("Erro ao tentar abrir diretorio :" + origem);
                Console.WriteLine("Erro ao tentar abrir diretorio :" + diretorio);
            }
            finally
            {
                Console.WriteLine("Beleza Final de Programa : ");
            }
            }
        }
    }