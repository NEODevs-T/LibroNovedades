using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// Responsable del proyecto
    /// </summary>
    public partial class Usuario
    {
        public Usuario()
        {
            Nivels = new HashSet<Nivel>();
        }

        /// <summary>
        /// Identificador del usuario
        /// </summary>
        public int IdUsuario { get; set; }
        /// <summary>
        /// nombre del usuario
        /// </summary>
        public string UsNombre { get; set; } = null!;
        /// <summary>
        /// estatus(0:inactivo,1:activo)
        /// </summary>
        public bool UsEstatus { get; set; }
        public string UsClave { get; set; } = null!;
        public string? UsCorreo { get; set; }
        public string UsApellido { get; set; } = null!;
        public string? UsUsuario { get; set; }
        public string UsFicha { get; set; } = null!;
        public string UsPass { get; set; } = null!;

        public virtual ICollection<Nivel> Nivels { get; set; }
    }
}
