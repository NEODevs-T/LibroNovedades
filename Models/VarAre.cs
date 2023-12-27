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
        public int IdParProdu { get; set; }

        public virtual ParProdu IdParProduNavigation { get; set; } = null!;
        public virtual VarCa IdVarCaNavigation { get; set; } = null!;
    }
}
