using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// historico de auditorias de calidad
    /// </summary>
    public partial class AudCa
    {
        public AudCa()
        {
            DatAudCas = new HashSet<DatAudCa>();
        }

        /// <summary>
        /// Identificador de la auditoria de calidad
        /// </summary>
        public int IdAudCa { get; set; }
        /// <summary>
        /// identificador del tecnico
        /// </summary>
        public int IdTecniCa { get; set; }
        /// <summary>
        /// identificador del area
        /// </summary>
        public int IdArea { get; set; }
        /// <summary>
        /// codigo del producto
        /// </summary>
        public string AccodiPro { get; set; } = null!;
        /// <summary>
        /// ficha del supervisor
        /// </summary>
        public string AcficSuper { get; set; } = null!;
        /// <summary>
        /// ficha del operador
        /// </summary>
        public string AcficOper { get; set; } = null!;
        /// <summary>
        /// fecha de la auditoria
        /// </summary>
        public DateTime Acfecha { get; set; }
        /// <summary>
        /// grupo de la auditoria
        /// </summary>
        public string Acgrupo { get; set; } = null!;
        /// <summary>
        /// turno de la aditoria
        /// </summary>
        public string Acturno { get; set; } = null!;
        /// <summary>
        /// observaciones dispuestas en la auditoria
        /// </summary>
        public string Acobserv { get; set; } = null!;
        /// <summary>
        /// 0: No es un cambio de producto; 1: cambio de producto
        /// </summary>
        public bool AcisCamPro { get; set; }
        /// <summary>
        /// 0: auditoria operador, 1: tecnico de calidad
        /// </summary>
        public bool AcisTecn { get; set; }
        /// <summary>
        /// lote del producto
        /// </summary>
        public string? Aclote { get; set; }
        /// <summary>
        /// presentacion del producto
        /// </summary>
        public string? Acpresentacion { get; set; }

        public virtual LinAre IdAreaNavigation { get; set; } = null!;
        public virtual TecniCa IdTecniCaNavigation { get; set; } = null!;
        public virtual ICollection<DatAudCa> DatAudCas { get; set; }
    }
}
