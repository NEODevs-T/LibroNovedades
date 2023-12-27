using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Pnccausa
    {
        public Pnccausa()
        {
            ProNoCons = new HashSet<ProNoCon>();
        }

        public int IdCausa { get; set; }
        public int IdCausante { get; set; }
        public string Cnombre { get; set; } = null!;
        public string? Cdescri { get; set; }
        public bool Cestado { get; set; }

        public virtual Pnccausante IdCausanteNavigation { get; set; } = null!;
        public virtual ICollection<ProNoCon> ProNoCons { get; set; }
    }
}
