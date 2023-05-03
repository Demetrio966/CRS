using System;
using System.Collections.Generic;

namespace DCONTEXCRS.DbContex;

public partial class SegTipoUsuario
{
    public int IdTipoUsuario { get; set; }

    public int IdEmpresa { get; set; }

    public int IdPermisos { get; set; }

    public string? TipoUsuario { get; set; }

    public int? IdUsuarioRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdUsuarioActualizado { get; set; }

    public DateTime? FechaActualizado { get; set; }
}
