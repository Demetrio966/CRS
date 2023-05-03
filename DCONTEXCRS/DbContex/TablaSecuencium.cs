using System;
using System.Collections.Generic;

namespace DCONTEXCRS.DbContex;

public partial class TablaSecuencium
{
    public int IdSecuencia { get; set; }

    public int IdEmpresa { get; set; }

    public string? NombreTabla { get; set; }

    public int? Secuencia { get; set; }

    public int? IdUsuarioRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdUsuarioActualizado { get; set; }

    public DateTime? FechaActualizado { get; set; }
}
