using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Pnccausante
    {
        public Pnccausante()
        {
            Pnccausas = new HashSet<Pnccausa>();
        }

        public int IdCausante { get; set; }
        public string Cnombre { get; set; } = null!;
        public string? Cdescri { get; set; }
        public bool Cestado { get; set; }

        public virtual ICollection<Pnccausa> Pnccausas { get; set; }
    }
}
