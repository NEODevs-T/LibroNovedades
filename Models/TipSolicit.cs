using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class TipSolicit
    {
        public TipSolicit()
        {
            ProMejConts = new HashSet<ProMejCont>();
        }

        public int IdTipSol { get; set; }
        public string Tsnombre { get; set; } = null!;

        public virtual ICollection<ProMejCont> ProMejConts { get; set; }
    }
}
