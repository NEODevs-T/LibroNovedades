using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class TipIncen
    {
        public TipIncen()
        {
            Resumen = new HashSet<Resuman>();
        }

        public int IdTipIncen { get; set; }
        public string? Tinombre { get; set; }
        public string? Tidesc { get; set; }
        public bool? Tiesta { get; set; }

        public virtual ICollection<Resuman> Resumen { get; set; }
    }
}
