using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Nodo
    {
        public Persona dato;
        public Nodo der = null;
        public Nodo izq = null;
    }
    public class NodoPila
    {
        public string accion;
        public Cita cita;
        public NodoPila sig;
    }
    public class NodoTerapeuta
    {
        public string nombre;
        public string especialidad;
        public NodoTerapeuta sig = null;
    }
    public class NodoCita
    {
        public Cita dato;
        public NodoCita sig;
    }
    public class NodoCola
    {
        public Cita dato;
        public NodoCola sig;
    }
}
