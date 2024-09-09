using System;
using System.Collections.Generic;

namespace Maestra.DTOs;

public partial class CentrosVDTO
{
    public int IdEmpresa { get; set; }

    public int IdCentro { get; set; }

    public string Centro { get; set; } = null!;

    public bool Estado { get; set; }
}
