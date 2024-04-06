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
            noti_email emailNotification = new noti_email();
            emailNotification.correo = "melvindan98@gmail.com";
            emailNotification.notifica("Este es un mensaje de prueba por correo.");

            noti_whatsapp NotificacionWhatsap = new noti_whatsapp();
            NotificacionWhatsap.telefono = "59629398";
            NotificacionWhatsap.notifica("Este es un mensaje de prueba por WhatsApp.");

            noti_texto Notificacionmensaje = new noti_texto();
            Notificacionmensaje.numero = "+59629398";
            Notificacionmensaje.notifica("Este es un mensaje de prueba por mensaje");
        }
    }
}
