﻿using System;
using System.Collections.Generic;

namespace DCONTEXCRS.DbContex;

public partial class SegPermiso
{
    public int IdPermisos { get; set; }

    public int IdEmpresa { get; set; }

    public int IdModulo { get; set; }

    public string? NombrePermiso { get; set; }

    public int? IdUsuarioRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdUsuarioActualizado { get; set; }

    public DateTime? FechaActualizado { get; set; }
}
