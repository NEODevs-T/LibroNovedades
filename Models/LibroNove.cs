using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class LibroNove
    {
        public int RdidReuDia { get; set; }
        public int IdLinea { get; set; }
        public string IdEquipo { get; set; } = null!;
        public string Rddiscrepa { get; set; } = null!;
        public double RdtiePerMi { get; set; }
        public string RdfichaRes { get; set; } = null!;
        public DateTime Rdfecha { get; set; }
    }
}
