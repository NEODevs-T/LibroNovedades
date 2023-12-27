using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Pncestado
    {
        public Pncestado()
        {
            ProNoCons = new HashSet<ProNoCon>();
        }

        public int IdEstado { get; set; }
        public string Enombre { get; set; } = null!;
        public string? Edescri { get; set; }
        public bool Estatus { get; set; }

        public virtual ICollection<ProNoCon> ProNoCons { get; set; }
    }
}
