using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_Clases
{
    public class Profesor : Persona
    {
        public int cursos_impartidos;
        public int años_en_la_institucion;
        public Profesor(string nombre, string apellido, string fecha_nacimiento, int telefono, string direccion, int cursos_impartidos, int años_en_la_institucion)
        : base(nombre, apellido, fecha_nacimiento, telefono, direccion)
        {
            cursos_impartidos = cursos_impartidos;
            años_en_la_institucion = años_en_la_institucion;
        }
    }
}
