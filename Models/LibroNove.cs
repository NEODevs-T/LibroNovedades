using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LibroNovedades.Validate;

namespace LibroNovedades.Models
{
    public partial class LibroNove
    {
        public int IdReuDia { get; set; }

        [ValidDiferenteACero]
        public int IdLinea { get; set; }
        [Required(ErrorMessage ="Coloque el id de equipo afectado.")]
        public string IdEquipo { get; set; } = null!;
        [Required(ErrorMessage ="Coloque la novedad.")] 
        public string Rddiscrepa { get; set; } = null!;

        //TODO: falta este campo
        [Required(ErrorMessage ="Coloque el tiempo perdido en minutos.")]
        public double RdtiePerMi { get; set; }

        [Required(ErrorMessage ="Coloque su ficha.")]
        public string RdfichaRes { get; set; } = null!;
        public DateTime Rdfecha { get; set; }
        [ValidDiferenteACero]
        public string Rdgrupo { get; set; } = null!;
        [ValidDiferenteACero]
        public string RdTurno { get; set; } = null!;

        [Required(ErrorMessage ="Coloque el id de la maquina.")]
        public string IdMaquina { get; set; } = null!;
        //TODO: falta este campo
        [Required(ErrorMessage ="Coloque el tipo de novedad.")]
        public int IdTipoNove { get; set; }

        [Required(ErrorMessage ="Coloque el area a la que pertenece.")]
        public int IdAreaCar { get; set; }
        public virtual Area IdAreaCarNavigation { get; set; } = null!;
        public virtual Linea IdLineaNavigation { get; set; } = null!;
    }
}
