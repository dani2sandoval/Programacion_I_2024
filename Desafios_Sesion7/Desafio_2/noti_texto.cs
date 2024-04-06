using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2
{
    internal class noti_texto : inter_notificable
    {
        public string numero;

        
        public void notifica(string mensaje)
        {
            Console.WriteLine("Enviando notificación por SMS al número "+ numero + ": " +mensaje);    
        }
    }

}

