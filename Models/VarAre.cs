using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// intermediario entre vareable de calidad y area
    /// </summary>
    public partial class VarAre
    {
        /// <summary>
        /// identificador de la Var_Are
        /// </summary>
        public int IdVarAre { get; set; }
        /// <summary>
        /// identificador de la variable de calidad
        /// </summary>
        public int IdVarCa { get; set; }
        /// <summary>
        /// identifiacador del area
        /// </summary>
        public int IdArea { get; set; }

        public virtual Area IdAreaNavigation { get; set; } = null!;
        public virtual VarCa IdVarCaNavigation { get; set; } = null!;
    }
}
