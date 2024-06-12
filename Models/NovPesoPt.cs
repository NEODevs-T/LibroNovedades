using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    /// <summary>
    /// Para guardar acciones o novedades en unidades con diferencia de peso en Distribucion y despacho
    /// </summary>
    public partial class NovPesoPt
    {
        public int IdNovPt { get; set; }
        /// <summary>
        /// Placa de Unidad
        /// </summary>
        public string Npplaca { get; set; } = null!;
        /// <summary>
        /// Peso según factura
        /// </summary>
        public double NppesoFact { get; set; }
        /// <summary>
        /// Peso según Romana
        /// </summary>
        public double NppesoRom { get; set; }
        /// <summary>
        /// Diferencia de Peso Factura vs Romana
        /// </summary>
        public double NpdifPeso { get; set; }
        /// <summary>
        /// Diferencia en Porcentaje de Peso Factura vs Romana
        /// </summary>
        public double NpdifPorc { get; set; }
        /// <summary>
        /// Fecha de Diferencia
        /// </summary>
        public string NpdateDif { get; set; } = null!;
        /// <summary>
        /// Fecha de Registro
        /// </summary>
        public string NpdateReg { get; set; } = null!;
        /// <summary>
        /// Registro de Autorizacion y usuario BPCS
        /// </summary>
        public string Npautoriza { get; set; } = null!;
        /// <summary>
        /// Empresa Transportista
        /// </summary>
        public string Npempresa { get; set; } = null!;
        /// <summary>
        /// Tipo de Vehiculo con Error
        /// </summary>
        public string NptipVech { get; set; } = null!;
        /// <summary>
        /// Capacidad del Vehiculo
        /// </summary>
        public int? Npcapacity { get; set; }
        /// <summary>
        /// Plan de Accion Tomado
        /// </summary>
        public string? NpplanAcc { get; set; }
    }
}
