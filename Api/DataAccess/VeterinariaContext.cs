﻿using Microsoft.EntityFrameworkCore;
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
        
        public virtual DbSet<Direccion> Direcciones { get; set; }

        public virtual DbSet<Propietario> Propietarios { get; set; }

        public virtual DbSet<Mascota> Mascotas { get; set; }

        public virtual DbSet<MascotaPropietario> MascotaPropietarios { get; set; }


        public virtual DbSet<Autorizacion> Autorizaciones { get; set; }

        public virtual DbSet<CarnetVacuna> CarnetVacunas { get; set; }


        //Veterinaria
        public virtual DbSet<Veterinaria> Veterinarias { get; set; }

        public virtual DbSet<HistoriaClinica> Historias { get; set; }
        public virtual DbSet<Tratamiento> Tratamientos { get; set; }

        public virtual DbSet<Producto> Productos { get; set; }

    }
}
