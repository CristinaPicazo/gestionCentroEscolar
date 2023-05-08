using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Curso
    {
        private int codigo;
        private string nombre;

        public int Codigo { get => codigo; set => codigo =  value ; }
        public string Nombre { get => nombre; set => nombre =  value ; }

        public Curso() {
            codigo = 0;
            nombre = "";
        }

        public Curso(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;     
        }

        public string detallesCurso()
        {
            string texto = "";
            texto += "\nCurso:\t\t " + codigo;
            texto += "\n Nombre:\t\t" + nombre;

            return texto;
        }
    }
}
