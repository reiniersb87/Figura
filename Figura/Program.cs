using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto p1 = new Punto(2,4);
            Punto p2 = new Punto(3,6);
            Circulo c1 = new Circulo(p1, 6);
            Rectangulo r1 = new Rectangulo(p2, 3, 7);
            Figura[] figuras = new Figura[]{c1, r1};

            Console.WriteLine("El area total es {0}", Figura.AreaTotal(figuras));
            Console.WriteLine("El area de la primera figura es {0}", figuras[0].Area().ToString(".###"));

            Console.WriteLine("El centro del circulo es ({0},{1})", c1.Centro.X, c1.Centro.Y);
            p1.X = 9; 
            p1.Y = 10;
            Console.WriteLine("El valor del punto P1 es ({0},{1})", p1.X, p1.Y);
            Console.WriteLine("El centro del circulo es ({0},{1})", c1.Centro.X, c1.Centro.Y);
            Console.WriteLine("El punto de referencia del rectangulo es ({0},{1})", r1.Referencia.X, r1.Referencia.Y);
            
            Console.WriteLine("c1.CompareTo(r1) {0}", c1.CompareTo(r1));
        }
    }
}
