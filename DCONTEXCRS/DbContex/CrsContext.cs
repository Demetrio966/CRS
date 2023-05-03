using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DCONTEXCRS.DbContex;

public partial class CrsContext : DbContext
{
    public CrsContext()
    {
    }

    public CrsContext(DbContextOptions<CrsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Catalogo> Catalogos { get; set; }

    public virtual DbSet<CrsOecdCorrDoc> CrsOecdCorrDocs { get; set; }

    public virtual DbSet<CrsOecdCuerpo> CrsOecdCuerpos { get; set; }

    public virtual DbSet<CrsOecdEncabezado> CrsOecdEncabezados { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Firma> Firmas { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<SegMenu> SegMenus { get; set; }

    public virtual DbSet<SegModulo> SegModulos { get; set; }

    public virtual DbSet<SegOpcione> SegOpciones { get; set; }

    public virtual DbSet<SegPermiso> SegPermisos { get; set; }

    public virtual DbSet<SegSubMenu> SegSubMenus { get; set; }

    public virtual DbSet<SegTipoUsuario> SegTipoUsuarios { get; set; }

    public virtual DbSet<SegUsuario> SegUsuarios { get; set; }

    public virtual DbSet<TablaSecuencium> TablaSecuencia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=LAPTOP-3NFRODC1; Database=CRS;User Id=sa;Password=1234;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Catalogo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("catalogo");

            entity.Property(e => e.Codigo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaActualizado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
        });

        modelBuilder.Entity<CrsOecdCorrDoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("crs_oecd_corr_doc");

            entity.Property(e => e.AccountBalance).HasColumnType("money");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AcctNumberType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClosedAccount)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CountryCode1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CountryCode_1");
            entity.Property(e => e.CountryCode2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CountryCode_2");
            entity.Property(e => e.CurrCode1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("currCode_1");
            entity.Property(e => e.CurrCode2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("currCode_2");
            entity.Property(e => e.DormantAccount)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaActualizado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdCorrDoc)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdCrsCuerpo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IssuedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("issuedBy");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LegalAddressType)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("legalAddressType");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NameType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nameType");
            entity.Property(e => e.PaymentAmnt).HasColumnType("money");
            entity.Property(e => e.PostCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PreexistingAccount)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ResCountryCode)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Street)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Tin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIN");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UndocumentedAccount)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.XnlNameType1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("xnlNameType_1");
            entity.Property(e => e.XnlNameType2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("xnlNameType_2");
            entity.Property(e => e.XnlNameType3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("xnlNameType_3");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany()
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("crs_oecd_corr_docConstraint");
        });

        modelBuilder.Entity<CrsOecdCuerpo>(entity =>
        {
            entity.HasKey(e => e.IdCrsCuerpo);

            entity.ToTable("crs_oecd_cuerpo");

            entity.Property(e => e.IdCrsCuerpo).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AddressFree)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DocRefId1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DocRefId_1");
            entity.Property(e => e.DocRefId2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DocRefId_2");
            entity.Property(e => e.DocTypeIndic1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DocTypeIndic_1");
            entity.Property(e => e.DocTypeIndic2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DocTypeIndic_2");
            entity.Property(e => e.FechaActualizado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.In)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN");
            entity.Property(e => e.Intype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("INType");
            entity.Property(e => e.IssuedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("issuedBy");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NameType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nameType");
            entity.Property(e => e.ResCountryCode)
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.CrsOecdCuerpos)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("crs_oecd_cuerpo_docConstraint");
        });

        modelBuilder.Entity<CrsOecdEncabezado>(entity =>
        {
            entity.HasKey(e => e.IdCrsEncabezado);

            entity.ToTable("crs_oecd_encabezado");

            entity.Property(e => e.IdCrsEncabezado).ValueGeneratedNever();
            entity.Property(e => e.Contact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaActualizado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.MessageRefId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MessageType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MessageTypeIndic)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReceivingCountry)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPeriod).HasColumnType("date");
            entity.Property(e => e.SendingCompanyIn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SendingCompanyIN");
            entity.Property(e => e.TransmittingCountry)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.CrsOecdEncabezados)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("crs_oecd_encabezado_docConstraint");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa);

            entity.ToTable("empresa");

            entity.Property(e => e.IdEmpresa).ValueGeneratedNever();
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaActualizado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.LogoTipo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Ruc)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Firma>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("firmas");

            entity.Property(e => e.FechaActualizado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Ruta)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany()
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("firmasConstraint");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.IdPersona).HasName("PK__personas__2EC8D2AC3AE08AD7");

            entity.ToTable("personas");

            entity.Property(e => e.IdPersona).ValueGeneratedNever();
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaActualizado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("personasConstraint");
        });

        modelBuilder.Entity<SegMenu>(entity =>
        {
            entity.HasKey(e => e.IdMenu);

            entity.ToTable("seg_menu");

            entity.Property(e => e.IdMenu).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaActualizado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SegModulo>(entity =>
        {
            entity.HasKey(e => e.IdModulo);

            entity.ToTable("seg_modulo");

            entity.Property(e => e.IdModulo).ValueGeneratedNever();
            entity.Property(e => e.FechaActualizado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.NombreModulo)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SegOpcione>(entity =>
        {
            entity.HasKey(e => e.IdOpciones);

            entity.ToTable("seg_opciones");

            entity.Property(e => e.IdOpciones).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaActualizado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SegPermiso>(entity =>
        {
            entity.HasKey(e => e.IdPermisos).HasName("PK_seg_permiso");

            entity.ToTable("seg_permisos");

            entity.Property(e => e.IdPermisos).ValueGeneratedNever();
            entity.Property(e => e.FechaActualizado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.NombrePermiso)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SegSubMenu>(entity =>
        {
            entity.HasKey(e => e.IdSubMenu);

            entity.ToTable("seg_sub_menu");

            entity.Property(e => e.IdSubMenu).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaActualizado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SegTipoUsuario>(entity =>
        {
            entity.HasKey(e => e.IdTipoUsuario);

            entity.ToTable("seg_tipo_usuario");

            entity.Property(e => e.IdTipoUsuario).ValueGeneratedNever();
            entity.Property(e => e.FechaActualizado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.TipoUsuario)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SegUsuario>(entity =>
        {
            entity.HasKey(e => e.IdUsusario);

            entity.ToTable("seg_usuario");

            entity.Property(e => e.IdUsusario).ValueGeneratedNever();
            entity.Property(e => e.Contrasena)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaActualizado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ususario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TablaSecuencium>(entity =>
        {
            entity.HasKey(e => e.IdSecuencia);

            entity.ToTable("tabla_secuencia");

            entity.Property(e => e.IdSecuencia).ValueGeneratedNever();
            entity.Property(e => e.FechaActualizado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.NombreTabla)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
