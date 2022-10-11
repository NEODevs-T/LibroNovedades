using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// Respuesta de las preguntas por proyectos
    /// </summary>
    public partial class RespP
    {
        /// <summary>
        /// Identificador de la respuesta del proyecto
        /// </summary>
        public int IdRespP { get; set; }
        /// <summary>
        /// identificador de la pregunta del proyecto
        /// </summary>
        public int IdPregP { get; set; }
        /// <summary>
        /// identificador del proyecto
        /// </summary>
        public int IdProyecto { get; set; }
        /// <summary>
        /// nota de la pregunta
        /// </summary>
        public double Rpcumpli { get; set; }
        /// <summary>
        /// observacion de la pregunta
        /// </summary>
        public string? Rpobserv { get; set; }

        public virtual PregP IdPregPNavigation { get; set; } = null!;
        public virtual Proyecto IdProyectoNavigation { get; set; } = null!;
    }
}
