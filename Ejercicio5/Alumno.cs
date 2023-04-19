using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Alumno : Persona
    {
        private int curso;
        public List<double> listaNotas;

        public int Curso { get => curso; set => curso =  value ; }

        public Alumno(string dni, string nombre): base(dni, nombre)
        {
            int curso = 0;
            listaNotas = new List<double>();
        }

        public override string ToString()
        {
            string texto = "Alumno: \n";
            texto += base.ToString();
            texto += "\nCurso: \t\t" + curso;
            texto += "\nNotas: " + vernotas();
            return texto;
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
                    texto += "\n\t" + nota;
                    totalNotas += nota;
                }
                notaMedia = totalNotas / listaNotas.Count;
                texto += "\nNota media: " + notaMedia;
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
