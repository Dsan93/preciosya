using System;
using System.Collections.Generic;

namespace preciosya
{
    public partial class Marca
    {
        public Marca()
        {
            Producto = new HashSet<Producto>();
        }

        public int MaId { get; set; }
        public string MaNombre { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
