using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Personal
    {
        public int IdPersonal { get; set; }
        public int? IdAreaTra { get; set; }
        public int? IdPuesto { get; set; }
        public string? PeNombre { get; set; }
        public string? PeApellido { get; set; }
        public string? PeFicha { get; set; }
        public bool? PeEstado { get; set; }

        public virtual AreaTra? IdAreaTraNavigation { get; set; }
        public virtual Puesto? IdPuestoNavigation { get; set; }
    }
}
