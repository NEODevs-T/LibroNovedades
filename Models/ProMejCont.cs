using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class ProMejCont
    {
        public ProMejCont()
        {
            ProResps = new HashSet<ProResp>();
        }

        public int IdProyecMc { get; set; }
        public int IdTipSol { get; set; }
        public int Pmccorrela { get; set; }
        public string Pmcobjetiv { get; set; } = null!;
        public string Pmcalcance { get; set; } = null!;
        public string Pmcsolcita { get; set; } = null!;
        public string Pmcreque { get; set; } = null!;
        public string PmctiemEst { get; set; } = null!;
        public string Pmcrevisor { get; set; } = null!;
        public DateTime PmcfechVer { get; set; }
        public int Pmcver { get; set; }
        public string PmcdesVer { get; set; } = null!;
        public string Pmcgaranti { get; set; } = null!;
        public string Pmcaprobad { get; set; } = null!;
        public DateTime PmcfechApr { get; set; }

        public virtual TipSolicit IdTipSolNavigation { get; set; } = null!;
        public virtual ICollection<ProResp> ProResps { get; set; }
    }
}
