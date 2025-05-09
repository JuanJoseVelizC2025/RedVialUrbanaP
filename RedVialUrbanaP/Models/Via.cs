using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedVialUrbanaP.Models
{
    public class Via
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public bool EsBidireccional { get; set; }
        public double Longitud { get; set; }
        public string Tipo { get; set; } // Avenida, calle, etc.

        public Via(string origen, string destino, bool bidireccional, double longitud, string tipo)
        {
            Origen = origen;
            Destino = destino;
            EsBidireccional = bidireccional;
            Longitud = longitud;
            Tipo = tipo;
        }
    }
}
