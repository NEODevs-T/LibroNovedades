using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// reuniones de paradas por mantenimiento
    /// </summary>
    public partial class AsisPm
    {
        /// <summary>
        /// identificador
        /// </summary>
        public int IdAsisPm { get; set; }
        /// <summary>
        /// identificador  CargoPM
        /// </summary>
        public int IdCargoPm { get; set; }
        /// <summary>
        /// identificador ReuParM
        /// </summary>
        public int IdReuParM { get; set; }
        /// <summary>
        /// 1: Asistencia, 0: Inasistencia
        /// </summary>
        public bool AisAsis { get; set; }

        public virtual CargoPm IdCargoPmNavigation { get; set; } = null!;
        public virtual ReuParM IdReuParMNavigation { get; set; } = null!;
    }
}
