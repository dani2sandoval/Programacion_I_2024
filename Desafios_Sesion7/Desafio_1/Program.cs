using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculadora1 oCalculadora = new calculadora1();
            oCalculadora.marca = "Casio";
            oCalculadora.serie = "246";

            oCalculadora.sumar(10, 5);
            oCalculadora.restar(10, 5);
            oCalculadora.multiplicar(10, 5);
            oCalculadora.dividir(10, 5);
            
            calculadora2 oCalculadora2 = new calculadora2();

            oCalculadora2.marca = "Yamaha";
            oCalculadora2.serie = "fix250";

            oCalculadora2.sumar(20, 5);
            oCalculadora2.potencia(10, 5);
            oCalculadora2.raiz(36);



        }
    }
}
