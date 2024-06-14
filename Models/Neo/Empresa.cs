﻿using System;
using System.Collections.Generic;

namespace LibroNovedades.Models.Neo
{
    public partial class Empresa
    {
        public Empresa()
        {
            Masters = new HashSet<Master>();
        }

        public int IdEmpresa { get; set; }
        public string Enombre { get; set; } = null!;
        public string? Edescri { get; set; }
        public bool Eestado { get; set; }
        public int IdCompania { get; set; }
        public DateTime Efecha { get; set; }

        public virtual ICollection<Master> Masters { get; set; }
    }
}