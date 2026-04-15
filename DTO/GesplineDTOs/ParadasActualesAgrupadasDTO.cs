
using System;
using System.Collections.Generic;

namespace LibroNovedades.DTOs;
public class ParadasActualesAgrupadasDTO
{
    public string CodigoParada { get; set; } = "";
    public string CodigoGrupoParada { get; set; } = "";
    public string ACodGes { get; set; } = "";
    public string NombreParada { get; set; } = "";
    public string Aparte { get; set; } = "";
    public double TiempoPerdido { get; set; }  = 0;
}