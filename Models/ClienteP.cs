using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// Area solicitante
    /// </summary>
    public partial class ClienteP
    {
        /// <summary>
        /// Identificador del cliente del proyecto
        /// </summary>
        public int IdClienteP { get; set; }
        /// <summary>
        /// nombre del area
        /// </summary>
        public string Cpnombre { get; set; } = null!;
        /// <summary>
        /// decripcion del area
        /// </summary>
        public string? Cpdescri { get; set; }
        /// <summary>
        /// estatus(0:inactivo,1:activo)
        /// </summary>
        public bool Cpestatus { get; set; }
    }
}
