using System;
using System.Collections.Generic;

namespace DCONTEXCRS.DbContex;

public partial class Persona
{
    public int IdPersona { get; set; }

    public int IdEmpresa { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public int? IdUsuarioRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdUsuarioActualizado { get; set; }

    public DateTime? FechaActualizado { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
}
