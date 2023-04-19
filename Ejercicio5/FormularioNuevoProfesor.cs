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
    public partial class FormularioNuevoProfesor : Form
    {
        ListaPersonas listaPersonas;
        ListaProfesores listaProfesores;
        public FormularioNuevoProfesor(ListaPersonas listaPersonas, ListaProfesores listaProfesores)
        {
            InitializeComponent();
            this.listaPersonas = listaPersonas;
            this.listaProfesores = listaProfesores;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string dni = dniTextBox.Text;
                string nombre = nombreTextBox.Text;

                Profesor profesor = new Profesor(dni, nombre);

                listaPersonas.anadirPersona(profesor);
                listaProfesores.anadirProfesor(profesor);
                this.Close();

            }
            catch(FormatException)
            {
                MessageBox.Show("No puede estar ningún campo vacío ni con el formato incorrecto");
            }
        }
    }
}
