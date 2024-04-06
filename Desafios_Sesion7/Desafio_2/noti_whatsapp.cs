using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2
{
    internal class noti_whatsapp : inter_notificable
    {
        public string telefono;

        public void notifica(string mensaje)
        {
            Console.WriteLine("Enviando notificación por whatsapp al numero " + telefono + ": " + mensaje);

        }

    }
}
