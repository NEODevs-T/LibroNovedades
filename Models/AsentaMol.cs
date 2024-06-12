using System;
using System.Collections.Generic;

namespace LibroNovedades.Models
{
    public partial class AsentaMol
    {
        public DateTime Amfecha { get; set; }
        public string Amturno { get; set; } = null!;
        public string Amgrupo { get; set; } = null!;
        public string Amficha { get; set; } = null!;
        public string Amarea { get; set; } = null!;
        public string AmcodPro { get; set; } = null!;
        public string Amcategor { get; set; } = null!;
        public string Amvariable { get; set; } = null!;
        public string Amunid { get; set; } = null!;
        public double Ammin { get; set; }
        public double Ammax { get; set; }
        public double Amvalor { get; set; }
        /// <summary>
        /// 1 es asentamientos de proceso, 2 asentamientos de maquina
        /// </summary>
        public int Amtip { get; set; }
    }
}
