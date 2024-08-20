using System;
using System.Collections.Generic;

namespace NeoAPI.DTOs.Maestra;

public class LineaVDTO
{
    public int IdDivision { get; set; }

    public int IdLinea { get; set; }

    public string Linea { get; set; } = null!;

    public bool Estado { get; set; }
}