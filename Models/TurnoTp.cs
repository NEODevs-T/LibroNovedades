﻿using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// turnos de tiempo perdido
    /// </summary>
    public partial class TurnoTp
    {
        public TurnoTp()
        {
            ParsiOees = new HashSet<ParsiOee>();
        }

        /// <summary>
        /// identificador del turno
        /// </summary>
        public int IdTurnoTp { get; set; }
        /// <summary>
        /// identificador del operador
        /// </summary>
        public string ToperaFich { get; set; } = null!;
        /// <summary>
        /// turno en curso
        /// </summary>
        public string Tturno { get; set; } = null!;
        /// <summary>
        /// fecha del turno
        /// </summary>
        public DateTime? Tfecha { get; set; }
        public string? TcodiProdu { get; set; }
        /// <summary>
        /// tiempo trabajo del turno
        /// </summary>
        public double? Ttrabajado { get; set; }
        /// <summary>
        /// tiempo perdido del turno
        /// </summary>
        public double? Tperdido { get; set; }
        /// <summary>
        /// productos buenos del turno
        /// </summary>
        public int? Tpbueno { get; set; }
        /// <summary>
        /// productos malos del turno
        /// </summary>
        public int? Tpmalo { get; set; }
        /// <summary>
        /// velocidad promedio del turno
        /// </summary>
        public double? Tvelocidad { get; set; }
        /// <summary>
        /// rendimiento del turno
        /// </summary>
        public double? Trendi { get; set; }
        /// <summary>
        /// calidad del turno
        /// </summary>
        public double? Tcalidad { get; set; }
        /// <summary>
        /// disponibilidad del turno
        /// </summary>
        public double? Tdispo { get; set; }
        /// <summary>
        /// OEE del turno
        /// </summary>
        public double? Toee { get; set; }

        public virtual ICollection<ParsiOee> ParsiOees { get; set; }
    }
}
