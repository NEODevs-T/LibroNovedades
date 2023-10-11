using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            Centros = new HashSet<Centro>();
            Planta = new HashSet<Plantum>();
        }

        public int IdEmpresa { get; set; }
        public int IdPais { get; set; }
        public string Enombre { get; set; } = null!;
        public string? Edescri { get; set; }
        public bool Eestado { get; set; }

        public virtual Pai IdPaisNavigation { get; set; } = null!;
        public virtual ICollection<Centro> Centros { get; set; }
        public virtual ICollection<Plantum> Planta { get; set; }
        public virtual ICollection<ReuDium> ReuDia { get; set; }
    }
}
