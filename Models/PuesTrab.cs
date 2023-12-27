using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class PuesTrab
    {
        public PuesTrab()
        {
            Montos = new HashSet<Monto>();
        }

        public int IdPuesTrab { get; set; }
        public string Ptnombre { get; set; } = null!;
        public string? Ptdescri { get; set; }
        public bool? Ptesta { get; set; }

        public virtual ICollection<Monto> Montos { get; set; }
    }
}
