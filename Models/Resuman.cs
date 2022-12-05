using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Resuman
    {
        public int IdResumen { get; set; }
        public int? IdTipSuple { get; set; }
        public DateTime? Rfecha { get; set; }
        public string? Rturno { get; set; }
        public string? Rgrupo { get; set; }
        public string? Rplanta { get; set; }
        public string? AreaTra { get; set; }
        public string? Rpuesto { get; set; }
        public bool? RisSplncia { get; set; }
        public string? Rtrabajado { get; set; }
        public string? RtraFicha { get; set; }
        public string? Rsuplido { get; set; }
        public string? RsupFicha { get; set; }

        public virtual TipSuple? IdTipSupleNavigation { get; set; }
    }
}
