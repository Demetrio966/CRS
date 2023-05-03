using System;
using System.Collections.Generic;

namespace DCONTEXCRS.DbContex;

public partial class CrsOecdCorrDoc
{
    public string IdCorrDoc { get; set; } = null!;

    public string IdCrsCuerpo { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public string? AccountNumber { get; set; }

    public string? AcctNumberType { get; set; }

    public string? UndocumentedAccount { get; set; }

    public string? ClosedAccount { get; set; }

    public string? PreexistingAccount { get; set; }

    public string? DormantAccount { get; set; }

    public string? ResCountryCode { get; set; }

    public string? Tin { get; set; }

    public string? IssuedBy { get; set; }

    public string? NameType { get; set; }

    public string? FirstName { get; set; }

    public string? XnlNameType1 { get; set; }

    public string? MiddleName { get; set; }

    public string? XnlNameType2 { get; set; }

    public string? LastName { get; set; }

    public string? XnlNameType3 { get; set; }

    public string? LegalAddressType { get; set; }

    public string? CountryCode1 { get; set; }

    public string? Street { get; set; }

    public string? PostCode { get; set; }

    public string? City { get; set; }

    public string? CountryCode2 { get; set; }

    public decimal? AccountBalance { get; set; }

    public string? CurrCode1 { get; set; }

    public string? Type { get; set; }

    public decimal? PaymentAmnt { get; set; }

    public string? CurrCode2 { get; set; }

    public int? IdUsuarioRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdUsuarioActualizado { get; set; }

    public DateTime? FechaActualizado { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
}
