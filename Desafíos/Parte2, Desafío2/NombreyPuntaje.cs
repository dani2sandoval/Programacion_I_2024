using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte2__Desafío2
{
    internal class NombreyPuntaje
    {

        public int Puntaje { get; private set; }

        public string Nombre{  get; private set; }
        public void metodo(string nombre, int puntaje)
        {
            Puntaje = puntaje;
            Nombre = nombre;
        }
    }
}
