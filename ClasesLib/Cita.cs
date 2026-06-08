using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cita
    {
        public int dniPaciente;
        public string nombrePaciente;
        public string terapeuta;
        public DateTime fechaHoraInicio;
        public int duracionMin; // 30 o 60
        public decimal precio;  // S/. 35 o S/. 60

        public override string ToString()
        {
            return string.Format("{0:dd/MM HH:mm} - {1} con {2} ({3} min, S/. {4})",
                fechaHoraInicio, nombrePaciente, terapeuta, duracionMin, precio);
        }
    }
}
