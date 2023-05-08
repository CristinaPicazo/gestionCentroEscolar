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
        public List<Curso> listaCursos;

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
                    foreach(Curso curso in listaCursos)
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
            foreach(Curso curso in listaCursos)
            {
                texto += curso.detallesCurso();
            }
            MessageBox.Show(texto);
        }

        public void mostarAlumnosPorCurso(ListaPersonas listaPersonas)
        {
            listaPersonas.mostrarPersonaPorCurso();           
            
        }

        public bool existeCurso(int cursoABuscar)
        {
            foreach(Curso curso in listaCursos)
            {
                    if(curso.Codigo == cursoABuscar) return true;
            }
                return false;
        }        
    }
}
