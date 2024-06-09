using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class ItipPre
    {
        public ItipPre()
        {
            Ipregunta = new HashSet<Ipreguntum>();
        }

        public int IdTipPre { get; set; }
        public string Tpnombre { get; set; } = null!;
        public string? Tpdescri { get; set; }
        public bool Tpestado { get; set; }
        public DateTime Tpfecha { get; set; }

        public virtual ICollection<Ipreguntum> Ipregunta { get; set; }
    }
}
