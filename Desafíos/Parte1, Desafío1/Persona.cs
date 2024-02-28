using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte1__Desafío1
{
    internal class Persona
    {
        public void Promedio()
        {
            Console.WriteLine("Ingresa tu nombre:");
            String nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el ingreso del primer mes");
            double ingreso1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el ingreso del segundo mes");
            double ingreso2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el ingreso del segundo mes");
            double ingreso3 = double.Parse(Console.ReadLine());
            double total = ingreso1 + ingreso2 + ingreso3;
            double promedio = total / 3;



            Console.WriteLine();

            Console.WriteLine("Hola " + nombre + " usted sumó " + total + " y promedió " + promedio + " quetzales en estos ultimos 3 meses");

            Console.ReadLine();
        }

    }
}
