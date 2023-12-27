using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// Para guardar registros impresos de salida en Puerta 1
    /// </summary>
    public partial class RegSaPtpcp
    {
        public int IdRegSal { get; set; }
        /// <summary>
        /// Fecha de Salida
        /// </summary>
        public DateTime Rsdate { get; set; }
        /// <summary>
        /// Numero de Ticket Salida
        /// </summary>
        public int? RstickeSal { get; set; }
        /// <summary>
        /// Placa de vehiculo
        /// </summary>
        public string RsplacaVeh { get; set; } = null!;
        /// <summary>
        /// Empresa vehiculo
        /// </summary>
        public string RscompVeh { get; set; } = null!;
        /// <summary>
        /// Hora de Entrada
        /// </summary>
        public double? RshoraEnt { get; set; }
        /// <summary>
        /// Hora de Salida
        /// </summary>
        public double? RshoraSal { get; set; }
        /// <summary>
        /// Observacion
        /// </summary>
        public string Rsobs { get; set; } = null!;
        /// <summary>
        /// Destino de la Unidad
        /// </summary>
        public string? Rsdest { get; set; }
        /// <summary>
        /// Detalles de la unidad
        /// </summary>
        public string? Rsdetalle { get; set; }
        /// <summary>
        /// Observacion Hecha en BPCS
        /// </summary>
        public string? RsobsSist { get; set; }
    }
}
