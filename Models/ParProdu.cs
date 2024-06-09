using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class ParProdu
    {
        public ParProdu()
        {
            VarAres = new HashSet<VarAre>();
        }

        public int IdParProdu { get; set; }
        public string Pnombre { get; set; } = null!;
        public string Pdetalle { get; set; } = null!;
        public bool Pestado { get; set; }

        public virtual ICollection<VarAre> VarAres { get; set; }
    }
}
