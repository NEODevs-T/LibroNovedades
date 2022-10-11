using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// Paradas de la linia
    /// </summary>
    public partial class ParaTp
    {
        public ParaTp()
        {
            TieParTps = new HashSet<TieParTp>();
        }

        /// <summary>
        /// identificador de la parada
        /// </summary>
        public int IdParaTp { get; set; }
        /// <summary>
        /// identificador del tipo de la parada
        /// </summary>
        public int IdTiParTp { get; set; }
        /// <summary>
        /// codigo de la parada
        /// </summary>
        public string? Pcodigo { get; set; }
        /// <summary>
        /// nombre de la parada
        /// </summary>
        public string Pnombre { get; set; } = null!;
        /// <summary>
        /// 0: Inactivo, 1:Activo
        /// </summary>
        public bool Pestado { get; set; }

        public virtual TiParTp IdTiParTpNavigation { get; set; } = null!;
        public virtual ICollection<TieParTp> TieParTps { get; set; }
    }
}
