using System;
using System.Collections.Generic;

namespace Maestra.DTOs;

public partial class LineaVDTO
{
    public int IdDivision { get; set; }

    public int IdLinea { get; set; }

    public string Linea { get; set; } = null!;

    public string LcenCos { get; set; } = null!;

    public int IdMaster { get; set; }

    public bool Estado { get; set; }
}
