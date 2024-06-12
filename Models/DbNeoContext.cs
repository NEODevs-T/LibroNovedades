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

        public virtual DbSet<AreAfect> AreAfects { get; set; } = null!;
        public virtual DbSet<Area> Areas { get; set; } = null!;
        public virtual DbSet<AreaCarga> AreaCargas { get; set; } = null!;
        public virtual DbSet<AsentaMol> AsentaMols { get; set; } = null!;
        public virtual DbSet<AsisPm> AsisPms { get; set; } = null!;
        public virtual DbSet<AsistenReu> AsistenReus { get; set; } = null!;
        public virtual DbSet<AudCa> AudCas { get; set; } = null!;
        public virtual DbSet<AutenUsr> AutenUsrs { get; set; } = null!;
        public virtual DbSet<CambFec> CambFecs { get; set; } = null!;
        public virtual DbSet<CambStat> CambStats { get; set; } = null!;
        public virtual DbSet<CambioEstadoVenezuela> CambioEstadoVenezuelas { get; set; } = null!;
        public virtual DbSet<CambiosEstadoColombium> CambiosEstadoColombia { get; set; } = null!;
        public virtual DbSet<CambiosEstadoGuatemala> CambiosEstadoGuatemalas { get; set; } = null!;
        public virtual DbSet<CambiosFechaColombium> CambiosFechaColombia { get; set; } = null!;
        public virtual DbSet<CambiosFechaGuatemala> CambiosFechaGuatemalas { get; set; } = null!;
        public virtual DbSet<CambiosFechaVenezuela> CambiosFechaVenezuelas { get; set; } = null!;
        public virtual DbSet<CargoPm> CargoPms { get; set; } = null!;
        public virtual DbSet<CargoReu> CargoReus { get; set; } = null!;
        public virtual DbSet<Centro> Centros { get; set; } = null!;
        public virtual DbSet<ClasifiTpm> ClasifiTpms { get; set; } = null!;
        public virtual DbSet<ClienteP> ClientePs { get; set; } = null!;
        public virtual DbSet<ConsAcei> ConsAceis { get; set; } = null!;
        public virtual DbSet<CortCate> CortCates { get; set; } = null!;
        public virtual DbSet<CorteDi> CorteDis { get; set; } = null!;
        public virtual DbSet<DatAudCa> DatAudCas { get; set; } = null!;
        public virtual DbSet<Division> Divisions { get; set; } = null!;
        public virtual DbSet<Empresa> Empresas { get; set; } = null!;
        public virtual DbSet<Encuestum> Encuesta { get; set; } = null!;
        public virtual DbSet<EquipoEam> EquipoEams { get; set; } = null!;
        public virtual DbSet<EquiposEamporLinea> EquiposEamporLineas { get; set; } = null!;
        public virtual DbSet<IdAreaConLinea> IdAreaConLineas { get; set; } = null!;
        public virtual DbSet<ImaqPre> ImaqPres { get; set; } = null!;
        public virtual DbSet<Imaquina> Imaquinas { get; set; } = null!;
        public virtual DbSet<InspecDatum> InspecData { get; set; } = null!;
        public virtual DbSet<Inspeccion> Inspeccions { get; set; } = null!;
        public virtual DbSet<Ipreguntum> Ipregunta { get; set; } = null!;
        public virtual DbSet<ItipPre> ItipPres { get; set; } = null!;
        public virtual DbSet<Ksf> Ksfs { get; set; } = null!;
        public virtual DbSet<LibroNove> LibroNoves { get; set; } = null!;
        public virtual DbSet<LibroNovedadesComedor> LibroNovedadesComedors { get; set; } = null!;
        public virtual DbSet<LibroNovedadesConversion> LibroNovedadesConversions { get; set; } = null!;
        public virtual DbSet<LibroNovedadesGeneral> LibroNovedadesGenerals { get; set; } = null!;
        public virtual DbSet<LibroNovedadesMolino> LibroNovedadesMolinos { get; set; } = null!;
        public virtual DbSet<LibroNovedadesPainsa> LibroNovedadesPainsas { get; set; } = null!;
        public virtual DbSet<LibroNovedadesPanasa> LibroNovedadesPanasas { get; set; } = null!;
        public virtual DbSet<LibroNovedadesVenezuela> LibroNovedadesVenezuelas { get; set; } = null!;
        public virtual DbSet<LinAre> LinAres { get; set; } = null!;
        public virtual DbSet<Linea> Lineas { get; set; } = null!;
        public virtual DbSet<Monto> Montos { get; set; } = null!;
        public virtual DbSet<Nivel> Nivels { get; set; } = null!;
        public virtual DbSet<NovPesoPt> NovPesoPts { get; set; } = null!;
        public virtual DbSet<NovedadesActualesChempro> NovedadesActualesChempros { get; set; } = null!;
        public virtual DbSet<Operador> Operadors { get; set; } = null!;
        public virtual DbSet<Pai> Pais { get; set; } = null!;
        public virtual DbSet<PaisEmpresaCentroDivisionLinea> PaisEmpresaCentroDivisionLineas { get; set; } = null!;
        public virtual DbSet<ParAre> ParAres { get; set; } = null!;
        public virtual DbSet<ParProdu> ParProdus { get; set; } = null!;
        public virtual DbSet<ParaTp> ParaTps { get; set; } = null!;
        public virtual DbSet<ParsiOee> ParsiOees { get; set; } = null!;
        public virtual DbSet<Parte> Partes { get; set; } = null!;
        public virtual DbSet<ParteLineaAreaCentro> ParteLineaAreaCentros { get; set; } = null!;
        public virtual DbSet<Personal> Personals { get; set; } = null!;
        public virtual DbSet<Plantilla> Plantillas { get; set; } = null!;
        public virtual DbSet<Pnccausa> Pnccausas { get; set; } = null!;
        public virtual DbSet<Pnccausante> Pnccausantes { get; set; } = null!;
        public virtual DbSet<PncdisDefi> PncdisDefis { get; set; } = null!;
        public virtual DbSet<Pncestado> Pncestados { get; set; } = null!;
        public virtual DbSet<Pncidentif> Pncidentifs { get; set; } = null!;
        public virtual DbSet<PncproDisp> PncproDisps { get; set; } = null!;
        public virtual DbSet<Pncriesgo> Pncriesgos { get; set; } = null!;
        public virtual DbSet<Pnctipo> Pnctipos { get; set; } = null!;
        public virtual DbSet<Pncunidad> Pncunidads { get; set; } = null!;
        public virtual DbSet<PregP> PregPs { get; set; } = null!;
        public virtual DbSet<ProMejCont> ProMejConts { get; set; } = null!;
        public virtual DbSet<ProNoCon> ProNoCons { get; set; } = null!;
        public virtual DbSet<ProResp> ProResps { get; set; } = null!;
        public virtual DbSet<ProductoNoConforme> ProductoNoConformes { get; set; } = null!;
        public virtual DbSet<ProyectoUsr> ProyectoUsrs { get; set; } = null!;
        public virtual DbSet<PuesTrab> PuesTrabs { get; set; } = null!;
        public virtual DbSet<RegPaletPt> RegPaletPts { get; set; } = null!;
        public virtual DbSet<RegSaPtpcp> RegSaPtpcps { get; set; } = null!;
        public virtual DbSet<RespP> RespPs { get; set; } = null!;
        public virtual DbSet<RespoReu> RespoReus { get; set; } = null!;
        public virtual DbSet<Resuman> Resumen { get; set; } = null!;
        public virtual DbSet<ReuDium> ReuDia { get; set; } = null!;
        public virtual DbSet<ReuParM> ReuParMs { get; set; } = null!;
        public virtual DbSet<ReunionDium> ReunionDia { get; set; } = null!;
        public virtual DbSet<ReunionWebColombium> ReunionWebColombia { get; set; } = null!;
        public virtual DbSet<ReunionWebGuatemala> ReunionWebGuatemalas { get; set; } = null!;
        public virtual DbSet<ReunionWebVenezuela> ReunionWebVenezuelas { get; set; } = null!;
        public virtual DbSet<Rol> Rols { get; set; } = null!;
        public virtual DbSet<RspnsblP> RspnsblPs { get; set; } = null!;
        public virtual DbSet<TecniCa> TecniCas { get; set; } = null!;
        public virtual DbSet<TiPaPar> TiPaPars { get; set; } = null!;
        public virtual DbSet<TiParTp> TiParTps { get; set; } = null!;
        public virtual DbSet<TieEjeTp> TieEjeTps { get; set; } = null!;
        public virtual DbSet<TieParTp> TieParTps { get; set; } = null!;
        public virtual DbSet<TipIncen> TipIncens { get; set; } = null!;
        public virtual DbSet<TipSolicit> TipSolicits { get; set; } = null!;
        public virtual DbSet<TipSuple> TipSuples { get; set; } = null!;
        public virtual DbSet<TurnoTp> TurnoTps { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<UsuariosPermiso> UsuariosPermisos { get; set; } = null!;
        public virtual DbSet<VarAre> VarAres { get; set; } = null!;
        public virtual DbSet<VarCa> VarCas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=10.20.1.60\\DESARROLLO;Initial Catalog=DbNeo;TrustServerCertificate=True;Persist Security Info=True;User ID=UsrEncuesta;Password=Enc2022**Ing");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AreAfect>(entity =>
            {
                entity.HasKey(e => e.IdAreAfect);

                entity.ToTable("AreAfect");

                entity.Property(e => e.Aadetalle)
                    .IsUnicode(false)
                    .HasColumnName("AADetalle");

                entity.Property(e => e.Aaestado).HasColumnName("AAEstado");

                entity.Property(e => e.Aanom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AANom");
            });

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

            modelBuilder.Entity<AreaCarga>(entity =>
            {
                entity.HasKey(e => e.IdAreaCarg);

                entity.ToTable("AreaCarga");

                entity.Property(e => e.IdAreaCarg).HasColumnName("idAreaCarg");

                entity.Property(e => e.Acdetalle)
                    .IsUnicode(false)
                    .HasColumnName("ACDetalle");

                entity.Property(e => e.Acestado).HasColumnName("ACEstado");

                entity.Property(e => e.Acnombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACNombre");
            });

            modelBuilder.Entity<AsentaMol>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AsentaMol");

                entity.Property(e => e.Amarea)
                    .IsUnicode(false)
                    .HasColumnName("AMArea");

                entity.Property(e => e.Amcategor)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AMCategor");

                entity.Property(e => e.AmcodPro)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AMCodPro");

                entity.Property(e => e.Amfecha)
                    .HasColumnType("date")
                    .HasColumnName("AMFecha");

                entity.Property(e => e.Amficha)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AMFicha");

                entity.Property(e => e.Amgrupo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AMGrupo");

                entity.Property(e => e.Ammax).HasColumnName("AMMax");

                entity.Property(e => e.Ammin).HasColumnName("AMMin");

                entity.Property(e => e.Amtip)
                    .HasColumnName("AMTip")
                    .HasComment("1 es asentamientos de proceso, 2 asentamientos de maquina");

                entity.Property(e => e.Amturno)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AMTurno");

                entity.Property(e => e.Amunid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMUnid");

                entity.Property(e => e.Amvalor).HasColumnName("AMValor");

                entity.Property(e => e.Amvariable)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AMVariable");
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

            modelBuilder.Entity<AsistenReu>(entity =>
            {
                entity.HasKey(e => e.IdAsistencia);

                entity.ToTable("AsistenReu");

                entity.Property(e => e.ArObser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ararea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ARArea");

                entity.Property(e => e.Arfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("ARFecha");

                entity.Property(e => e.AridCargoR).HasColumnName("ARIdCargoR");

                entity.HasOne(d => d.AridCargoRNavigation)
                    .WithMany(p => p.AsistenReus)
                    .HasForeignKey(d => d.AridCargoR)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AsistenReu_CargoReu");
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

            modelBuilder.Entity<CambioEstadoVenezuela>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CambioEstadoVenezuela");

                entity.Property(e => e.Centro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Linea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CambiosEstadoColombium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CambiosEstadoColombia");

                entity.Property(e => e.Centro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Linea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CambiosEstadoGuatemala>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CambiosEstadoGuatemala");

                entity.Property(e => e.Centro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Linea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CambiosFechaColombium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CambiosFechaColombia");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDeCambio)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha de Cambio");

                entity.Property(e => e.FechaNueva)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha Nueva");

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CambiosFechaGuatemala>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CambiosFechaGuatemala");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDeCambio)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha de Cambio");

                entity.Property(e => e.FechaNueva)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha Nueva");

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CambiosFechaVenezuela>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CambiosFechaVenezuela");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDeCambio)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha de Cambio");

                entity.Property(e => e.FechaNueva)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha Nueva");

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
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

            modelBuilder.Entity<CargoReu>(entity =>
            {
                entity.HasKey(e => e.IdCargoR);

                entity.ToTable("CargoReu");

                entity.Property(e => e.Crarea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CRArea");

                entity.Property(e => e.Crbloque).HasColumnName("CRBloque");

                entity.Property(e => e.Crempresa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREmpresa");

                entity.Property(e => e.Cresta).HasColumnName("CREsta");

                entity.Property(e => e.Crnombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CRNombre");
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

                entity.Property(e => e.Ctpmestado).HasColumnName("CTPMEstado");

                entity.Property(e => e.Ctpmnom)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CTPMNom");
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

            modelBuilder.Entity<ConsAcei>(entity =>
            {
                entity.HasKey(e => e.IdConsAcei);

                entity.ToTable("ConsAcei");

                entity.HasComment("Para guardar los registros de consumo de aceite grado alimenticio en conversión");

                entity.Property(e => e.Cacant)
                    .HasColumnName("CACant")
                    .HasComment("Cantidad de transacción");

                entity.Property(e => e.Cacelda)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CACelda")
                    .HasComment("Centro de consumo");

                entity.Property(e => e.Cafecha)
                    .HasColumnType("date")
                    .HasColumnName("CAFecha")
                    .HasComment("Fecha del registro");

                entity.Property(e => e.Cagrupo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CAGrupo")
                    .HasComment("Grupo de rotación");

                entity.Property(e => e.Camaq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CAMaq")
                    .HasComment("Parte de consumo");

                entity.Property(e => e.Canombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANombre")
                    .HasComment("Nombre del usuario");

                entity.Property(e => e.Catrans)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CATrans")
                    .HasComment("Tipo de transacción");

                entity.Property(e => e.Caturno)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CATurno")
                    .HasComment("Turno del registro");
            });

            modelBuilder.Entity<CortCate>(entity =>
            {
                entity.HasKey(e => e.IdCortCate);

                entity.ToTable("CortCate");

                entity.Property(e => e.Cccodigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCCodigo");

                entity.Property(e => e.Ccdesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CCDesc");

                entity.Property(e => e.Ccnombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCNombre");
            });

            modelBuilder.Entity<CorteDi>(entity =>
            {
                entity.HasKey(e => e.IdCortDisc);

                entity.Property(e => e.Cdcategoria)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CDCategoria");

                entity.Property(e => e.Cdcentro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CDCentro");

                entity.Property(e => e.CdcodProd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CDCodProd");

                entity.Property(e => e.Cdcorte).HasColumnName("CDCorte");

                entity.Property(e => e.Cdequipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CDEquipo");

                entity.Property(e => e.Cdexpres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CDExpres");

                entity.Property(e => e.CdfecDisc)
                    .HasColumnType("datetime")
                    .HasColumnName("CDFecDisc");

                entity.Property(e => e.CdfechaAsen)
                    .HasColumnType("datetime")
                    .HasColumnName("CDFechaAsen");

                entity.Property(e => e.Cdgrupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CDGrupo");

                entity.Property(e => e.Cdmax).HasColumnName("CDMax");

                entity.Property(e => e.Cdmin).HasColumnName("CDMin");

                entity.Property(e => e.Cdmuestra).HasColumnName("CDMuestra");

                entity.Property(e => e.Cdnuevo).HasColumnName("CDNuevo");

                entity.Property(e => e.CdplanAcc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CDPlanAcc");

                entity.Property(e => e.Cdresuelto).HasColumnName("CDResuelto");

                entity.Property(e => e.Cdsuperv)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CDSuperv");

                entity.Property(e => e.CdtipoAsen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CDTipoAsen");

                entity.Property(e => e.Cdturno).HasColumnName("CDTurno");

                entity.Property(e => e.Cdvariable)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CDVariable");

                entity.HasOne(d => d.IdCortCateNavigation)
                    .WithMany(p => p.CorteDis)
                    .HasForeignKey(d => d.IdCortCate)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CorteDis_CortCate");
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

            modelBuilder.Entity<Encuestum>(entity =>
            {
                entity.HasKey(e => e.IdEncuesta);

                entity.ToTable("Encuesta", "his");

                entity.Property(e => e.EcodPro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ECodPro");

                entity.Property(e => e.EnomPro)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ENomPro");

                entity.Property(e => e.EusrDesti)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EUsrDesti");

                entity.HasOne(d => d.IdRemitenNavigation)
                    .WithMany(p => p.Encuesta)
                    .HasForeignKey(d => d.IdRemiten)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Encuesta_RspnsblP");
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

            modelBuilder.Entity<EquiposEamporLinea>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EquiposEAMporLinea");

                entity.Property(e => e.Centro)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EcodEquiEam)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ECodEquiEAM");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Equipo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Linea)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false);
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

            modelBuilder.Entity<ImaqPre>(entity =>
            {
                entity.HasKey(e => e.IdMaqPre);

                entity.ToTable("IMaqPre");

                entity.Property(e => e.Mpfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("MPFecha")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdMaquinaNavigation)
                    .WithMany(p => p.ImaqPres)
                    .HasForeignKey(d => d.IdMaquina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IMaqPre_IMaquina");

                entity.HasOne(d => d.IdPreguntaNavigation)
                    .WithMany(p => p.ImaqPres)
                    .HasForeignKey(d => d.IdPregunta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IMaqPre_IPregunta");
            });

            modelBuilder.Entity<Imaquina>(entity =>
            {
                entity.HasKey(e => e.IdMaquina);

                entity.ToTable("IMaquina");

                entity.Property(e => e.Mdescri)
                    .IsUnicode(false)
                    .HasColumnName("MDescri");

                entity.Property(e => e.Mestado)
                    .IsRequired()
                    .HasColumnName("MEstado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("MFecha")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mnombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MNombre");
            });

            modelBuilder.Entity<InspecDatum>(entity =>
            {
                entity.HasKey(e => e.IdInsData);

                entity.Property(e => e.Iddata).HasColumnName("IDData");

                entity.Property(e => e.Idobserv)
                    .IsUnicode(false)
                    .HasColumnName("IDObserv");

                entity.HasOne(d => d.IdInspecNavigation)
                    .WithMany(p => p.InspecData)
                    .HasForeignKey(d => d.IdInspec)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InspecData_Inspeccion");

                entity.HasOne(d => d.IdMaqPreNavigation)
                    .WithMany(p => p.InspecData)
                    .HasForeignKey(d => d.IdMaqPre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InspecData_IMaqPre");
            });

            modelBuilder.Entity<Inspeccion>(entity =>
            {
                entity.HasKey(e => e.IdInspec);

                entity.ToTable("Inspeccion", "his");

                entity.Property(e => e.Iarea)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IArea");

                entity.Property(e => e.Iequipo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IEquipo");

                entity.Property(e => e.Ifecha)
                    .HasColumnType("datetime")
                    .HasColumnName("IFecha")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ificha)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IFicha");

                entity.Property(e => e.Igrupo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IGrupo");

                entity.Property(e => e.Iturno)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ITurno");
            });

            modelBuilder.Entity<Ipreguntum>(entity =>
            {
                entity.HasKey(e => e.IdPregunta);

                entity.ToTable("IPregunta");

                entity.Property(e => e.Pdescri)
                    .IsUnicode(false)
                    .HasColumnName("PDescri");

                entity.Property(e => e.Pestado).HasColumnName("PEstado");

                entity.Property(e => e.Pfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("PFecha")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdTipPreNavigation)
                    .WithMany(p => p.Ipregunta)
                    .HasForeignKey(d => d.IdTipPre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IPregunta_ITipPre");
            });

            modelBuilder.Entity<ItipPre>(entity =>
            {
                entity.HasKey(e => e.IdTipPre);

                entity.ToTable("ITipPre");

                entity.Property(e => e.Tpdescri)
                    .IsUnicode(false)
                    .HasColumnName("TPDescri");

                entity.Property(e => e.Tpestado).HasColumnName("TPEstado");

                entity.Property(e => e.Tpfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("TPFecha")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tpnombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TPNombre");
            });

            modelBuilder.Entity<Ksf>(entity =>
            {
                entity.HasKey(e => e.Idksf);

                entity.ToTable("KSF");

                entity.Property(e => e.KsfNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
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

            modelBuilder.Entity<LibroNovedadesComedor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LibroNovedadesComedor");

                entity.Property(e => e.AreaCargador)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Area cargador");

                entity.Property(e => e.Centro)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClasificacionTpm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Clasificacion TPM");

                entity.Property(e => e.CodigoEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Codigo Equipo");

                entity.Property(e => e.Discrepancia).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FichaDelRegistrador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ficha del Registrador");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Linea)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Lnfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("LNFecha");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.TiempoPerdido).HasColumnName("Tiempo Perdido");

                entity.Property(e => e.TipoDeNovedad)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Tipo de Novedad");

                entity.Property(e => e.Turno)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LibroNovedadesConversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LibroNovedadesConversion");

                entity.Property(e => e.AreaCargador)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Area cargador");

                entity.Property(e => e.Centro)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClasificacionTpm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Clasificacion TPM");

                entity.Property(e => e.CodigoEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Codigo Equipo");

                entity.Property(e => e.Discrepancia).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FichaDelRegistrador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ficha del Registrador");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Linea)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Lnfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("LNFecha");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.TiempoPerdido).HasColumnName("Tiempo Perdido");

                entity.Property(e => e.TipoDeNovedad)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Tipo de Novedad");

                entity.Property(e => e.Turno)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LibroNovedadesGeneral>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Libro_NovedadesGeneral");

                entity.Property(e => e.AreaCargador)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Area cargador");

                entity.Property(e => e.Centro)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClasificacionTpm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Clasificacion TPM");

                entity.Property(e => e.CodigoEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Codigo Equipo");

                entity.Property(e => e.Discrepancia).IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FichaDelRegistrador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ficha del Registrador");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdCentro).HasColumnName("idCentro");

                entity.Property(e => e.IdDivision).HasColumnName("idDivision");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.IdLinea).HasColumnName("idLinea");

                entity.Property(e => e.IdPais).HasColumnName("idPais");

                entity.Property(e => e.Linea)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Lnfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("LNFecha");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TiempoPerdido).HasColumnName("Tiempo Perdido");

                entity.Property(e => e.TipoDeNovedad)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Tipo de Novedad");

                entity.Property(e => e.Turno)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LibroNovedadesMolino>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LibroNovedadesMolino");

                entity.Property(e => e.AreaCargador)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Area cargador");

                entity.Property(e => e.Centro)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClasificacionTpm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Clasificacion TPM");

                entity.Property(e => e.CodigoEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Codigo Equipo");

                entity.Property(e => e.Discrepancia).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FichaDelRegistrador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ficha del Registrador");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Linea)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Lnfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("LNFecha");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.TiempoPerdido).HasColumnName("Tiempo Perdido");

                entity.Property(e => e.TipoDeNovedad)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Tipo de Novedad");

                entity.Property(e => e.Turno)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LibroNovedadesPainsa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LibroNovedadesPainsa");

                entity.Property(e => e.AreaCargador)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Area cargador");

                entity.Property(e => e.Centro)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClasificacionTpm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Clasificacion TPM");

                entity.Property(e => e.CodigoEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Codigo Equipo");

                entity.Property(e => e.Discrepancia).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FichaDelRegistrador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ficha del Registrador");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Linea)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Lnfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("LNFecha");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.TiempoPerdido).HasColumnName("Tiempo Perdido");

                entity.Property(e => e.TipoDeNovedad)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Tipo de Novedad");

                entity.Property(e => e.Turno)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LibroNovedadesPanasa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LibroNovedadesPanasa");

                entity.Property(e => e.AreaCargador)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Area cargador");

                entity.Property(e => e.Centro)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClasificacionTpm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Clasificacion TPM");

                entity.Property(e => e.CodigoEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Codigo Equipo");

                entity.Property(e => e.Discrepancia).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FichaDelRegistrador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ficha del Registrador");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Linea)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Lnfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("LNFecha");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.TiempoPerdido).HasColumnName("Tiempo Perdido");

                entity.Property(e => e.TipoDeNovedad)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Tipo de Novedad");

                entity.Property(e => e.Turno)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LibroNovedadesVenezuela>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LibroNovedadesVenezuela");

                entity.Property(e => e.AreaCargador)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Area cargador");

                entity.Property(e => e.Centro)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClasificacionTpm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Clasificacion TPM");

                entity.Property(e => e.CodigoEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Codigo Equipo");

                entity.Property(e => e.Discrepancia).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FichaDelRegistrador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ficha del Registrador");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Linea)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Lnfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("LNFecha");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.TiempoPerdido).HasColumnName("Tiempo Perdido");

                entity.Property(e => e.TipoDeNovedad)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Tipo de Novedad");

                entity.Property(e => e.Turno)
                    .HasMaxLength(1)
                    .IsUnicode(false);
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

            modelBuilder.Entity<Monto>(entity =>
            {
                entity.HasKey(e => e.IdMontos);

                entity.Property(e => e.Mescalon).HasColumnName("MEscalon");

                entity.Property(e => e.Mesta).HasColumnName("MEsta");

                entity.Property(e => e.MfecAct)
                    .HasColumnType("datetime")
                    .HasColumnName("MFecAct");

                entity.Property(e => e.Mmonto).HasColumnName("MMonto");

                entity.Property(e => e.Muser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MUser");

                entity.HasOne(d => d.IdLineaNavigation)
                    .WithMany(p => p.Montos)
                    .HasForeignKey(d => d.IdLinea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Montos_Linea");

                entity.HasOne(d => d.IdPuesTrabNavigation)
                    .WithMany(p => p.Montos)
                    .HasForeignKey(d => d.IdPuesTrab)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Montos_PuesTrab");
            });

            modelBuilder.Entity<Nivel>(entity =>
            {
                entity.HasKey(e => e.IdNivel);

                entity.ToTable("Nivel");

                entity.HasOne(d => d.IdDivisionNavigation)
                    .WithMany(p => p.Nivels)
                    .HasForeignKey(d => d.IdDivision)
                    .HasConstraintName("FK_Nivel_Division");

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

            modelBuilder.Entity<NovPesoPt>(entity =>
            {
                entity.HasKey(e => e.IdNovPt);

                entity.ToTable("NovPesoPT");

                entity.HasComment("Para guardar acciones o novedades en unidades con diferencia de peso en Distribucion y despacho");

                entity.Property(e => e.IdNovPt).HasColumnName("IdNovPT");

                entity.Property(e => e.Npautoriza)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NPAutoriza")
                    .HasComment("Registro de Autorizacion y usuario BPCS");

                entity.Property(e => e.Npcapacity)
                    .HasColumnName("NPCapacity")
                    .HasComment("Capacidad del Vehiculo");

                entity.Property(e => e.NpdateDif)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NPDateDif")
                    .HasComment("Fecha de Diferencia");

                entity.Property(e => e.NpdateReg)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NPDateReg")
                    .HasComment("Fecha de Registro");

                entity.Property(e => e.NpdifPeso)
                    .HasColumnName("NPDifPeso")
                    .HasComment("Diferencia de Peso Factura vs Romana");

                entity.Property(e => e.NpdifPorc)
                    .HasColumnName("NPDifPorc")
                    .HasComment("Diferencia en Porcentaje de Peso Factura vs Romana");

                entity.Property(e => e.Npempresa)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NPEmpresa")
                    .HasComment("Empresa Transportista");

                entity.Property(e => e.NppesoFact)
                    .HasColumnName("NPPesoFact")
                    .HasComment("Peso según factura");

                entity.Property(e => e.NppesoRom)
                    .HasColumnName("NPPesoRom")
                    .HasComment("Peso según Romana");

                entity.Property(e => e.Npplaca)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NPPlaca")
                    .HasComment("Placa de Unidad");

                entity.Property(e => e.NpplanAcc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NPPlanAcc")
                    .HasComment("Plan de Accion Tomado");

                entity.Property(e => e.NptipVech)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NPTipVech")
                    .HasComment("Tipo de Vehiculo con Error");
            });

            modelBuilder.Entity<NovedadesActualesChempro>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NovedadesActualesChempro");

                entity.Property(e => e.Centro)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Codigo Equipo");

                entity.Property(e => e.Discrepancia).IsUnicode(false);

                entity.Property(e => e.FichaDelRegistrador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ficha del Registrador");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Linea)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Lnfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("LNFecha");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.TiempoPerdido).HasColumnName("Tiempo Perdido");

                entity.Property(e => e.TipoDeNovedad)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Tipo de Novedad");

                entity.Property(e => e.Turno)
                    .HasMaxLength(1)
                    .IsUnicode(false);
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

            modelBuilder.Entity<Pai>(entity =>
            {
                entity.HasKey(e => e.IdPais);

                entity.Property(e => e.Pestado).HasColumnName("PEstado");

                entity.Property(e => e.Pnombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PNombre");
            });

            modelBuilder.Entity<PaisEmpresaCentroDivisionLinea>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PaisEmpresaCentroDivisionLinea");

                entity.Property(e => e.Centro)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Linea)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false);
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

                entity.HasOne(d => d.IdParteNavigation)
                    .WithMany(p => p.ParAres)
                    .HasForeignKey(d => d.IdParte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParAre_Parte");
            });

            modelBuilder.Entity<ParProdu>(entity =>
            {
                entity.HasKey(e => e.IdParProdu);

                entity.ToTable("ParProdu");

                entity.Property(e => e.Pdetalle)
                    .IsUnicode(false)
                    .HasColumnName("PDetalle");

                entity.Property(e => e.Pestado).HasColumnName("PEstado");

                entity.Property(e => e.Pnombre)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PNombre");
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
                    .HasConstraintName("FK_ParsiOEE_LinAre");

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

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.HasKey(e => e.IdPersonal)
                    .HasName("PK__Personal__05A9201B1DEC2386");

                entity.ToTable("Personal");

                entity.Property(e => e.PeApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeFicha)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PeGrupo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PeNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Plantilla>(entity =>
            {
                entity.HasKey(e => e.IdPlantilla);

                entity.ToTable("Plantilla");

                entity.Property(e => e.Pcentro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PCentro");

                entity.Property(e => e.PidLinea).HasColumnName("PIdLinea");

                entity.Property(e => e.PidPuesto).HasColumnName("PIdPuesto");

                entity.Property(e => e.Plinea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PLinea");

                entity.Property(e => e.Ppuesto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PPuesto");

                entity.HasOne(d => d.IdPersonalNavigation)
                    .WithMany(p => p.Plantillas)
                    .HasForeignKey(d => d.IdPersonal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plantilla_Personal");
            });

            modelBuilder.Entity<Pnccausa>(entity =>
            {
                entity.HasKey(e => e.IdCausa);

                entity.ToTable("PNCCausa");

                entity.Property(e => e.Cdescri)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CDescri");

                entity.Property(e => e.Cestado).HasColumnName("CEstado");

                entity.Property(e => e.Cnombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CNombre");

                entity.Property(e => e.IdCausante).HasDefaultValueSql("((18))");

                entity.HasOne(d => d.IdCausanteNavigation)
                    .WithMany(p => p.Pnccausas)
                    .HasForeignKey(d => d.IdCausante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PNCCausa_PNCCausante");
            });

            modelBuilder.Entity<Pnccausante>(entity =>
            {
                entity.HasKey(e => e.IdCausante);

                entity.ToTable("PNCCausante");

                entity.Property(e => e.Cdescri)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CDescri");

                entity.Property(e => e.Cestado).HasColumnName("CEstado");

                entity.Property(e => e.Cnombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNombre");
            });

            modelBuilder.Entity<PncdisDefi>(entity =>
            {
                entity.HasKey(e => e.IdDisDefi);

                entity.ToTable("PNCDisDefi");

                entity.Property(e => e.Dddescri)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DDDescri");

                entity.Property(e => e.Ddestado).HasColumnName("DDEstado");

                entity.Property(e => e.Ddnombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DDNombre");
            });

            modelBuilder.Entity<Pncestado>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.ToTable("PNCEstado");

                entity.Property(e => e.Edescri)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EDescri");

                entity.Property(e => e.Enombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENombre");

                entity.Property(e => e.Estatus).HasColumnName("EStatus");
            });

            modelBuilder.Entity<Pncidentif>(entity =>
            {
                entity.HasKey(e => e.IdIdentif);

                entity.ToTable("PNCIdentif");

                entity.Property(e => e.Idescri)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IDescri");

                entity.Property(e => e.Iestado).HasColumnName("IEstado");

                entity.Property(e => e.Inombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("INombre");
            });

            modelBuilder.Entity<PncproDisp>(entity =>
            {
                entity.HasKey(e => e.IdProDisp);

                entity.ToTable("PNCProDisp");

                entity.Property(e => e.Pddescri)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PDDescri");

                entity.Property(e => e.Pdestado).HasColumnName("PDEstado");

                entity.Property(e => e.Pdnombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("PDNombre");
            });

            modelBuilder.Entity<Pncriesgo>(entity =>
            {
                entity.HasKey(e => e.IdRiesgo);

                entity.ToTable("PNCRiesgo");

                entity.Property(e => e.Rdescri)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("RDescri");

                entity.Property(e => e.Restado).HasColumnName("REstado");

                entity.Property(e => e.Rnombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("RNombre");
            });

            modelBuilder.Entity<Pnctipo>(entity =>
            {
                entity.HasKey(e => e.IdTipo);

                entity.ToTable("PNCTipo");

                entity.Property(e => e.Tdescri)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TDescri");

                entity.Property(e => e.Testado).HasColumnName("TEstado");

                entity.Property(e => e.Tnombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("TNombre");
            });

            modelBuilder.Entity<Pncunidad>(entity =>
            {
                entity.HasKey(e => e.IdUnidad);

                entity.ToTable("PNCUnidad");

                entity.Property(e => e.Udescri)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("UDescri");

                entity.Property(e => e.Uestado).HasColumnName("UEstado");

                entity.Property(e => e.Unombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UNombre");
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

            modelBuilder.Entity<ProMejCont>(entity =>
            {
                entity.HasKey(e => e.IdProyecMc);

                entity.ToTable("ProMejCont");

                entity.Property(e => e.IdProyecMc).HasColumnName("IdProyecMC");

                entity.Property(e => e.Pmcalcance)
                    .HasColumnType("text")
                    .HasColumnName("PMCAlcance");

                entity.Property(e => e.Pmcaprobad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PMCAprobad");

                entity.Property(e => e.Pmccorrela).HasColumnName("PMCCorrela");

                entity.Property(e => e.PmcdesVer)
                    .HasColumnType("text")
                    .HasColumnName("PMCDesVer");

                entity.Property(e => e.PmcfechApr)
                    .HasColumnType("date")
                    .HasColumnName("PMCFechApr");

                entity.Property(e => e.PmcfechVer)
                    .HasColumnType("date")
                    .HasColumnName("PMCFechVer");

                entity.Property(e => e.Pmcgaranti)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PMCGaranti");

                entity.Property(e => e.Pmcobjetiv)
                    .HasColumnType("text")
                    .HasColumnName("PMCObjetiv");

                entity.Property(e => e.Pmcreque)
                    .HasColumnType("text")
                    .HasColumnName("PMCReque");

                entity.Property(e => e.Pmcrevisor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PMCRevisor");

                entity.Property(e => e.Pmcsolcita)
                    .IsUnicode(false)
                    .HasColumnName("PMCSolcita");

                entity.Property(e => e.PmctiemEst)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PMCTiemEst");

                entity.Property(e => e.Pmcver).HasColumnName("PMCVer");

                entity.HasOne(d => d.IdTipSolNavigation)
                    .WithMany(p => p.ProMejConts)
                    .HasForeignKey(d => d.IdTipSol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProMejCont_TipSolicit");
            });

            modelBuilder.Entity<ProNoCon>(entity =>
            {
                entity.HasKey(e => e.IdProNoCon);

                entity.ToTable("ProNoCon", "his");

                entity.Property(e => e.IdProNoCon).HasColumnName("idProNoCon");

                entity.Property(e => e.IdCausa).HasDefaultValueSql("((1))");

                entity.Property(e => e.Pnccantida).HasColumnName("PNCCantida");

                entity.Property(e => e.Pnccargador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PNCCargador");

                entity.Property(e => e.PnccauLibe)
                    .IsUnicode(false)
                    .HasColumnName("PNCCauLibe");

                entity.Property(e => e.PnccodProd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PNCCodProd");

                entity.Property(e => e.PncdesProd)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PNCDesProd");

                entity.Property(e => e.Pncfecha)
                    .HasColumnType("date")
                    .HasColumnName("PNCFecha");

                entity.Property(e => e.PncindLibe)
                    .IsUnicode(false)
                    .HasColumnName("PNCIndLibe");

                entity.Property(e => e.Pnclote)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PNCLote");

                entity.Property(e => e.PncordFabr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PNCOrdFabr");

                entity.HasOne(d => d.IdCausaNavigation)
                    .WithMany(p => p.ProNoCons)
                    .HasForeignKey(d => d.IdCausa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProNoCon_PNCCausa");

                entity.HasOne(d => d.IdDisDefiNavigation)
                    .WithMany(p => p.ProNoCons)
                    .HasForeignKey(d => d.IdDisDefi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProNoCon_PNCDisDefi");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.ProNoCons)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProNoCon_PNCEstado");

                entity.HasOne(d => d.IdIdentifNavigation)
                    .WithMany(p => p.ProNoCons)
                    .HasForeignKey(d => d.IdIdentif)
                    .HasConstraintName("FK_ProNoCon_PNCIdentif");

                entity.HasOne(d => d.IdLugaEvenNavigation)
                    .WithMany(p => p.ProNoCons)
                    .HasForeignKey(d => d.IdLugaEven)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProNoCon_Linea");

                entity.HasOne(d => d.IdProDispNavigation)
                    .WithMany(p => p.ProNoCons)
                    .HasForeignKey(d => d.IdProDisp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProNoCon_PNCProDisp");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.ProNoCons)
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProNoCon_PNCTipo");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.ProNoCons)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProNoCon_PNCUnidad");
            });

            modelBuilder.Entity<ProResp>(entity =>
            {
                entity.HasKey(e => e.IdProResp);

                entity.ToTable("ProResp");

                entity.Property(e => e.IdProyecMc).HasColumnName("IdProyecMC");

                entity.HasOne(d => d.IdProyecMcNavigation)
                    .WithMany(p => p.ProResps)
                    .HasForeignKey(d => d.IdProyecMc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProResp_ProMejCont");

                entity.HasOne(d => d.IdRspnsblPNavigation)
                    .WithMany(p => p.ProResps)
                    .HasForeignKey(d => d.IdRspnsblP)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProResp_RspnsblP");
            });

            modelBuilder.Entity<ProductoNoConforme>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductoNoConforme");

                entity.Property(e => e.AlternativaPropuestoDeDisposicion)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Alternativa Propuesto De Disposicion");

                entity.Property(e => e.CausaDeLiberación)
                    .IsUnicode(false)
                    .HasColumnName("Causa de Liberación");

                entity.Property(e => e.Causante)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoDeProducto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Codigo de Producto");

                entity.Property(e => e.DescripcionDeProducto)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Descripcion de Producto");

                entity.Property(e => e.DisposicionDefinitiva)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Disposicion Definitiva");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FichaDelCargador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ficha del Cargador");

                entity.Property(e => e.Identificacion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.IndicacionDeLiberacion)
                    .IsUnicode(false)
                    .HasColumnName("Indicacion de Liberacion");

                entity.Property(e => e.Lote)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LugarEvento)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Lugar Evento");

                entity.Property(e => e.NoConformidad)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("No Conformidad");

                entity.Property(e => e.OrdenDeFabricacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Orden de Fabricacion");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Unidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProyectoUsr>(entity =>
            {
                entity.HasKey(e => e.IdProyecto)
                    .HasName("PK_Proyecto_1");

                entity.ToTable("ProyectoUsr");

                entity.Property(e => e.Pestado).HasColumnName("PEstado");

                entity.Property(e => e.Pnombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PNombre");
            });

            modelBuilder.Entity<PuesTrab>(entity =>
            {
                entity.HasKey(e => e.IdPuesTrab);

                entity.ToTable("PuesTrab");

                entity.Property(e => e.Ptdescri)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PTDescri");

                entity.Property(e => e.Ptesta).HasColumnName("PTEsta");

                entity.Property(e => e.Ptnombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PTNombre");
            });

            modelBuilder.Entity<RegPaletPt>(entity =>
            {
                entity.HasKey(e => e.IdRegPal)
                    .HasName("PK_RegPaletasPT");

                entity.ToTable("RegPaletPT");

                entity.HasComment("Para Guardar data de Conteos Ciclicos de Paletas");

                entity.Property(e => e.Rpdate)
                    .HasColumnType("date")
                    .HasColumnName("RPDate")
                    .HasComment("Fecha de Carga");

                entity.Property(e => e.RpdifInv)
                    .HasColumnName("RPDifInv")
                    .HasComment("Resta entre Inventario contado menos el teorico");

                entity.Property(e => e.RpinvCont)
                    .HasColumnName("RPInvCont")
                    .HasComment("Inventario Contado Total");

                entity.Property(e => e.RpinvIni)
                    .HasColumnName("RPInvIni")
                    .HasComment("Inventario Inicial del Conteo");

                entity.Property(e => e.RpinvPalNc).HasColumnName("RPInvPalNC");

                entity.Property(e => e.RpinvPm)
                    .HasColumnName("RPInvPM")
                    .HasComment("Inventario en Pie de Maquina");

                entity.Property(e => e.RpinvPtCo)
                    .HasColumnName("RPInvPT_CO")
                    .HasComment("Inventario en Jaula de Paletas");

                entity.Property(e => e.RpinvTeori)
                    .HasColumnName("RPInvTeori")
                    .HasComment("Inventario Teorico al sumar Inventario Inicial, entrada y salidad de paletas");

                entity.Property(e => e.Rptime)
                    .HasColumnName("RPTime")
                    .HasComment("Hora de Carga");
            });

            modelBuilder.Entity<RegSaPtpcp>(entity =>
            {
                entity.HasKey(e => e.IdRegSal);

                entity.ToTable("RegSaPTPCP");

                entity.HasComment("Para guardar registros impresos de salida en Puerta 1");

                entity.Property(e => e.RscompVeh)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RSCompVeh")
                    .HasComment("Empresa vehiculo");

                entity.Property(e => e.Rsdate)
                    .HasColumnType("date")
                    .HasColumnName("RSDate")
                    .HasComment("Fecha de Salida");

                entity.Property(e => e.Rsdest)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RSDest")
                    .HasComment("Destino de la Unidad");

                entity.Property(e => e.Rsdetalle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RSDetalle")
                    .HasComment("Detalles de la unidad");

                entity.Property(e => e.RshoraEnt)
                    .HasColumnName("RSHoraEnt")
                    .HasComment("Hora de Entrada");

                entity.Property(e => e.RshoraSal)
                    .HasColumnName("RSHoraSal")
                    .HasComment("Hora de Salida");

                entity.Property(e => e.Rsobs)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RSObs")
                    .HasComment("Observacion");

                entity.Property(e => e.RsobsSist)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RSObsSist")
                    .HasComment("Observacion Hecha en BPCS");

                entity.Property(e => e.RsplacaVeh)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RSPlacaVeh")
                    .HasComment("Placa de vehiculo");

                entity.Property(e => e.RstickeSal)
                    .HasColumnName("RSTickeSal")
                    .HasComment("Numero de Ticket Salida");
            });

            modelBuilder.Entity<RespP>(entity =>
            {
                entity.HasKey(e => e.IdRespP);

                entity.ToTable("RespP");

                entity.HasComment("Respuesta de las preguntas por proyectos");

                entity.Property(e => e.IdRespP).HasComment("Identificador de la respuesta del proyecto");

                entity.Property(e => e.IdPregP).HasComment("identificador de la pregunta del proyecto");

                entity.Property(e => e.Rpcumpli)
                    .HasColumnName("RPCumpli")
                    .HasComment("nota de la pregunta");

                entity.Property(e => e.Rpobserv)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("RPObserv")
                    .HasComment("observacion de la pregunta");

                entity.HasOne(d => d.IdEncuestaNavigation)
                    .WithMany(p => p.RespPs)
                    .HasForeignKey(d => d.IdEncuesta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RespP_Encuesta");

                entity.HasOne(d => d.IdPregPNavigation)
                    .WithMany(p => p.RespPs)
                    .HasForeignKey(d => d.IdPregP)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RespP_PregP");
            });

            modelBuilder.Entity<RespoReu>(entity =>
            {
                entity.HasKey(e => e.IdResReu);

                entity.ToTable("RespoReu");

                entity.Property(e => e.Rrdesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RRDesc");

                entity.Property(e => e.Rresta).HasColumnName("RREsta");

                entity.Property(e => e.Rrnombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RRNombre");
            });

            modelBuilder.Entity<Resuman>(entity =>
            {
                entity.HasKey(e => e.IdResumen)
                    .HasName("PK__Resumen__C15B26E506657487");

                entity.Property(e => e.RfecPago)
                    .HasColumnType("datetime")
                    .HasColumnName("RFecPago");

                entity.Property(e => e.Rfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("RFecha");

                entity.Property(e => e.Rgrupo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RGrupo");

                entity.Property(e => e.Rsuplido)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("RSuplido");

                entity.Property(e => e.Rturno).HasColumnName("RTurno");

                entity.Property(e => e.RuserPago)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RUserPago");

                entity.Property(e => e.RuserVali)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RUserVali");

                entity.HasOne(d => d.IdMontosNavigation)
                    .WithMany(p => p.Resumen)
                    .HasForeignKey(d => d.IdMontos)
                    .HasConstraintName("FK_Resumen_Montos");

                entity.HasOne(d => d.IdPersonalNavigation)
                    .WithMany(p => p.Resumen)
                    .HasForeignKey(d => d.IdPersonal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Resumen_Personal");

                entity.HasOne(d => d.IdTipIncenNavigation)
                    .WithMany(p => p.Resumen)
                    .HasForeignKey(d => d.IdTipIncen)
                    .HasConstraintName("FK_Resumen_TipIncen");

                entity.HasOne(d => d.IdTipSupleNavigation)
                    .WithMany(p => p.Resumen)
                    .HasForeignKey(d => d.IdTipSuple)
                    .HasConstraintName("FK_Resumen_TipSuple");
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

                entity.HasOne(d => d.IdResReuNavigation)
                    .WithMany(p => p.ReuDia)
                    .HasForeignKey(d => d.IdResReu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReuDia_RespoReu");

                entity.HasOne(d => d.IdksfNavigation)
                    .WithMany(p => p.ReuDia)
                    .HasForeignKey(d => d.Idksf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReuDia_KSF");
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

            modelBuilder.Entity<ReunionDium>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AfectadoKsf)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_equipo");

                entity.Property(e => e.Discrepancia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Div)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Fecha2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaTrab)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_trab");

                entity.Property(e => e.FechaTrab1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fecha_trab1");

                entity.Property(e => e.OrdenTrabajo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanDeAccion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Plan_de_accion");

                entity.Property(e => e.Produfin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tiempo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReunionWebColombium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ReunionWebColombia");

                entity.Property(e => e.Acción)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Centro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Código)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Discrepancia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.División)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Equipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaReunión).HasColumnType("date");

                entity.Property(e => e.FechaTrabajo).HasColumnType("date");

                entity.Property(e => e.Kfs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KFS");

                entity.Property(e => e.Línea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Odt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ODT");

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tiempo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReunionWebGuatemala>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ReunionWebGuatemala");

                entity.Property(e => e.Acción)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Centro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Código)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Discrepancia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.División)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Equipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaReunión).HasColumnType("date");

                entity.Property(e => e.FechaTrabajo).HasColumnType("date");

                entity.Property(e => e.Kfs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KFS");

                entity.Property(e => e.Línea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Odt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ODT");

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tiempo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReunionWebVenezuela>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ReunionWebVenezuela");

                entity.Property(e => e.Acción)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Centro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Código)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Discrepancia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.División)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Equipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaReunión).HasColumnType("date");

                entity.Property(e => e.FechaTrabajo).HasColumnType("date");

                entity.Property(e => e.Kfs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KFS");

                entity.Property(e => e.Línea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Odt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ODT");

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol);

                entity.ToTable("Rol");

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
                    .HasColumnName("RPUsuario")
                    .HasDefaultValueSql("('Nulo')");
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

                entity.Property(e => e.TenumVuelt).HasColumnName("TENumVuelt");

                entity.Property(e => e.Teproducidos).HasColumnName("TEProducidos");

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

                entity.HasOne(d => d.IdAreAfectNavigation)
                    .WithMany(p => p.TieParTps)
                    .HasForeignKey(d => d.IdAreAfect)
                    .HasConstraintName("FK_TieParTP_AreAfect");

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
            });

            modelBuilder.Entity<TipIncen>(entity =>
            {
                entity.HasKey(e => e.IdTipIncen);

                entity.ToTable("TipIncen");

                entity.Property(e => e.Tidesc)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("TIDesc");

                entity.Property(e => e.Tiesta).HasColumnName("TIEsta");

                entity.Property(e => e.Tinombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TINombre");
            });

            modelBuilder.Entity<TipSolicit>(entity =>
            {
                entity.HasKey(e => e.IdTipSol);

                entity.ToTable("TipSolicit");

                entity.Property(e => e.Tsnombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TSNombre");
            });

            modelBuilder.Entity<TipSuple>(entity =>
            {
                entity.HasKey(e => e.IdTipSuple)
                    .HasName("PK__TipSuple__9ECDEC913F95291A");

                entity.ToTable("TipSuple");

                entity.Property(e => e.Tscausa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TSCausa");

                entity.Property(e => e.Tsdescri)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TSDescri");

                entity.Property(e => e.Tsestado).HasColumnName("TSEstado");
            });

            modelBuilder.Entity<TurnoTp>(entity =>
            {
                entity.HasKey(e => e.IdTurnoTp);

                entity.ToTable("TurnoTP");

                entity.HasComment("turnos de tiempo perdido");

                entity.Property(e => e.IdTurnoTp)
                    .HasColumnName("IdTurnoTP")
                    .HasComment("identificador del turno");

                entity.Property(e => e.Tcalidad)
                    .HasColumnName("TCalidad")
                    .HasComment("calidad del turno");

                entity.Property(e => e.TcodiProdu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TCodiProdu");

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

                entity.Property(e => e.ToperaFich)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TOperaFich")
                    .HasComment("identificador del operador");

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
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("Usuario");

                entity.HasComment("Responsable del proyecto");

                entity.HasIndex(e => e.UsUsuario, "IX_Usuario")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasComment("Identificador del usuario");

                entity.Property(e => e.UsApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsClave)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UsCorreo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsEstatus).HasComment("estatus(0:inactivo,1:activo)");

                entity.Property(e => e.UsFicha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("nombre del usuario");

                entity.Property(e => e.UsPass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsuariosPermiso>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Usuarios_Permisos");

                entity.Property(e => e.Centro)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Proyecto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsApellido)
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

            modelBuilder.Entity<VarAre>(entity =>
            {
                entity.HasKey(e => e.IdVarAre);

                entity.ToTable("VarAre");

                entity.HasComment("intermediario entre vareable de calidad y area");

                entity.Property(e => e.IdVarAre).HasComment("identificador de la Var_Are");

                entity.Property(e => e.IdParProdu).HasComment("identifiacador del area");

                entity.Property(e => e.IdVarCa).HasComment("identificador de la variable de calidad");

                entity.HasOne(d => d.IdParProduNavigation)
                    .WithMany(p => p.VarAres)
                    .HasForeignKey(d => d.IdParProdu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VarAre_ParProdu");

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

                entity.Property(e => e.Vcmax).HasColumnName("VCMax");

                entity.Property(e => e.Vcmin).HasColumnName("VCMin");

                entity.Property(e => e.Vcnom)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("VCNom")
                    .HasComment("nombre de la variable");

                entity.Property(e => e.Vcobj).HasColumnName("VCObj");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
