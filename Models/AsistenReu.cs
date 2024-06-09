using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class AsistenReu
    {
        public string Ararea { get; set; } = null!;
        public int IdAsistencia { get; set; }
        public DateTime? Arfecha { get; set; }
        public int AridCargoR { get; set; }
        public int ArAsistente { get; set; }
        public int? ArSuplente { get; set; }
        public string? ArObser { get; set; }

        public virtual CargoReu AridCargoRNavigation { get; set; } = null!;
    }
}
