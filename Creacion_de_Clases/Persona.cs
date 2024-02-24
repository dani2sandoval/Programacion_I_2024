using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_Clases
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public string fecha_nacimiento;
        public int telefono;
        public string direccion;

        public Persona(string nombre, string apellido, string fecha_nacimiento, int telefono, string direccion)
        {
            
            
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha_nacimiento = fecha_nacimiento;
            this.telefono = telefono;
            this.direccion = direccion;
        }
    }
}
