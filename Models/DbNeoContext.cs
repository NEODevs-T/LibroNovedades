using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LibroNovedades.Models
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

        public virtual DbSet<Area> Areas { get; set; } = null!;
        public virtual DbSet<AsisPm> AsisPms { get; set; } = null!;
        public virtual DbSet<AudCa> AudCas { get; set; } = null!;
        public virtual DbSet<AutenUsr> AutenUsrs { get; set; } = null!;
        public virtual DbSet<CargoPm> CargoPms { get; set; } = null!;
        public virtual DbSet<Centro> Centros { get; set; } = null!;
        public virtual DbSet<ClienteP> ClientePs { get; set; } = null!;
        public virtual DbSet<DatAudCa> DatAudCas { get; set; } = null!;
        public virtual DbSet<IdAreaConLinea> IdAreaConLineas { get; set; } = null!;
        public virtual DbSet<LibroNove> LibroNoves { get; set; } = null!;
        public virtual DbSet<LinAre> LinAres { get; set; } = null!;
        public virtual DbSet<LinPro> LinPros { get; set; } = null!;
        public virtual DbSet<Linea> Lineas { get; set; } = null!;
        public virtual DbSet<Operador> Operadors { get; set; } = null!;
        public virtual DbSet<ParAre> ParAres { get; set; } = null!;
        public virtual DbSet<ParaTp> ParaTps { get; set; } = null!;
        public virtual DbSet<ParsiOee> ParsiOees { get; set; } = null!;
        public virtual DbSet<Parte> Partes { get; set; } = null!;
        public virtual DbSet<ParteLineaAreaCentro> ParteLineaAreaCentros { get; set; } = null!;
        public virtual DbSet<PregP> PregPs { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Proyecto> Proyectos { get; set; } = null!;
        public virtual DbSet<RespP> RespPs { get; set; } = null!;
        public virtual DbSet<ReuParM> ReuParMs { get; set; } = null!;
        public virtual DbSet<RspnsblP> RspnsblPs { get; set; } = null!;
        public virtual DbSet<TecniCa> TecniCas { get; set; } = null!;
        public virtual DbSet<TiPaPar> TiPaPars { get; set; } = null!;
        public virtual DbSet<TiParTp> TiParTps { get; set; } = null!;
        public virtual DbSet<TieEjeTp> TieEjeTps { get; set; } = null!;
        public virtual DbSet<TieParTp> TieParTps { get; set; } = null!;
        public virtual DbSet<TurPro> TurPros { get; set; } = null!;
        public virtual DbSet<TurnoTp> TurnoTps { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<VarAre> VarAres { get; set; } = null!;
        public virtual DbSet<VarCa> VarCas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=AZTDTDB03\\DESARROLLO;Database=DbNeo;TrustServerCertificate=True;Persist Security Info=True;User ID=UsrEncuesta;Password=Enc2022**Ing");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.IdArea);

                entity.ToTable("Area");

                entity.HasComment("Area de produccion");

                entity.Property(e => e.IdArea).HasComment("identificador del area");

                entity.Property(e => e.Adetalle)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ADetalle")
                    .HasComment("Detalle del area");

                entity.Property(e => e.Aestado)
                    .HasColumnName("AEstado")
                    .HasComment("0: Inactivo, 1:Activo");

                entity.Property(e => e.Anom)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ANom")
                    .HasComment("nombre del area");
            });

            modelBuilder.Entity<AsisPm>(entity =>
            {
                entity.HasKey(e => e.IdAsisPm);

                entity.ToTable("AsisPM");

                entity.HasComment("reuniones de paradas por mantenimiento");

                entity.Property(e => e.IdAsisPm)
                    .HasColumnName("IdAsisPM")
                    .HasComment("identificador");

                entity.Property(e => e.AisAsis)
                    .HasColumnName("AIsAsis")
                    .HasComment("1: Asistencia, 0: Inasistencia");

                entity.Property(e => e.IdCargoPm)
                    .HasColumnName("IdCargoPM")
                    .HasComment("identificador  CargoPM");

                entity.Property(e => e.IdReuParM).HasComment("identificador ReuParM");

                entity.HasOne(d => d.IdCargoPmNavigation)
                    .WithMany(p => p.AsisPms)
                    .HasForeignKey(d => d.IdCargoPm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AsisPM_CargoPM");

                entity.HasOne(d => d.IdReuParMNavigation)
                    .WithMany(p => p.AsisPms)
                    .HasForeignKey(d => d.IdReuParM)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AsisPM_ReuParM");
            });

            modelBuilder.Entity<AudCa>(entity =>
            {
                entity.HasKey(e => e.IdAudCa);

                entity.ToTable("AudCa", "his");

                entity.HasComment("historico de auditorias de calidad");

                entity.Property(e => e.IdAudCa).HasComment("Identificador de la auditoria de calidad");

                entity.Property(e => e.AccodiPro)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ACCodiPro")
                    .HasComment("codigo del producto");

                entity.Property(e => e.Acfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("ACFecha")
                    .HasComment("fecha de la auditoria");

                entity.Property(e => e.AcficOper)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ACFicOper")
                    .HasComment("ficha del operador");

                entity.Property(e => e.AcficSuper)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ACFicSuper")
                    .HasComment("ficha del supervisor");

                entity.Property(e => e.Acgrupo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACGrupo")
                    .HasComment("grupo de la auditoria");

                entity.Property(e => e.AcisCamPro)
                    .HasColumnName("ACisCamPro")
                    .HasComment("0: No es un cambio de producto; 1: cambio de producto");

                entity.Property(e => e.AcisTecn)
                    .HasColumnName("ACisTecn")
                    .HasComment("0: auditoria operador, 1: tecnico de calidad");

                entity.Property(e => e.Aclote)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ACLote")
                    .HasComment("lote del producto");

                entity.Property(e => e.Acobserv)
                    .IsUnicode(false)
                    .HasColumnName("ACObserv")
                    .HasComment("observaciones dispuestas en la auditoria");

                entity.Property(e => e.Acpresentacion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ACPresentacion")
                    .HasComment("presentacion del producto");

                entity.Property(e => e.Acturno)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTurno")
                    .HasComment("turno de la aditoria");

                entity.Property(e => e.IdArea).HasComment("identificador del area");

                entity.Property(e => e.IdTecniCa).HasComment("identificador del tecnico");

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.AudCas)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AudCa_LinAre");

                entity.HasOne(d => d.IdTecniCaNavigation)
                    .WithMany(p => p.AudCas)
                    .HasForeignKey(d => d.IdTecniCa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AudCa_TecniCa");
            });

            modelBuilder.Entity<AutenUsr>(entity =>
            {
                entity.HasKey(e => e.IdAuten);

                entity.ToTable("AutenUsr");

                entity.Property(e => e.Aapellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AApellido");

                entity.Property(e => e.Aestatus).HasColumnName("AEstatus");

                entity.Property(e => e.Anivel).HasColumnName("ANivel");

                entity.Property(e => e.Anombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ANombre");

                entity.Property(e => e.AuFicha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuPass)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CargoPm>(entity =>
            {
                entity.HasKey(e => e.IdCargoPm);

                entity.ToTable("CargoPM");

                entity.HasComment("cargos registrados en las reuniones de las paradas por mantenimiento");

                entity.Property(e => e.IdCargoPm)
                    .HasColumnName("IdCargoPM")
                    .HasComment("identificador");

                entity.Property(e => e.Cpmnom)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CPMNom")
                    .HasComment("cargo del asistidor");
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
            });

            modelBuilder.Entity<ClienteP>(entity =>
            {
                entity.HasKey(e => e.IdClienteP);

                entity.ToTable("ClienteP");

                entity.HasComment("Area solicitante");

                entity.Property(e => e.IdClienteP).HasComment("Identificador del cliente del proyecto");

                entity.Property(e => e.Cpdescri)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CPDescri")
                    .HasComment("decripcion del area");

                entity.Property(e => e.Cpestatus)
                    .HasColumnName("CPEstatus")
                    .HasComment("estatus(0:inactivo,1:activo)");

                entity.Property(e => e.Cpnombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CPNombre")
                    .HasComment("nombre del area");
            });

            modelBuilder.Entity<DatAudCa>(entity =>
            {
                entity.HasKey(e => e.IdDatAudCa);

                entity.ToTable("DatAudCa");

                entity.HasComment("data de la auditoria");

                entity.Property(e => e.IdDatAudCa).HasComment("Identificador del dato");

                entity.Property(e => e.DacisAcep)
                    .HasColumnName("DACIsAcep")
                    .HasComment("0: no aceptable, 1:aceptable");

                entity.Property(e => e.Dacvalor)
                    .HasColumnName("DACValor")
                    .HasComment("valor observado");

                entity.Property(e => e.IdAudCa).HasComment("identificador de la auditoria");

                entity.Property(e => e.IdVarCa).HasComment("identificador de la variable");

                entity.HasOne(d => d.IdAudCaNavigation)
                    .WithMany(p => p.DatAudCas)
                    .HasForeignKey(d => d.IdAudCa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DatAudCa_AudCa");

                entity.HasOne(d => d.IdVarCaNavigation)
                    .WithMany(p => p.DatAudCas)
                    .HasForeignKey(d => d.IdVarCa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DatAudCa_VarCa");
            });

            modelBuilder.Entity<IdAreaConLinea>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IdAreaConLinea");

                entity.Property(e => e.Anom)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ANom");

                entity.Property(e => e.Lnom)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("LNom");
            });

            modelBuilder.Entity<LibroNove>(entity =>
            {
                entity.HasKey(e => e.RdidReuDia)
                    .HasName("PK_LibroNovedades");

                entity.ToTable("LibroNove");

                entity.Property(e => e.RdidReuDia).HasColumnName("RDIdReuDia");

                entity.Property(e => e.IdEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rddiscrepa)
                    .IsUnicode(false)
                    .HasColumnName("RDDiscrepa");

                entity.Property(e => e.Rdfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("RDFecha");

                entity.Property(e => e.RdfichaRes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RDFichaRes");

                entity.Property(e => e.RdtiePerMi).HasColumnName("RDTiePerMi");
            });

            modelBuilder.Entity<LinAre>(entity =>
            {
                entity.HasKey(e => e.IdLinAre);

                entity.ToTable("LinAre");

                entity.HasComment("ntermediario entre linea y area");

                entity.Property(e => e.IdLinAre).HasComment("Identificador");

                entity.Property(e => e.IdLinea).HasComment("Codigo de la linea con area");

                entity.Property(e => e.Lacodigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LACodigo")
                    .HasComment("Codigo de la linea con area");

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.LinAres)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LinAre_Area");

                entity.HasOne(d => d.IdLineaNavigation)
                    .WithMany(p => p.LinAres)
                    .HasForeignKey(d => d.IdLinea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LinAre_Linea");
            });

            modelBuilder.Entity<LinPro>(entity =>
            {
                entity.HasKey(e => e.IdLinPro);

                entity.ToTable("LinPro");

                entity.HasComment("intermediario entre linea y producto");

                entity.Property(e => e.IdLinPro).HasComment("identificador de la Lin_Pro");

                entity.Property(e => e.IdLinea).HasComment("identificador de la linea");

                entity.Property(e => e.IdProducto).HasComment("identificador del producto");

                entity.HasOne(d => d.IdLineaNavigation)
                    .WithMany(p => p.LinPros)
                    .HasForeignKey(d => d.IdLinea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LinPro_Linea");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.LinPros)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LinPro_Producto");
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
                    .HasColumnName("LCenCos");

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

                entity.HasOne(d => d.IdCentroNavigation)
                    .WithMany(p => p.Lineas)
                    .HasForeignKey(d => d.IdCentro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Linea_Centro");
            });

            modelBuilder.Entity<Operador>(entity =>
            {
                entity.HasKey(e => e.IdOperador);

                entity.ToTable("Operador");

                entity.Property(e => e.IdOperador).HasComment("identificador");

                entity.Property(e => e.Opapellido)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OPApellido")
                    .HasComment("apellido del operador		");

                entity.Property(e => e.Opestado)
                    .HasColumnName("OPEstado")
                    .HasComment("0: Inactivo, 1:Activo		");

                entity.Property(e => e.OpfechaIng)
                    .HasColumnType("date")
                    .HasColumnName("OPFechaIng")
                    .HasComment("fecha de ingreso		");

                entity.Property(e => e.OpfechaNac)
                    .HasColumnType("date")
                    .HasColumnName("OPFechaNac")
                    .HasComment("fecha de nacimiento		");

                entity.Property(e => e.Opficha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPFicha")
                    .HasComment("ficha del operador");

                entity.Property(e => e.Opnombre)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OPNombre")
                    .HasComment("nombre del operador		");
            });

            modelBuilder.Entity<ParAre>(entity =>
            {
                entity.HasKey(e => e.IdParAre);

                entity.ToTable("ParAre");

                entity.HasComment("intermediario entre la parte y el area");

                entity.Property(e => e.IdParAre).HasComment("identificador del Par_Are");

                entity.Property(e => e.IdArea).HasComment("identificador del area");

                entity.Property(e => e.IdParte).HasComment("identifiacador de la parte");

                entity.Property(e => e.Pacodigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PACodigo")
                    .HasComment("codigo de la parte correspondiente al area		");

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.ParAres)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParAre_LinAre");
            });

            modelBuilder.Entity<ParaTp>(entity =>
            {
                entity.HasKey(e => e.IdParaTp);

                entity.ToTable("ParaTP");

                entity.HasComment("Paradas de la linia");

                entity.Property(e => e.IdParaTp)
                    .HasColumnName("IdParaTP")
                    .HasComment("identificador de la parada");

                entity.Property(e => e.IdTiParTp)
                    .HasColumnName("IdTiParTP")
                    .HasComment("identificador del tipo de la parada");

                entity.Property(e => e.Pcodigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PCodigo")
                    .HasComment("codigo de la parada");

                entity.Property(e => e.Pestado)
                    .HasColumnName("PEstado")
                    .HasComment("0: Inactivo, 1:Activo");

                entity.Property(e => e.Pnombre)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PNombre")
                    .HasComment("nombre de la parada");

                entity.HasOne(d => d.IdTiParTpNavigation)
                    .WithMany(p => p.ParaTps)
                    .HasForeignKey(d => d.IdTiParTp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParaTP_TiParTP");
            });

            modelBuilder.Entity<ParsiOee>(entity =>
            {
                entity.HasKey(e => e.IdParsiOee);

                entity.ToTable("ParsiOEE", "his");

                entity.HasComment("datos obteneidos de un area especifico del turno en curso");

                entity.Property(e => e.IdParsiOee)
                    .HasColumnName("IdParsiOEE")
                    .HasComment("identificador del turno");

                entity.Property(e => e.IdArea).HasComment("identificador de la linea");

                entity.Property(e => e.IdTurnoTp)
                    .HasColumnName("IdTurnoTP")
                    .HasComment("identificador del turno en curso");

                entity.Property(e => e.Pcalidad)
                    .HasColumnName("PCalidad")
                    .HasComment("calidad del turno");

                entity.Property(e => e.Pdispo)
                    .HasColumnName("PDispo")
                    .HasComment("disponibilidad del turno");

                entity.Property(e => e.Poee)
                    .HasColumnName("POEE")
                    .HasComment("OEE del turno");

                entity.Property(e => e.Ppbueno)
                    .HasColumnName("PPBueno")
                    .HasComment("productos buenos del turno");

                entity.Property(e => e.Pperdido)
                    .HasColumnName("PPerdido")
                    .HasComment("tiempo perdido del turno");

                entity.Property(e => e.Ppmalo)
                    .HasColumnName("PPMalo")
                    .HasComment("productos malos del turno");

                entity.Property(e => e.Prendi)
                    .HasColumnName("PRendi")
                    .HasComment("rendimiento del turno");

                entity.Property(e => e.Ptrabajado)
                    .HasColumnName("PTrabajado")
                    .HasComment("tiempo trabajo del turno");

                entity.Property(e => e.Pvelocidad)
                    .HasColumnName("PVelocidad")
                    .HasComment("velocidad promedio del turno");

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.ParsiOees)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParsiOEE_Area");

                entity.HasOne(d => d.IdTurnoTpNavigation)
                    .WithMany(p => p.ParsiOees)
                    .HasForeignKey(d => d.IdTurnoTp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParsiOEE_TurnoTP");
            });

            modelBuilder.Entity<Parte>(entity =>
            {
                entity.HasKey(e => e.IdParte);

                entity.ToTable("Parte");

                entity.HasComment("Partes que componen el area");

                entity.Property(e => e.IdParte).HasComment("identificador");

                entity.Property(e => e.Pdetalle)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("PDetalle")
                    .HasComment("detalle de la parte");

                entity.Property(e => e.Pestado)
                    .HasColumnName("PEstado")
                    .HasComment("0: Inactivo, 1:Activo");

                entity.Property(e => e.Pnombre)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PNombre")
                    .HasComment("nombre de la parte");
            });

            modelBuilder.Entity<ParteLineaAreaCentro>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ParteLineaAreaCentro");

                entity.Property(e => e.Area)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Centro)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoDelArea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Codigo del Area");

                entity.Property(e => e.CodigocDeLaParte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Codigoc de la Parte");

                entity.Property(e => e.Linea)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Parte)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PregP>(entity =>
            {
                entity.HasKey(e => e.IdPregP);

                entity.ToTable("PregP");

                entity.HasComment("preguntas de satisfaccion");

                entity.Property(e => e.IdPregP).HasComment("identificador de la pregunta");

                entity.Property(e => e.Ppestatus)
                    .HasColumnName("PPEstatus")
                    .HasComment("estatus(0:inactivo,1:activo)");

                entity.Property(e => e.PpisObser)
                    .HasColumnName("PPIsObser")
                    .HasComment("(0:no tiene observacion,1: tiene observacion)");

                entity.Property(e => e.Ppnombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PPNombre")
                    .HasComment("pregunta de la encuesta");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.ToTable("Producto");

                entity.HasComment("Productos");

                entity.Property(e => e.IdProducto).HasComment("identificador");

                entity.Property(e => e.Pcodigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PCodigo")
                    .HasComment("Codigo del producto");

                entity.Property(e => e.Pdetalle)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("PDetalle")
                    .HasComment("detalle de la parte");

                entity.Property(e => e.Pestado)
                    .HasColumnName("PEstado")
                    .HasComment("0: Inactivo, 1:Activo");

                entity.Property(e => e.Pnombre)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PNombre")
                    .HasComment("nombre de la parte");
            });

            modelBuilder.Entity<Proyecto>(entity =>
            {
                entity.HasKey(e => e.IdProyecto);

                entity.ToTable("Proyecto", "his");

                entity.HasComment("Proyecto de Mejora Continua");

                entity.Property(e => e.IdProyecto).HasComment("Identificador del proyecto");

                entity.Property(e => e.IdClienteP).HasComment("identificador del cliente");

                entity.Property(e => e.IdRspnsblP).HasComment("identificador del responsable");

                entity.Property(e => e.Pdetalle)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("PDetalle")
                    .HasComment("detalle del proyecto");

                entity.Property(e => e.PfechaC)
                    .HasColumnType("date")
                    .HasColumnName("PFechaC")
                    .HasComment("fecha del cierre del proyecto");

                entity.Property(e => e.PfechaP)
                    .HasColumnType("date")
                    .HasColumnName("PFechaP")
                    .HasComment("fecha programada");

                entity.Property(e => e.PfechaS)
                    .HasColumnType("date")
                    .HasColumnName("PFechaS")
                    .HasComment("fecha de la solicitud");

                entity.Property(e => e.Pfechai)
                    .HasColumnType("date")
                    .HasColumnName("PFechai")
                    .HasComment("fecha de inicio del poyecto");

                entity.Property(e => e.PisEncue)
                    .HasColumnName("PIsEncue")
                    .HasComment("0:no se ha realizado la encuesta, 1: se realizo");

                entity.Property(e => e.Pnombre)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PNombre")
                    .HasComment("nombre del proyecto");

                entity.Property(e => e.Pnota)
                    .HasColumnName("PNota")
                    .HasComment("nota de la encuesta");

                entity.HasOne(d => d.IdClientePNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.IdClienteP)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proyecto_ClienteP");

                entity.HasOne(d => d.IdRspnsblPNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.IdRspnsblP)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proyecto_RspnsblP");
            });

            modelBuilder.Entity<RespP>(entity =>
            {
                entity.HasKey(e => e.IdRespP);

                entity.ToTable("RespP");

                entity.HasComment("Respuesta de las preguntas por proyectos");

                entity.Property(e => e.IdRespP).HasComment("Identificador de la respuesta del proyecto");

                entity.Property(e => e.IdPregP).HasComment("identificador de la pregunta del proyecto");

                entity.Property(e => e.IdProyecto).HasComment("identificador del proyecto");

                entity.Property(e => e.Rpcumpli)
                    .HasColumnName("RPCumpli")
                    .HasComment("nota de la pregunta");

                entity.Property(e => e.Rpobserv)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("RPObserv")
                    .HasComment("observacion de la pregunta");

                entity.HasOne(d => d.IdPregPNavigation)
                    .WithMany(p => p.RespPs)
                    .HasForeignKey(d => d.IdPregP)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RespP_PregP");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.RespPs)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RespP_Proyecto");
            });

            modelBuilder.Entity<ReuParM>(entity =>
            {
                entity.HasKey(e => e.IdReuParM);

                entity.ToTable("ReuParM");

                entity.HasComment("reuniones de paradas por mantenimiento");

                entity.Property(e => e.IdReuParM).HasComment("identificador");

                entity.Property(e => e.Rparea)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RPArea")
                    .HasComment("area en la que se realizo la parada planificada");

                entity.Property(e => e.RpasunSpa)
                    .HasColumnName("RPAsunSPA")
                    .HasComment("asuntos tratados en el SPA");

                entity.Property(e => e.RpfechaPar)
                    .HasColumnType("date")
                    .HasColumnName("RPFechaPar")
                    .HasComment("fecha de la parada planificada");

                entity.Property(e => e.RpfechaReu)
                    .HasColumnType("date")
                    .HasColumnName("RPFechaReu")
                    .HasComment("fecha de la reunion");

                entity.Property(e => e.Rpmaquina)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("RPMaquina")
                    .HasComment("maquina de la parada programada");

                entity.Property(e => e.RpnumAct)
                    .HasColumnName("RPNumAct")
                    .HasComment("numero actividades de la parada");

                entity.Property(e => e.Rpporce)
                    .HasColumnName("RPPorce")
                    .HasComment("Porcentaje de asistencia");

                entity.Property(e => e.RptiePar)
                    .HasColumnName("RPTiePar")
                    .HasComment("tiempo de la parada planificada");

                entity.Property(e => e.RptipReu)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RPTipReu")
                    .HasComment("tipo de reunion");
            });

            modelBuilder.Entity<RspnsblP>(entity =>
            {
                entity.HasKey(e => e.IdRspnsblP);

                entity.ToTable("RspnsblP");

                entity.HasComment("Responsable del proyecto");

                entity.Property(e => e.IdRspnsblP).HasComment("Identificador del cliente del proyecto");

                entity.Property(e => e.Rpestatus)
                    .HasColumnName("RPEstatus")
                    .HasComment("estatus(0:inactivo,1:activo)");

                entity.Property(e => e.Rpnombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("RPNombre")
                    .HasComment("nombre del responsable");

                entity.Property(e => e.Rpusuario)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RPUsuario");
            });

            modelBuilder.Entity<TecniCa>(entity =>
            {
                entity.HasKey(e => e.IdTecniCa);

                entity.ToTable("TecniCa");

                entity.HasComment("tecnicos de calidad");

                entity.Property(e => e.Tcestado).HasColumnName("TCEstado");

                entity.Property(e => e.Tcficha)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TCFicha");

                entity.Property(e => e.Tcnom)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TCNom");

                entity.Property(e => e.TcusuW)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TCUsuW");
            });

            modelBuilder.Entity<TiPaPar>(entity =>
            {
                entity.HasKey(e => e.IdTiPaPar);

                entity.ToTable("TiPaPar");

                entity.HasComment("intermediario entre el tipo de parada y la parte");

                entity.Property(e => e.IdTiPaPar).HasComment("identificador del TiPa_Par");

                entity.Property(e => e.IdParte).HasComment("identifiacador de la parte");

                entity.Property(e => e.IdTiParTp)
                    .HasColumnName("IdTiParTP")
                    .HasComment("identificador de tipo de parada");

                entity.HasOne(d => d.IdParteNavigation)
                    .WithMany(p => p.TiPaPars)
                    .HasForeignKey(d => d.IdParte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TiPaPar_Parte");

                entity.HasOne(d => d.IdTiParTpNavigation)
                    .WithMany(p => p.TiPaPars)
                    .HasForeignKey(d => d.IdTiParTp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TiPaPar_TiParTP");
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

            modelBuilder.Entity<TieEjeTp>(entity =>
            {
                entity.HasKey(e => e.IdTieEjeTp);

                entity.ToTable("TieEjeTP");

                entity.HasComment("tiempo ejecutado en el turno");

                entity.Property(e => e.IdTieEjeTp)
                    .HasColumnName("IdTieEjeTP")
                    .HasComment("identificador del tiempo ejecutado de un turno");

                entity.Property(e => e.IdParsiOee)
                    .HasColumnName("IdParsiOEE")
                    .HasComment("identificador del turno");

                entity.Property(e => e.Tebueno)
                    .HasColumnName("TEBueno")
                    .HasComment("cantidad de productos buenos");

                entity.Property(e => e.Teduracion)
                    .HasColumnName("TEDuracion")
                    .HasComment("duracion del tiempo ejecutado");

                entity.Property(e => e.Tefechaf)
                    .HasColumnType("datetime")
                    .HasColumnName("TEFechaf")
                    .HasComment("fecha final del tiempo ejecutado");

                entity.Property(e => e.Tefechai)
                    .HasColumnType("datetime")
                    .HasColumnName("TEFechai")
                    .HasComment("fecha de inicio del tiempo ejecutado");

                entity.Property(e => e.Temalo)
                    .HasColumnName("TEMalo")
                    .HasComment("cantidad de productos malos");

                entity.Property(e => e.Tevelocidad)
                    .HasColumnName("TEVelocidad")
                    .HasComment("velocidad promedio");

                entity.HasOne(d => d.IdParsiOeeNavigation)
                    .WithMany(p => p.TieEjeTps)
                    .HasForeignKey(d => d.IdParsiOee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TieEjeTP_ParsiOEE");
            });

            modelBuilder.Entity<TieParTp>(entity =>
            {
                entity.HasKey(e => e.IdTieParTp);

                entity.ToTable("TieParTP");

                entity.HasComment("tiempo parado en el turno");

                entity.Property(e => e.IdTieParTp)
                    .HasColumnName("IdTieParTP")
                    .HasComment("identificador del tiempo parado de un turno");

                entity.Property(e => e.IdParaTp)
                    .HasColumnName("IdParaTP")
                    .HasComment("identificador de la parada");

                entity.Property(e => e.IdParsiOee)
                    .HasColumnName("IdParsiOEE")
                    .HasComment("identificador del turno");

                entity.Property(e => e.IdParte).HasComment("identificador de la parte");

                entity.Property(e => e.Teduracion)
                    .HasColumnName("TEDuracion")
                    .HasComment("duracion de la parada");

                entity.Property(e => e.Tefechaf)
                    .HasColumnType("datetime")
                    .HasColumnName("TEFechaf")
                    .HasComment("fecha final de la parada");

                entity.Property(e => e.Tefechai)
                    .HasColumnType("datetime")
                    .HasColumnName("TEFechai")
                    .HasComment("fecha de inicio de la parada");

                entity.HasOne(d => d.IdParaTpNavigation)
                    .WithMany(p => p.TieParTps)
                    .HasForeignKey(d => d.IdParaTp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TieParTP_ParaTP");

                entity.HasOne(d => d.IdParsiOeeNavigation)
                    .WithMany(p => p.TieParTps)
                    .HasForeignKey(d => d.IdParsiOee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TieParTP_ParsiOEE");

                entity.HasOne(d => d.IdParteNavigation)
                    .WithMany(p => p.TieParTps)
                    .HasForeignKey(d => d.IdParte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TieParTP_ParAre");
            });

            modelBuilder.Entity<TurPro>(entity =>
            {
                entity.HasKey(e => e.IdTurPro);

                entity.ToTable("TurPro");

                entity.HasComment("intermediario entre turno del tiempo perdido y producto");

                entity.Property(e => e.IdTurPro).HasComment("identificador de la Tur_Pro");

                entity.Property(e => e.IdProducto).HasComment("identificador del producto");

                entity.Property(e => e.IdTurnoTp)
                    .HasColumnName("IdTurnoTP")
                    .HasComment("identificador del turno");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.TurPros)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TurPro_Producto");

                entity.HasOne(d => d.IdTurnoTpNavigation)
                    .WithMany(p => p.TurPros)
                    .HasForeignKey(d => d.IdTurnoTp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TurPro_TurnoTP");
            });

            modelBuilder.Entity<TurnoTp>(entity =>
            {
                entity.HasKey(e => e.IdTurnoTp);

                entity.ToTable("TurnoTP");

                entity.HasComment("turnos de tiempo perdido");

                entity.Property(e => e.IdTurnoTp)
                    .HasColumnName("IdTurnoTP")
                    .HasComment("identificador del turno");

                entity.Property(e => e.IdLinea).HasComment("identificador de la linea");

                entity.Property(e => e.IdOperador).HasComment("identificador del operador");

                entity.Property(e => e.Tcalidad)
                    .HasColumnName("TCalidad")
                    .HasComment("calidad del turno");

                entity.Property(e => e.Tdispo)
                    .HasColumnName("TDispo")
                    .HasComment("disponibilidad del turno");

                entity.Property(e => e.Tfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("TFecha")
                    .HasComment("fecha del turno");

                entity.Property(e => e.Toee)
                    .HasColumnName("TOEE")
                    .HasComment("OEE del turno");

                entity.Property(e => e.Tpbueno)
                    .HasColumnName("TPBueno")
                    .HasComment("productos buenos del turno");

                entity.Property(e => e.Tperdido)
                    .HasColumnName("TPerdido")
                    .HasComment("tiempo perdido del turno");

                entity.Property(e => e.Tpmalo)
                    .HasColumnName("TPMalo")
                    .HasComment("productos malos del turno");

                entity.Property(e => e.Trendi)
                    .HasColumnName("TRendi")
                    .HasComment("rendimiento del turno");

                entity.Property(e => e.Ttrabajado)
                    .HasColumnName("TTrabajado")
                    .HasComment("tiempo trabajo del turno");

                entity.Property(e => e.Tturno)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("turno en curso");

                entity.Property(e => e.Tvelocidad)
                    .HasColumnName("TVelocidad")
                    .HasComment("velocidad promedio del turno");

                entity.HasOne(d => d.IdLineaNavigation)
                    .WithMany(p => p.TurnoTps)
                    .HasForeignKey(d => d.IdLinea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TurnoTP_Linea");

                entity.HasOne(d => d.IdOperadorNavigation)
                    .WithMany(p => p.TurnoTps)
                    .HasForeignKey(d => d.IdOperador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TurnoTP_Operador");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("Usuario");

                entity.HasComment("Responsable del proyecto");

                entity.Property(e => e.IdUsuario).HasComment("Identificador del usuario");

                entity.Property(e => e.Usestatus)
                    .HasColumnName("USEstatus")
                    .HasComment("estatus(0:inactivo,1:activo)");

                entity.Property(e => e.Usnombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("USNombre")
                    .HasComment("nombre del usuario");
            });

            modelBuilder.Entity<VarAre>(entity =>
            {
                entity.HasKey(e => e.IdVarAre);

                entity.ToTable("VarAre");

                entity.HasComment("intermediario entre vareable de calidad y area");

                entity.Property(e => e.IdVarAre).HasComment("identificador de la Var_Are");

                entity.Property(e => e.IdArea).HasComment("identifiacador del area");

                entity.Property(e => e.IdVarCa).HasComment("identificador de la variable de calidad");

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.VarAres)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VarAre_Area");

                entity.HasOne(d => d.IdVarCaNavigation)
                    .WithMany(p => p.VarAres)
                    .HasForeignKey(d => d.IdVarCa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VarAre_VarCa");
            });

            modelBuilder.Entity<VarCa>(entity =>
            {
                entity.HasKey(e => e.IdVarCa);

                entity.ToTable("VarCa");

                entity.HasComment("variable de calidad auditadas");

                entity.Property(e => e.IdVarCa).HasComment("identificador de la variable de calidad");

                entity.Property(e => e.Vcdetalle)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("VCDetalle")
                    .HasComment("Detalle de la variable");

                entity.Property(e => e.Vcestado)
                    .HasColumnName("VCEstado")
                    .HasComment("0: Inactivo, 1:Activo");

                entity.Property(e => e.Vcisobser)
                    .HasColumnName("VCIsobser")
                    .HasComment("0: no de tipo observable 1:es de tipo numerico");

                entity.Property(e => e.Vcnom)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("VCNom")
                    .HasComment("nombre de la variable");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
