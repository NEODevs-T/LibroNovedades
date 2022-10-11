using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// data de la auditoria
    /// </summary>
    public partial class DatAudCa
    {
        /// <summary>
        /// Identificador del dato
        /// </summary>
        public int IdDatAudCa { get; set; }
        /// <summary>
        /// identificador de la variable
        /// </summary>
        public int IdVarCa { get; set; }
        /// <summary>
        /// identificador de la auditoria
        /// </summary>
        public int IdAudCa { get; set; }
        /// <summary>
        /// valor observado
        /// </summary>
        public double Dacvalor { get; set; }
        /// <summary>
        /// 0: no aceptable, 1:aceptable
        /// </summary>
        public bool? DacisAcep { get; set; }

        public virtual AudCa IdAudCaNavigation { get; set; } = null!;
        public virtual VarCa IdVarCaNavigation { get; set; } = null!;
    }
}
