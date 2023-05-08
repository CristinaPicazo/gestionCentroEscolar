using Microsoft.VisualBasic;
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
    public partial class FormularioAlumnos : Form
    {

        public ListaPersonas listaPersonas;
        public List<Alumno> listaAlumno = new List<Alumno>();
        ListaCursos listaCursos;
        string alumno = "alumno";

        public FormularioAlumnos(ListaPersonas listaPersonas, ListaCursos listaCursos)
        {
            this.listaPersonas = listaPersonas;
            this.listaCursos = listaCursos;
            InitializeComponent();
        }

        //Introducir Alumno
        private void button1_Click(object sender, EventArgs e)
        {
            FormularioNuevoAlumno formularioNuevoAlumno = new FormularioNuevoAlumno(listaPersonas, listaCursos);
            formularioNuevoAlumno.ShowDialog();
        }

        //Eliminar Alumno
        private void button2_Click(object sender, EventArgs e)
        {
            listaPersonas.eliminarPersona();
        }

        //Mostrar Lista Alumnos
        private void button3_Click(object sender, EventArgs e)
        {
            listaPersonas.mostrarAlumnos();
        }

        //Ordenar

        private void button5_Click(object sender, EventArgs e)
        {
            listaPersonas.ordenar(alumno);
        }

        //Mostrar por nombre
        private void button4_Click(object sender, EventArgs e)
        {
            listaPersonas.mostrarPersonaPorNombre(alumno);
        }
        //Alumnos de un curso
        private void button6_Click(object sender, EventArgs e)
        {
            listaPersonas.mostrarPersonaPorCurso();
        }

        //añadir notas
        private void button7_Click(object sender, EventArgs e)
        {
            listaPersonas.anadirNotas();
        }

        private void formularioAlumnos_Load(object sender, EventArgs e)
        {

        }

        //eliminar notas
        private void button9_Click(object sender, EventArgs e)
        {
            listaPersonas.eliminarNotas();
        }

        //Nota media mayor 5
        private void button8_Click(object sender, EventArgs e)
        {
            listaPersonas.alumnosNotaMediaMayorCinco();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listaPersonas.alumnosNotaMediaMenorCinco();

        }
    }
}
