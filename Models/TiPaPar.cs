using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// intermediario entre el tipo de parada y la parte
    /// </summary>
    public partial class TiPaPar
    {
        /// <summary>
        /// identificador del TiPa_Par
        /// </summary>
        public int IdTiPaPar { get; set; }
        /// <summary>
        /// identificador de tipo de parada
        /// </summary>
        public int IdTiParTp { get; set; }
        /// <summary>
        /// identifiacador de la parte
        /// </summary>
        public int IdParte { get; set; }

        public virtual Parte IdParteNavigation { get; set; } = null!;
        public virtual TiParTp IdTiParTpNavigation { get; set; } = null!;
    }
}
