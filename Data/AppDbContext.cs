using Backcrazyhorse.Models;
using Microsoft.EntityFrameworkCore;

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
                .HasMany(s => s.ClimbingRoute)
                .WithOne(cr => cr.Sector)
                .HasForeignKey(cr => cr.SectorId);
            }
        }
}