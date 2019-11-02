using System;
using System.Collections.Generic;

namespace preciosya
{
    public partial class Provincia
    {
        public Provincia()
        {
            Partido = new HashSet<Partido>();
        }

        public int PrId { get; set; }
        public string PrNombre { get; set; }
        public int PrPaId { get; set; }

        public virtual Pais PrPa { get; set; }
        public virtual ICollection<Partido> Partido { get; set; }
    }
}
