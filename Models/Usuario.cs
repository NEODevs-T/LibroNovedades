using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// Responsable del proyecto
    /// </summary>
    public partial class Usuario
    {
        /// <summary>
        /// Identificador del usuario
        /// </summary>
        public int IdUsuario { get; set; }
        /// <summary>
        /// nombre del usuario
        /// </summary>
        public string Usnombre { get; set; } = null!;
        /// <summary>
        /// estatus(0:inactivo,1:activo)
        /// </summary>
        public bool Usestatus { get; set; }
    }
}
