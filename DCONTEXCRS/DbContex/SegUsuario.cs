using System;
using System.Collections.Generic;

namespace DCONTEXCRS.DbContex;

public partial class SegUsuario
{
    public int IdUsusario { get; set; }

    public int IdEmpresa { get; set; }

    public int IdTipoUsuario { get; set; }

    public int IdPersona { get; set; }

    public string? Ususario { get; set; }

    public string? Contrasena { get; set; }

    public string? Ip { get; set; }

    public int? IdUsuarioRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdUsuarioActualizado { get; set; }

    public DateTime? FechaActualizado { get; set; }
}
