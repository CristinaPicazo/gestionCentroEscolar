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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListaPersonas listaPersonas = new ListaPersonas();

        //Gestión Cursos
        private void button1_Click(object sender, EventArgs e)
        {
            FormularioCursos formularioCursos = new FormularioCursos(listaPersonas);
            formularioCursos.ShowDialog();
        }

        //Gestión Alumnos
        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Gestión Profesores
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
