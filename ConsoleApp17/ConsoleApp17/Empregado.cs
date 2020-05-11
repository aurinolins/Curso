using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp17
{
    class Empregado : IComparable
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Empregado(string emp)
        {

            Console.WriteLine("Vou tratar o funcionario : " + emp);
            string[] vect = emp.Split(',');
            this.Nome = vect[0];
            this.Salario = double.Parse(vect[1], CultureInfo.InvariantCulture) ;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        int IComparable.CompareTo(object obj)
        {
            if ( ! (obj is Empregado))
            {
                throw new NotImplementedException("Comparing erro : ");
            }

            Empregado outro = obj as Empregado;

            return this.Salario.CompareTo(outro.Salario);
            
        }
    }
}
