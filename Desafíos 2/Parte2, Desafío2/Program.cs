using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte2__Desafío2
{

    internal class Program
    {




        static void Main(string[] args)
        {
            Volumen oVolumen = new Volumen(4, 5, 6);
            int volumen = oVolumen.operacion;

            Console.WriteLine("el volumen es de " + volumen);
            

            Volumen oVolumen2 = new Volumen(6, 7, 8);
            int volumen2 = oVolumen2.operacion;

            Console.WriteLine("el volumen de esta caja es " + volumen2);
            

            Volumen oVolumen3 = new Volumen(10, 10, 10);
            int volumen3 = oVolumen3.operacion;

            Console.WriteLine("el volumen de esta caja es " + volumen3);
            Console.ReadLine();


        }
    }
}

