using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte1__Desafío2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operaciones oOperaciones = new Operaciones();

            Console.WriteLine(
                oOperaciones.Suma(20, 10));

            Console.WriteLine(
                oOperaciones.Resta(20, 10));

            Console.WriteLine(
                oOperaciones.Multiplicacion(20, 10));

            Console.WriteLine(
                oOperaciones.Division(20, 10));

            Console.ReadLine();

            
        }
    }
}
