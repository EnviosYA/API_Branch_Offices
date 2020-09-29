using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PS.Template.Domain.Entities;

namespace PS.Template.API.Entities
{
    public partial class SucursalDBContext : DbContext
    {
        public SucursalDBContext()
        {
        }

        public SucursalDBContext(DbContextOptions<SucursalDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Direccion> Direccion { get; set; }
        public virtual DbSet<Localidad> Localidad { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Sucursal> Sucursal { get; set; }
        public virtual DbSet<EstadoSucursal> EstadoSucursal { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Direccion>(entity =>
            {
                entity.HasKey(e => e.IdDireccion);

                entity.Property(e => e.IdDireccion)
                    .HasColumnName("idDireccion");

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdLocalidad).HasColumnName("idLocalidad");

                entity.Property(e => e.Latitud)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdLocalidadNavigation)
                    .WithMany(p => p.Direccion)
                    .HasForeignKey(d => d.IdLocalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Direccion_Localidad");
            });            

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.HasKey(e => e.IdProvincia);

                entity.Property(e => e.IdProvincia)
                    .HasColumnName("idProvincia")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasData(new Provincia
                {
                    IdProvincia = 1,
                    Nombre = "Buenos Aires",
                });
            });

            modelBuilder.Entity<Localidad>(entity =>
            {
                entity.HasKey(e => e.IdLocalidad);

                entity.Property(e => e.IdLocalidad)
                    .HasColumnName("idLocalidad")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cp).HasColumnName("CP");

                entity.Property(e => e.IdProvincia).HasColumnName("idProvincia");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Localidad)
                    .HasForeignKey(d => d.IdProvincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Localidad_Provincia");


                entity.HasData(new Localidad
                {
                    IdLocalidad = 1,
                    Nombre = "Retiro seccion 1",
                    Cp = 1001,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 2,
                    Nombre = "Monserrat seccion 1",
                    Cp = 1002,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 3,
                    Nombre = "San Nicolas seccion 1",
                    Cp = 1003,
                    IdProvincia = 1,
                });

                entity.HasData(new Localidad
                {
                    IdLocalidad = 4,
                    Nombre = "San Nicolas seccion 2",
                    Cp = 1004,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 5,
                    Nombre = "San Nicolas seccion 3",
                    Cp = 1005,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 6,
                    Nombre = "Retiro seccion 2",
                    Cp = 1006,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 7,
                    Nombre = "Retiro seccion 3",
                    Cp = 1007,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 8,
                    Nombre = "Monserrat seccion 2",
                    Cp = 1001,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 9,
                    Nombre = "San Nicolas seccion 4",
                    Cp = 1009,
                    IdProvincia = 1,
                });

                entity.HasData(new Localidad
                {
                    IdLocalidad = 10,
                    Nombre = "San Nicolas seccion 5",
                    Cp = 1010,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 11,
                    Nombre = "Retiro seccion 4",
                    Cp = 1011,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 12,
                    Nombre = "Monserrat seccion 3",
                    Cp = 1012,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 13,
                    Nombre = "San Nicolas seccion 6",
                    Cp = 1013,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 14,
                    Nombre = "Recoleta seccion 1",
                    Cp = 1014,
                    IdProvincia = 1,
                });

                entity.HasData(new Localidad
                {
                    IdLocalidad = 15,
                    Nombre = "San Nicolas seccion 7",
                    Cp = 1015,
                    IdProvincia = 1,
                });

                entity.HasData(new Localidad
                {
                    IdLocalidad = 16,
                    Nombre = "Recoleta seccion 2",
                    Cp = 1016,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 17,
                    Nombre = "San Nicolas seccion seccion 8",
                    Cp = 1017,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 18,
                    Nombre = "Recoleta seccion 3",
                    Cp = 1018,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 19,
                    Nombre = "Recoleta seccion 4",
                    Cp = 1019,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 20,
                    Nombre = "Recoleta seccion 5",
                    Cp = 1020,
                    IdProvincia = 1,
                });
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                entity.HasKey(e => e.IdSucursal);

                entity.Property(e => e.IdSucursal)
                    .HasColumnName("idSucursal")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdDireccion).HasColumnName("idDireccion");
                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDireccionNavigation)
                    .WithMany(p => p.Sucursal)
                    .HasForeignKey(d => d.IdDireccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sucursal_Direccion");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");               

                entity.HasOne(d => d.IdEstadoNavigation)
                   .WithMany(p => p.Sucursal)
                   .HasForeignKey(d => d.IdEstado)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_Sucursal_EstadoSucursal");
            });

            modelBuilder.Entity<EstadoSucursal>(entity =>
            {
                entity.HasKey(e => e.idEstado);

                entity.Property(e => e.idEstado)
                        .HasColumnName("idEstado")
                        .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
                
                entity.ToTable("EstadoSucursal");
                entity.HasData(new EstadoSucursal { idEstado = 1, Descripcion = "Habilitada" });
                entity.HasData(new EstadoSucursal { idEstado = 2, Descripcion = "Inhabilitada" });
            });            
        }
    }
}
