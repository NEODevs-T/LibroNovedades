using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Encuestum
    {
        public Encuestum()
        {
            RespPs = new HashSet<RespP>();
        }

        public int IdEncuesta { get; set; }
        public string EusrDesti { get; set; } = null!;
        public int IdRemiten { get; set; }
        public string? EcodPro { get; set; }
        public bool? EisEncuest { get; set; }
        public int? Enota { get; set; }
        public string? EnomPro { get; set; }

        public virtual RspnsblP IdRemitenNavigation { get; set; } = null!;
        public virtual ICollection<RespP> RespPs { get; set; }
    }
}
