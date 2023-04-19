using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public class ListaPersonas
    {

        private List<Persona> listaPersonas;

        public ListaPersonas()
        {
            listaPersonas = new List<Persona>();
        }     

        public virtual void anadirPersona(Persona persona)
        {
            listaPersonas.Add(persona);
        }

        public virtual void mostrarPersonas()//TODO sale a 0
        {
            if(this.listaPersonas.Count > 0)
            {
                foreach(var persona in this.listaPersonas)
                {
                    MessageBox.Show(persona.ToString());
                }
            }
            else
            {
                MessageBox.Show("La lista esta vacía");
            }
        }

        public virtual void eliminarPersona(ListaPersonas listaPersonas)
        {
            try
            {
                string dni = Interaction.InputBox("Dni de persona a eliminar:");
                bool encontrada = false;
                if(dni != "")
                {
                    foreach(var persona in this.listaPersonas)
                    {
                        if(persona.Dni == dni)
                        {
                                this.listaPersonas.Remove(persona);
                                
                                MessageBox.Show("Alumno " + persona.Nombre + " eliminado.");
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

        public virtual void ordenarPersonas()
        {            
            listaPersonas.Sort((x, y) => string.Compare(x.Nombre, y.Nombre));
            MessageBox.Show("Lista ordenada.");
        }

        public virtual void mostrarPersonaPorNombre()
        {
            if(listaPersonas.Count > 0)
            {
                string nombre = Interaction.InputBox("Escribir el nombre de la persona a mostrar");
                bool encontrada = false;
                string texto = "";
                foreach(var persona in listaPersonas)
                {
                    if(persona.Nombre == nombre)
                    {
                        encontrada = true;
                        texto = persona.ToString();
                    }
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
