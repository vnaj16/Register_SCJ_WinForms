using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register_SCJ_WinForms.Models
{
    public class Alumno
    {
        public Alumno(string Nombre, string Apellido, string DNI)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellido;
            this.DNI = DNI;
        }

        public Alumno()
        {
                
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }

        public override string ToString()
        {
            return Nombre + ' ' + Apellidos + " (DNI: " + DNI + ')';
        }
    }

}


