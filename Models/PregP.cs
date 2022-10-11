using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// preguntas de satisfaccion
    /// </summary>
    public partial class PregP
    {
        public PregP()
        {
            RespPs = new HashSet<RespP>();
        }

        /// <summary>
        /// identificador de la pregunta
        /// </summary>
        public int IdPregP { get; set; }
        /// <summary>
        /// pregunta de la encuesta
        /// </summary>
        public string Ppnombre { get; set; } = null!;
        /// <summary>
        /// (0:no tiene observacion,1: tiene observacion)
        /// </summary>
        public bool PpisObser { get; set; }
        /// <summary>
        /// estatus(0:inactivo,1:activo)
        /// </summary>
        public bool Ppestatus { get; set; }

        public virtual ICollection<RespP> RespPs { get; set; }
    }
}
