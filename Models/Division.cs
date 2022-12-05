using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Division
    {
        public Division()
        {
            Lineas = new HashSet<Linea>();
            Nivels = new HashSet<Nivel>();
        }

        public int IdDivision { get; set; }
        public int? IdCentro { get; set; }
        public string? Dnombre { get; set; }
        public string? Ddetalle { get; set; }
        public bool? Destado { get; set; }

        public virtual Centro? IdCentroNavigation { get; set; }
        public virtual ICollection<Linea> Lineas { get; set; }
        public virtual ICollection<Nivel> Nivels { get; set; }
    }
}
