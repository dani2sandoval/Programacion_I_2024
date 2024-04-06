using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class calculadora2 : calculadora1
    {
        public double potencia(double Base, double exponente)
        {
            return Math.Pow(Base, exponente);
        }

        public double raiz(double numero)
        {
            return Math.Sqrt(numero);
        }

    }
}
