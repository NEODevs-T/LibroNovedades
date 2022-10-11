using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// variable de calidad auditadas
    /// </summary>
    public partial class VarCa
    {
        public VarCa()
        {
            DatAudCas = new HashSet<DatAudCa>();
            VarAres = new HashSet<VarAre>();
        }

        /// <summary>
        /// identificador de la variable de calidad
        /// </summary>
        public int IdVarCa { get; set; }
        /// <summary>
        /// nombre de la variable
        /// </summary>
        public string Vcnom { get; set; } = null!;
        /// <summary>
        /// Detalle de la variable
        /// </summary>
        public string? Vcdetalle { get; set; }
        /// <summary>
        /// 0: no de tipo observable 1:es de tipo numerico
        /// </summary>
        public bool Vcisobser { get; set; }
        /// <summary>
        /// 0: Inactivo, 1:Activo
        /// </summary>
        public bool Vcestado { get; set; }

        public virtual ICollection<DatAudCa> DatAudCas { get; set; }
        public virtual ICollection<VarAre> VarAres { get; set; }
    }
}
