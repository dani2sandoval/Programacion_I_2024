using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2
{
    internal class noti_email : inter_notificable
    {
        public string correo;

        public void notifica(string mensaje)
        {
            Console.WriteLine("enviando el siguiente mensaje al correo a " + correo + ": " + mensaje);


            
        }

    }
}
