using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class AreAfect
    {
        public AreAfect()
        {
            TieParTps = new HashSet<TieParTp>();
        }

        public int IdAreAfect { get; set; }
        public string Aanom { get; set; } = null!;
        public bool Aaestado { get; set; }
        public string? Aadetalle { get; set; }

        public virtual ICollection<TieParTp> TieParTps { get; set; }
    }
}
