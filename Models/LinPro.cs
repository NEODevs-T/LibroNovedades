using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// intermediario entre linea y producto
    /// </summary>
    public partial class LinPro
    {
        /// <summary>
        /// identificador de la Lin_Pro
        /// </summary>
        public int IdLinPro { get; set; }
        /// <summary>
        /// identificador de la linea
        /// </summary>
        public int IdLinea { get; set; }
        /// <summary>
        /// identificador del producto
        /// </summary>
        public int IdProducto { get; set; }

        public virtual Linea IdLineaNavigation { get; set; } = null!;
        public virtual Producto IdProductoNavigation { get; set; } = null!;
    }
}
