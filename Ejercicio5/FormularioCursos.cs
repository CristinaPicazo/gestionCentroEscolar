using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class FormularioCursos : Form
    {
        public ListaPersonas listaPersonas;
        ListaCursos listaCursos = new ListaCursos();
        public FormularioCursos(ListaPersonas listaPersonas)
        {
            InitializeComponent();
            this.listaPersonas = listaPersonas;
        }

        //Añadir Curso
        private void button1_Click(object sender, EventArgs e)
        {
            FormularioNuevoCurso formularioNuevoCurso = new FormularioNuevoCurso(listaCursos);
            formularioNuevoCurso.ShowDialog();
        }


        //Eliminar Curso
        private void button2_Click(object sender, EventArgs e)
        {
            listaCursos.eliminarCurso();
        }

        //Mostrar todos los cursos
        private void button3_Click(object sender, EventArgs e)
        {
            listaCursos.mostrarCursos();
        }

        //Mostrar todos los alumnos pertenecientes a un curso
        private void button4_Click(object sender, EventArgs e)
        {
            listaCursos.mostarAlumnosPorCurso(listaPersonas);
        }
    }
}
