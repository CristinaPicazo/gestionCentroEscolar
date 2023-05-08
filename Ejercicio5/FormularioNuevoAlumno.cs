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
    public partial class FormularioNuevoAlumno : Form
    {
        ListaPersonas listaPersonas;
        ListaCursos listaCursos;

        public FormularioNuevoAlumno(ListaPersonas listaPersonas, ListaCursos listaCursos)
        {
            this.listaPersonas = listaPersonas;
            this.listaCursos = listaCursos;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string dni = dniTextBox.Text;
                string nombre = nombreTextBox.Text;
                string telefono = telefonoTextBox.Text;
                int curso = int.Parse(cursoTextBox.Text);

                if(listaCursos.existeCurso(curso) && !listaPersonas.existeDNI(dni))
                {
                    Alumno alumno = new Alumno(dni, nombre, telefono, curso);
                    listaPersonas.anadirPersona(alumno);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tiene que existir el curso y el dni tiene que ser único");
                }

            }catch(FormatException)
            {
                MessageBox.Show("No puede estar ningún campo vacío ni con el formato incorrecto");
            }

        }

        private void cursoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
