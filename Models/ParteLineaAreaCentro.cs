using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class ParteLineaAreaCentro
    {
        public string? CodigocDeLaParte { get; set; }
        public string? CodigoDelArea { get; set; }
        public string Parte { get; set; } = null!;
        public string Linea { get; set; } = null!;
        public string Centro { get; set; } = null!;
        public string Area { get; set; } = null!;
    }
}
