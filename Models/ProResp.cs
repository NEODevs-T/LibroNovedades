using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class ProResp
    {
        public int IdProResp { get; set; }
        public int IdRspnsblP { get; set; }
        public int IdProyecMc { get; set; }

        public virtual ProMejCont IdProyecMcNavigation { get; set; } = null!;
        public virtual RspnsblP IdRspnsblPNavigation { get; set; } = null!;
    }
}
