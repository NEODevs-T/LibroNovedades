using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class PaisEmpresaCentroDivisionLinea
    {
        public string Pais { get; set; } = null!;
        public string Empresa { get; set; } = null!;
        public string Centro { get; set; } = null!;
        public string? Division { get; set; }
        public string Linea { get; set; } = null!;
        public int IdPais { get; set; }
        public int IdEmpresa { get; set; }
        public int IdCentro { get; set; }
        public int IdDivision { get; set; }
        public int IdLinea { get; set; }
    }
}
