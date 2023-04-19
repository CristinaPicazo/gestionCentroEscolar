using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public class ListaProfesores
    {
        private List<Profesor> listaProfesores;
        public ListaProfesores()
        {
            listaProfesores = new List<Profesor>();
        }
        public void anadirProfesor(Profesor profesor)
        {
            listaProfesores.Add(profesor);
        }

        public void mostrarProfesores()
        {
            {
                if(listaProfesores.Count > 0)
                {
                    string texto = "Profesores:";
                    foreach(var profesor in listaProfesores)
                    {
                        texto += "\n" + profesor.Nombre;
                    }
                    MessageBox.Show(texto);
                }
                else
                {
                    MessageBox.Show("La lista esta vacía");
                }
            }
        }

        public void eliminarProfesor()
        {
            try
            {
                string dni = Interaction.InputBox("Dni del profesor a eliminar:");
                bool encontrada = false;
                if(dni != "")
                {
                    foreach(var profesor in listaProfesores)
                    {
                        if(profesor.Dni == dni)
                        {

                            listaProfesores.Remove(profesor);

                            MessageBox.Show("Profesor " + profesor.Nombre + " eliminado.");
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

        public void anadirAsignatura()
        {
            try
            {
                string dni = Interaction.InputBox("Dni del profesor:");
                bool encontrado = false;
                bool mas = false;

                if(dni != "")
                {
                    foreach(var profesor in listaProfesores)
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

        public virtual void ordenarProfesores()
        {
            listaProfesores.Sort((x, y) => string.Compare(x.Nombre, y.Nombre));
            MessageBox.Show("Lista ordenada.");
        }

        public virtual void mostrarProfesorPorNombre()
        {
            if(listaProfesores.Count > 0)
            {
                string nombre = Interaction.InputBox("Escribir el nombre del profesor a mostrar");
                bool encontrado = false;
                string texto = "";
                foreach(var profesor in listaProfesores)
                {
                    if(profesor.Nombre == nombre)
                    {
                        encontrado = true;
                        texto = profesor.ToString();
                    }
                }
                if(!encontrado)
                {
                    MessageBox.Show("Profesor no encontrado");
                }
                MessageBox.Show(texto);
            }
            else
            {
                MessageBox.Show("La lista esta vacía");
            }
        }

        public void eliminarAsignaturas()
        {
            {
                if(listaProfesores.Count > 0)
                {
                    string nombre = Interaction.InputBox("Escribir el nombre del profesor:");
                    bool encontrado = false;
                    string texto = "";
                    foreach(var profesor in listaProfesores)
                    {
                        if(profesor.Nombre == nombre)
                        {
                            encontrado = true;
                            profesor.borrarAsignaturas();
                            MessageBox.Show("Las asignaturas del profesor " + profesor.Nombre + " han sido borradas");
                        }
                    }
                    if(!encontrado)
                    {
                        MessageBox.Show("Profesor no encontrado");
                    }
                    MessageBox.Show(texto);
                }
                else
                {
                    MessageBox.Show("La lista esta vacía");
                }
            }
        }   
        
        public void profesoresUnaAsignatura()
        {
            
                if(listaProfesores.Count > 0)
                {
                    string asignatura = Interaction.InputBox("Escribir el nombre de la asignatura:");
                    bool encontrado = false;
                    string texto = "";
                    foreach(var profesor in listaProfesores)
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
        

    }
}
