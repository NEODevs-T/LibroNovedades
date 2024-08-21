using System;
using System.Collections.Generic;

namespace Maestra.DTOs;

public class LineaVDTO
{
    public int IdDivision { get; set; }

    public int IdLinea { get; set; }

    public string Linea { get; set; } = null!;

    public bool Estado { get; set; }
}