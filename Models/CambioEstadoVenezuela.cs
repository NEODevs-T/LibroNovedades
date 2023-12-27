using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class CambioEstadoVenezuela
    {
        public int IdReuDia { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Estado { get; set; }
        public string? Usuario { get; set; }
        public string? Centro { get; set; }
        public string? Division { get; set; }
        public string? Linea { get; set; }
        public string Empresa { get; set; } = null!;
        public string Pais { get; set; } = null!;
    }
}
