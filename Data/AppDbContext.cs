using Backcrazyhorse.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Backcrazyhorse.Data;

namespace Backcrazyhorse.Data
{
        public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Massive> Massives { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<ClimbingRoute> ClimbingRoutes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>()
                .HasMany(c => c.Regions)
                .WithOne(r => r.Country)
                .HasForeignKey (r => r.CountryId);

            modelBuilder.Entity<Region>()
                .HasMany(r => r.Massives)
                .WithOne(m => m.Region) 
                .HasForeignKey(m => m.RegionId);

            modelBuilder.Entity<Massive>()
                .HasMany(m => m.Sectors)
                .WithOne(s => s.Massive)
                .HasForeignKey(s => s.MassiveId);

            modelBuilder.Entity<Sector>()
                .HasMany(s => s.ClimbingRoutes)
                .WithOne(cr => cr.Sector)
                .HasForeignKey(cr => cr.SectorId);

            modelBuilder.Entity<ClimbingRoute>()
                .HasMany(c => c.Images);

             modelBuilder.Entity<Image>()
                .HasOne(i => i.ClimbingRoute)
                .WithMany(cr => cr.Images)
                .HasForeignKey(i => i.ClimbingRouteId);

            modelBuilder.Entity<Image>()
                .HasOne(i => i.Sector)
                .WithMany(s => s.Images)
                .HasForeignKey(i => i.SectorId);


            modelBuilder.Entity<Sector>().HasData(
                new Sector { SectorId = 1, Name = "Heart Wall", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 2, Name = "rooftop", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 3, Name = "The Gatekeeper Buttress", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 4, Name = "Anxiety State Crisis Cave", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 5, Name = "Reunion Buttress", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 6, Name = "Buddha Buttress", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 7, Name = "The Aircon Wall", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 8, Name = "Windy Cave", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 9, Name = "Crazy Horse Area", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 10, Name = "The Horse Shoe", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 11, Name = "The Archway", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 12, Name = "The Evening Terraces", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 13, Name = "The Furnace", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 14, Name = "The Junkyard", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 15, Name = "The Hanging Gardens", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 16, Name = "Tamarind Village", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 17, Name = "Little Monkey Cove", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 18, Name = "Vision", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 19, Name = "Naam Prik Wall", Describe = "Описание сектора", MassiveId = 111 },
                new Sector { SectorId = 20, Name = "The Ant Hill", Describe = "Описание сектора", MassiveId = 111 }
);


        }
    }
}