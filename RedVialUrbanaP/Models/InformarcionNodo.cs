using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedVialUrbanaP.Models
{
    public abstract class InformacionNodo
    {
        public int CantidadVehiculos { get; set; }
        public string EstadoSemaforo { get; set; } // "Rojo", "Verde", etc.
        public double TiempoPromedioTransito { get; set; }

        public abstract void ActualizarInformacion(int vehiculosEntrantes, string nuevoEstadoSemaforo);
    }
}
