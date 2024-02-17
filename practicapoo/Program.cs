using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace práctica_poo
{
    public class Figurita
    {
        public virtual void Dibujar()
        {
            Console.WriteLine("Dibujando una figura");
        }
    }

    public class Triangulo : Figurita
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibujando un triangulo");
        }
    }

    public class Circulo : Figurita
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibujando un círculo");
        }
    }

    class Programa
    {
        static void Main()
        {
            Triangulo miTriangulo = new Triangulo();
            Circulo miCirculo = new Circulo();

            Console.WriteLine("Figurita genérica:");
            DibujarFigura(new Figurita());

            Console.WriteLine("\nCuadrado:");
            DibujarFigura(miTriangulo);

            Console.WriteLine("\nCírculo:");
            DibujarFigura(miTriangulo);
        }

        static void DibujarFigura(Figurita figura)
        {
            figura.Dibujar();
        }
    }

}