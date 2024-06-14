using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LibroNovedades.Models.Neo
{
    public partial class DbNeoContext : DbContext
    {
        public DbNeoContext()
        {
        }

        public DbNeoContext(DbContextOptions<DbNeoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AreaCarga> AreaCargas { get; set; } = null!;
        public virtual DbSet<CambFec> CambFecs { get; set; } = null!;
        public virtual DbSet<CambStat> CambStats { get; set; } = null!;
        public virtual DbSet<Centro> Centros { get; set; } = null!;
        public virtual DbSet<ClasifiTpm> ClasifiTpms { get; set; } = null!;
        public virtual DbSet<Division> Divisions { get; set; } = null!;
        public virtual DbSet<Empresa> Empresas { get; set; } = null!;
        public virtual DbSet<EquipoEam> EquipoEams { get; set; } = null!;
        public virtual DbSet<LibroNove> LibroNoves { get; set; } = null!;
        public virtual DbSet<Linea> Lineas { get; set; } = null!;
        public virtual DbSet<Master> Masters { get; set; } = null!;
        public virtual DbSet<Nivel> Nivels { get; set; } = null!;
        public virtual DbSet<Pai> Pais { get; set; } = null!;
        public virtual DbSet<ProyectoUsr> ProyectoUsrs { get; set; } = null!;
        public virtual DbSet<ReuDium> ReuDia { get; set; } = null!;
        public virtual DbSet<Rol> Rols { get; set; } = null!;
        public virtual DbSet<TiParTp> TiParTps { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AreaCarga>(entity =>
            {
                entity.HasKey(e => e.IdAreaCarg)
                    .HasName("PK_AreaCarga_1");

                entity.ToTable("AreaCarga", "lib");

                entity.Property(e => e.IdAreaCarg).HasColumnName("idAreaCarg");

                entity.Property(e => e.Acdetalle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACDetalle");

                entity.Property(e => e.Acestado).HasColumnName("ACEstado");

                entity.Property(e => e.Acnombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACNombre");
            });

            modelBuilder.Entity<CambFec>(entity =>
            {
                entity.HasKey(e => e.IdCambFec)
                    .HasName("PK_CambFec_1");

                entity.ToTable("CambFec", "reu");

                entity.Property(e => e.Cffec)
                    .HasColumnType("datetime")
                    .HasColumnName("CFFec");

                entity.Property(e => e.CffecNew)
                    .HasColumnType("datetime")
                    .HasColumnName("CFFecNew");

                entity.Property(e => e.Cfuser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CFUser");

                entity.HasOne(d => d.IdReuDiaNavigation)
                    .WithMany(p => p.CambFecs)
                    .HasForeignKey(d => d.IdReuDia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CambFec_ReuDia");
            });

            modelBuilder.Entity<CambStat>(entity =>
            {
                entity.HasKey(e => e.IdCambStat)
                    .HasName("PK_CambStat_1");

                entity.ToTable("CambStat", "reu");

                entity.Property(e => e.Cbfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("CBFecha");

                entity.Property(e => e.Cbstat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBStat");

                entity.Property(e => e.Cbuser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBUser");

                entity.HasOne(d => d.IdReuDiaNavigation)
                    .WithMany(p => p.CambStats)
                    .HasForeignKey(d => d.IdReuDia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CambStat_ReuDia");
            });

            modelBuilder.Entity<Centro>(entity =>
            {
                entity.HasKey(e => e.IdCentro);

                entity.ToTable("Centro", "mae");

                entity.Property(e => e.Cdetalle)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CDetalle");

                entity.Property(e => e.Cestado).HasColumnName("CEstado");

                entity.Property(e => e.Cfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("CFecha");

                entity.Property(e => e.Cnom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNom");
            });

            modelBuilder.Entity<ClasifiTpm>(entity =>
            {
                entity.HasKey(e => e.IdCtpm)
                    .HasName("PK_ClasifiTPM_1");

                entity.ToTable("ClasifiTPM", "lib");

                entity.Property(e => e.IdCtpm).HasColumnName("IdCTPM");

                entity.Property(e => e.Ctpmestado).HasColumnName("CTPMEstado");

                entity.Property(e => e.Ctpmnom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CTPMNom");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.HasKey(e => e.IdDivision)
                    .HasName("PK_Division_1");

                entity.ToTable("Division", "mae");

                entity.Property(e => e.Ddetalle)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("DDetalle");

                entity.Property(e => e.Destado).HasColumnName("DEstado");

                entity.Property(e => e.Dfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("DFecha");

                entity.Property(e => e.Dnombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DNombre");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("PK_Empresa_1");

                entity.ToTable("Empresa", "mae");

                entity.Property(e => e.Edescri)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EDescri");

                entity.Property(e => e.Eestado).HasColumnName("EEstado");

                entity.Property(e => e.Efecha)
                    .HasColumnType("datetime")
                    .HasColumnName("EFecha");

                entity.Property(e => e.Enombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENombre");
            });

            modelBuilder.Entity<EquipoEam>(entity =>
            {
                entity.HasKey(e => e.IdEquipo);

                entity.ToTable("EquipoEAM", "mae");

                entity.Property(e => e.EcodEquiEam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ECodEquiEAM");

                entity.Property(e => e.EdescriEam)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EDescriEAM");

                entity.Property(e => e.EestaEam).HasColumnName("EEstaEAM");

                entity.Property(e => e.Efecha)
                    .HasColumnType("datetime")
                    .HasColumnName("EFecha");

                entity.Property(e => e.EnombreEam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENombreEAM");

                entity.HasOne(d => d.IdLineaNavigation)
                    .WithMany(p => p.EquipoEams)
                    .HasForeignKey(d => d.IdLinea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquipoEAM_Linea");
            });

            modelBuilder.Entity<LibroNove>(entity =>
            {
                entity.HasKey(e => e.IdlibrNov);

                entity.ToTable("LibroNove", "lib");

                entity.Property(e => e.IdCtpm).HasColumnName("IdCTPM");

                entity.Property(e => e.IdEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdParada)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lndiscrepa)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("LNDiscrepa");

                entity.Property(e => e.Lnfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("LNFecha");

                entity.Property(e => e.LnfichaRes)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LNFichaRes");

                entity.Property(e => e.Lngrupo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LNGrupo");

                entity.Property(e => e.LnisPizUni).HasColumnName("LNIsPizUni");

                entity.Property(e => e.LnisResu).HasColumnName("LNIsResu");

                entity.Property(e => e.Lnobserv)
                    .IsUnicode(false)
                    .HasColumnName("LNObserv");

                entity.Property(e => e.LntiePerMi).HasColumnName("LNTiePerMi");

                entity.Property(e => e.Lnturno)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LNTurno");

                entity.HasOne(d => d.IdAreaCarNavigation)
                    .WithMany(p => p.LibroNoves)
                    .HasForeignKey(d => d.IdAreaCar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LibroNove_AreaCarga");

                entity.HasOne(d => d.IdCtpmNavigation)
                    .WithMany(p => p.LibroNoves)
                    .HasForeignKey(d => d.IdCtpm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LibroNove_ClasifiTPM");

                entity.HasOne(d => d.IdLineaNavigation)
                    .WithMany(p => p.LibroNoves)
                    .HasPrincipalKey(p => p.IdLinea)
                    .HasForeignKey(d => d.IdLinea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LibroNove_Master");

                entity.HasOne(d => d.IdTipoNoveNavigation)
                    .WithMany(p => p.LibroNoves)
                    .HasForeignKey(d => d.IdTipoNove)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LibroNove_TiParTP");
            });

            modelBuilder.Entity<Linea>(entity =>
            {
                entity.HasKey(e => e.IdLinea)
                    .HasName("PK_Linea_1");

                entity.ToTable("Linea", "mae");

                entity.Property(e => e.LcenCos)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LCenCos");

                entity.Property(e => e.Ldetalle)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("LDetalle");

                entity.Property(e => e.Lestado).HasColumnName("LEstado");

                entity.Property(e => e.Lfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("LFecha");

                entity.Property(e => e.Lnom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LNom");

                entity.Property(e => e.Lofic)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOFIC");
            });

            modelBuilder.Entity<Master>(entity =>
            {
                entity.HasKey(e => e.IdMaster);

                entity.ToTable("Master", "mae");

                entity.HasIndex(e => e.IdLinea, "IX_IdLinea")
                    .IsUnique();

                entity.HasOne(d => d.IdCentroNavigation)
                    .WithMany(p => p.Masters)
                    .HasForeignKey(d => d.IdCentro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Master_Centro");

                entity.HasOne(d => d.IdDivisionNavigation)
                    .WithMany(p => p.Masters)
                    .HasForeignKey(d => d.IdDivision)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Master_Division");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Masters)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Master_Empresa");

                entity.HasOne(d => d.IdLineaNavigation)
                    .WithOne(p => p.Master)
                    .HasForeignKey<Master>(d => d.IdLinea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Master_Linea");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Masters)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Master_Pais");
            });

            modelBuilder.Entity<Nivel>(entity =>
            {
                entity.HasKey(e => e.IdNivel)
                    .HasName("PK_Nivel_1");

                entity.ToTable("Nivel", "mae");

                entity.HasOne(d => d.IdMasterNavigation)
                    .WithMany(p => p.Nivels)
                    .HasForeignKey(d => d.IdMaster)
                    .HasConstraintName("FK_Nivel_Master");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.Nivels)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nivel_ProyectoUsr");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Nivels)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK_Nivel_Rol");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Nivels)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nivel_Usuario");
            });

            modelBuilder.Entity<Pai>(entity =>
            {
                entity.HasKey(e => e.IdPais);

                entity.ToTable("Pais", "mae");

                entity.Property(e => e.Pestado).HasColumnName("PEstado");

                entity.Property(e => e.Pfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("PFecha");

                entity.Property(e => e.Pnombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PNombre");
            });

            modelBuilder.Entity<ProyectoUsr>(entity =>
            {
                entity.HasKey(e => e.IdProyecto);

                entity.ToTable("ProyectoUsr", "mae");

                entity.Property(e => e.Pestado).HasColumnName("PEstado");

                entity.Property(e => e.Pnombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PNombre");
            });

            modelBuilder.Entity<ReuDium>(entity =>
            {
                entity.HasKey(e => e.IdReuDia)
                    .HasName("PK_ReuDia_1");

                entity.ToTable("ReuDia", "reu");

                entity.Property(e => e.Rdarea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RDArea");

                entity.Property(e => e.Rdcentro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RDCentro");

                entity.Property(e => e.RdcodDis)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("RDCodDis");

                entity.Property(e => e.RdcodEq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RDCodEq");

                entity.Property(e => e.Rddisc)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("RDDisc");

                entity.Property(e => e.Rddiv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RDDiv");

                entity.Property(e => e.RdfecCrea)
                    .HasColumnType("date")
                    .HasColumnName("RDFecCrea");

                entity.Property(e => e.RdfecReu)
                    .HasColumnType("date")
                    .HasColumnName("RDFecReu");

                entity.Property(e => e.RdfecTra)
                    .HasColumnType("date")
                    .HasColumnName("RDFecTra");

                entity.Property(e => e.RdnumDis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RDNumDis");

                entity.Property(e => e.Rdobs)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("RDObs");

                entity.Property(e => e.Rdodt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RDOdt");

                entity.Property(e => e.RdplanAcc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("RDPlanAcc");

                entity.Property(e => e.Rdstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RDStatus");

                entity.Property(e => e.Rdtiempo).HasColumnName("RDTiempo");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK_Rol_1");

                entity.ToTable("Rol", "mae");

                entity.Property(e => e.Rdescri)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RDescri");

                entity.Property(e => e.Restado).HasColumnName("REstado");

                entity.Property(e => e.Rnombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RNombre");
            });

            modelBuilder.Entity<TiParTp>(entity =>
            {
                entity.HasKey(e => e.IdTiParTp)
                    .HasName("PK_TiParTP_1");

                entity.ToTable("TiParTP", "tps");

                entity.Property(e => e.IdTiParTp)
                    .ValueGeneratedNever()
                    .HasColumnName("IdTiParTP");

                entity.Property(e => e.Tpcodigo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TPCodigo");

                entity.Property(e => e.Tpestado).HasColumnName("TPEstado");

                entity.Property(e => e.Tpnombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TPNombre");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK_Usuario_1");

                entity.ToTable("Usuario", "mae");

                entity.HasIndex(e => e.IdUsuario, "IX_Usuario")
                    .IsUnique();

                entity.HasIndex(e => e.UsUsuario, "UsUsuario_Usuario_1")
                    .IsUnique();

                entity.Property(e => e.UsApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsClave)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UsCorreo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsFicha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UsPass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
