using System;
using System.Collections.Generic;

namespace DCONTEXCRS.DbContex;

public partial class CrsOecdEncabezado
{
    public int IdCrsEncabezado { get; set; }

    public int? IdEmpresa { get; set; }

    public string? SendingCompanyIn { get; set; }

    public string TransmittingCountry { get; set; } = null!;

    public string? ReceivingCountry { get; set; }

    public string MessageType { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string MessageRefId { get; set; } = null!;

    public string MessageTypeIndic { get; set; } = null!;

    public DateTime ReportingPeriod { get; set; }

    public int? IdUsuarioRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdUsuarioActualizado { get; set; }

    public DateTime? FechaActualizado { get; set; }

    public virtual Empresa? IdEmpresaNavigation { get; set; }
}
