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
            int codigo = int.Parse(Interaction.InputBox("Código del curso a eliminar:"));
            if (codigo > 0)
            {
                //TODO buscar curso
                //TODO Eliminarlo desde Curso y quitarlo de la lista
            }

        }
    }
}
