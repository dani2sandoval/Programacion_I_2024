using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte1__Desafío1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero positivo");
            

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 == 0){
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }

            }

            Console.ReadLine();
        }
    }
}
