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
        public FormularioCursos(ListaPersonas listaPersonas)
        {
            InitializeComponent();
            this.listaPersonas = listaPersonas;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
