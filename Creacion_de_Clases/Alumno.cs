using Creacion_de_Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_Clases
{
    public class Alumno : Persona
    {
        public int ciclo { get; set; }
        public int cursos_asignados { get; set; }

        public Alumno(string nombre, string apellido, string fecha_nacimiento, int telefono, string direccion, int ciclo, int cursos_asignados)
            : base(nombre, apellido, fecha_nacimiento, telefono, direccion)
        {
            ciclo = ciclo;
            cursos_asignados = cursos_asignados;
        }
    }

}
