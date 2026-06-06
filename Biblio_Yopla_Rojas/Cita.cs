using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Yopla_Rojas
{
    public class Cita
    {
        public int dniCliente;
        public string nombreCliente;
        public string anfitriona;
        public DateTime fechaHoraInicio;
        public int duracionMin;
        public decimal precio;

        public override string ToString()
        {
            return string.Format("{0:dd/MM HH:mm} - {1} con {2} ({3} min, S/. {4})",
                fechaHoraInicio, nombreCliente, anfitriona, duracionMin, precio);
        }
    }
}
