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
        public virtual DbSet<Pai> Pais { get; set; } = null!;
        public virtual DbSet<ReuDium> ReuDia { get; set; } = null!;
        public virtual DbSet<TiParTp> TiParTps { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=10.20.1.60\\DESARROLLO;Initial Catalog=DbNeo;TrustServerCertificate=True;Persist Security Info=True;User ID=UsrEncNeo;Password=L3C7U3A2023*");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AreaCarga>(entity =>
            {
                entity.HasKey(e => e.IdAreaCarg);

                entity.ToTable("AreaCarga");

                entity.Property(e => e.IdAreaCarg).HasColumnName("idAreaCarg");

                entity.Property(e => e.Acdetalle)
                    .IsUnicode(false)
                    .HasColumnName("ACDetalle");

                entity.Property(e => e.Acengllish)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACEngllish")
                    .HasDefaultValueSql("('English')");

                entity.Property(e => e.Acestado).HasColumnName("ACEstado");

                entity.Property(e => e.Acnombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACNombre");
            });

            modelBuilder.Entity<CambFec>(entity =>
            {
                entity.HasKey(e => e.IdCambFec);

                entity.ToTable("CambFec");

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
                    .HasConstraintName("FK_CambFec_ReuDia1");
            });

            modelBuilder.Entity<CambStat>(entity =>
            {
                entity.HasKey(e => e.IdCambStat);

                entity.ToTable("CambStat");

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

                entity.ToTable("Centro");

                entity.HasComment("centro de produccion");

                entity.Property(e => e.IdCentro).HasComment("identificador del centro");

                entity.Property(e => e.Cdetalle)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("CDetalle")
                    .HasComment("Detalle del centro");

                entity.Property(e => e.Cestado)
                    .HasColumnName("CEstado")
                    .HasComment("0: Inactivo, 1:Activo");

                entity.Property(e => e.Cnom)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CNom")
                    .HasComment("nombre del centro");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Centros)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK_Centro_Empresa");
            });

            modelBuilder.Entity<ClasifiTpm>(entity =>
            {
                entity.HasKey(e => e.IdCtpm);

                entity.ToTable("ClasifiTPM");

                entity.Property(e => e.IdCtpm).HasColumnName("IdCTPM");

                entity.Property(e => e.Ctpmenglis)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CTPMEnglis")
                    .HasDefaultValueSql("('English')");

                entity.Property(e => e.Ctpmestado).HasColumnName("CTPMEstado");

                entity.Property(e => e.Ctpmnom)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CTPMNom");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.HasKey(e => e.IdDivision);

                entity.ToTable("Division");

                entity.Property(e => e.Ddetalle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DDetalle");

                entity.Property(e => e.Destado).HasColumnName("DEstado");

                entity.Property(e => e.Dnombre)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DNombre");

                entity.HasOne(d => d.IdCentroNavigation)
                    .WithMany(p => p.Divisions)
                    .HasForeignKey(d => d.IdCentro)
                    .HasConstraintName("FK_Division_Centro");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("Empresa");

                entity.Property(e => e.Edescri)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EDescri");

                entity.Property(e => e.Eestado).HasColumnName("EEstado");

                entity.Property(e => e.Enombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENombre");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Empresas)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Empresa_Pais");
            });

            modelBuilder.Entity<EquipoEam>(entity =>
            {
                entity.HasKey(e => e.IdEquipo);

                entity.ToTable("EquipoEAM");

                entity.Property(e => e.EcodEquiEam)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ECodEquiEAM");

                entity.Property(e => e.EdescriEam)
                    .IsUnicode(false)
                    .HasColumnName("EDescriEAM");

                entity.Property(e => e.EestaEam)
                    .HasColumnName("EEstaEAM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EnombreEam)
                    .HasMaxLength(200)
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
                entity.HasKey(e => e.IdlibrNov)
                    .HasName("PK_LibroNovedades");

                entity.ToTable("LibroNove");

                entity.Property(e => e.IdCtpm)
                    .HasColumnName("IdCTPM")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.IdEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdMaquina)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdParada)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lndiscrepa)
                    .IsUnicode(false)
                    .HasColumnName("LNDiscrepa");

                entity.Property(e => e.Lnfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("LNFecha");

                entity.Property(e => e.LnfichaRes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LNFichaRes");

                entity.Property(e => e.Lngrupo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LNGrupo");

                entity.Property(e => e.LnisPizUni).HasColumnName("LNIsPizUni");

                entity.Property(e => e.LnisResu)
                    .HasColumnName("LNIsResu")
                    .HasDefaultValueSql("((2))");

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
                    .HasForeignKey(d => d.IdLinea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LibroNove_Linea");

                entity.HasOne(d => d.IdTipoNoveNavigation)
                    .WithMany(p => p.LibroNoves)
                    .HasForeignKey(d => d.IdTipoNove)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LibroNove_TiParTP");
            });

            modelBuilder.Entity<Linea>(entity =>
            {
                entity.HasKey(e => e.IdLinea);

                entity.ToTable("Linea");

                entity.HasComment("linea de produccion");

                entity.Property(e => e.IdLinea).HasComment("identificador de la linea");

                entity.Property(e => e.IdCentro).HasComment("identificador del centro");

                entity.Property(e => e.LcenCos)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LCenCos")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ldetalle)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("LDetalle")
                    .HasComment("Detalle de la linea");

                entity.Property(e => e.Lestado)
                    .HasColumnName("LEstado")
                    .HasComment("0: Inactivo, 1:Activo");

                entity.Property(e => e.Lnom)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("LNom")
                    .HasComment("nombre de la linea");

                entity.Property(e => e.Lofic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOFIC");

                entity.HasOne(d => d.IdCentroNavigation)
                    .WithMany(p => p.Lineas)
                    .HasForeignKey(d => d.IdCentro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Linea_Centro1");

                entity.HasOne(d => d.IdDivisionNavigation)
                    .WithMany(p => p.Lineas)
                    .HasForeignKey(d => d.IdDivision)
                    .HasConstraintName("FK_Linea_Division");
            });

            modelBuilder.Entity<Pai>(entity =>
            {
                entity.HasKey(e => e.IdPais);

                entity.Property(e => e.Pestado).HasColumnName("PEstado");

                entity.Property(e => e.Pnombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PNombre");
            });

            modelBuilder.Entity<ReuDium>(entity =>
            {
                entity.HasKey(e => e.IdReuDia);

                entity.Property(e => e.IdReuDia).HasComment("id tabla");

                entity.Property(e => e.IdEmpresa).HasDefaultValueSql("((1))");

                entity.Property(e => e.IdPais).HasComment("Id del pais");

                entity.Property(e => e.Idksf).HasComment("Id del afectado");

                entity.Property(e => e.Rdarea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RDArea")
                    .HasComment("Lineas o maquinas.");

                entity.Property(e => e.Rdcentro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RDCentro")
                    .HasComment("centro o planta");

                entity.Property(e => e.RdcodDis)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("RDCodDis")
                    .HasComment("Codigo del estado de la discrepancia.");

                entity.Property(e => e.RdcodEq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RDCodEq")
                    .HasComment("Codigo del equipo");

                entity.Property(e => e.Rddisc)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("RDDisc")
                    .HasComment("Descripción de la discrepancia");

                entity.Property(e => e.Rddiv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RDDiv")
                    .HasComment("Division");

                entity.Property(e => e.RdfecReu)
                    .HasColumnType("date")
                    .HasColumnName("RDFecReu")
                    .HasComment("fecha de la discrepancia planteada en la reunion");

                entity.Property(e => e.RdfecTra)
                    .HasColumnType("date")
                    .HasColumnName("RDFecTra")
                    .HasComment("fecha planificada del trabajo.");

                entity.Property(e => e.RdnumDis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RDNumDis")
                    .HasComment("Correlativo de la discrepancia si es mayor a un dia");

                entity.Property(e => e.Rdobs)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("RDObs")
                    .HasComment("observación.");

                entity.Property(e => e.Rdodt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RDOdt")
                    .HasComment("orden de trabajo");

                entity.Property(e => e.RdplanAcc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("RDPlanAcc")
                    .HasComment("Plan de acción.");

                entity.Property(e => e.Rdstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RDStatus")
                    .HasComment("Estado de las discrepancia");

                entity.Property(e => e.Rdtiempo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RDTiempo")
                    .HasComment("Tiempo de reparación de la discrepancia.");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.ReuDia)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK_ReuDia_Empresa");
            });

            modelBuilder.Entity<TiParTp>(entity =>
            {
                entity.HasKey(e => e.IdTiParTp);

                entity.ToTable("TiParTP");

                entity.HasComment("tipo de parada del tiempo perdido");

                entity.Property(e => e.IdTiParTp)
                    .HasColumnName("IdTiParTP")
                    .HasComment("identificador");

                entity.Property(e => e.Tpcodigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TPCodigo")
                    .HasComment("codigo del tipo parada");

                entity.Property(e => e.Tpestado)
                    .HasColumnName("TPEstado")
                    .HasComment("0: Inactivo, 1:Activo");

                entity.Property(e => e.Tpnombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TPNombre")
                    .HasComment("nombre del centro");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
