using System;
using System.Collections.Generic;

namespace DCONTEXCRS.DbContex;

public partial class SegMenu
{
    public int IdMenu { get; set; }

    public int IdSubMenu { get; set; }

    public int IdEmpresa { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? IdUsuarioRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdUsuarioActualizado { get; set; }

    public DateTime? FechaActualizado { get; set; }
}
