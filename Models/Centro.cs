using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// centro de produccion
    /// </summary>
    public partial class Centro
    {
        public Centro()
        {
            Divisions = new HashSet<Division>();
            Lineas = new HashSet<Linea>();
        }

        /// <summary>
        /// identificador del centro
        /// </summary>
        public int IdCentro { get; set; }
        /// <summary>
        /// nombre del centro
        /// </summary>
        public string Cnom { get; set; } = null!;
        /// <summary>
        /// Detalle del centro
        /// </summary>
        public string? Cdetalle { get; set; }
        public int? IdEmpresa { get; set; }
        /// <summary>
        /// 0: Inactivo, 1:Activo
        /// </summary>
        public bool Cestado { get; set; }

        public virtual Empresa? IdEmpresaNavigation { get; set; }
        public virtual ICollection<Division> Divisions { get; set; }
        public virtual ICollection<Linea> Lineas { get; set; }
    }
}
