using ConsoleApp9.Entidades.Enum;    
namespace ConsoleApp9.Entidades
{
    abstract class Figura
    {
        public Color Color { get; set; }
      
        public Figura(Color color)
        {
            Color = color;
        }
    public abstract double Area();

    }
}
