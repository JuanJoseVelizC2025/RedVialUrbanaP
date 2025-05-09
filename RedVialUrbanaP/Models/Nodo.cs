using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedVialUrbanaP.Models
{
    public class Nodo
    {
        public string Nombre { get; set; }
        public InformacionNodo Info { get; set; }

        public string TipoViaNorte { get; set; }
        public string TipoViaSur { get; set; }
        public string TipoViaEste { get; set; }
        public string TipoViaOeste { get; set; }

        public Nodo Norte { get; set; }
        public Nodo Sur { get; set; }
        public Nodo Este { get; set; }
        public Nodo Oeste { get; set; }

        public Nodo(string nombre, InformacionNodo info)
        {
            Nombre = nombre;
            Info = info;
        }
    }
}
