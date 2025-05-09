using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedVialUrbanaP.Models
{
    class InformacionNodoBasica : InformacionNodo
    {
        public override void ActualizarInformacion(int vehiculosEntrantes, string nuevoEstadoSemaforo)
        {
            CantidadVehiculos += vehiculosEntrantes;
            EstadoSemaforo = nuevoEstadoSemaforo;
        }
    }
}
