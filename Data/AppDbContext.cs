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


           
            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId=101010, Name="Thailand" } 
            );

            modelBuilder.Entity<Region>().HasData(
                new Region { RegionId=110101000, Name="Chiang Mai", CountryId=101010 } 
            );

            modelBuilder.Entity<Massive>().HasData(
                new Massive { MassiveId=111, RegionId=110101000, Name="Crazy Horse Buttress" } 
            );

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
                new ClimbingRoute { ClimbingRouteId = 100132, Name = "Duang Jai / Flame Heart", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 25m", BoltCount = 13, SectorId = 1 },
                new ClimbingRoute { ClimbingRouteId = 100133, Name = "Kuu Jai / Twin Heart", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 15m", BoltCount = 9, SectorId = 1 },
                new ClimbingRoute { ClimbingRouteId = 100134, Name = "Dtok Jai / Startled", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 17m", BoltCount = 14, SectorId = 1 },
                new ClimbingRoute { ClimbingRouteId = 100135, Name = "Peaun Jai Rai / My Friend is Mean", Describe = "Описание трассы", Category = "5a", Testimonial = "Sport 18m", BoltCount = 11, SectorId = 1 },
                new ClimbingRoute { ClimbingRouteId = 100136, Name = "Heun Fah / Ascending the Sky", Describe = "Описание трассы", Category = "5b", Testimonial = "Sport 21m", BoltCount = 5, SectorId = 2 },
                new ClimbingRoute { ClimbingRouteId = 100137, Name = "A Route with a View", Describe = "Описание трассы", Category = "5c+", Testimonial = "Sport 22m", BoltCount = 8, SectorId = 2 },
                new ClimbingRoute { ClimbingRouteId = 100138, Name = "Skyscraper", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 29m", BoltCount = 11, SectorId = 2 },
                new ClimbingRoute { ClimbingRouteId = 100139, Name = "The Keymaster", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport 25m", BoltCount = 14, SectorId = 3 },
                new ClimbingRoute { ClimbingRouteId = 100140, Name = "The Gatekeeper", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 25m", BoltCount = 8, SectorId = 3 },
                new ClimbingRoute { ClimbingRouteId = 100141, Name = "Inferno", Describe = "Описание трассы", Category = "7a", Testimonial = "Sport 29m", BoltCount = 8, SectorId = 3 },
                new ClimbingRoute { ClimbingRouteId = 100142, Name = "Unleash the Phat Physique", Describe = "Описание трассы", Category = "7a", Testimonial = "Sport 28m", BoltCount = 9, SectorId = 3 },
                new ClimbingRoute { ClimbingRouteId = 100143, Name = "All Quiet on the Eastern Front", Describe = "Описание трассы", Category = "7a", Testimonial = "Sport 24m", BoltCount = 8, SectorId = 3 },
                new ClimbingRoute { ClimbingRouteId = 100144, Name = "No name", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport", SectorId = 3 },
                new ClimbingRoute { ClimbingRouteId = 100145, Name = "Short Tail", Describe = "Описание трассы", Category = "5a", Testimonial = "Sport 12m", BoltCount = 7, SectorId = 4 },
                new ClimbingRoute { ClimbingRouteId = 100146, Name = "Cave Man", Describe = "Описание трассы", Category = "5b", Testimonial = "Sport 16m", BoltCount = 9, SectorId = 4 },
                new ClimbingRoute { ClimbingRouteId = 100147, Name = "Horse's Heart", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 11m", BoltCount = 6, SectorId = 4 },
                new ClimbingRoute { ClimbingRouteId = 100148, Name = "The Underworld", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 15m", BoltCount = 9, SectorId = 4 },
                new ClimbingRoute { ClimbingRouteId = 100149, Name = "Beautiful Mess", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 19m", BoltCount = 12, SectorId = 4 },
                new ClimbingRoute { ClimbingRouteId = 100150, Name = "The End of Relationships", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 12m", SectorId = 4 },
                new ClimbingRoute { ClimbingRouteId = 100151, Name = "The Underground", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 11m", BoltCount = 6, SectorId = 4 },
                new ClimbingRoute { ClimbingRouteId = 100152, Name = "In Deep Space", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 80m", BoltCount = 4, SectorId = 4 },
                new ClimbingRoute { ClimbingRouteId = 100153, Name = "Spaceman Pitch 1", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport 25m", BoltCount = 10, SectorId = 4 },
                new ClimbingRoute { ClimbingRouteId = 100154, Name = "Spaceman Pitch 2", Describe = "Описание трассы", Category = "7b+", Testimonial = "Sport 30m", BoltCount = 15, SectorId = 4 },
                new ClimbingRoute { ClimbingRouteId = 100155, Name = "Space Manouevers Pitch 1", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport 30m", BoltCount = 12, SectorId = 4 },
                new ClimbingRoute { ClimbingRouteId = 100156, Name = "Space Manoeuvers Pitch 2", Describe = "Описание трассы", Category = "7b", Testimonial = "Sport 15m", BoltCount = 7, SectorId = 4 },
                new ClimbingRoute { ClimbingRouteId = 100157, Name = "Space Manoeuvers Pitch 3", Describe = "Описание трассы", Category = "7b", Testimonial = "Sport 25m", BoltCount = 9, SectorId = 4 },
                new ClimbingRoute { ClimbingRouteId = 100158, Name = "Sunseeker Pitch 1", Describe = "Описание трассы", Category = "6c+", Testimonial = "Sport 22m", BoltCount = 9, SectorId = 4 },
                new ClimbingRoute { ClimbingRouteId = 100159, Name = "Sunseeker Pitch 2", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport 25m", BoltCount = 6, SectorId = 4 },
                new ClimbingRoute { ClimbingRouteId = 100160, Name = "Anxiety State Crisis / Anxiety State Crisis Pitch 2 42m", Describe = "Описание трассы", Category = "7a", Testimonial = "Sport 42m", BoltCount = 11, SectorId = 4 },
                new ClimbingRoute { ClimbingRouteId = 100161, Name = "10mg Boulder", Describe = "Описание трассы", Category = "V4", Testimonial = "Boulder 3m", SectorId = 4 },
                new ClimbingRoute { ClimbingRouteId = 100162, Name = "Reminisce", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 11m", BoltCount = 5, SectorId = 5 },
                new ClimbingRoute { ClimbingRouteId = 100163, Name = "Reunion 52m", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 52m", BoltCount = 23, SectorId = 5 },
                new ClimbingRoute { ClimbingRouteId = 100164, Name = "Handsome and Old", Describe = "Описание трассы", Category = "5b+", Testimonial = "Sport 12m", BoltCount = 9, SectorId = 5 },
                new ClimbingRoute { ClimbingRouteId = 100165, Name = "Teamwork", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 13m", BoltCount = 9, SectorId = 5 },
                new ClimbingRoute { ClimbingRouteId = 100166, Name = "Smells Like Team Spirit", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 16m", BoltCount = 10, SectorId = 5 },
                new ClimbingRoute { ClimbingRouteId = 100167, Name = "Walk the Plank", Describe = "Описание трассы", Category = "7b", Testimonial = "Sport 15m", BoltCount = 8, SectorId = 5 },
                new ClimbingRoute { ClimbingRouteId = 100168, Name = "The Shining Path", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 20m", BoltCount = 12, SectorId = 6 },
                new ClimbingRoute { ClimbingRouteId = 100169, Name = "Uncontrolled Burning", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport 26m", BoltCount = 14, SectorId = 6 },
                new ClimbingRoute { ClimbingRouteId = 100170, Name = "Mumipeiko", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 15m", BoltCount = 6, SectorId = 6 },
                new ClimbingRoute { ClimbingRouteId = 100171, Name = "Unnamed Route Spor", Describe = "Описание трассы", Category = "7a+", Testimonial = "Sport 9m", BoltCount = 6, SectorId = 7 },
                new ClimbingRoute { ClimbingRouteId = 100172, Name = "No name 1", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport", BoltCount = 5, SectorId = 7 },
                new ClimbingRoute { ClimbingRouteId = 100173, Name = "No name 2", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport", SectorId = 7 },
                new ClimbingRoute { ClimbingRouteId = 100174, Name = "No name 3", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport", SectorId = 7 },
                new ClimbingRoute { ClimbingRouteId = 100175, Name = "Cool and Funky", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 12m", BoltCount = 6, SectorId = 7 },
                new ClimbingRoute { ClimbingRouteId = 100176, Name = "Welcome to the Wonderworld", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 12m", BoltCount = 6, SectorId = 7 },
                new ClimbingRoute { ClimbingRouteId = 100177, Name = "Freeblast", Describe = "Описание трассы", Category = "7b", Testimonial = "Sport 13m", BoltCount = 5, SectorId = 7 },
                new ClimbingRoute { ClimbingRouteId = 100178, Name = "Foaming at the Mouth", Describe = "Описание трассы", Category = "6c+", Testimonial = "Sport 13m", BoltCount = 6, SectorId = 7 },
                new ClimbingRoute { ClimbingRouteId = 100179, Name = "The Foaming Pumpus", Describe = "Описание трассы", Category = "7c", Testimonial = "Sport 13m", BoltCount = 7, SectorId = 7 },
                new ClimbingRoute { ClimbingRouteId = 100180, Name = "The Wild Pumpus", Describe = "Описание трассы", Category = "7b+", Testimonial = "Sport 12m", BoltCount = 7, SectorId = 7 },
                new ClimbingRoute { ClimbingRouteId = 100181, Name = "Wild & Free", Describe = "Описание трассы", Category = "7c+", Testimonial = "Sport 15m", BoltCount = 10, SectorId = 7 },
                new ClimbingRoute { ClimbingRouteId = 100182, Name = "Sport Satay", Describe = "Описание трассы", Category = "7a", Testimonial = "Sport 13m", BoltCount = 6, SectorId = 7 },
                new ClimbingRoute { ClimbingRouteId = 100183, Name = "Air Conditioner", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 14m", BoltCount = 8, SectorId = 7 },
                new ClimbingRoute { ClimbingRouteId = 100184, Name = "No name", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport", SectorId = 7 },
                new ClimbingRoute { ClimbingRouteId = 100185, Name = "Show Off the Police", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 20m", BoltCount = 7, SectorId = 7 },
                new ClimbingRoute { ClimbingRouteId = 100186, Name = "Unnamed Route", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport", SectorId = 7 },
                new ClimbingRoute { ClimbingRouteId = 100187, Name = "Unnamed Route", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport", SectorId = 7 },
                new ClimbingRoute { ClimbingRouteId = 100188, Name = "Morning Glory", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 31m", BoltCount = 13, SectorId = 8 },
                new ClimbingRoute { ClimbingRouteId = 100189, Name = "Earthquake", Describe = "Описание трассы", Category = "7a", Testimonial = "Sport 25m", BoltCount = 10, SectorId = 8 },
                new ClimbingRoute { ClimbingRouteId = 100190, Name = "Trojan Horse", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 55m", BoltCount = 31, SectorId = 8 },
                new ClimbingRoute { ClimbingRouteId = 100191, Name = "Trojan Horse Pitch 1", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 15m", BoltCount = 10, SectorId = 8 },
                new ClimbingRoute { ClimbingRouteId = 100192, Name = "Trojan Horse, Pitch 2", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 25m", BoltCount = 15, SectorId = 8 },
                new ClimbingRoute { ClimbingRouteId = 100193, Name = "Trojan Horse, Pitch 3", Describe = "Описание трассы", Category = "5a", Testimonial = "Sport 15m", BoltCount = 6, SectorId = 8 },
                new ClimbingRoute { ClimbingRouteId = 100194, Name = "The Muppet Show", Describe = "Описание трассы", Category = "5", Testimonial = "Sport 27m", BoltCount = 10, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100195, Name = "Ding Dong", Describe = "Описание трассы", Category = "5", Testimonial = "Sport 24m", BoltCount = 13, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100196, Name = "Rope and Rock", Describe = "Описание трассы", Category = "5", Testimonial = "Sport 24m", BoltCount = 13, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100197, Name = "Mai Roo Reuang / I Have No Idea", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport 15m", BoltCount = 6, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100198, Name = "Magic Drop", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 18m", BoltCount = 8, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100199, Name = "Reindeer Request", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 22m", BoltCount = 10, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100200, Name = "Ayah!", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 21m", BoltCount = 11, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100201, Name = "The Thai Who Loved Me", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 14m", BoltCount = 7, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100202, Name = "Partners Left", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 13m", BoltCount = 5, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100203, Name = "Partners Right", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 13m", BoltCount = 6, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100204, Name = "A Horse with No Name", Describe = "Описание трассы", Category = "5", Testimonial = "Sport 37m", BoltCount = 17, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100205, Name = "The Bamboo Finders", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 21m", BoltCount = 10, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100206, Name = "It's Got to Be Funky", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 20m", BoltCount = 9, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100207, Name = "The Beehouse", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport 27m", BoltCount = 12, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100208, Name = "Blood, Love and Steel Pitch 1", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport 26m", BoltCount = 11, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100209, Name = "Blood, Love and Steel Pitch 2", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 17m", BoltCount = 7, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100210, Name = "Headhunters Pitch 1", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport 26m", BoltCount = 10, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100211, Name = "Headhunters Pitch 2", Describe = "Описание трассы", Category = "7a", Testimonial = "Sport 20m", BoltCount = 9, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100212, Name = "Headhunters Pitch 2", Describe = "Описание трассы", Category = "7a+", Testimonial = "Sport 20m", BoltCount = 9, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100213, Name = "Headhunters Pitch 3", Describe = "Описание трассы", Category = "7a", Testimonial = "Sport 20m", BoltCount = 8, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100214, Name = "Free the Spirit", Describe = "Описание трассы", Category = "7b+", Testimonial = "Sport 20m", BoltCount = 7, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100215, Name = "Baby Rock", Describe = "Описание трассы", Category = "7b+", Testimonial = "Sport 30m", BoltCount = 10, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100216, Name = "Wild Ride on a Crazy Horse", Describe = "Описание трассы", Category = "8a+", Testimonial = "Sport 18m", BoltCount = 7, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100217, Name = "Dangerous Joy", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport 20m", BoltCount = 11, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100218, Name = "Give me More", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 20m", BoltCount = 6, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100219, Name = "The Horse Knows the Way", Describe = "Описание трассы", Category = "7b", Testimonial = "Sport 18m", BoltCount = 8, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100220, Name = "Ma / The Horse's Ass", Describe = "Описание трассы", Category = "7a+", Testimonial = "Sport 18m", BoltCount = 7, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100221, Name = "Don't Look a Gifthorse in the Mouth Pitch 1", Describe = "Описание трассы", Category = "7a", Testimonial = "Sport 18m", BoltCount = 5, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100222, Name = "Don't Look a Gifthorse in the Mouth Pitch 2", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport 16m", BoltCount = 8, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100223, Name = "Into The Sun Pitch 1", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 18m", BoltCount = 5, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100224, Name = "Into The Sun Pitch 2", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 16m", BoltCount = 9, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100225, Name = "Some Like it Hot Sp", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 25m", BoltCount = null, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100226, Name = "Some Like it Hot Pitch 2 Sp", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport 25m", BoltCount = null, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100227, Name = "V5 20mg", Describe = "Описание трассы", Category = "V5", Testimonial = "Sport", BoltCount = null, SectorId = 9 },
                new ClimbingRoute { ClimbingRouteId = 100228, Name = "Victoree / Victor-eee", Describe = "Описание трассы", Category = "0", Testimonial = "Sport 12m", BoltCount = 5, SectorId = 10 },
                new ClimbingRoute { ClimbingRouteId = 100229, Name = "Robert's Stress", Describe = "Описание трассы", Category = "5b+", Testimonial = "Sport 15m", BoltCount = 7, SectorId = 10 },
                new ClimbingRoute { ClimbingRouteId = 100230, Name = "Groove is in the Heart", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 15m", BoltCount = 8, SectorId = 10 },
                new ClimbingRoute { ClimbingRouteId = 100231, Name = "Drill and Blast, Drill and Bolt", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 16m", BoltCount = 7, SectorId = 10 },
                new ClimbingRoute { ClimbingRouteId = 100232, Name = "Out of the Trees", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 16m", BoltCount = 7, SectorId = 10 },
                new ClimbingRoute { ClimbingRouteId = 100233, Name = "Snooze You Lose", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 16m", BoltCount = 9, SectorId = 10 },
                new ClimbingRoute { ClimbingRouteId = 100234, Name = "While You Were Sleeping", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 15m", BoltCount = 7, SectorId = 10 },
                new ClimbingRoute { ClimbingRouteId = 100235, Name = "Sandbag", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport 20m", BoltCount = 9, SectorId = 11 },
                new ClimbingRoute { ClimbingRouteId = 100236, Name = "Kee Dtak / Diarrhea", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 22m", BoltCount = 12, SectorId = 11 },
                new ClimbingRoute { ClimbingRouteId = 100237, Name = "Gruntfest", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport 19m", BoltCount = 10, SectorId = 11 },
                new ClimbingRoute { ClimbingRouteId = 100238, Name = "Kee Gai / Chicken Shit", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 19m", BoltCount = 8, SectorId = 11 },
                new ClimbingRoute { ClimbingRouteId = 100239, Name = "Heartbeat", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 8m", BoltCount = 4, SectorId = 11 },
                new ClimbingRoute { ClimbingRouteId = 100240, Name = "The Tree Surgeon", Describe = "Описание трассы", Category = "6c+", Testimonial = "Sport 18m", BoltCount = 8, SectorId = 11 },
                new ClimbingRoute { ClimbingRouteId = 100241, Name = "Crazy Hot", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 19m", BoltCount = 9, SectorId = 11 },
                new ClimbingRoute { ClimbingRouteId = 100242, Name = "Overheat", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport 28m", BoltCount = 13, SectorId = 12 },
                new ClimbingRoute { ClimbingRouteId = 100243, Name = "Margueritaville", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 25m", BoltCount = 9, SectorId = 12 },
                new ClimbingRoute { ClimbingRouteId = 100244, Name = "Tiera Del Fuego", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 20m", BoltCount = 8, SectorId = 12 },
                new ClimbingRoute { ClimbingRouteId = 100245, Name = "Every Man's An Island", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport 15m", BoltCount = 12, SectorId = 13 },
                new ClimbingRoute { ClimbingRouteId = 100246, Name = "The Easy Bake Oven", Describe = "Описание трассы", Category = "5", Testimonial = "Sport 25m", BoltCount = 12, SectorId = 13 },
                new ClimbingRoute { ClimbingRouteId = 100247, Name = "Sideshow 45m", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 45m", BoltCount = 15, SectorId = 13 },
                new ClimbingRoute { ClimbingRouteId = 100248, Name = "Sideshow - 1st Pitch", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 27m", BoltCount = 9, SectorId = 13 },
                new ClimbingRoute { ClimbingRouteId = 100249, Name = "Sideshow - 2nd Pitch", Describe = "Описание трассы", Category = "4", Testimonial = "Sport 18m", BoltCount = 4, SectorId = 13 },
                new ClimbingRoute { ClimbingRouteId = 100250, Name = "Backburner", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 24m", BoltCount = 11, SectorId = 13 },
                new ClimbingRoute { ClimbingRouteId = 100251, Name = "The Balance of Power", Describe = "Описание трассы", Category = "7a+", Testimonial = "Sport 25m", BoltCount = 11, SectorId = 13 },
                new ClimbingRoute { ClimbingRouteId = 100252, Name = "The Incinerator - 1st Pitch", Describe = "Описание трассы", Category = "7a", Testimonial = "Sport 18m", BoltCount = 7, SectorId = 13 },
                new ClimbingRoute { ClimbingRouteId = 100253, Name = "The Incinerator - 2nd Pitch", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 17m", BoltCount = 11, SectorId = 13 },
                new ClimbingRoute { ClimbingRouteId = 100254, Name = "Solarise", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 25m", BoltCount = 11, SectorId = 13 },
                new ClimbingRoute { ClimbingRouteId = 100255, Name = "Fire in the Mind", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 24m", BoltCount = 10, SectorId = 13 },
                new ClimbingRoute { ClimbingRouteId = 100256, Name = "Black Hole Sun", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport 30m", BoltCount = 15, SectorId = 13 },
                new ClimbingRoute { ClimbingRouteId = 100257, Name = "Love Me, Love My Route", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 23m", BoltCount = 13, SectorId = 13 },
                new ClimbingRoute { ClimbingRouteId = 100258, Name = "Destiny", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 22m", BoltCount = 9, SectorId = 14 },
                new ClimbingRoute { ClimbingRouteId = 100259, Name = "Sage", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 16m", BoltCount = 7, SectorId = 14 },
                new ClimbingRoute { ClimbingRouteId = 100260, Name = "S Song Of Stone", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport", BoltCount = null, SectorId = 14 }, // Category or bolt count is incorrect, should be checked
                new ClimbingRoute { ClimbingRouteId = 100261, Name = "Serial Drilla", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport 14m", BoltCount = 6, SectorId = 14 },
                new ClimbingRoute { ClimbingRouteId = 100262, Name = "Tarzan", Describe = "Описание трассы", Category = "5b", Testimonial = "Sport 14m threads 1", BoltCount = 5, SectorId = 15 },
                new ClimbingRoute { ClimbingRouteId = 100263, Name = "Rock Climbing 101", Describe = "Описание трассы", Category = "5b", Testimonial = "Sport 12m", BoltCount = 6, SectorId = 15 },
                new ClimbingRoute { ClimbingRouteId = 100264, Name = "Flapper", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 15m", BoltCount = 7, SectorId = 15 },
                new ClimbingRoute { ClimbingRouteId = 100265, Name = "Rock Climbing 102", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 14m threads 1", BoltCount = 7, SectorId = 15 },
                new ClimbingRoute { ClimbingRouteId = 100266, Name = "Unnamed multipitch 45m", Describe = "Описание трассы", Category = "5c+", Testimonial = "Sport 45m threads 2", BoltCount = 25, SectorId = 16 },
                new ClimbingRoute { ClimbingRouteId = 100267, Name = "The Chimney Sweep", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 12m", BoltCount = 6, SectorId = 16 },
                new ClimbingRoute { ClimbingRouteId = 100268, Name = "Chimney Creep", Describe = "Описание трассы", Category = "6c+", Testimonial = "Sport 12m", BoltCount = 6, SectorId = 16 },
                new ClimbingRoute { ClimbingRouteId = 100269, Name = "The Queen Bee", Describe = "Описание трассы", Category = "5b", Testimonial = "Sport 13m", BoltCount = 5, SectorId = 16 },
                new ClimbingRoute { ClimbingRouteId = 100270, Name = "Gecko", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 16m", BoltCount = 8, SectorId = 16 },
                new ClimbingRoute { ClimbingRouteId = 100271, Name = "No name 3", Describe = "Описание трассы", Category = "5", Testimonial = "Sport", BoltCount = null, SectorId = 16 },
                new ClimbingRoute { ClimbingRouteId = 100272, Name = "No name 4", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport", BoltCount = null, SectorId = 16 },
                new ClimbingRoute { ClimbingRouteId = 100273, Name = "No name 5", Describe = "Описание трассы", Category = "0", Testimonial = "Sport", BoltCount = null, SectorId = 16 }, 
                new ClimbingRoute { ClimbingRouteId = 100274, Name = "Happy Birthday", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 13m", BoltCount = 5, SectorId = 16 },
                new ClimbingRoute { ClimbingRouteId = 100275, Name = "Samurai", Describe = "Описание трассы", Category = "5b", Testimonial = "Sport 13m", BoltCount = 6, SectorId = 16 },
                new ClimbingRoute { ClimbingRouteId = 100276, Name = "Sii Pahn Haa / 4500", Describe = "Описание трассы", Category = "5a", Testimonial = "Sport 20m", BoltCount = 9, SectorId = 16 },
                new ClimbingRoute { ClimbingRouteId = 100277, Name = "unknown1", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 15m", BoltCount = null, SectorId = 17 },
                new ClimbingRoute { ClimbingRouteId = 100278, Name = "unknown2", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 15m", BoltCount = null, SectorId = 17 },
                new ClimbingRoute { ClimbingRouteId = 100279, Name = "unknown3", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 15m", BoltCount = null, SectorId = 17 },
                new ClimbingRoute { ClimbingRouteId = 100280, Name = "unknown4", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 20m", BoltCount = null, SectorId = 17 },
                new ClimbingRoute { ClimbingRouteId = 100281, Name = "Ling Jaw Jaw / Really Handsome", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 20m", BoltCount = 12, SectorId = 17 },
                new ClimbingRoute { ClimbingRouteId = 100282, Name = "Jesse James / Left variation", Describe = "Описание трассы", Category = "6b", Testimonial = "Sport 18m", BoltCount = 9, SectorId = 17 },
                new ClimbingRoute { ClimbingRouteId = 100283, Name = "Jesse James / Right variation", Describe = "Описание трассы", Category = "7a+", Testimonial = "Sport 18m", BoltCount = 9, SectorId = 17 },
                new ClimbingRoute { ClimbingRouteId = 100284, Name = "unknown5 Sp", Describe = "Описание трассы", Category = "7a", Testimonial = "Sport 20m", BoltCount = null, SectorId = 17 },
                new ClimbingRoute { ClimbingRouteId = 100285, Name = "Noname1 Sp", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 20m", BoltCount = null, SectorId = 17 },
                new ClimbingRoute { ClimbingRouteId = 100286, Name = "Monkey Around", Describe = "Описание трассы", Category = "5b", Testimonial = "Sport 13m", BoltCount = 7, SectorId = 17 },
                new ClimbingRoute { ClimbingRouteId = 100287, Name = "Miya Arom Siya", Describe = "Описание трассы", Category = "5b", Testimonial = "Sport 13m", BoltCount = 7, SectorId = 17 },
                new ClimbingRoute { ClimbingRouteId = 100288, Name = "Ling Leum / Flaky Monkey", Describe = "Описание трассы", Category = "5c+", Testimonial = "Sport 11m", BoltCount = 7, SectorId = 17 },
                new ClimbingRoute { ClimbingRouteId = 100289, Name = "Ling Ling / Monkey Monkey", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 11m", BoltCount = 7, SectorId = 17 },
                new ClimbingRoute { ClimbingRouteId = 100290, Name = "Shock the Monkey", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 14m", BoltCount = 7, SectorId = 17 },
                new ClimbingRoute { ClimbingRouteId = 100291, Name = "just", Describe = "Описание трассы", Category = "0", Testimonial = " ", BoltCount = null, SectorId = 18 },
                new ClimbingRoute { ClimbingRouteId = 100292, Name = "Naam Prik Dtah Daeng / Red-eye Chili Paste", Describe = "Описание трассы", Category = "6a+", Testimonial = "Sport 12m", BoltCount = 5, SectorId = 19 },
                new ClimbingRoute { ClimbingRouteId = 100293, Name = "No name 1", Describe = "Описание трассы", Category = "5c", Testimonial = "Sport 10m", BoltCount = 6, SectorId = 20 },
                new ClimbingRoute { ClimbingRouteId = 100294, Name = "No name 2", Describe = "Описание трассы", Category = "6a", Testimonial = "Sport 25m", BoltCount = null, SectorId = 20 },
                new ClimbingRoute { ClimbingRouteId = 100295, Name = "No name 3", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport 23m", BoltCount = null, SectorId = 20 },
                new ClimbingRoute { ClimbingRouteId = 100296, Name = "The Absent Minded Bolter", Describe = "Описание трассы", Category = "7a+", Testimonial = "Sport 18m", BoltCount = 8, SectorId = 20 },
                new ClimbingRoute { ClimbingRouteId = 100297, Name = "Ants in My Pants", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport 19m", BoltCount = 6, SectorId = 20 },
                new ClimbingRoute { ClimbingRouteId = 100298, Name = "The Wasp Factory", Describe = "Описание трассы", Category = "6c+", Testimonial = "Sport 25m", BoltCount = 11, SectorId = 20 },
                new ClimbingRoute { ClimbingRouteId = 100299, Name = "Bleachin'", Describe = "Описание трассы", Category = "7b+", Testimonial = "Sport 20m", BoltCount = 8, SectorId = 20 },
                new ClimbingRoute { ClimbingRouteId = 100300, Name = "Flushed", Describe = "Описание трассы", Category = "6b+", Testimonial = "Sport 30m", BoltCount = 12, SectorId = 20 },
                new ClimbingRoute { ClimbingRouteId = 100301, Name = "Intensify", Describe = "Описание трассы", Category = "7b", Testimonial = "Sport 30m", BoltCount = 13, SectorId = 20 },
                new ClimbingRoute { ClimbingRouteId = 100302, Name = "Bristol Fashion", Describe = "Описание трассы", Category = "8b+", Testimonial = "Sport", BoltCount = null, SectorId = 20 },
                new ClimbingRoute { ClimbingRouteId = 100303, Name = "Sexy Beast", Describe = "Описание трассы", Category = "6c", Testimonial = "Sport 25m", BoltCount = null, SectorId = 20 }
            );

        }
    }
}