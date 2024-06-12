using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Pncunidad
    {
        public Pncunidad()
        {
            ProNoCons = new HashSet<ProNoCon>();
        }

        public int IdUnidad { get; set; }
        public string Unombre { get; set; } = null!;
        public string? Udescri { get; set; }
        public bool Uestado { get; set; }

        public virtual ICollection<ProNoCon> ProNoCons { get; set; }
    }
}
