using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class Operador
    {
        /// <summary>
        /// identificador
        /// </summary>
        public int IdOperador { get; set; }
        /// <summary>
        /// ficha del operador
        /// </summary>
        public string Opficha { get; set; } = null!;
        /// <summary>
        /// nombre del operador		
        /// </summary>
        public string Opnombre { get; set; } = null!;
        /// <summary>
        /// apellido del operador		
        /// </summary>
        public string? Opapellido { get; set; }
        /// <summary>
        /// fecha de nacimiento		
        /// </summary>
        public DateTime? OpfechaNac { get; set; }
        /// <summary>
        /// fecha de ingreso		
        /// </summary>
        public DateTime? OpfechaIng { get; set; }
        /// <summary>
        /// 0: Inactivo, 1:Activo		
        /// </summary>
        public bool Opestado { get; set; }
    }
}
