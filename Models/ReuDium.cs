using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class ReuDium
    {
        public ReuDium()
        {
            CambFecs = new HashSet<CambFec>();
            CambStats = new HashSet<CambStat>();
        }

        /// <summary>
        /// id tabla
        /// </summary>
        public int IdReuDia { get; set; }
        /// <summary>
        /// Id del pais
        /// </summary>
        public int IdPais { get; set; }
        public int IdResReu { get; set; }
        /// <summary>
        /// Id del afectado
        /// </summary>
        public int Idksf { get; set; }
        /// <summary>
        /// centro o planta
        /// </summary>
        public string? Rdcentro { get; set; }
        /// <summary>
        /// Division
        /// </summary>
        public string? Rddiv { get; set; }
        /// <summary>
        /// Lineas o maquinas.
        /// </summary>
        public string? Rdarea { get; set; }
        /// <summary>
        /// Codigo del equipo
        /// </summary>
        public string? RdcodEq { get; set; }
        /// <summary>
        /// Descripción de la discrepancia
        /// </summary>
        public string? Rddisc { get; set; }
        /// <summary>
        /// Codigo del estado de la discrepancia.
        /// </summary>
        public string? RdcodDis { get; set; }
        /// <summary>
        /// Plan de acción.
        /// </summary>
        public string? RdplanAcc { get; set; }
        /// <summary>
        /// Tiempo de reparación de la discrepancia.
        /// </summary>
        public string? Rdtiempo { get; set; }
        /// <summary>
        /// Estado de las discrepancia
        /// </summary>
        public string? Rdstatus { get; set; }
        /// <summary>
        /// orden de trabajo
        /// </summary>
        public string? Rdodt { get; set; }
        /// <summary>
        /// Correlativo de la discrepancia si es mayor a un dia
        /// </summary>
        public string? RdnumDis { get; set; }
        /// <summary>
        /// fecha de la discrepancia planteada en la reunion
        /// </summary>
        public DateTime? RdfecReu { get; set; }
        /// <summary>
        /// fecha planificada del trabajo.
        /// </summary>
        public DateTime? RdfecTra { get; set; }
        /// <summary>
        /// observación.
        /// </summary>
        public string? Rdobs { get; set; }

        public virtual Pai IdPaisNavigation { get; set; } = null!;
        public virtual RespoReu IdResReuNavigation { get; set; } = null!;
        public virtual Ksf IdksfNavigation { get; set; } = null!;
        public virtual ICollection<CambFec> CambFecs { get; set; }
        public virtual ICollection<CambStat> CambStats { get; set; }
    }
}
