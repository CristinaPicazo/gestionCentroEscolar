using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Profesor : Persona
    {
        public List<string> listaAsignaturas;

        public Profesor(string dni, string nombre) : base(dni, nombre)
        {
            listaAsignaturas = new List<string>();
        }

        public override string ToString()
        {
            string texto = "Alumno: \n";
            texto += base.ToString();
            texto += "\nAsignaturas: " + verAsignaturas();
            return texto;
        }

        public string verAsignaturas()
        {
            string texto = "";
            if(listaAsignaturas.Count > 0)
            {
                foreach(var asignatura in listaAsignaturas)
                {
                    texto += "\n\t" + asignatura;
                }
            }
            return texto;
        }

        public void anadirAsignatura(string asignatura)
        {
            if(asignatura != "")
            {
                listaAsignaturas.Add(asignatura);
            }
        }
        public void borrarAsignaturas()
        {
            listaAsignaturas.Clear();
        }

        public bool imparteAsignatura(string asignaturaABuscar)
        {
            bool imparteEstaAsignatura = false;
            foreach(var asignatura in listaAsignaturas)
            {
                if(asignatura == asignaturaABuscar)
                {
                    imparteEstaAsignatura = true;
                }
            }            
            return imparteEstaAsignatura;
        }

       
    }

}
