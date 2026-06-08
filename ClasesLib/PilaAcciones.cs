using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class PilaAcciones
    {
        private class NodoPila
        {
            public string accion;
            public Cita cita;
            public NodoPila sig;
        }

        private NodoPila cima = null;

        public void Push(string accion, Cita cita)
        {
            NodoPila nuevo = new NodoPila();
            nuevo.accion = accion;
            nuevo.cita = cita;
            nuevo.sig = cima;
            cima = nuevo;
        }

        public bool EstaVacia()
        {
            return cima == null;
        }

        public bool Pop(out string accion, out Cita cita)
        {
            if (cima == null)
            {
                accion = null;
                cita = null;
                return false;
            }
            accion = cima.accion;
            cita = cima.cita;
            cima = cima.sig;
            return true;
        }
    }
}
