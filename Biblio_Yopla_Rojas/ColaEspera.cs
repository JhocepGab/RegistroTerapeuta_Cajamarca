using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Yopla_Rojas
{
    public class ColaEspera
    {
        public NodoCola frente = null;
        public NodoCola fin = null;

        public bool EstaVacia()
        {
            return frente == null;
        }

        public void Encolar(Cita c)
        {
            NodoCola nuevo = new NodoCola();
            nuevo.dato = c;

            if (fin == null)
            {
                frente = nuevo;
                fin = nuevo;
            }
            else
            {
                fin.sig = nuevo;
                fin = nuevo;
            }
        }

        public Cita Desencolar()
        {
            if (frente == null) return null;

            Cita c = frente.dato;
            frente = frente.sig;

            if (frente == null)
            {
                fin = null;
            }
            return c;
        }
    }
}
