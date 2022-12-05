using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class ProyectoUsr
    {
        public ProyectoUsr()
        {
            Nivels = new HashSet<Nivel>();
        }

        public int IdProyecto { get; set; }
        public string Pnombre { get; set; } = null!;
        public bool Pestado { get; set; }

        public virtual ICollection<Nivel> Nivels { get; set; }
    }
}
