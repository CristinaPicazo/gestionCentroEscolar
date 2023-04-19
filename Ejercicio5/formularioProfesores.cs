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
        ListaProfesores listaProfesores = new ListaProfesores();
        public formularioProfesores(ListaPersonas listaPersonas)
        {
            InitializeComponent();
            this.listaPersonas = listaPersonas;
        }

        //Nuevo profesor
        private void button1_Click(object sender, EventArgs e)
        {
            FormularioNuevoProfesor formularioNuevoProfesor = new FormularioNuevoProfesor(listaPersonas, listaProfesores);
            formularioNuevoProfesor.ShowDialog();
        }

        //Eliminar profesor
        private void button2_Click(object sender, EventArgs e)
        {
            listaProfesores.eliminarProfesor();
        }

        //Mostrar lista
        private void button3_Click(object sender, EventArgs e)
        {
            listaProfesores.mostrarProfesores();
        }

        //ordenar
        private void button4_Click(object sender, EventArgs e)
        {
            listaProfesores.ordenarProfesores();
        }

        //Mostrar datos
        private void button5_Click(object sender, EventArgs e)
        {
            listaProfesores.mostrarProfesorPorNombre();
        }

        //añadir asignaturas
        private void button6_Click(object sender, EventArgs e)
        {
            listaProfesores.anadirAsignatura();
        }

        //Eliminar asignaturas
        private void button7_Click(object sender, EventArgs e)
        {
            listaProfesores.eliminarAsignaturas();
        }

        //Mostrar profesores que imparten una asignatura
        private void button8_Click(object sender, EventArgs e)
        {
            listaProfesores.profesoresUnaAsignatura();
        }
    }
}
