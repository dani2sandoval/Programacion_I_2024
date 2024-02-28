using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Parte1__Desafío2
{
    public class Operaciones
    {
        public int Suma(int n1, int n2)
        {
            return n1 + n2;
        }
        public int Resta(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Multiplicacion(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Division(int n1, int n2)
        {
            return n1 / n2;
        }


    }
}
