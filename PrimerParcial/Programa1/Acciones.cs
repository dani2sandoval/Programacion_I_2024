using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    internal class Acciones
    {
       
        public int saldo { get; set; }
        public int cantidadadepositar { get; set; }

        public int cantidadaretirar { get; set; }

        public string opcion {  get; set; }

       public void buclemenu()
       {

            saldo = 1500;
            int x = 1;
             
            do
            {
                Console.WriteLine("Bienvenido a tu banca virtual");
                Console.WriteLine("a. Ver saldo actual");
                Console.WriteLine("b. Depositar en la cuenta");
                Console.WriteLine("c. Retirar dinero de la cuenta");
                Console.WriteLine("d. Salir del programa");
                opcion = Console.ReadLine();



                switch (opcion)
                {
                    case "a":
                        Console.WriteLine("Su saldo es de " + saldo);
                        break;
                    
                    case "b":
                        Console.WriteLine("Cuanto desea depositar: ");
                        cantidadadepositar = int.Parse(Console.ReadLine());
                        saldo = cantidadadepositar + saldo;
                        Console.WriteLine("deposito realizado");
                        break;

                    case "c":
                        Console.WriteLine("Cuanto desea retirar: ");
                        cantidadaretirar = int.Parse(Console.ReadLine());
                        saldo = saldo - cantidadaretirar;
                        Console.WriteLine("retiro realizado");
                        break;

                    case "d":
                        x = 0;
                        break;

                    default:
                        Console.WriteLine("ingrese una opcion correcta");
                        break ;
                        
                }
                
            } while (x == 1);

            
       }


    }
}
