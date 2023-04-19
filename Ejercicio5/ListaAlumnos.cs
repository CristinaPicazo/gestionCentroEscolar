using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public class ListaAlumnos
    {
        private List<Alumno> listaAlumnos;
        public ListaAlumnos()
        {
            listaAlumnos = new List<Alumno>();
        }
        public void anadirAlumno(Alumno alumno)
        {
            listaAlumnos.Add(alumno);
        }

        public void mostrarAlumnos()
        {
            {
                if(listaAlumnos.Count > 0)
                {
                    string texto = "Alumnos:";
                    foreach(var alumno in listaAlumnos)
                    {
                        texto+="\n" + alumno.Nombre;
                    }
                    MessageBox.Show(texto);
                }
                else
                {
                    MessageBox.Show("La lista esta vacía");
                }
            }
        }

        public void eliminarAlumno()
        {
            try
            {
                string dni = Interaction.InputBox("Dni del alumno a eliminar:");
                bool encontrada = false;
                if(dni != "")
                {
                    foreach(var alumno in listaAlumnos)
                    {
                        if(alumno.Dni == dni)
                        {

                            listaAlumnos.Remove(alumno);

                            MessageBox.Show("Alumno " + alumno.Nombre + " eliminado.");
                            encontrada = true;
                            break;
                        }
                    }
                    if(!encontrada)
                    {
                        MessageBox.Show("Persona no encontrada");
                    }
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("El código tiene que ser numérico");
            }
        }

        public void anadirNotas()
        {
            try
            {
                string dni = Interaction.InputBox("Dni del alumno:");
                bool encontrado = false;
                bool mas = false;

                if(dni != "")
                {
                    foreach(var alumno in listaAlumnos)
                    {
                        if(alumno.Dni == dni)
                        {
                            encontrado = true;
                            do
                            {
                                double nota = double.Parse(Interaction.InputBox("Introduce nota entre 0 y 10"));
                                if(nota >= 0 && nota <= 10)
                                {
                                    alumno.anadirNotas(nota);
                                    MessageBox.Show("Nota añadida");
                                }
                                else
                                {
                                    MessageBox.Show("La nota tiene que ser entre 0 y 10");
                                }
                                var resultado = MessageBox.Show("¿Añadir otra nota?", "Notas", MessageBoxButtons.YesNoCancel);

                                if(resultado == DialogResult.Yes)
                                {
                                    mas = true;
                                }
                                else
                                {
                                    mas = false;
                                }
                            }
                            while(mas);
                        }
                    }
                    if(!encontrado)
                    {
                        MessageBox.Show("Persona no encontrada");
                    }
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("El código tiene que ser numérico");
            }
        }

        public virtual void ordenarAlumnos()
        {
            listaAlumnos.Sort((x, y) => string.Compare(x.Nombre, y.Nombre));
            MessageBox.Show("Lista ordenada.");
        }

        public virtual void mostrarAlumnoPorNombre()
        {
            if(listaAlumnos.Count > 0)
            {
                string nombre = Interaction.InputBox("Escribir el nombre del alumnmo a mostrar");
                bool encontrado = false;
                string texto = "";
                foreach(var alumno in listaAlumnos)
                {
                    if(alumno.Nombre == nombre)
                    {
                        encontrado = true;
                        texto = alumno.ToString();
                    }
                }
                if(!encontrado)
                {
                    MessageBox.Show("Alumno no encontrado");
                }
                MessageBox.Show(texto);
            }
            else
            {
                MessageBox.Show("La lista esta vacía");
            }
        }

        public void eliminarNotas()
        {
            {
                if(listaAlumnos.Count > 0)
                {
                    string nombre = Interaction.InputBox("Escribir el nombre del alumnmo:");
                    bool encontrado = false;
                    string texto = "";
                    foreach(var alumno in listaAlumnos)
                    {
                        if(alumno.Nombre == nombre)
                        {
                            encontrado = true;
                            alumno.borrarNotas();
                            MessageBox.Show("Notas del alumno " + alumno.Nombre + " borradas");
                        }
                    }
                    if(!encontrado)
                    {
                        MessageBox.Show("Alumno no encontrado");
                    }
                    MessageBox.Show(texto);
                }
                else
                {
                    MessageBox.Show("La lista esta vacía");
                }
            }
        }

        public void alumnosNotaMediaMayorCinco()
        {
            string texto = "";
            if(listaAlumnos.Count > 0)
            {
                foreach(var alumno in listaAlumnos)
                {
                    texto += alumno.notaMediaMayorCinco();
                }
                MessageBox.Show(texto);
            }
            else
            {
                MessageBox.Show("La lista esta vacía");
            }
        }
        public void alumnosNotaMediaMenorCinco()
        {
            if(listaAlumnos.Count > 0)
            {
                string texto = "";
                foreach(var alumno in listaAlumnos)
                {
                    texto += alumno.notaMediaMenorCinco();
                }
                MessageBox.Show(texto);
            }
            else
            {
                MessageBox.Show("La lista esta vacía");
            }
        }



    }

}
