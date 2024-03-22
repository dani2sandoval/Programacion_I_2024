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

            String[,] totito = new string[3, 3]
            {
                {"X", "O", "O" },
                {"O", "X", "O" },
                {"O", "O", "X" }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(totito[i, j] + " ");
                }
                Console.WriteLine();
            }
           
            Console.ReadLine();
           


        }
    }
}
