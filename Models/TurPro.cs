using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// intermediario entre turno del tiempo perdido y producto
    /// </summary>
    public partial class TurPro
    {
        /// <summary>
        /// identificador de la Tur_Pro
        /// </summary>
        public int IdTurPro { get; set; }
        /// <summary>
        /// identificador del turno
        /// </summary>
        public int IdTurnoTp { get; set; }
        /// <summary>
        /// identificador del producto
        /// </summary>
        public int IdProducto { get; set; }

        public virtual Producto IdProductoNavigation { get; set; } = null!;
        public virtual TurnoTp IdTurnoTpNavigation { get; set; } = null!;
    }
}
