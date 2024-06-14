using System;
using System.Collections.Generic;

namespace LibroNovedades.Models.Neo
{
    public partial class Centro
    {
        public Centro()
        {
            Masters = new HashSet<Master>();
        }

        public int IdCentro { get; set; }
        public string Cnom { get; set; } = null!;
        public string? Cdetalle { get; set; }
        public bool Cestado { get; set; }
        public DateTime Cfecha { get; set; }

        public virtual ICollection<Master> Masters { get; set; }
    }
}
