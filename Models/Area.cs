using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// Area de produccion
    /// </summary>
    public partial class Area
    {
        public Area()
        {
            LibroNoves = new HashSet<LibroNove>();
            LinAres = new HashSet<LinAre>();
            VarAres = new HashSet<VarAre>();
        }

        /// <summary>
        /// identificador del area
        /// </summary>
        public int IdArea { get; set; }
        /// <summary>
        /// nombre del area
        /// </summary>
        public string Anom { get; set; } = null!;
        /// <summary>
        /// Detalle del area
        /// </summary>
        public string? Adetalle { get; set; }
        /// <summary>
        /// 0: Inactivo, 1:Activo
        /// </summary>
        public bool Aestado { get; set; }

        public virtual ICollection<LibroNove> LibroNoves { get; set; }
        public virtual ICollection<LinAre> LinAres { get; set; }
        public virtual ICollection<VarAre> VarAres { get; set; }
    }
}
