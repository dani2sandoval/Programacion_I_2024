using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int x = 0;

            Console.WriteLine("Registrate");
            Console.WriteLine("Ingresa tu nombre: ");
            String nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu número de teléfono: "); 
            String numero = Console.ReadLine();
            Console.WriteLine("Ingresa tu correo: ");
            String correo = Console.ReadLine();
            Console.WriteLine("Ingresa una contraseña para tu cuenta: ");
            String contraseña = Console.ReadLine();



            do
            {

                Console.WriteLine();
                Console.WriteLine("Inicia Sesión");

                Console.WriteLine("Ingrese su correo: ");
                String correo_ingresado = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña: ");
                String contraseña_ingresada = Console.ReadLine();

                if (correo == correo_ingresado && contraseña == contraseña_ingresada)
                {
                    Console.WriteLine("Bienvenido " + nombre);
                    Console.ReadLine();
                    x = 1;
                    

                }
                else
                {
                    Console.WriteLine("Intentalo de nuevo");
                    x = 0;
                }
              


            }while(x == 0);   
    }
}

    }
