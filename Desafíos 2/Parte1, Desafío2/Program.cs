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

            Console.WriteLine("Ingresa un número entero positivo");

            int x = int.Parse(Console.ReadLine());

            if (x <= 1)
            {
                Console.WriteLine("No es primo");



            }
            else if (x == 2 || x == 3)
            {
                Console.WriteLine("Es primo");

            }

            else if(x % 2 == 0 || x % 3 == 0)
            {
                Console.WriteLine("No es primo");

            }

            else
            {

                bool y = true;

                for (int i = 5; i * i <= x; i += 6)
                {
                    if (x % i == 0 || x % (i + 2) == 0)
                    {
                        y = false;
                        break;
                    }

                }

                if (y)
                {
                    Console.WriteLine("Es primo");
                }
                else
                {
                    Console.WriteLine("No es primo");
                }


            }


                Console.ReadLine();

        }
    }
}
