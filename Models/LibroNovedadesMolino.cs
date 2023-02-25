using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class LibroNovedadesMolino
    {
        public string Linea { get; set; } = null!;
        public string CodigoEquipo { get; set; } = null!;
        public string Centro { get; set; } = null!;
        public string? TipoDeNovedad { get; set; }
        public string Discrepancia { get; set; } = null!;
        public double TiempoPerdido { get; set; }
        public string FichaDelRegistrador { get; set; } = null!;
        public string Grupo { get; set; } = null!;
        public string Turno { get; set; } = null!;
        public string? Observacion { get; set; }
        public DateTime Lnfecha { get; set; }
    }
}
