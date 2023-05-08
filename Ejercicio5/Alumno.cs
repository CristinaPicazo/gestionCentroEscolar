using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public class Alumno : Persona
    {
        public List<double> listaNotas;

        public Alumno(string dni, string nombre, string telefono, int curso): base(dni, nombre, telefono, curso)
        {
            listaNotas = new List<double>();
        }

        public override string ToString()
        {
            string texto = "\nAlumno: \n";
            texto += base.ToString();
            texto += "\nNotas: " + vernotas();
            return texto;
        }

        public bool buscarCurso(int curso)
        {
            bool tieneCurso = false;
            {
                if(curso == Curso)
                {
                    tieneCurso = true;
                }
            }
            return tieneCurso;
        }

        public string vernotas()
        {
            string texto = "";
            double totalNotas = 0;
            double notaMedia = 0;
            if(listaNotas.Count > 0)
            {
                foreach(var nota in listaNotas)
                {
                    texto += + nota+", ";
                    totalNotas += nota;
                }
                notaMedia = Math.Round(totalNotas / listaNotas.Count,2);
                texto += "\nNota media: " + notaMedia + "\n ";
            }
            return texto;
        }

        public void anadirNotas(double nota)
        {
            if(nota > 0) { 
                listaNotas.Add(nota);
            }
        }
        public void borrarNotas()
        {
            listaNotas.Clear();
        }

        public string notaMediaMayorCinco()
        {
            string texto = "";
            double totalNotas = 0;
            double notaMedia = 0;

            if(listaNotas.Count > 0)
            {
                foreach(var nota in listaNotas)
                {
                    totalNotas += nota;
                }
                notaMedia = totalNotas / listaNotas.Count;
                if(notaMedia >= 5)
                {
                    texto += "\n"+Nombre+ " nota media: " + notaMedia;
                }
            }
            return texto;
        }
        public string notaMediaMenorCinco()
        {
            string texto = "";
            double totalNotas = 0;
            double notaMedia = 0;

            if(listaNotas.Count > 0)
            {
                foreach(var nota in listaNotas)
                {
                    totalNotas += nota;
                }
                notaMedia = totalNotas / listaNotas.Count;
                if(notaMedia < 5)
                {
                    texto += "\n" + Nombre + " nota media: " + notaMedia;
                }
            }
            return texto;
        }
    }
}
