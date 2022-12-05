using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class AreaTra
    {
        public AreaTra()
        {
            Personals = new HashSet<Personal>();
        }

        public int IdAreaTra { get; set; }
        public int? IdPlanta { get; set; }
        public int? AtcodBpc { get; set; }
        public string? Atnombre { get; set; }
        public string? Atcodigo { get; set; }
        public bool? Atestado { get; set; }

        public virtual Plantum? IdPlantaNavigation { get; set; }
        public virtual ICollection<Personal> Personals { get; set; }
    }
}
