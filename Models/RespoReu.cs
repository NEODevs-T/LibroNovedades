using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class RespoReu
    {
        public int IdResReu { get; set; }
        public string Rrnombre { get; set; } = null!;
        public bool Rresta { get; set; }
    }
}
