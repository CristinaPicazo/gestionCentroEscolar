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
    public partial class formularioProfesores : Form
    {
        ListaPersonas listaPersonas;
        public List<Profesor> listaProfesor = new List<Profesor>();
        ListaCursos listaCursos;
        string profesor = "profesor";

        public formularioProfesores(ListaPersonas listaPersonas, ListaCursos listaCursos)
        {
            this.listaPersonas = listaPersonas;
            this.listaCursos = listaCursos;
            InitializeComponent();

        }


        //Nuevo profesor
        private void button1_Click(object sender, EventArgs e)
        {
            FormularioNuevoProfesor formularioNuevoProfesor = new FormularioNuevoProfesor(listaPersonas,listaCursos);
            formularioNuevoProfesor.ShowDialog();
        }

        //Eliminar profesor
        private void button2_Click(object sender, EventArgs e)
        {
            listaPersonas.eliminarPersona();
        }

        //Mostrar lista
        private void button3_Click(object sender, EventArgs e)
        {
            listaPersonas.mostrarProfesores();
        }

        //ordenar
        private void button4_Click(object sender, EventArgs e)
        {
            listaPersonas.ordenar(profesor);
        }

        //Mostrar datos
        private void button5_Click(object sender, EventArgs e)
        {
            listaPersonas.mostrarPersonaPorNombre(profesor);
        }

        //añadir asignaturas
        private void button6_Click(object sender, EventArgs e)
        {
            listaPersonas.anadirAsignatura();
        }

        //Eliminar asignaturas
        private void button7_Click(object sender, EventArgs e)
        {
            listaPersonas.eliminarAsignaturas();
        }

        //Mostrar profesores que imparten una asignatura
        private void button8_Click(object sender, EventArgs e)
        {
            listaPersonas.profesoresUnaAsignatura();
        }
    }
}
