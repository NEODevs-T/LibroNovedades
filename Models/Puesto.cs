using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Puesto
    {
        public Puesto()
        {
            Resumen = new HashSet<Resuman>();
        }

        public int IdPuesto { get; set; }
        public string? PuCodigo { get; set; }
        public string? PuDescri { get; set; }
        public bool? PuEstado { get; set; }
        public int IdAreaTra { get; set; }

        public virtual AreaTra IdAreaTraNavigation { get; set; } = null!;
        public virtual ICollection<Resuman> Resumen { get; set; }
    }
}
