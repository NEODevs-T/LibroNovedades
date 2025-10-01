using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using LibroNovedades.Validate;
using LibroNovedades.Resources;

namespace LibroNovedades.DTOs;

public class LibroNoveDTO
{
    public int IdlibrNov { get; set; }
    // [ValidDiferenteACero]
    public int IdLinea { get; set; }
    [Required(
        ErrorMessageResourceType = typeof(ValidationMessages),
        ErrorMessageResourceName = "RequiredEquipment")]
    public string IdEquipo { get; set; } = null!;
    [ValidDiscrepancia]
    public string Lndiscrepa { get; set; }
    // [ValidMayorACero]
    public double LntiePerMi { get; set; }
    [Required(
        ErrorMessageResourceType = typeof(ValidationMessages),
        ErrorMessageResourceName = "RequiredSheet")]
    public string LnfichaRes { get; set; } = null!;
    public DateTime Lnfecha { get; set; }
    [ValidDiferenteACero, StringLength(1, ErrorMessage = "Se debe poner un único carácter. / Only a single character must be entered.")]
    public string Lngrupo { get; set; } = null!;
    [ValidTurno, StringLength(1, ErrorMessage = "Se debe poner un único carácter. / Only a single character must be entered.")]
    public string Lnturno { get; set; } = null!;
    public int IdPais { get; set; }

    public int IdTipoNove { get; set; }
    // [Required(ErrorMessage = "Coloque el area a la que pertenece.")]
    public int IdAreaCar { get; set; }
    public string? Lnobserv { get; set; }
    public string? IdParada { get; set; }
    public int? TipoReu { get; set; }
    public bool LnisPizUni { get; set; }
    [ValidDiferenteACero]
    public int IdCtpm { get; set; }
    public int? LnisResu { get; set; }
    public int IdMaster { get; set; } = 0;
    public string? LnfichSupe { get; set; }
    public string? Linea { get; set; } = null!;
    public string? AreaCarga { get; set; } = null!;
    public void Deconstruct(out int idLinea, out string idEquipo, out DateTime lnfecha, out bool lnisPizUni)
    {
        idLinea = this.IdLinea;
        idEquipo = this.IdEquipo;
        lnfecha = this.Lnfecha;
        lnisPizUni = this.LnisPizUni;
    }
}
