using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LibroNovedades.Models.Neo;
using LibroNovedades.Validate;

namespace LibroNovedades.DTOs;

public class LibroNoveDTO
{
    public int IdlibrNov { get; set; }

    [ValidDiferenteACero]
    public int IdLinea { get; set; }

    [Required(ErrorMessage = "Coloque el id de equipo afectado.")]
    public string IdEquipo { get; set; } = null!;

    [Required(ErrorMessage = "Coloque la novedad."), StringLength(150, ErrorMessage = "Alcanzo el limite de caracteres. Favor poner los detalles en las observacion")]
    public string Lndiscrepa { get; set; } = null!;

    [ValidMayorACero]
    public int LntiePerMi { get; set; }

    [Required(ErrorMessage = "Coloque su ficha.")]
    public string LnfichaRes { get; set; } = null!;

    public DateTime Lnfecha { get; set; }

    [ValidDiferenteACero, StringLength(1, ErrorMessage = "Se debe poner un único carácter")]
    public string Lngrupo { get; set; } = null!;

    [ValidTurno, StringLength(1, ErrorMessage = "Se debe poner un único carácter")]
    public string Lnturno { get; set; } = null!;

    [ValidDiferenteACero]
    public int IdTipoNove { get; set; }

    [Required(ErrorMessage = "Coloque el area a la que pertenece.")]
    public int IdAreaCar { get; set; }

    public string? Lnobserv { get; set; }

    public string? IdParada { get; set; }

    public bool LnisPizUni { get; set; }

    [ValidDiferenteACero]
    public int IdCtpm { get; set; }

    public int? LnisResu { get; set; }

    public int IdMaster { get; set; } = 0;



    public virtual Master? IdMasterNavigation { get; set; } = null;

    public virtual AreaCarga? IdAreaCarNavigation { get; set; } = null;

    public void Deconstruct(out int idLinea, out string idEquipo, out DateTime lnfecha, out bool lnisPizUni)
    {
        idLinea = this.IdLinea;
        idEquipo = this.IdEquipo;
        lnfecha = this.Lnfecha;
        lnisPizUni = this.LnisPizUni;
    }
}
