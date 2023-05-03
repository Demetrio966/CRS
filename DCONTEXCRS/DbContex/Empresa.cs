using System;
using System.Collections.Generic;

namespace DCONTEXCRS.DbContex;

public partial class Empresa
{
    public int IdEmpresa { get; set; }

    public string? Nombre { get; set; }

    public string? Ruc { get; set; }

    public int? IdPersonaRepresentate { get; set; }

    public string? Telefono { get; set; }

    public string? Pais { get; set; }

    public string? Direccion { get; set; }

    public string? LogoTipo { get; set; }

    public int? IdUsuarioRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdUsuarioActualizado { get; set; }

    public DateTime? FechaActualizado { get; set; }

    public virtual ICollection<CrsOecdCuerpo> CrsOecdCuerpos { get; set; } = new List<CrsOecdCuerpo>();

    public virtual ICollection<CrsOecdEncabezado> CrsOecdEncabezados { get; set; } = new List<CrsOecdEncabezado>();

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
