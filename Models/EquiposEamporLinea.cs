using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class EquiposEamporLinea
    {
        public string Pais { get; set; } = null!;
        public string Empresa { get; set; } = null!;
        public string Centro { get; set; } = null!;
        public string? Division { get; set; }
        public string Linea { get; set; } = null!;
        public string Equipo { get; set; } = null!;
        public int IdPais { get; set; }
        public int IdEmpresa { get; set; }
        public int IdCentro { get; set; }
        public int IdDivision { get; set; }
        public int IdLinea { get; set; }
        public int IdEquipo { get; set; }
        public string EcodEquiEam { get; set; } = null!;
    }
}
