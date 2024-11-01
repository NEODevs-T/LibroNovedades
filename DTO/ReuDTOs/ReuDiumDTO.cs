using System;
using System.Collections.Generic;

namespace ReunionDiaria.DTOs;


public partial class ReuDiumDTO
{
    public int IdReuDia { get; set; }

    public int? IdMaster { get; set; }

    public int IdEmpresa { get; set; }

    public int IdResReu { get; set; }

    public int Idksf { get; set; }

    public string? Rdcentro { get; set; }

    public string? Rddiv { get; set; }

    public string? Rdarea { get; set; }

    public string? RdcodEq { get; set; }

    public string? Rddisc { get; set; }

    public string? RdcodDis { get; set; }

    public string? RdplanAcc { get; set; }

    public double? Rdtiempo { get; set; }

    public string? Rdstatus { get; set; }

    public string? Rdodt { get; set; }

    public string? RdnumDis { get; set; }

    public DateOnly? RdfecReu { get; set; }

    public DateOnly? RdfecTra { get; set; }

    public string? Rdobs { get; set; }

    public DateOnly? RdfecCrea { get; set; }
}