using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class IdAreaConLinea
    {
        public int IdLinAre { get; set; }
        public int IdLinea { get; set; }
        public string Lnom { get; set; } = null!;
        public int IdArea { get; set; }
        public string Anom { get; set; } = null!;
    }
}
