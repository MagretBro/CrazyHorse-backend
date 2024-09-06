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


            modelBuilder.Entity<ClimbingRoute>().HasData(
            new ClimbingRoute { ClimbingRouteId = 100099, Name = "Suud Suud Jai / Put Your Heart Into It", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport 22m", BoltCount = 14, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100100, Name = "Kra Ten Kong Hua Jai / Heartbeat", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport 18m", BoltCount = 11, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100101, Name = "Gam Lang Jai / Spirit, Morale", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport 18m", BoltCount = 11, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100102, Name = "Jai Kwang / Open-Minded", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport 26m", BoltCount = 15, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100103, Name = "Unknown", Describe = "Описание трассы", Category = "6c+", Testimonial = "Sport 25m", BoltCount = 16, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100104, Name = "Pah Dtat Hua Jai / Heart Surgery", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 25m", BoltCount = 13, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100105, Name = "Mar Jark Jai / Heartfelt", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 25m", BoltCount = 15, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100106, Name = "Tang Jai / Intentions", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 25m", BoltCount = 15, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100107, Name = "Deung Duut Jai / Attractive", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 20m", BoltCount = 13, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100108, Name = "Jai Tuud / Wimp", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 18m", BoltCount = 12, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100109, Name = "Jai Rag / I Love My Heart", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 16m", BoltCount = 12, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100110, Name = "Kob Jai Lai Lai / Thank You Very Much", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 16m", BoltCount = 10, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100111, Name = "Rang Lai Jai / Hesitate", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 16m", BoltCount = 11, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100112, Name = "Song Jit Song Jai / I'm Torn", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 16m", BoltCount = 11, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100113, Name = "Jai Ngai / Gullible", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 12m", BoltCount = 9, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100114, Name = "Pun Jai / Proud", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 13m", BoltCount = 9, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100115, Name = "Jai Guide / Guide Heart", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport 13m", BoltCount = 6, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100116, Name = "Mun Jai / Confident", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport 19m", BoltCount = 10, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100117, Name = "Jai Yen Yen / Patient / The Proposal / Calm", Describe = "Описание трассы", Category = "6c+", Testimonial = "Sport 21m", BoltCount = 11, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100118, Name = "Jai Glah Reu Plao / Are You Courageous?", Describe = "Описание трассы", Category = "7a+", Testimonial = "Sport 22m", BoltCount = 10, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100119, Name = "Dee Jai Tee Dai Geud / It's Great to be Alive", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport 19m", BoltCount = 10, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100120, Name = "Saht Jai / Satisfied", Describe = "Описание трассы", Category = "6c+", Testimonial = "Sport 16m", BoltCount = 9, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100121, Name = "Dtat Sin Jai / Decide", Describe = "Описание трассы", Category = "6c+", Testimonial = "Sport 14m", BoltCount = 9, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100122, Name = "Jai Det / Fearless", Describe = "Описание трассы", Category = "7a+", Testimonial = "Sport 13m", BoltCount = 7, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100123, Name = "Pak Jai / Rest Your Heart", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 20m", BoltCount = 10, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100124, Name = "Blaek Jai / Surprised / Wondering", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 21m", BoltCount = 9, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100125, Name = "Bratup Jai / Impressed", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport 22m", BoltCount = 12, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100126, Name = "Jai Rawn / Hot Headed", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 27m", BoltCount = 13, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100127, Name = "Ruam Jai / Together", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 36m", BoltCount = 17, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100128, Name = "Jai Teung Jai / Heart to Heart", Describe = "Описание трассы", Category = "6c+", Testimonial = "Sport 35m", BoltCount = 18, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100129, Name = "Jai Loy / Spaced-Out", Describe = "Описание трассы", Category = "7a+", Testimonial = "Sport 23m", BoltCount = 10, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100130, Name = "Dtang Jai / Conscious", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport 25m", BoltCount = 10, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100131, Name = "Hua Jai Wai / Heart Attack", Describe = "Описание трассы", Category = "6c+", Testimonial = "Sport 10m", BoltCount = 8, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100132, Name = "Jaod Jai / Sincere", Describe = "Описание трассы", Category = "7a", Testimonial = "Sport 30m", BoltCount = 12, SectorId = 1 },
            new ClimbingRoute { ClimbingRouteId = 100133, Name = "Kuu Jai / Twin Heart", Describe = "Описание трассы", Grade = "5c", Testimonial = "Sport 15m", BoltCount = 9, SectorId = 1 },
    new ClimbingRoute { ClimbingRouteId = 100134, Name = "Dtok Jai / Startled", Describe = "Описание трассы", Grade = "6a+", Testimonial = "Sport 17m", BoltCount = 14, SectorId = 1 },
    new ClimbingRoute { ClimbingRouteId = 100135, Name = "Peaun Jai Rai / My Friend is Mean", Describe = "Описание трассы", Grade = "5a", Testimonial = "Sport 18m", BoltCount = 11, SectorId = 1 },
    new ClimbingRoute { ClimbingRouteId = 100136, Name = "Heun Fah / Ascending the Sky", Describe = "Описание трассы", Grade = "5b", Testimonial = "Sport 21m", BoltCount = 5, ThreadCount = 2, SectorId = 2 },
    new ClimbingRoute { ClimbingRouteId = 100137, Name = "A Route with a View", Describe = "Описание трассы", Grade = "5c+", Testimonial = "Sport 22m", BoltCount = 8, ThreadCount = 2, SectorId = 2 },
    new ClimbingRoute { ClimbingRouteId = 100138, Name = "Skyscraper", Describe = "Описание трассы", Grade = "6a+", Testimonial = "Sport 29m", BoltCount = 11, SectorId = 2 },
    new ClimbingRoute { ClimbingRouteId = 100139, Name = "The Keymaster", Describe = "Описание трассы", Grade = "6c", Testimonial = "Sport 25m", BoltCount = 14, SectorId = 3 },
    new ClimbingRoute { ClimbingRouteId = 100140, Name = "The Gatekeeper", Describe = "Описание трассы", Grade = "6b", Testimonial = "Sport 25m", BoltCount = 8, ThreadCount = 1, SectorId = 3 },
    new ClimbingRoute { ClimbingRouteId = 100141, Name = "Inferno", Describe = "Описание трассы", Grade = "7a", Testimonial = "Sport 29m", BoltCount = 8, ThreadCount = 1, SectorId = 3 },
    new ClimbingRoute { ClimbingRouteId = 100142, Name = "Unleash the Phat Physique", Describe = "Описание трассы", Grade = "7a", Testimonial = "Sport 28m", BoltCount = 9, ThreadCount = 1, SectorId = 3 },
    new ClimbingRoute { ClimbingRouteId = 100143, Name = "All Quiet on the Eastern Front", Describe = "Описание трассы", Grade = "7a", Testimonial = "Sport 24m", BoltCount = 8, ThreadCount = 1, SectorId = 3 },
    new ClimbingRoute { ClimbingRouteId = 100144, Name = "No name", Describe = "Описание трассы", Grade = "6b+", Testimonial = "Sport", SectorId = 3 },
    new ClimbingRoute { ClimbingRouteId = 100145, Name = "Short Tail", Describe = "Описание трассы", Grade = "5a", Testimonial = "Sport 12m", BoltCount = 7, SectorId = 4 },
    new ClimbingRoute { ClimbingRouteId = 100146, Name = "Cave Man", Describe = "Описание трассы", Grade = "5b", Testimonial = "Sport 16m", BoltCount = 9, SectorId = 4 },
    new ClimbingRoute { ClimbingRouteId = 100147, Name = "Horse's Heart", Describe = "Описание трассы", Grade = "5c", Testimonial = "Sport 11m", BoltCount = 6, SectorId = 4 },
    new ClimbingRoute { ClimbingRouteId = 100148, Name = "The Underworld", Describe = "Описание трассы", Grade = "5c", Testimonial = "Sport 15m", BoltCount = 9, SectorId = 4 },
    new ClimbingRoute { ClimbingRouteId = 100149, Name = "Beautiful Mess", Describe = "Описание трассы", Grade = "6a", Testimonial = "Sport 19m", BoltCount = 12, SectorId = 4 },
    new ClimbingRoute { ClimbingRouteId = 100150, Name = "The End of Relationships", Describe = "Описание трассы", Grade = "5c", Testimonial = "Sport 12m", SectorId = 4 },
    new ClimbingRoute { ClimbingRouteId = 100151, Name = "The Underground", Describe = "Описание трассы", Grade = "5c", Testimonial = "Sport 11m", BoltCount = 6, SectorId = 4 },
    new ClimbingRoute { ClimbingRouteId = 100152, Name = "In Deep Space", Describe = "Описание трассы", Grade = "5c", Testimonial = "Sport 80m", BoltCount = 4, SectorId = 4 },
    new ClimbingRoute { ClimbingRouteId = 100153, Name = "Spaceman Pitch 1", Describe = "Описание трассы", Grade = "6c", Testimonial = "Sport 25m", BoltCount = 10, SectorId = 4 },
    new ClimbingRoute { ClimbingRouteId = 100154, Name = "Spaceman Pitch 2", Describe = "Описание трассы", Grade = "7b+", Testimonial = "Sport 30m", BoltCount = 15, SectorId = 4 },
    new ClimbingRoute { ClimbingRouteId = 100155, Name = "Space Manouevers Pitch 1", Describe = "Описание трассы", Grade = "6c", Testimonial = "Sport 30m", BoltCount = 12, SectorId = 4 },
    new ClimbingRoute { ClimbingRouteId = 100156, Name = "Space Manoeuvers Pitch 2", Describe = "Описание трассы", Grade = "7b", Testimonial = "Sport 15m", BoltCount = 7, SectorId = 4 },
    new ClimbingRoute { ClimbingRouteId = 100157, Name = "Space Manoeuvers Pitch 3", Describe = "Описание трассы", Grade = "7b", Testimonial = "Sport 25m", BoltCount = 9, SectorId = 4 },
    new ClimbingRoute { ClimbingRouteId = 100158, Name = "Sunseeker Pitch 1", Describe = "Описание трассы", Grade = "6c+", Testimonial = "Sport 22m", BoltCount = 9, SectorId = 4 },
    new ClimbingRoute { ClimbingRouteId = 100159, Name = "Sunseeker Pitch 2", Describe = "Описание трассы", Grade = "6b+", Testimonial = "Sport 25m", BoltCount = 6, SectorId = 4 },
    new ClimbingRoute { ClimbingRouteId = 100160, Name = "Anxiety State Crisis / Anxiety State Crisis Pitch 2 42m", Describe = "Описание трассы", Grade = "7a", Testimonial = "Sport 42m", BoltCount = 11, SectorId = 4 },
    new ClimbingRoute { ClimbingRouteId = 100161, Name = "10mg Boulder", Describe = "Описание трассы", Grade = "V4", Testimonial = "Boulder 3m", SectorId = 4 },
    new ClimbingRoute { ClimbingRouteId = 100162, Name = "Reminisce", Describe = "Описание трассы", Grade = "6a", Testimonial = "Sport 11m", BoltCount = 5, SectorId = 5 },
    new ClimbingRoute { ClimbingRouteId = 100163, Name = "Reunion 52m", Describe = "Описание трассы", Grade = "6a+", Testimonial = "Sport 52m", BoltCount = 23, SectorId = 5 },
    new ClimbingRoute { ClimbingRouteId = 100164, Name = "Handsome and Old", Describe = "Описание трассы", Grade = "5b+", Testimonial = "Sport 12m", BoltCount = 9, SectorId = 5 },
    new ClimbingRoute { ClimbingRouteId = 100165, Name = "Teamwork", Describe = "Описание трассы", Grade = "5c", Testimonial = "Sport 13m", BoltCount = 9, SectorId = 5 },
    new ClimbingRoute { ClimbingRouteId = 100166, Name = "Smells Like Team Spirit", Describe = "Описание трассы", Grade = "6a", Testimonial = "Sport 16m", BoltCount = 10, SectorId = 5 },
);



        }
    }
}