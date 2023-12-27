using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class ReunionWebVenezuela
    {
        public int IdReuDia { get; set; }
        public string? Centro { get; set; }
        public string? División { get; set; }
        public string? Línea { get; set; }
        public string? Equipo { get; set; }
        public string Responsable { get; set; } = null!;
        public string? Discrepancia { get; set; }
        public string? Código { get; set; }
        public string? Acción { get; set; }
        public int? Tiempo { get; set; }
        public string? Estado { get; set; }
        public string? Odt { get; set; }
        public DateTime? FechaReunión { get; set; }
        public DateTime? FechaTrabajo { get; set; }
        public string Kfs { get; set; } = null!;
        public string Empresa { get; set; } = null!;
        public string Pais { get; set; } = null!;
    }
}
