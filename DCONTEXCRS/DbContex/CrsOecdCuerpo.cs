using System;
using System.Collections.Generic;

namespace DCONTEXCRS.DbContex;

public partial class CrsOecdCuerpo
{
    public int IdCrsCuerpo { get; set; }

    public int IdCrsEncabezado { get; set; }

    public int IdEmpresa { get; set; }

    public string? ResCountryCode { get; set; }

    public string? In { get; set; }

    public string? IssuedBy { get; set; }

    public string? Intype { get; set; }

    public string? Name { get; set; }

    public string? NameType { get; set; }

    public string? Address { get; set; }

    public string? CountryCode { get; set; }

    public string? AddressFree { get; set; }

    public string? DocTypeIndic1 { get; set; }

    public string? DocRefId1 { get; set; }

    public string? DocTypeIndic2 { get; set; }

    public string? DocRefId2 { get; set; }

    public int? IdUsuarioRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdUsuarioActualizado { get; set; }

    public DateTime? FechaActualizado { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
}
