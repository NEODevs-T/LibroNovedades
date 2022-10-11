using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// tecnicos de calidad
    /// </summary>
    public partial class TecniCa
    {
        public TecniCa()
        {
            AudCas = new HashSet<AudCa>();
        }

        public int IdTecniCa { get; set; }
        public string Tcnom { get; set; } = null!;
        public string? Tcficha { get; set; }
        public string? TcusuW { get; set; }
        public bool Tcestado { get; set; }

        public virtual ICollection<AudCa> AudCas { get; set; }
    }
}
