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
    public partial class formularioAlumnos : Form
    {
        ListaPersonas listaPersonas;        
        ListaAlumnos listaAlumnos = new ListaAlumnos();
        public formularioAlumnos(ListaPersonas listaPersonas)
        {
            InitializeComponent();
            this.listaPersonas = listaPersonas;
        }

        //Introducir Alumno
        private void button1_Click(object sender, EventArgs e)
        {
            FormularioNuevoAlumno formularioNuevoAlumno = new FormularioNuevoAlumno(listaPersonas, listaAlumnos);
            formularioNuevoAlumno.ShowDialog();
        }

        //Eliminar Alumno
        private void button2_Click(object sender, EventArgs e)
        {
            listaAlumnos.eliminarAlumno();
        }

        //Mostrar Lista Alumnos
        private void button3_Click(object sender, EventArgs e)
        {
            listaAlumnos.mostrarAlumnos();
        }

        //Ordenar

        private void button5_Click(object sender, EventArgs e)
        {
            listaAlumnos.ordenarAlumnos();
        }

        //Mostrar por nombre
        private void button4_Click(object sender, EventArgs e)
        {
            listaAlumnos.mostrarAlumnoPorNombre();
        }
        //Alumnos de un curso
        private void button6_Click(object sender, EventArgs e)
        {
            //TODO buscar curso en comun y mostrar alumnos
        }

        //añadir notas
        private void button7_Click(object sender, EventArgs e)
        {
            listaAlumnos.anadirNotas();
        }

        private void formularioAlumnos_Load(object sender, EventArgs e)
        {

        }

        //eliminar notas
        private void button9_Click(object sender, EventArgs e)
        {
            listaAlumnos.eliminarNotas();
        }

        //Nota media mayor 5
        private void button8_Click(object sender, EventArgs e)
        {
            listaAlumnos.alumnosNotaMediaMayorCinco();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listaAlumnos.alumnosNotaMediaMenorCinco();

        }
    }
}
