﻿using System;
using System.Collections.Generic;

namespace preciosya.Models
{
    public partial class Comercio
    {
        public int ComId { get; set; }
        public string ComNombre { get; set; }
        public string ComDescripcion { get; set; }
        public int ComUsId { get; set; }
        public string ComDireccion { get; set; }
        public int? ComUbId { get; set; }
        public int? ComProId { get; set; }

        public virtual Producto ComPro { get; set; }
        public virtual Ubicacion ComUb { get; set; }
        public virtual Usuario ComUs { get; set; }
    }
}
