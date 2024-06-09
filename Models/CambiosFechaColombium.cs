using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class CambiosFechaColombium
    {
        public int IdCambFec { get; set; }
        public int IdReuDia { get; set; }
        public DateTime FechaDeCambio { get; set; }
        public DateTime FechaNueva { get; set; }
        public string Usuario { get; set; } = null!;
        public string Empresa { get; set; } = null!;
        public string Pais { get; set; } = null!;
    }
}
