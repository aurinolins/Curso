using System;
using System.Globalization;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data : ") ;
            DateTime dtinfo = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy" , CultureInfo.InvariantCulture );
           
            Console.WriteLine(dtinfo.CalculaTempo());
            
        }
    }
}
