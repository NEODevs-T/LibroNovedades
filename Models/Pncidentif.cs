using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Pncidentif
    {
        public Pncidentif()
        {
            ProNoCons = new HashSet<ProNoCon>();
        }

        public int IdIdentif { get; set; }
        public string Inombre { get; set; } = null!;
        public string? Idescri { get; set; }
        public bool Iestado { get; set; }

        public virtual ICollection<ProNoCon> ProNoCons { get; set; }
    }
}
