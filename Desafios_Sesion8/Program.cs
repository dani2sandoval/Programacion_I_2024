using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Sesion8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "Este es mi correo: melvindan98@gmail.com. Por favor, envíeme un correo con sus comentarios.";

            Analizar analizador = new Analizar();
            analizador.AnalizarCorreo(texto);


        }
    }
}
