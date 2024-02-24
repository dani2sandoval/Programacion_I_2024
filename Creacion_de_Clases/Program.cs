using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_Clases

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona oPersona = new Persona("Melvin", "Sandoval", "14 de diciembre del 2005", 59629398, "Av El Cementerio");
            Alumno oAlumno = new Alumno("Kevin", "Gutiérrez", "12 de abril del 2000", 987654321, "Bo. Chipilapa", 2, 5);
            Profesor oProfesor = new Profesor("Marco", "Tulio", "29 de febrero de 1986", 092344565, "Bo. San Francisco", 2, 4);
        }
    }
}
