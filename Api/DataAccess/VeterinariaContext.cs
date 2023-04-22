using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Drawing;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.DataAccess
{
    public class VeterinariaContext : DbContext
    {
        public VeterinariaContext(DbContextOptions<VeterinariaContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de Tratamiento
            modelBuilder.Entity<Tratamiento>()
                .HasOne(t => t.HistoriaClinica)
                .WithMany(h => h.Tratamientos)
                .HasForeignKey(t => t.HistoriaClinicaId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public virtual DbSet<Direccion> Direcciones { get; set; }

        public virtual DbSet<Propietario> Propietarios { get; set; }

        public virtual DbSet<Mascota> Mascotas { get; set; }

        public virtual DbSet<MascotaPropietario> MascotaPropietarios { get; set; }

        public virtual DbSet<Autorizacion> Autorizaciones { get; set; }

        public virtual DbSet<Vacuna> Vacunas { get; set; }

        public virtual DbSet<Veterinaria> Veterinarias { get; set; }

        public virtual DbSet<HistoriaClinica> Historias { get; set; }

        public virtual DbSet<Tratamiento> Tratamientos { get; set; }

        public virtual DbSet<Producto> Productos { get; set; }

        public virtual DbSet<Servicio> Servicios { get; set; }

        public virtual DbSet<Recordatorio> Recordatorios { get; set; }


        //Usuario
        public virtual DbSet<Usuario> Usuarios { get; set;}
        public virtual DbSet<Role> Roles { get; set; }

    }
}
