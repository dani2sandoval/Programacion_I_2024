using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte2__Desafío2
{
    internal class Volumen
    {

        public int ancho { get; set; }
        public int profundidad { get; set; }

        public int altura { get; set; }

        public int operacion => ancho * profundidad * altura;

        public Volumen(int ancho, int profundidad, int altura)
        {

            this.ancho = ancho;
            this.profundidad = profundidad;
            this.altura = altura;
        }
    }
}
