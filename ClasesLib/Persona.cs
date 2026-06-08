using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        public int dni;
        public string nombre;
        public string telefono;

        public override string ToString()
        {
            return string.Format("{0}  |  {1}  |  Tel: {2}", dni, nombre, telefono);
        }

        public static bool operator >(Persona p1, Persona p2)
        {
            if (p1.dni > p2.dni)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Persona p1, Persona p2)
        {
            if (p1.dni < p2.dni) return true;
            return false;
        }
    }
}
