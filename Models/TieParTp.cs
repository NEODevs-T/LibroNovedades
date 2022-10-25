using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// tiempo parado en el turno
    /// </summary>
    public partial class TieParTp
    {
        /// <summary>
        /// identificador del tiempo parado de un turno
        /// </summary>
        public int IdTieParTp { get; set; }
        /// <summary>
        /// identificador del turno
        /// </summary>
        public int IdParsiOee { get; set; }
        /// <summary>
        /// identificador de la parada
        /// </summary>
        public int IdParaTp { get; set; }
        /// <summary>
        /// fecha de inicio de la parada
        /// </summary>
        public DateTime Tefechai { get; set; }
        /// <summary>
        /// fecha final de la parada
        /// </summary>
        public DateTime? Tefechaf { get; set; }
        /// <summary>
        /// duracion de la parada
        /// </summary>
        public double? Teduracion { get; set; }

        public virtual ParaTp IdParaTpNavigation { get; set; } = null!;
        public virtual ParsiOee IdParsiOeeNavigation { get; set; } = null!;
    }
}
