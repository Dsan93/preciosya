using System;
using System.Collections.Generic;

namespace preciosya.Models
{
    public partial class Ubicacion
    {
        public Ubicacion()
        {
            Comercio = new HashSet<Comercio>();
        }

        public int UbId { get; set; }
        public int? UbParId { get; set; }

        public virtual Partido UbPar { get; set; }
        public virtual ICollection<Comercio> Comercio { get; set; }
    }
}
