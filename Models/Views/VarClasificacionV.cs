﻿using System;
using System.Collections.Generic;

namespace LibroNovedades.Models.Neo.Views;

public partial class VarClasificacionV
{
    public int IdMaster { get; set; }

    public int IdLinea { get; set; }

    public int IdClasiVar { get; set; }

    public string Clasificacion { get; set; } = null!;

    public bool Estado { get; set; }
}
