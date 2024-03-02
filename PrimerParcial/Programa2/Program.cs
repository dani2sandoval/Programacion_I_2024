using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Programa2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int x = 1;
            int sum;
            int prom = 0;
            do
            {
                Console.Write("Ingrese un número: ");
                sum = int.Parse(Console.ReadLine());

                if (sum != 0)
                {
                    num  += sum;
                    prom++;
                }
                else
                {
                    x = 0;
                }

            } while (x == 1);

            Console.WriteLine("la suma de todos los numeros es: " + num);
            Console.WriteLine("El promedio es de: " + num/prom);
            Console.ReadLine();




            


        }
    }
}
