using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte2__Desafío1
{
    internal class Program
    {
        public class SuperficieFrontal
        {
            public int altura { get; set; }
            public int largo { get; set; }

            public int operacion => altura * largo;

            public SuperficieFrontal(int altura, int largo)
            {
                this.altura = altura;
                this.largo = largo;
            }

        }


        static void Main(string[] args)
        {
            SuperficieFrontal oSuperficieFrontal = new SuperficieFrontal(10 ,5);
            int superficie = oSuperficieFrontal.operacion;
            Console.WriteLine("la superficie es de " + superficie);
            Console.ReadLine();

        }
    }
}
