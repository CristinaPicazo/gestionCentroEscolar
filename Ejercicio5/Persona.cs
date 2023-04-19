using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public abstract class Persona
    {
        private string dni;
        private string nombre;

        public string Dni { get => dni; set => dni =  value ; }
        public string Nombre { get => nombre; set => nombre =  value ; }


        public Persona()
        {
            dni = "";
            nombre = "";
        }
        public Persona(string dni, string nombre)
        {
            Dni = dni;
            Nombre = nombre;
        }

        public override string ToString()
        {
            string texto;
            texto = "\nDNI: \t\t" + dni;
            texto += "\nNombre: \t\t" + nombre;
            return texto;
        }
    }
}
