using System;
using System.Collections.Generic;

namespace LibroNovedades.DTOs;

public class ParadasActualesDTO
{
    public string CodigoRegistro { get; set; } = "";
    public string CodigoGrupoParada { get; set; } = "";
    public string NombreParada { get; set; } = "";
    public double TiempoPerdido { get; set; } = 0;
    public string ParteNombre { get; set; } = "";
    public string CodigoParte { get; set; } = "";
}