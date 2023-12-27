using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Pncriesgo
    {
        public int IdRiesgo { get; set; }
        public string Rnombre { get; set; } = null!;
        public string? Rdescri { get; set; }
        public bool Restado { get; set; }
    }
}
