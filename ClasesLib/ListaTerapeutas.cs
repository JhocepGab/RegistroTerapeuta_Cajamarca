using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    // Nodo de la lista simple de terapeutas
    public class NodoTerapeuta
    {
        public string nombre;
        public string especialidad;
        public NodoTerapeuta sig = null;
    }

    // Lista simple enlazada para registrar terapeutas
    public class ListaTerapeutas
    {
        private NodoTerapeuta primero = null;

        // Carga las 5 terapeutas predeterminadas
        public ListaTerapeutas()
        {
            AgregarPredeterminadas();
        }
        private void AgregarPredeterminadas()
        {
            Agregar("Valeria",    "Masaje Relajante");
            Agregar("Camila",     "Masaje Descontracturante");
            Agregar("Luna",       "Masaje Terapeutico");
            Agregar("Sofia",      "Masaje Deportivo");
            Agregar("Abril",      "Masaje Reductor");
        }

        public void Agregar(string nombre, string especialidad)
        {
            NodoTerapeuta nuevo = new NodoTerapeuta();
            nuevo.nombre = nombre;
            nuevo.especialidad = especialidad;

            if (primero == null)
            {
                primero = nuevo;
                return;
            }

            NodoTerapeuta aux = primero;
            while (aux.sig != null)
            {
                aux = aux.sig;
            }
            aux.sig = nuevo;
        }

        public bool Existe(string nombre)
        {
            NodoTerapeuta aux = primero;
            while (aux != null)
            {
                if (aux.nombre.ToUpper() == nombre.ToUpper())
                {
                    return true;
                }
                aux = aux.sig;
            }
            return false;
        }

        public bool Eliminar(string nombre)
        {
            if (primero == null) return false;

            if (primero.nombre.ToUpper() == nombre.ToUpper())
            {
                primero = primero.sig;
                return true;
            }

            NodoTerapeuta ant = primero;
            NodoTerapeuta act = primero.sig;
            while (act != null)
            {
                if (act.nombre.ToUpper() == nombre.ToUpper())
                {
                    ant.sig = act.sig;
                    return true;
                }
                ant = act;
                act = act.sig;
            }
            return false;
        }

        public void LlenarListBox(ListBox lb)
        {
            lb.Items.Clear();
            NodoTerapeuta aux = primero;
            while (aux != null)
            {
                lb.Items.Add(aux.nombre + "  -  " + aux.especialidad);
                aux = aux.sig;
            }
        }

        public void LlenarComboBox(ComboBox cmb)
        {
            string seleccionada = cmb.SelectedItem != null ? cmb.SelectedItem.ToString() : "";
            cmb.Items.Clear();
            NodoTerapeuta aux = primero;
            while (aux != null)
            {
                cmb.Items.Add(aux.nombre);
                aux = aux.sig;
            }
            if (seleccionada != "" && cmb.Items.Contains(seleccionada))
            {
                cmb.SelectedItem = seleccionada;
            }
        }
    }
}
