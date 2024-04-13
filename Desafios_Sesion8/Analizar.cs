using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Sesion8
{
    internal class Analizar
    {
        public bool DireccionCorreo(string palabra)
        {
            if (palabra.Contains("@") && palabra.Contains("."))
            {
                string[] partes = palabra.Split('@');

                if (partes.Length == 2 && partes[1].Contains("."))
                {
                    return true;
                }
            }

            return false;


        }

        public void AnalizarCorreo(string texto)
        {
            string[] palabras = texto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string palabra in palabras)
            {
                if (DireccionCorreo(palabra))
                {
                    Console.WriteLine(palabra);
                }
            }



        }
    }

}
