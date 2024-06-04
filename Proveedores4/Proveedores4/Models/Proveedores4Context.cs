using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Proveedores4.Models
{
    public partial class Proveedores4Context : DbContext
    {
        public Proveedores4Context()
        {
        }

        public Proveedores4Context(DbContextOptions<Proveedores4Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Proveedore> Proveedores { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("server=DESKTOP-54M18O1\\DIEGO; database=Proveedores4; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasIndex(e => e.Cuit, "UQ__Proveedo__F46C159864DFDF83")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Postal");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Correo_Electronico");

                entity.Property(e => e.Cuit)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CUIT")
                    .IsFixedLength();

                entity.Property(e => e.DireccionCalle)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Direccion_Calle");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Registro");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SitioWeb)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Sitio_Web");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProductosServicios)
                    .HasColumnType("text")
                    .HasColumnName("Tipo_Productos_servicios");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
