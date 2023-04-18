﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using s7_01.Api.DataAccess;

#nullable disable

namespace s7_01.Migrations
{
    [DbContext(typeof(VeterinariaContext))]
    [Migration("20230417170303_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Autorizacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("EsActiva")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaAutorizacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("MascotaId")
                        .HasColumnType("int");

                    b.Property<int>("VeterinariaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MascotaId");

                    b.HasIndex("VeterinariaId");

                    b.ToTable("Autorizaciones");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Direccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoPostal")
                        .HasColumnType("int");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdPersona")
                        .IsUnique();

                    b.ToTable("Direcciones");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.HistoriaClinica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comentarios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MascotaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MascotaId");

                    b.ToTable("Historias");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Peso")
                        .HasColumnType("DECIMAL(5,2)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("URLFotoPerfil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.MascotaPropietario", b =>
                {
                    b.Property<int>("MascotaId")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("PropietarioId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<bool>("EsPrincipal")
                        .HasColumnType("bit");

                    b.HasKey("MascotaId", "PropietarioId");

                    b.HasIndex("PropietarioId");

                    b.ToTable("MascotaPropietarios");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persona");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Costo")
                        .HasColumnType("DECIMAL(11,2)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VeterinariaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VeterinariaId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Recordatorio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreadorId")
                        .HasColumnType("int");

                    b.Property<int>("DestinatarioId")
                        .HasColumnType("int");

                    b.Property<int>("DiasPreviosNotificacion")
                        .HasColumnType("int");

                    b.Property<bool>("EsEmailEnviado")
                        .HasColumnType("bit");

                    b.Property<bool>("EsLeido")
                        .HasColumnType("bit");

                    b.Property<bool>("EsPushNotificationEnviada")
                        .HasColumnType("bit");

                    b.Property<bool>("EsSMSEnviado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNotificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DestinatarioId");

                    b.ToTable("Recordatorios");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Costo")
                        .HasColumnType("DECIMAL(11,2)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VeterinariaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VeterinariaId");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Tratamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DosisMedicamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("HistoriaClinicaId")
                        .HasColumnType("int");

                    b.Property<string>("NombreMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoTratamiento")
                        .HasColumnType("int");

                    b.Property<int>("VeterinariaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistoriaClinicaId");

                    b.HasIndex("VeterinariaId");

                    b.ToTable("Tratamientos");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Vacuna", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("EsDosisUnica")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaAplicacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("HistoriaClinicaId")
                        .HasColumnType("int");

                    b.Property<string>("LoteSerial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ProximaAplicacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HistoriaClinicaId");

                    b.ToTable("Vacunas");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Propietario", b =>
                {
                    b.HasBaseType("s7_01.Api.DataAccess.Models.Persona");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URLFotoPerfil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Propietario");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Veterinaria", b =>
                {
                    b.HasBaseType("s7_01.Api.DataAccess.Models.Persona");

                    b.Property<string>("CUIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoURI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Whatsapp")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Veterinaria");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Autorizacion", b =>
                {
                    b.HasOne("s7_01.Api.DataAccess.Models.Mascota", "Mascota")
                        .WithMany()
                        .HasForeignKey("MascotaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("s7_01.Api.DataAccess.Models.Veterinaria", "Veterinaria")
                        .WithMany()
                        .HasForeignKey("VeterinariaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mascota");

                    b.Navigation("Veterinaria");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Direccion", b =>
                {
                    b.HasOne("s7_01.Api.DataAccess.Models.Persona", "Persona")
                        .WithOne("Direccion")
                        .HasForeignKey("s7_01.Api.DataAccess.Models.Direccion", "IdPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.HistoriaClinica", b =>
                {
                    b.HasOne("s7_01.Api.DataAccess.Models.Mascota", "Mascota")
                        .WithMany()
                        .HasForeignKey("MascotaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mascota");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.MascotaPropietario", b =>
                {
                    b.HasOne("s7_01.Api.DataAccess.Models.Mascota", "Mascota")
                        .WithMany()
                        .HasForeignKey("MascotaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("s7_01.Api.DataAccess.Models.Propietario", "Propietario")
                        .WithMany()
                        .HasForeignKey("PropietarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mascota");

                    b.Navigation("Propietario");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Producto", b =>
                {
                    b.HasOne("s7_01.Api.DataAccess.Models.Veterinaria", "Veterinaria")
                        .WithMany("Productos")
                        .HasForeignKey("VeterinariaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Veterinaria");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Recordatorio", b =>
                {
                    b.HasOne("s7_01.Api.DataAccess.Models.Propietario", "Destinatario")
                        .WithMany()
                        .HasForeignKey("DestinatarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destinatario");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Servicio", b =>
                {
                    b.HasOne("s7_01.Api.DataAccess.Models.Veterinaria", "Veterinaria")
                        .WithMany("Servicios")
                        .HasForeignKey("VeterinariaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Veterinaria");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Tratamiento", b =>
                {
                    b.HasOne("s7_01.Api.DataAccess.Models.HistoriaClinica", "HistoriaClinica")
                        .WithMany("Tratamientos")
                        .HasForeignKey("HistoriaClinicaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("s7_01.Api.DataAccess.Models.Veterinaria", "Veterinaria")
                        .WithMany()
                        .HasForeignKey("VeterinariaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HistoriaClinica");

                    b.Navigation("Veterinaria");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Vacuna", b =>
                {
                    b.HasOne("s7_01.Api.DataAccess.Models.HistoriaClinica", "HistoriaClinica")
                        .WithMany("Vacunas")
                        .HasForeignKey("HistoriaClinicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HistoriaClinica");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.HistoriaClinica", b =>
                {
                    b.Navigation("Tratamientos");

                    b.Navigation("Vacunas");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Persona", b =>
                {
                    b.Navigation("Direccion");
                });

            modelBuilder.Entity("s7_01.Api.DataAccess.Models.Veterinaria", b =>
                {
                    b.Navigation("Productos");

                    b.Navigation("Servicios");
                });
#pragma warning restore 612, 618
        }
    }
}