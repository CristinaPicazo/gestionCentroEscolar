using Ejercicio5;
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
    public class ListaPersonas
    {

        private List<Persona> listaPersonas;
        private List<Alumno> listaAlumno;
        private List<Profesor> listaProfesor;


        public ListaPersonas()
        {
            listaPersonas = new List<Persona>();
            listaAlumno = new List<Alumno>();
            listaProfesor = new List<Profesor>();
        }

        public void anadirPersona(Persona persona)
        {
            listaPersonas.Add(persona);            
            if(persona.GetType() == typeof(Alumno))
            {
                listaAlumno.Add((Alumno)persona);
            }
            else
            {
                listaProfesor.Add((Profesor)persona);
            }
        }

        public void eliminarPersona()
        {
            string texto = "";
            try
            {
                if(listaPersonas.Count > 0)
                {
                    string dni = Interaction.InputBox("Dni de persona a eliminar:");
                    bool encontrada = false;
                    foreach(Persona personas in listaPersonas)
                    {
                        if(personas.Dni == dni)
                        {
                            listaPersonas.Remove(personas);
                            if(personas.GetType() == typeof(Alumno))
                            {
                                listaAlumno.Remove((Alumno)personas);
                                texto = personas.Nombre + " ha sido eliminado/a.";
                                encontrada = true;
                                break;
                            }
                            else
                            {
                                listaProfesor.Remove((Profesor)personas);
                                texto = personas.Nombre + " ha sido eliminado/a.";
                                encontrada = true;
                                break;
                            }
                        }
                    }
                if(!encontrada)
                {
                        texto = "Persona no encontrada";
                }
                }
            }
            catch(FormatException)
            {
                texto = "El código tiene que ser numérico";
            }
            catch(Exception ex)
            {
                texto = "Error " + ex;
            }
            MessageBox.Show(texto);                       
        }
        
        public void mostrarAlumnos()
        {
            string texto = "";

            if(listaAlumno.Count > 0)

            {
                foreach(Alumno alumno in listaAlumno)
                    texto += alumno.ToString();
            }

            else
            {
                texto = "La lista esta vacía";
            }
            MessageBox.Show(texto);
        }
        public void mostrarProfesores()
        {
            string texto = "";

            if(listaProfesor.Count > 0)

            {
                foreach(Profesor profesor in listaProfesor)
                    texto += profesor.ToString();
            }

            else
            {
                texto = "La lista esta vacía";
            }
            MessageBox.Show(texto);
        }

        public void ordenar(string persona)
        {
            if(persona == "alumno")
            {
                listaAlumno.Sort((x, y) => string.Compare(x.Nombre, y.Nombre));
            }
            else
            {
                listaProfesor.Sort((x, y) => string.Compare(x.Nombre, y.Nombre));
            }
            MessageBox.Show("Lista ordenada.");
        }

        //lo tenía separado pero creo que con ordenar() no queda mal
        public void ordenarAlumnos()
        {
            listaAlumno.Sort((x, y) => string.Compare(x.Nombre, y.Nombre));
            MessageBox.Show("Lista ordenada.");
        }
        public void ordenarProfesores()
        {
            listaProfesor.Sort((x, y) => string.Compare(x.Nombre, y.Nombre));
            MessageBox.Show("Lista ordenada.");
        }

        public void mostrarPersonaPorNombre(string persona)
        {
            string texto = "";
            string nombre = Interaction.InputBox("Escribir el nombre de la persona a mostrar");
            bool encontrado = false;
            if(persona == "alumno")
            {
                foreach(var alumno in listaAlumno)
                {
                    if(alumno.Nombre == nombre)
                    {
                        encontrado = true;
                        texto = alumno.ToString();
                    }
                }
                if(!encontrado)
                {
                    texto = "Alumno no encontrado";
                }
            }
            else
            {
                foreach(var profesor in listaProfesor)
                {
                    if(profesor.Nombre == nombre)
                    {
                        encontrado = true;
                        texto = profesor.ToString();
                    }
                }
                if(!encontrado)
                {
                    texto = "Profesor no encontrado";
                }
            }

            MessageBox.Show(texto);
        }

        public void mostrarPersonaPorCurso()
        {
            try
            {
                int curso = int.Parse(Interaction.InputBox("Introducir Curso:"));
                string texto = "";
                bool encontrada = false;
                if(listaAlumno.Count > 0)
                {
                       texto += "\nCurso: " + curso;                    
                       texto += "\nAlumnos: ";
                    foreach(Alumno alumno in listaAlumno)
                    {
                        if(alumno.buscarCurso(curso))
                        {
                            texto += "\n\t" + alumno.Nombre;
                            encontrada = true;
                        }

                    }
                    if(!encontrada)
                    {
                        texto = "Curso no encontrado";
                    }
                    MessageBox.Show(texto);
                }
                else
                {
                    MessageBox.Show("La lista esta vacía");
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

                foreach(Alumno alumno in listaAlumno)
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
            catch(FormatException)
            {
                MessageBox.Show("El código tiene que ser numérico");
            }
        }

        

        public void eliminarNotas()
        {            
                if(listaAlumno.Count > 0)
                {
                    string nombre = Interaction.InputBox("Escribir el nombre del alumnmo:");
                    bool encontrado = false;
                    foreach(Alumno alumno in listaAlumno)
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
                }
                else
                {
                    MessageBox.Show("La lista esta vacía");
                }            
        }

        public void alumnosNotaMediaMayorCinco()
        {
            string texto = "";
            if(listaAlumno.Count > 0)
            {
                foreach(Alumno alumno in listaAlumno)
                {
                    texto += alumno.notaMediaMayorCinco();
                }
            }
            else
            {
                texto = "La lista esta vacía";
            }
            MessageBox.Show(texto);
        }
        public void alumnosNotaMediaMenorCinco()
        {
            string texto = "";
            if(listaAlumno.Count > 0)
            {
                foreach(Alumno alumno in listaAlumno)
                {
                    texto += alumno.notaMediaMenorCinco();
                }
            }
            else
            {
                texto = "La lista esta vacía";
            }
                MessageBox.Show(texto);
        }

        public void anadirAsignatura()
        {
            try
            {
                string dni = Interaction.InputBox("Dni del profesor:");
                bool encontrado = false;
                bool mas = false;

                if(dni != "")
                {
                    foreach(Profesor profesor in listaProfesor)
                    {
                        if(profesor.Dni == dni)
                        {
                            encontrado = true;
                            do
                            {
                                string asignatura = Interaction.InputBox("Introduce la asignatura:");
                                if(asignatura != "")
                                {
                                    profesor.anadirAsignatura(asignatura);
                                    MessageBox.Show("Asignatura añadida");
                                }
                                var resultado = MessageBox.Show("¿Añadir otra asignatura?", "Asignatura", MessageBoxButtons.YesNoCancel);

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

        public void eliminarAsignaturas()
        {
           string texto = "";

            if(listaProfesor.Count > 0)
                {
                    string nombre = Interaction.InputBox("Escribir el nombre del profesor:");
                    bool encontrado = false;
                    foreach(Profesor profesor in listaProfesor)
                    {
                        if(profesor.Nombre == nombre)
                        {
                            encontrado = true;
                            profesor.borrarAsignaturas();
                            texto="Las asignaturas del profesor " + profesor.Nombre + " han sido borradas";
                        }
                    }
                    if(!encontrado)
                    {
                        texto="Profesor no encontrado";
                    }
                }
                else
                {
                    texto ="La lista esta vacía";
                }
                MessageBox.Show(texto);
            
        }

        public void profesoresUnaAsignatura()
        {

            if(listaProfesor.Count > 0)
            {
                string asignatura = Interaction.InputBox("Escribir el nombre de la asignatura:");
                bool encontrado = false;
                string texto = "";
                foreach(Profesor profesor in listaProfesor)
                {
                    if(profesor.imparteAsignatura(asignatura))
                    {
                        texto += "\n" + profesor.Nombre;
                        encontrado = true;
                    }
                }
                if(!encontrado)
                {
                    MessageBox.Show("Asignatura no encontrada");
                }
                MessageBox.Show(texto);
            }
            else
            {
                MessageBox.Show("La lista esta vacía");
            }
        }

        public bool existeDNI(string dni)
        {
            foreach(Persona persona in listaPersonas)
            {
                if(persona.Dni == dni) return true;
            }
            return false;
        }
    }
}

