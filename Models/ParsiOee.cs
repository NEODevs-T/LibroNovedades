using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// datos obteneidos de un area especifico del turno en curso
    /// </summary>
    public partial class ParsiOee
    {
        public ParsiOee()
        {
            TieEjeTps = new HashSet<TieEjeTp>();
            TieParTps = new HashSet<TieParTp>();
        }

        /// <summary>
        /// identificador del turno
        /// </summary>
        public int IdParsiOee { get; set; }
        /// <summary>
        /// identificador del turno en curso
        /// </summary>
        public int IdTurnoTp { get; set; }
        /// <summary>
        /// identificador de la linea
        /// </summary>
        public int IdArea { get; set; }
        /// <summary>
        /// tiempo trabajo del turno
        /// </summary>
        public double? Ptrabajado { get; set; }
        /// <summary>
        /// tiempo perdido del turno
        /// </summary>
        public double? Pperdido { get; set; }
        /// <summary>
        /// productos buenos del turno
        /// </summary>
        public int? Ppbueno { get; set; }
        /// <summary>
        /// productos malos del turno
        /// </summary>
        public int? Ppmalo { get; set; }
        /// <summary>
        /// velocidad promedio del turno
        /// </summary>
        public double? Pvelocidad { get; set; }
        /// <summary>
        /// rendimiento del turno
        /// </summary>
        public double? Prendi { get; set; }
        /// <summary>
        /// calidad del turno
        /// </summary>
        public double? Pcalidad { get; set; }
        /// <summary>
        /// disponibilidad del turno
        /// </summary>
        public double? Pdispo { get; set; }
        /// <summary>
        /// OEE del turno
        /// </summary>
        public double? Poee { get; set; }

        public virtual Area IdAreaNavigation { get; set; } = null!;
        public virtual TurnoTp IdTurnoTpNavigation { get; set; } = null!;
        public virtual ICollection<TieEjeTp> TieEjeTps { get; set; }
        public virtual ICollection<TieParTp> TieParTps { get; set; }
    }
}
