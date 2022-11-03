using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Practica6.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Departamento> Departamentos { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<Funcione> Funciones { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("SQL"));
            }
            //optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=BlazorCrud;integrated security=True;");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>(entity =>
            {

                entity.HasKey(e => e.IntId);
                entity.Property(e => e.IntId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IntId);
                entity.Property(e => e.IntId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Funcione>(entity =>
            {
                entity.HasKey(e => e.IntId);
                entity.Property(e => e.IntId).ValueGeneratedOnAdd();

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
