using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Ipreguntum
    {
        public Ipreguntum()
        {
            ImaqPres = new HashSet<ImaqPre>();
        }

        public int IdPregunta { get; set; }
        public int IdTipPre { get; set; }
        public string Pdescri { get; set; } = null!;
        public bool Pestado { get; set; }
        public DateTime Pfecha { get; set; }

        public virtual ItipPre IdTipPreNavigation { get; set; } = null!;
        public virtual ICollection<ImaqPre> ImaqPres { get; set; }
    }
}
