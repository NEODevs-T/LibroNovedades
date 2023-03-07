using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class AreaCarga
    {
        public AreaCarga()
        {
            LibroNoves = new HashSet<LibroNove>();
        }

        public int IdAreaCarg { get; set; }
        public string Acnombre { get; set; } = null!;
        public string? Acdetalle { get; set; }
        public bool Acestado { get; set; }

        public virtual ICollection<LibroNove> LibroNoves { get; set; }
    }
}
