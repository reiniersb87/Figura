using System;

namespace Figura
{
    public abstract class Figura : IComparable
    {
        public abstract double Perimetro();
        public abstract double Area();

        public static double AreaTotal(Figura[] figuras)
        { 
            if (figuras == null)
            {
                throw new Exception("No existe array de figuras");
            }

            double result = 0;
            foreach (var figura in figuras)
            {
                result += figura.Area();
            }
            return result;
        }

        public static Figura MayorArea(Figura[] figuras)
        {
            if (figuras == null || figuras.Length == 0)
                throw new Exception("No hay figuras");
            Figura mayor = figuras[0];

            for (int i = 1; i < figuras.Length; i++)
            {
                if (mayor.CompareTo(figuras[i]) == 1)
                    mayor = figuras[i];
            }
            return mayor;
        }

        public static Figura MayorPerimetro(Figura[] figuras)
        {
            if (figuras == null || figuras.Length == 0)
                throw new Exception("No hay figuras");
            Figura mayor = figuras[0];

            for (int i = 1; i < figuras.Length; i++)
            {
                if (mayor.CompareToPerimetro(figuras[i]) == 1)
                    mayor = figuras[i];
            }
            return mayor;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                throw new Exception("Object is Null");

            Figura figura = obj as Figura;
            if (figura != null)
            {
                if (this.Area() > figura.Area())
                    return -1;
                else if (this.Area() == figura.Area())
                    return 0;
                else
                    return 1;
            }
            else
            {
                throw new Exception("Object is not a temperature");
            }
        }

        public int CompareToPerimetro(object obj)
        {
            if (obj == null)
                throw new Exception("Object is Null");

            Figura figura = obj as Figura;
            if (figura != null)
            {
                if (this.Perimetro() > figura.Perimetro())
                    return -1;
                else if (this.Perimetro() == figura.Perimetro())
                    return 0;
                else
                    return 1;
            }
            else
            {
                throw new Exception("Object is not a temperature");
            }
        }
    }

    public class Punto
    {
        protected float y;
        protected float x;

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }

        public Punto(float _x, float _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public Punto(Punto p)
        {
            this.x = p.X;
            this.Y = p.Y;
        }
    }

    public class Circulo : Figura
    {
        protected Punto centro;
        //protected float y;
        //protected float x;
        protected float radio;

        public Circulo(Punto _centro, float _radio)
        {
            //this.x = _x;
            //this.y = _y;
            //this.centro = _centro;
            this.centro = _centro;
            this.radio = _radio;
        }

        public float Radio { get => radio; set => radio = value; }
        //public float X { get => x; set => x = value; }
        //public float Y { get => y; set => y = value; }
        public Punto Centro
        {
            get => centro;
            set
            {
                centro.X = value.X;
                centro.Y = value.Y;
            }
        }

        public override double Area()
        {
            return radio * radio * 3.141592;
        }

        public override double Perimetro()
        {
            return 2 * radio * 3.141592;
        }

        //TODO: Falta por implementar
        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class Rectangulo : Figura
    {
        protected Punto referencia;
        protected float ancho;
        protected float largo;

        public Rectangulo(Punto _centro, float _ancho, float _largo)
        {
            this.largo = _largo;
            this.ancho = _ancho;
            this.referencia = _centro;
        }

        public float Ancho { get => ancho; set => ancho = value; }
        public float Largo { get => largo; set => largo = value; }
        public Punto Referencia
        {
            get => referencia;
            set
            {
                referencia.X = value.X;
                referencia.Y = value.Y;
            }
        }

        public override double Area()
        {
            return ancho * largo;
        }

        public override double Perimetro()
        {
            return 2 * ancho + 2 * largo;
        }
    }
}


