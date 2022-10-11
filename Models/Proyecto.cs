using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// Proyecto de Mejora Continua
    /// </summary>
    public partial class Proyecto
    {
        public Proyecto()
        {
            RespPs = new HashSet<RespP>();
        }

        /// <summary>
        /// Identificador del proyecto
        /// </summary>
        public int IdProyecto { get; set; }
        /// <summary>
        /// identificador del cliente
        /// </summary>
        public int IdClienteP { get; set; }
        /// <summary>
        /// identificador del responsable
        /// </summary>
        public int IdRspnsblP { get; set; }
        /// <summary>
        /// fecha de la solicitud
        /// </summary>
        public DateTime PfechaS { get; set; }
        /// <summary>
        /// fecha de inicio del poyecto
        /// </summary>
        public DateTime? Pfechai { get; set; }
        /// <summary>
        /// fecha del cierre del proyecto
        /// </summary>
        public DateTime? PfechaC { get; set; }
        /// <summary>
        /// nombre del proyecto
        /// </summary>
        public string Pnombre { get; set; } = null!;
        /// <summary>
        /// detalle del proyecto
        /// </summary>
        public string? Pdetalle { get; set; }
        /// <summary>
        /// 0:no se ha realizado la encuesta, 1: se realizo
        /// </summary>
        public bool PisEncue { get; set; }
        /// <summary>
        /// nota de la encuesta
        /// </summary>
        public double? Pnota { get; set; }
        /// <summary>
        /// fecha programada
        /// </summary>
        public DateTime? PfechaP { get; set; }

        public virtual ClienteP IdClientePNavigation { get; set; } = null!;
        public virtual RspnsblP IdRspnsblPNavigation { get; set; } = null!;
        public virtual ICollection<RespP> RespPs { get; set; }
    }
}
