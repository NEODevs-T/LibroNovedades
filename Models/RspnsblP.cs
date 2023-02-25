using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// Responsable del proyecto
    /// </summary>
    public partial class RspnsblP
    {
        public RspnsblP()
        {
            ProResps = new HashSet<ProResp>();
            Proyectos = new HashSet<Proyecto>();
        }

        /// <summary>
        /// Identificador del cliente del proyecto
        /// </summary>
        public int IdRspnsblP { get; set; }
        /// <summary>
        /// nombre del responsable
        /// </summary>
        public string Rpnombre { get; set; } = null!;
        /// <summary>
        /// estatus(0:inactivo,1:activo)
        /// </summary>
        public bool Rpestatus { get; set; }
        public string Rpusuario { get; set; } = null!;

        public virtual ICollection<ProResp> ProResps { get; set; }
        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
