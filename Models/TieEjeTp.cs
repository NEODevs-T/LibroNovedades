using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// tiempo ejecutado en el turno
    /// </summary>
    public partial class TieEjeTp
    {
        /// <summary>
        /// identificador del tiempo ejecutado de un turno
        /// </summary>
        public int IdTieEjeTp { get; set; }
        /// <summary>
        /// identificador del turno
        /// </summary>
        public int IdParsiOee { get; set; }
        /// <summary>
        /// fecha de inicio del tiempo ejecutado
        /// </summary>
        public DateTime Tefechai { get; set; }
        /// <summary>
        /// fecha final del tiempo ejecutado
        /// </summary>
        public DateTime? Tefechaf { get; set; }
        /// <summary>
        /// duracion del tiempo ejecutado
        /// </summary>
        public double? Teduracion { get; set; }
        /// <summary>
        /// velocidad promedio
        /// </summary>
        public double? Tevelocidad { get; set; }
        /// <summary>
        /// cantidad de productos buenos
        /// </summary>
        public int? Tebueno { get; set; }
        /// <summary>
        /// cantidad de productos malos
        /// </summary>
        public int? Temalo { get; set; }

        public virtual ParsiOee IdParsiOeeNavigation { get; set; } = null!;
    }
}
