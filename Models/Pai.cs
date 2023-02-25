using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Pai
    {
        public Pai()
        {
            Empresas = new HashSet<Empresa>();
            ReuDia = new HashSet<ReuDium>();
        }

        public int IdPais { get; set; }
        public string Pnombre { get; set; } = null!;
        public bool Pestado { get; set; }

        public virtual ICollection<Empresa> Empresas { get; set; }
        public virtual ICollection<ReuDium> ReuDia { get; set; }
    }
}
