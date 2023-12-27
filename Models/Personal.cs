using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Personal
    {
        public Personal()
        {
            Plantillas = new HashSet<Plantilla>();
            Resumen = new HashSet<Resuman>();
        }

        public int IdPersonal { get; set; }
        public string? PeNombre { get; set; }
        public string? PeApellido { get; set; }
        public string? PeFicha { get; set; }
        public bool? PeEstado { get; set; }
        public string? PeGrupo { get; set; }

        public virtual ICollection<Plantilla> Plantillas { get; set; }
        public virtual ICollection<Resuman> Resumen { get; set; }
    }
}
