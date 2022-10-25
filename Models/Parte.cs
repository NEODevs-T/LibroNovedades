using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// Partes que componen el area
    /// </summary>
    public partial class Parte
    {
        public Parte()
        {
            ParAres = new HashSet<ParAre>();
            TiPaPars = new HashSet<TiPaPar>();
        }

        /// <summary>
        /// identificador
        /// </summary>
        public int IdParte { get; set; }
        /// <summary>
        /// nombre de la parte
        /// </summary>
        public string Pnombre { get; set; } = null!;
        /// <summary>
        /// detalle de la parte
        /// </summary>
        public string? Pdetalle { get; set; }
        /// <summary>
        /// 0: Inactivo, 1:Activo
        /// </summary>
        public bool Pestado { get; set; }

        public virtual ICollection<ParAre> ParAres { get; set; }
        public virtual ICollection<TiPaPar> TiPaPars { get; set; }
    }
}
