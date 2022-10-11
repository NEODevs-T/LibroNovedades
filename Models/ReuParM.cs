using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// reuniones de paradas por mantenimiento
    /// </summary>
    public partial class ReuParM
    {
        public ReuParM()
        {
            AsisPms = new HashSet<AsisPm>();
        }

        /// <summary>
        /// identificador
        /// </summary>
        public int IdReuParM { get; set; }
        /// <summary>
        /// area en la que se realizo la parada planificada
        /// </summary>
        public string? Rparea { get; set; }
        /// <summary>
        /// fecha de la reunion
        /// </summary>
        public DateTime? RpfechaReu { get; set; }
        /// <summary>
        /// fecha de la parada planificada
        /// </summary>
        public DateTime? RpfechaPar { get; set; }
        /// <summary>
        /// maquina de la parada programada
        /// </summary>
        public string? Rpmaquina { get; set; }
        /// <summary>
        /// numero actividades de la parada
        /// </summary>
        public int? RpnumAct { get; set; }
        /// <summary>
        /// tipo de reunion
        /// </summary>
        public string? RptipReu { get; set; }
        /// <summary>
        /// tiempo de la parada planificada
        /// </summary>
        public double? RptiePar { get; set; }
        /// <summary>
        /// asuntos tratados en el SPA
        /// </summary>
        public int? RpasunSpa { get; set; }
        /// <summary>
        /// Porcentaje de asistencia
        /// </summary>
        public double? Rpporce { get; set; }

        public virtual ICollection<AsisPm> AsisPms { get; set; }
    }
}
