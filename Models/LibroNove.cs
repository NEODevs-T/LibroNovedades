// using System;
// using System.Collections.Generic;

// namespace LibroNovedades.Models
// {
//     public partial class LibroNove
//     {
//         public int IdlibrNov { get; set; }
//         public int IdLinea { get; set; }
//         public string IdEquipo { get; set; } = null!;
//         public string Lndiscrepa { get; set; } = null!;
//         public double LntiePerMi { get; set; }
//         public string LnfichaRes { get; set; } = null!;
//         public DateTime Lnfecha { get; set; }
//         public string Lngrupo { get; set; } = null!;
//         public string Lnturno { get; set; } = null!;
//         public string IdMaquina { get; set; } = null!;
//         public int IdTipoNove { get; set; }
//         public int IdAreaCar { get; set; }
//         public string? Lnobserv { get; set; }
//         public string? IdParada { get; set; }
//         public bool LnisPizUni { get; set; }
//         public int? IdCtpm { get; set; }
//         public int? LnisResu { get; set; }

//         public virtual Centro IdAreaCarNavigation { get; set; } = null!;
//         public virtual ClasifiTpm? IdCtpmNavigation { get; set; }
//         public virtual Linea IdLineaNavigation { get; set; } = null!;
//         public virtual TiParTp IdTipoNoveNavigation { get; set; } = null!;
//     }
// }

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LibroNovedades.Validate;

namespace LibroNovedades.Models
{
    public partial class LibroNove
    {
        public int IdlibrNov { get; set; }
        [ValidDiferenteACero]
        public int IdLinea { get; set; }
        [Required(ErrorMessage ="Coloque el id de equipo afectado.")]
        public string IdEquipo { get; set; } = null!;
        [Required(ErrorMessage ="Coloque la novedad.")] 
        public string Lndiscrepa { get; set; } = null!;
        [ValidDiferenteACero]
        public double LntiePerMi { get; set; }
        [Required(ErrorMessage ="Coloque su ficha.")]
        public string LnfichaRes { get; set; } = null!;
        public DateTime Lnfecha { get; set; }
        [ValidDiferenteACero]
        public string Lngrupo { get; set; } = null!;
        [ValidDiferenteACero]
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

        public int? IdCtpm { get; set; }
        public int? LnisResu { get; set; }

        public virtual Centro IdAreaCarNavigation { get; set; } = null!;
        public virtual ClasifiTpm? IdCtpmNavigation { get; set; }
        public virtual Linea IdLineaNavigation { get; set; } = null!;
        public virtual TiParTp IdTipoNoveNavigation { get; set; } = null!;
    }
}
