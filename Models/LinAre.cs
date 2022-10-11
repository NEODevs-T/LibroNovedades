using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// ntermediario entre linea y area
    /// </summary>
    public partial class LinAre
    {
        public LinAre()
        {
            AudCas = new HashSet<AudCa>();
            ParAres = new HashSet<ParAre>();
        }

        /// <summary>
        /// Identificador
        /// </summary>
        public int IdLinAre { get; set; }
        /// <summary>
        /// Codigo de la linea con area
        /// </summary>
        public int IdLinea { get; set; }
        public int IdArea { get; set; }
        /// <summary>
        /// Codigo de la linea con area
        /// </summary>
        public string? Lacodigo { get; set; }

        public virtual Area IdAreaNavigation { get; set; } = null!;
        public virtual Linea IdLineaNavigation { get; set; } = null!;
        public virtual ICollection<AudCa> AudCas { get; set; }
        public virtual ICollection<ParAre> ParAres { get; set; }
    }
}
