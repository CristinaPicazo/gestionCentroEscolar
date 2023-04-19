﻿using System;
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
        ListaAlumnos listaAlumnos;
        public FormularioNuevoAlumno(ListaPersonas listaPersonas, ListaAlumnos listaAlumnos)
        {
            InitializeComponent();
            this.listaPersonas = listaPersonas;
            this.listaAlumnos = listaAlumnos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string dni = dniTextBox.Text;
                string nombre = nombreTextBox.Text;

                Alumno alumno = new Alumno(dni, nombre);

                listaPersonas.anadirPersona(alumno);
                listaAlumnos.anadirAlumno(alumno);
                this.Close();

            }catch(FormatException)
            {
                MessageBox.Show("No puede estar ningún campo vacío ni con el formato incorrecto");
            }

        }
    }
}
