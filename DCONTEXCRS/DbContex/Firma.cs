using System;
using System.Collections.Generic;

namespace DCONTEXCRS.DbContex;

public partial class Firma
{
    public int? IdFirma { get; set; }

    public int? IdPersona { get; set; }

    public int? IdEmpresa { get; set; }

    public string? Ruta { get; set; }

    public int? IdUsuarioRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdUsuarioActualizado { get; set; }

    public DateTime? FechaActualizado { get; set; }

    public virtual Empresa? IdEmpresaNavigation { get; set; }
}
