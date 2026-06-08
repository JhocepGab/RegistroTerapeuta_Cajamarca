using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public class NodoCita
    {
        public Cita dato;
        public NodoCita sig;
    }

    public class ListaCitas
    {
        private NodoCita primero = null;

        public void InsertarOrdenado(Cita c)
        {
            NodoCita nuevo = new NodoCita();
            nuevo.dato = c;

            if (primero == null || c.fechaHoraInicio < primero.dato.fechaHoraInicio)
            {
                nuevo.sig = primero;
                primero = nuevo;
                return;
            }

            NodoCita act = primero;
            while (act.sig != null && act.sig.dato.fechaHoraInicio <= c.fechaHoraInicio)
            {
                act = act.sig;
            }
            nuevo.sig = act.sig;
            act.sig = nuevo;
        }

        public bool ExisteConflicto(string terapeuta, DateTime fechaHora)
        {
            NodoCita aux = primero;
            while (aux != null)
            {
                if (aux.dato.terapeuta == terapeuta && aux.dato.fechaHoraInicio == fechaHora)
                {
                    return true;
                }
                aux = aux.sig;
            }
            return false;
        }

        public void LlenarListBox(ListBox lb)
        {
            lb.Items.Clear();
            NodoCita aux = primero;
            while (aux != null)
            {
                lb.Items.Add(aux.dato);
                aux = aux.sig;
            }
        }

        public bool Eliminar(Cita c)
        {
            if (primero == null) return false;

            if (primero.dato == c)
            {
                primero = primero.sig;
                return true;
            }

            NodoCita ant = primero;
            NodoCita act = primero.sig;
            while (act != null)
            {
                if (act.dato == c)
                {
                    ant.sig = act.sig;
                    return true;
                }
                ant = act;
                act = act.sig;
            }
            return false;
        }
    }
}
