using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// tipo de parada del tiempo perdido
    /// </summary>
    public partial class TiParTp
    {
        public TiParTp()
        {
            LibroNoves = new HashSet<LibroNove>();
        }

        /// <summary>
        /// identificador
        /// </summary>
        public int IdTiParTp { get; set; }
        /// <summary>
        /// codigo del tipo parada
        /// </summary>
        public string? Tpcodigo { get; set; }
        /// <summary>
        /// nombre del centro
        /// </summary>
        public string? Tpnombre { get; set; }
        /// <summary>
        /// 0: Inactivo, 1:Activo
        /// </summary>
        public bool Tpestado { get; set; }

        public virtual ICollection<LibroNove> LibroNoves { get; set; }
    }
}
