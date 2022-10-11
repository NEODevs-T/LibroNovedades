using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// cargos registrados en las reuniones de las paradas por mantenimiento
    /// </summary>
    public partial class CargoPm
    {
        public CargoPm()
        {
            AsisPms = new HashSet<AsisPm>();
        }

        /// <summary>
        /// identificador
        /// </summary>
        public int IdCargoPm { get; set; }
        /// <summary>
        /// cargo del asistidor
        /// </summary>
        public string? Cpmnom { get; set; }

        public virtual ICollection<AsisPm> AsisPms { get; set; }
    }
}
