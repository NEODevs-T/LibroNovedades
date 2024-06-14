﻿using System;
using System.Collections.Generic;

namespace LibroNovedades.Models.Neo
{
    public partial class ReuDium
    {
        public ReuDium()
        {
            CambFecs = new HashSet<CambFec>();
            CambStats = new HashSet<CambStat>();
        }

        public int IdReuDia { get; set; }
        public int? IdMaster { get; set; }
        public int IdEmpresa { get; set; }
        public int IdResReu { get; set; }
        public int Idksf { get; set; }
        public string? Rdcentro { get; set; }
        public string? Rddiv { get; set; }
        public string? Rdarea { get; set; }
        public string? RdcodEq { get; set; }
        public string? Rddisc { get; set; }
        public string? RdcodDis { get; set; }
        public string? RdplanAcc { get; set; }
        public double? Rdtiempo { get; set; }
        public string? Rdstatus { get; set; }
        public string? Rdodt { get; set; }
        public string? RdnumDis { get; set; }
        public DateTime? RdfecReu { get; set; }
        public DateTime? RdfecTra { get; set; }
        public string? Rdobs { get; set; }
        public DateTime? RdfecCrea { get; set; }

        public virtual ICollection<CambFec> CambFecs { get; set; }
        public virtual ICollection<CambStat> CambStats { get; set; }
    }
}
