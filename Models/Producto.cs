using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// Productos
    /// </summary>
    public partial class Producto
    {
        public Producto()
        {
            LinPros = new HashSet<LinPro>();
            TurPros = new HashSet<TurPro>();
        }

        /// <summary>
        /// identificador
        /// </summary>
        public int IdProducto { get; set; }
        /// <summary>
        /// Codigo del producto
        /// </summary>
        public string? Pcodigo { get; set; }
        /// <summary>
        /// nombre de la parte
        /// </summary>
        public string Pnombre { get; set; } = null!;
        /// <summary>
        /// detalle de la parte
        /// </summary>
        public string? Pdetalle { get; set; }
        /// <summary>
        /// 0: Inactivo, 1:Activo
        /// </summary>
        public bool Pestado { get; set; }

        public virtual ICollection<LinPro> LinPros { get; set; }
        public virtual ICollection<TurPro> TurPros { get; set; }
    }
}
