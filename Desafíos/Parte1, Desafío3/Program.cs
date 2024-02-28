using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Parte1__Desafío3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                
            try
            {
                //aqui se coloca el codigo que puede fallar
                //en este caso fallara porque las intrucciones indican ingresar caracteres en lugar de numeros, ya que no se pueden almacenar letras en un float
                Suma oSuma = new Suma();
                Console.WriteLine("Ingrese el primer numero: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero: ");
                int n2 = int.Parse(Console.ReadLine());
                Console.ReadLine();
            }

            //el excpetion sirve para aclarar la excepcion, en caso de recibir los parametros correctos
            catch (Exception ex)
            {
                //aqui se ejecutan acciones cuando el codigo falla
                Console.Error.WriteLine("Algo salio mal, intenta de nuevo");
                Console.Error.WriteLine(ex.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("finally ejecutado" );
                Console.ReadLine();
            }
        }
    }
}
