using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// Para Guardar data de Conteos Ciclicos de Paletas
    /// </summary>
    public partial class RegPaletPt
    {
        public int IdRegPal { get; set; }
        /// <summary>
        /// Inventario Inicial del Conteo
        /// </summary>
        public int? RpinvIni { get; set; }
        /// <summary>
        /// Inventario Teorico al sumar Inventario Inicial, entrada y salidad de paletas
        /// </summary>
        public int? RpinvTeori { get; set; }
        /// <summary>
        /// Inventario Contado Total
        /// </summary>
        public int? RpinvCont { get; set; }
        /// <summary>
        /// Inventario en Pie de Maquina
        /// </summary>
        public int? RpinvPm { get; set; }
        /// <summary>
        /// Inventario en Jaula de Paletas
        /// </summary>
        public int? RpinvPtCo { get; set; }
        /// <summary>
        /// Resta entre Inventario contado menos el teorico
        /// </summary>
        public int? RpdifInv { get; set; }
        /// <summary>
        /// Fecha de Carga
        /// </summary>
        public DateTime Rpdate { get; set; }
        /// <summary>
        /// Hora de Carga
        /// </summary>
        public double Rptime { get; set; }
        public int? RpinvPalNc { get; set; }
    }
}
