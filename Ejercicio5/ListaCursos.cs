using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public class ListaCursos
    {
        private List<Curso> listaCursos;

        public ListaCursos()
        {
            listaCursos= new List<Curso>();
        }

        public void anadirCurso(Curso curso)
        {
            listaCursos.Add(curso);
        }

        public void eliminarCurso()
        {
            try
            {
                int codigo = int.Parse(Interaction.InputBox("Código del curso a eliminar:"));
                if(codigo > 0)
                {
                    foreach(var curso in listaCursos)
                    {
                        if(curso.Codigo == codigo)
                        {
                            listaCursos.Remove(curso);
                            MessageBox.Show("Curso " + curso.Nombre + " eliminado.");
                            break;
                        }
                    }
                }
            }catch(FormatException)
            {
                MessageBox.Show("El código tiene que ser numérico");
            }
        }

        public void mostrarCursos()
        {
            string texto = "";
            foreach(var curso in listaCursos)
            {
                texto = "Curso: ";
                texto += curso.detallesCurso();
            }
            MessageBox.Show(texto);
        }

        public void mostarAlumnosPorCurso(ListaPersonas listaPersonas)
        {
            try
            {
                string texto;
                bool encontrado = false;
                int codigo = int.Parse(Interaction.InputBox("Código del curso a mostrar:"));
                if(codigo > 0)
                {
                    foreach(var curso in listaCursos)
                    {
                        if(curso.Codigo == codigo)
                        {
                            texto = curso.detallesCurso();
                            //texto += listaPersonas.detalleAlumno();
                            //TODO buscar alumnos por curso y mostrarlos en el curso
                            encontrado= true;
                            MessageBox.Show(texto);
                        }                        
                    }
                    if(!encontrado)
                    {
                        MessageBox.Show("Curso no encontrado");
                    }
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("El código tiene que ser numérico");
            }
            
        }
    }
}
