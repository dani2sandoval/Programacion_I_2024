using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte1__Desafío3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int sum = 0;
            int x = 0;
            
            
            
            do
            {
                Console.WriteLine("Ingrese la calificación:");
                string cal = Console.ReadLine();

                if (cal.ToLower() == "fin")
                {

                    x = 1;
                }
                else
                
                if (int.TryParse(cal, out int cal1))

                {

                    if (cal1 >= 1 && cal1 <= 10)
                    {
                        num += cal1;
                        sum++;
                    }
                    else
                    {
                        Console.WriteLine("Ingresa un numero del 1 al 10 ");
                    }
                                
                }


                

            }while (x == 0);


            if (sum == 0)
            {
                Console.WriteLine("no se ingresaron calificaciones");
            }
            else
            {
                double prom = num / sum;
                Console.WriteLine("El promedio del alumno es de: " + prom);
            }
            

            Console.ReadLine();
        }
    }
}
