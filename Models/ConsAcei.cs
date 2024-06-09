using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// Para guardar los registros de consumo de aceite grado alimenticio en conversión
    /// </summary>
    public partial class ConsAcei
    {
        public int IdConsAcei { get; set; }
        /// <summary>
        /// Nombre del usuario
        /// </summary>
        public string? Canombre { get; set; }
        /// <summary>
        /// Grupo de rotación
        /// </summary>
        public string? Cagrupo { get; set; }
        /// <summary>
        /// Turno del registro
        /// </summary>
        public string? Caturno { get; set; }
        /// <summary>
        /// Tipo de transacción
        /// </summary>
        public string? Catrans { get; set; }
        /// <summary>
        /// Fecha del registro
        /// </summary>
        public DateTime? Cafecha { get; set; }
        /// <summary>
        /// Cantidad de transacción
        /// </summary>
        public double? Cacant { get; set; }
        /// <summary>
        /// Centro de consumo
        /// </summary>
        public string? Cacelda { get; set; }
        /// <summary>
        /// Parte de consumo
        /// </summary>
        public string? Camaq { get; set; }
    }
}
