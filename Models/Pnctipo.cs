using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Pnctipo
    {
        public Pnctipo()
        {
            ProNoCons = new HashSet<ProNoCon>();
        }

        public int IdTipo { get; set; }
        public string Tnombre { get; set; } = null!;
        public string? Tdescri { get; set; }
        public bool Testado { get; set; }

        public virtual ICollection<ProNoCon> ProNoCons { get; set; }
    }
}
