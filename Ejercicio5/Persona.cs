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
        private string telefono;
        int curso;

        public string Dni { get => dni; set => dni =  value ; }
        public string Nombre { get => nombre; set => nombre =  value ; }
        public string Telefono { get => telefono; set => telefono =  value ; }
        public int Curso { get => curso; set => curso =  value ; }

        public Persona()
        {
            dni = "";
            nombre = "";
            telefono = "";
            curso = 0;
        }
        public Persona(string dni, string nombre, string telefono, int curso)
        {
            Dni = dni;
            Nombre = nombre;
            Telefono = telefono;
            Curso = curso;
        }

        public override string ToString()
        {
            string texto;
            texto = "\nDNI: \t\t" + dni;
            texto += "\nNombre: \t\t" + nombre;
            texto += "\nTeléfono: \t" + telefono;
            texto += "\nCurso: \t\t" + curso;
            return texto;
        }
    }
}
