using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte2__Desafío2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int puntajerecord = 1000;
            string jugadorrecord = "Juan";

            NombreyPuntaje oJugador1 = new NombreyPuntaje();

            Console.WriteLine("Ingresa primero tu nombre y el puntaje que obtuviste");

            oJugador1.metodo(Console.ReadLine(), int.Parse(Console.ReadLine()));

            if (oJugador1.Puntaje > puntajerecord)
            {
                Console.WriteLine("El nuevo record es de " + oJugador1.Puntaje);
                Console.WriteLine("Nuevo record obtenido por " + oJugador1.Nombre);


            }
            else
            {
                Console.WriteLine("Puntuación más alta de " + puntajerecord + " aún no ha sido superada y sigue a manos de " + jugadorrecord);
            }
            Console.ReadLine();
        }

    }

}