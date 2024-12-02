using System;
using System.Collections.Generic;

namespace LibroNovedades.Models.Neo
{
    public partial class ClasifiTpm
    {
        public ClasifiTpm()
        {
            LibroNoves = new HashSet<LibroNove>();
        }

        public int IdCtpm { get; set; }
        public string Ctpmnom { get; set; } = null!;
        public bool Ctpmestado { get; set; }
        public string Ctpmenglis { get; set; } = null!;

        public virtual ICollection<LibroNove> LibroNoves { get; set; }
    }
}
