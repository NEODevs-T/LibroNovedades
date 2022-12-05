using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Puesto
    {
        public Puesto()
        {
            Personals = new HashSet<Personal>();
        }

        public int IdPuesto { get; set; }
        public string? PuCodigo { get; set; }
        public string? PuDescri { get; set; }
        public bool? PuEstado { get; set; }

        public virtual ICollection<Personal> Personals { get; set; }
    }
}
