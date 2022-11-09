using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LibroNovedades.ModelsDocIng
{
    public partial class DOC_IngIContext : DbContext
    {
        public DOC_IngIContext()
        {
        }

        public DOC_IngIContext(DbContextOptions<DOC_IngIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BdDiv1> BdDiv1s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=10.20.1.60\\DBVEN01;Database=DOC_IngI;TrustServerCertificate=True;Persist Security Info=True;User ID=usrDocIng;Password=usrDoc08*Sq*");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BdDiv1>(entity =>
            {
                entity.ToTable("BD_Div1");

                entity.Property(e => e.Id).HasColumnName("ID");

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

                entity.Property(e => e.Ksf)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanDeAccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plan_de_accion");

                entity.Property(e => e.Produfin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ps)
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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
