using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Plantum
    {
        public Plantum()
        {
            AreaTras = new HashSet<AreaTra>();
        }

        public int IdPlanta { get; set; }
        public string? PlCodigo { get; set; }
        public string? PlDescri { get; set; }
        public bool? PlEstado { get; set; }
        public int IdEmpresa { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
        public virtual ICollection<AreaTra> AreaTras { get; set; }
    }
}
