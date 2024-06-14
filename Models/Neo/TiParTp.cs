using System;
using System.Collections.Generic;

namespace LibroNovedades.Models.Neo
{
    public partial class TiParTp
    {
        public TiParTp()
        {
            LibroNoves = new HashSet<LibroNove>();
        }

        public int IdTiParTp { get; set; }
        public string Tpcodigo { get; set; } = null!;
        public string Tpnombre { get; set; } = null!;
        public bool Tpestado { get; set; }

        public virtual ICollection<LibroNove> LibroNoves { get; set; }
    }
}
