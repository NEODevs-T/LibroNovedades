using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class AutenUsr
    {
        public int IdAuten { get; set; }
        public string? AuFicha { get; set; }
        public string? AuPass { get; set; }
        public string? Anombre { get; set; }
        public string? Aapellido { get; set; }
        public int? Anivel { get; set; }
        public bool? Aestatus { get; set; }
    }
}
