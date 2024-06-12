using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class RespoReu
    {
        public RespoReu()
        {
            ReuDia = new HashSet<ReuDium>();
        }

        public int IdResReu { get; set; }
        public string Rrnombre { get; set; } = null!;
        public bool Rresta { get; set; }
        public string? Rrdesc { get; set; }

        public virtual ICollection<ReuDium> ReuDia { get; set; }
    }
}
