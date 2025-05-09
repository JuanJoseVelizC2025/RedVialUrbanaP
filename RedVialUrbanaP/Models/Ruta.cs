using RedVialUrbanaP.Estructuras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedVialUrbanaP.Models
{
    public class Ruta
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public ListaSimple<Nodo> Recorrido { get; set; }
        public double TiempoEstimado { get; set; }

        public Ruta(string origen, string destino)
        {
            Origen = origen;
            Destino = destino;
            Recorrido = new ListaSimple<Nodo>();
        }
    }
}
