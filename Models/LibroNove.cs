﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibroNovedades.Validate;

namespace LibroNovedades.Models
{
    public partial class LibroNove
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdlibrNov { get; set; }
        [ValidDiferenteACero]
        public int IdLinea { get; set; }
        [Required(ErrorMessage ="Coloque el id de equipo afectado.")]
        public string IdEquipo { get; set; } = null!;
        [Required(ErrorMessage ="Coloque la novedad."),StringLength(150,ErrorMessage="Alcanzo el limite de caracteres. Favor poner los detalles en las observacion")] 
        public string Lndiscrepa { get; set; } = null!;
        [ValidMayorACero]
        public double LntiePerMi { get; set; }
        [Required(ErrorMessage ="Coloque su ficha.")]
        public string LnfichaRes { get; set; } = null!;
        public DateTime Lnfecha { get; set; }
        [ValidDiferenteACero,StringLength(1,ErrorMessage="Se debe poner un único carácter")]
        public string Lngrupo { get; set; } = null!;
        [ValidTurno,StringLength(1,ErrorMessage="Se debe poner un único carácter")]
        public string Lnturno { get; set; } = null!;
        [Required(ErrorMessage ="Coloque el id de la maquina.")]
        public string IdMaquina { get; set; } = null!;
        [ValidDiferenteACero]
        public int IdTipoNove { get; set; }
        [Required(ErrorMessage ="Coloque el area a la que pertenece.")]
        public int IdAreaCar { get; set; }
        public string? Lnobserv { get; set; }
        public string? IdParada { get; set; }
        public bool LnisPizUni { get; set; }
        [ValidDiferenteACero]
        public int? IdCtpm { get; set; }
        public int? LnisResu { get; set; }

        public virtual AreaCarga IdAreaCarNavigation { get; set; } = null!;
        public virtual ClasifiTpm? IdCtpmNavigation { get; set; }
        public virtual Linea IdLineaNavigation { get; set; } = null!;
        public virtual TiParTp IdTipoNoveNavigation { get; set; } = null!;
    }
}
