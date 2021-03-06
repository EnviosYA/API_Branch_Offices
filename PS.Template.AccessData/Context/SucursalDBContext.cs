﻿using Microsoft.EntityFrameworkCore;
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
            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.HasKey(e => e.IdProvincia);

                entity.Property(e => e.IdProvincia)
                    .HasColumnName("idProvincia");

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
                    .HasColumnName("idLocalidad");

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
                    Nombre = "Retiro",
                    Cp = 1001,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 2,
                    Nombre = "Monserrat",
                    Cp = 1002,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 3,
                    Nombre = "Florencio Varela",
                    Cp = 1888,
                    IdProvincia = 1,
                });

                entity.HasData(new Localidad
                {
                    IdLocalidad = 4,
                    Nombre = "Quilmes",
                    Cp = 1878,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 5,
                    Nombre = "Avellaneda",
                    Cp = 1870,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 6,
                    Nombre = "Berazategui",
                    Cp = 1884,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 7,
                    Nombre = "Lanus",
                    Cp = 1824,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 8,
                    Nombre = "Banfield",
                    Cp = 1828,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 9,
                    Nombre = "La Plata",
                    Cp = 1900,
                    IdProvincia = 1,
                });

                entity.HasData(new Localidad
                {
                    IdLocalidad = 10,
                    Nombre = "Ranelagh",
                    Cp = 1886,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 11,
                    Nombre = "San Francisco Solano",
                    Cp = 1846,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 12,
                    Nombre = "Berisso",
                    Cp = 1923,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 13,
                    Nombre = "Wilde",
                    Cp = 1875,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 14,
                    Nombre = "Chascomus",
                    Cp = 7130,
                    IdProvincia = 1,
                });

                entity.HasData(new Localidad
                {
                    IdLocalidad = 15,
                    Nombre = "Punta Lara",
                    Cp = 1931,
                    IdProvincia = 1,
                });

                entity.HasData(new Localidad
                {
                    IdLocalidad = 16,
                    Nombre = "Guillermo Hudson",
                    Cp = 1885,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 17,
                    Nombre = "Bernal",
                    Cp = 1876,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 18,
                    Nombre = "Recoleta",
                    Cp = 1018,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 19,
                    Nombre = "Punta Indio",
                    Cp = 1917,
                    IdProvincia = 1,
                });
                entity.HasData(new Localidad
                {
                    IdLocalidad = 20,
                    Nombre = "Temperley",
                    Cp = 1874,
                    IdProvincia = 1,
                });

            });

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

                entity.HasData(new Direccion
                {
                    IdDireccion = 1,
                    Latitud = -34.5901743,
                    Longitud = -58.3796545,
                    Calle = "Av. del Libertador",
                    Altura = 408,
                    IdLocalidad = 1,
                });

                entity.HasData(new Direccion
                {
                    IdDireccion = 2,
                    Latitud = -34.613230,
                    Longitud = -58.383805,
                    Calle = "Av. Belgrano",
                    Altura = 1201,
                    IdLocalidad = 2,
                });
                entity.HasData(new Direccion
                {
                    IdDireccion = 3,
                    Latitud = -34.796817,
                    Longitud = -58.279027,
                    Calle = "Av. Gral. José de San Martín",
                    Altura = 1999,
                    IdLocalidad = 3,
                });
                entity.HasData(new Direccion
                {
                    IdDireccion = 4,
                    Latitud = -34.725701,
                    Longitud = -58.262265,
                    Calle = "3 de Febrero",
                    Altura = 204,
                    IdLocalidad = 4,
                });
            });

            modelBuilder.Entity<EstadoSucursal>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.Property(e => e.IdEstado)
                        .HasColumnName("IdEstado")
                        .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.ToTable("EstadoSucursal");
                entity.HasData(new EstadoSucursal { IdEstado = 1, Descripcion = "Habilitada" });
                entity.HasData(new EstadoSucursal { IdEstado = 2, Descripcion = "Inhabilitada" });
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                entity.HasKey(e => e.IdSucursal);

                entity.Property(e => e.IdSucursal)
                    .HasColumnName("idSucursal");

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

                entity.Property(e => e.IdEstado).HasColumnName("IdEstado");               

                entity.HasOne(d => d.IdEstadoNavigation)
                   .WithMany(p => p.Sucursal)
                   .HasForeignKey(d => d.IdEstado)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_Sucursal_EstadoSucursal");

                entity.HasData(new Sucursal
                {
                    IdSucursal = 1,
                    Nombre = "EnvioYa Retiro",
                    IdDireccion = 1,
                    IdEstado = 1,
                });
                entity.HasData(new Sucursal
                {
                    IdSucursal = 2,
                    Nombre = "EnvioYa Monserrat",
                    IdDireccion = 2,
                    IdEstado = 1,
                });
                entity.HasData(new Sucursal
                {
                    IdSucursal = 3,
                    Nombre = "EnvioYa Florencio Varela",
                    IdDireccion = 3,
                    IdEstado = 1,
                });
                entity.HasData(new Sucursal
                {
                    IdSucursal = 4,
                    Nombre = "EnvioYa Quilmes",
                    IdDireccion = 4,
                    IdEstado = 1,
                });
            });                     
        }
    }
}
