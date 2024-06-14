using System;
using System.Collections.Generic;

namespace LibroNovedades.Models.Neo
{
    public partial class Division
    {
        public Division()
        {
            Masters = new HashSet<Master>();
        }

        public int IdDivision { get; set; }
        public string Dnombre { get; set; } = null!;
        public string? Ddetalle { get; set; }
        public bool Destado { get; set; }
        public DateTime Dfecha { get; set; }

        public virtual ICollection<Master> Masters { get; set; }
    }
}
