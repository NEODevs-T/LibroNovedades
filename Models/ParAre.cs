using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// intermediario entre la parte y el area
    /// </summary>
    public partial class ParAre
    {
        /// <summary>
        /// identificador del Par_Are
        /// </summary>
        public int IdParAre { get; set; }
        /// <summary>
        /// identificador del area
        /// </summary>
        public int IdArea { get; set; }
        /// <summary>
        /// identifiacador de la parte
        /// </summary>
        public int IdParte { get; set; }
        /// <summary>
        /// codigo de la parte correspondiente al area		
        /// </summary>
        public string? Pacodigo { get; set; }

        public virtual LinAre IdAreaNavigation { get; set; } = null!;
        public virtual Parte IdParteNavigation { get; set; } = null!;
    }
}
