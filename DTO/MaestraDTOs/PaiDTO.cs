using System;
using System.Collections.Generic;

namespace Maestra.DTOs;

public class PaiDTO
{
    public int IdPais { get; set; }

    public string Pnombre { get; set; } = null!;

    public bool Pestado { get; set; }

    public DateTime Pfecha { get; set; }

}