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
    public partial class FormularioNuevoCurso : Form
    {
        public ListaCursos listaCursos;

        public FormularioNuevoCurso(ListaCursos listaCursos)
        {
            InitializeComponent();
            this.listaCursos= listaCursos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            int codigo = int.Parse(codigoTextBox.Text);
            string nombre = nombreTextBox.Text;

                Curso curso = new Curso(codigo,nombre);
                listaCursos.anadirCurso(curso);
                this.Close();
            }
            catch(FormatException)
            {
                MessageBox.Show("No puede estar ningún campo vacío ni con el formato incorrecto");
            }
        }
    }
}
