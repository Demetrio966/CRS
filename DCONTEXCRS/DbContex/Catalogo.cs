using System;
using System.Collections.Generic;

namespace DCONTEXCRS.DbContex;

public partial class Catalogo
{
    public int? IdCatalogo { get; set; }

    public int? IdEmpresa { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public int? IdUsuarioRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int IdUsuarioActualizado { get; set; }

    public DateTime FechaActualizado { get; set; }
}
