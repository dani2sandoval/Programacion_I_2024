using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] miArray = new int[5, 5]
            {
                {9, 3, 5, 500, 425},
                {14, 25, 12, 700, 267},
                {47, 81, 24, 145, 220},
                {27, 10, 15, 500, 425},
                {20, 123, 30, 234, 456},
            };

            arreglo(miArray);
            
           
        }

        static void arreglo(int[,] miArray)
        {
            int suma1 = 0;
            int suma2 = 0;
            int suma3 = 0;
            int suma4 = 0;
            int suma5 = 0;

            //recorre los elementos de la columna y cuando finaliza una columna suma i, y se continua a la siguiente fila
            for (int i = 0; i < 5; i++)
            {
                suma1 += miArray[i, 0];
                suma2 += miArray[i, 1];
                suma3 += miArray[i, 2];
                suma4 += miArray[i, 3];
                suma5 += miArray[i, 4];

            }

            if (suma1 < 100)
            {
                Console.WriteLine("El total de compras es de: " +  suma1 + " por lo tanto no tendra descuento");
                
            }
            else if(suma1 >= 100 && suma1 <= 1000)
            {
                Console.WriteLine("El total de compras es de " + suma1 + " obtendrá un 10% de descuento");

            }
            else if(suma1 > 1000)
            {
                Console.WriteLine("El total de compras es de " + suma1 + " obtendrá un 20% de descuento");
            }


            if (suma2 < 100)
            {
                Console.WriteLine("El total de compras es de: " + suma2 + " por lo tanto no tendra descuento");

            }
            else if (suma2 >= 100 && suma2 <= 1000)
            {
                Console.WriteLine("El total de compras es de " + suma2 + " obtendrá un 10% de descuento");

            }
            else if(suma2 > 1000)
            {
                Console.WriteLine("El total de compras es de " + suma2 + " obtendrá un 20% de descuento");
            }

            if (suma3 < 100)
            {
                Console.WriteLine("El total de compras es de: " + suma3 + " por lo tanto no tendra descuento");

            }
            else if (suma3 >= 100 && suma3 <= 1000)
            {
                Console.WriteLine("El total de compras es de " + suma3 + " obtendrá un 10% de descuento");

            }
            else if(suma3 > 1000)
            {
                Console.WriteLine("El total de compras es de " + suma3 + " obtendrá un 20% de descuento");
            }


            if (suma4 < 100)
            {
                Console.WriteLine("El total de compras es de: " + suma4 + " por lo tanto no tendra descuento");

            }
            else if (suma4 >= 100 && suma4 <= 1000)
            {
                Console.WriteLine("El total de compras es de " + suma4 + " obtendrá un 10% de descuento");

            }
            else if(suma4 > 1000)
            {
                Console.WriteLine("El total de compras es de " + suma4 + " obtendrá un 20% de descuento");
            }

            if(suma5 < 100)
            {
                Console.WriteLine("El total de compras es de: " + suma5 + " por lo tanto no tendra descuento");
            }

            else if(suma5 >= 100 &&suma5 <= 1000){
                Console.WriteLine("El total de compras es de " + suma5 + " obtendrá un 10% de descuento");
            }
            else if(suma5 > 1000)
            {
                Console.WriteLine("el total de compras es de " + suma5 + " obtendrá un 20% de descuento");
            }
           
            Console.ReadLine();

        }
    
    
    
    
    
    
    }







    }

