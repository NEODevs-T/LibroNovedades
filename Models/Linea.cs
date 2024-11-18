using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// linea de produccion
    /// </summary>
    public partial class Linea
    {
        public Linea()
        {
            EquipoEams = new HashSet<EquipoEam>();
            LibroNoves = new HashSet<LibroNove>();
        }

        /// <summary>
        /// identificador de la linea
        /// </summary>
        public int IdLinea { get; set; }
        /// <summary>
        /// identificador del centro
        /// </summary>
        public int IdCentro { get; set; }
        public int? IdDivision { get; set; }
        /// <summary>
        /// nombre de la linea
        /// </summary>
        public string Lnom { get; set; } = null!;
        /// <summary>
        /// Detalle de la linea
        /// </summary>
        public string? Ldetalle { get; set; }
        /// <summary>
        /// 0: Inactivo, 1:Activo
        /// </summary>
        public bool Lestado { get; set; }
        public string? LcenCos { get; set; }
        public string? Lofic { get; set; }

        public virtual Centro IdCentroNavigation { get; set; } = null!;
        public virtual Division? IdDivisionNavigation { get; set; }
        public virtual ICollection<EquipoEam> EquipoEams { get; set; }
        public virtual ICollection<LibroNove> LibroNoves { get; set; }
    }
}
