using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backcrazyhorse.Migrations
{
    /// <inheritdoc />
    public partial class AddingRoutes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Describe",
                table: "ClimbingRoutes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "ClimbingRoutes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "ClimbingRoutes",
                columns: new[] { "ClimbingRouteId", "BoltCount", "Category", "Describe", "Name", "SectorId", "Testimonial" },
                values: new object[,]
                {
                    { 100099, 14, "6b+", "Описание трассы", "Suud Suud Jai / Put Your Heart Into It", 1, "Sport 22m" },
                    { 100100, 11, "6b+", "Описание трассы", "Kra Ten Kong Hua Jai / Heartbeat", 1, "Sport 18m" },
                    { 100101, 11, "6b+", "Описание трассы", "Gam Lang Jai / Spirit, Morale", 1, "Sport 18m" },
                    { 100102, 15, "6c", "Описание трассы", "Jai Kwang / Open-Minded", 1, "Sport 26m" },
                    { 100103, 16, "6c+", "Описание трассы", "Unknown", 1, "Sport 25m" },
                    { 100104, 13, "6b", "Описание трассы", "Pah Dtat Hua Jai / Heart Surgery", 1, "Sport 25m" },
                    { 100105, 15, "6a+", "Описание трассы", "Mar Jark Jai / Heartfelt", 1, "Sport 25m" },
                    { 100106, 15, "6a+", "Описание трассы", "Tang Jai / Intentions", 1, "Sport 25m" },
                    { 100107, 13, "6b", "Описание трассы", "Deung Duut Jai / Attractive", 1, "Sport 20m" },
                    { 100108, 12, "5c", "Описание трассы", "Jai Tuud / Wimp", 1, "Sport 18m" },
                    { 100109, 12, "5c", "Описание трассы", "Jai Rag / I Love My Heart", 1, "Sport 16m" },
                    { 100110, 10, "6b", "Описание трассы", "Kob Jai Lai Lai / Thank You Very Much", 1, "Sport 16m" },
                    { 100111, 11, "6a+", "Описание трассы", "Rang Lai Jai / Hesitate", 1, "Sport 16m" },
                    { 100112, 11, "5c", "Описание трассы", "Song Jit Song Jai / I'm Torn", 1, "Sport 16m" },
                    { 100113, 9, "6a", "Описание трассы", "Jai Ngai / Gullible", 1, "Sport 12m" },
                    { 100114, 9, "6b", "Описание трассы", "Pun Jai / Proud", 1, "Sport 13m" },
                    { 100115, 6, "6b+", "Описание трассы", "Jai Guide / Guide Heart", 1, "Sport 13m" },
                    { 100116, 10, "6c", "Описание трассы", "Mun Jai / Confident", 1, "Sport 19m" },
                    { 100117, 11, "6c+", "Описание трассы", "Jai Yen Yen / Patient / The Proposal / Calm", 1, "Sport 21m" },
                    { 100118, 10, "7a+", "Описание трассы", "Jai Glah Reu Plao / Are You Courageous?", 1, "Sport 22m" },
                    { 100119, 10, "6b+", "Описание трассы", "Dee Jai Tee Dai Geud / It's Great to be Alive", 1, "Sport 19m" },
                    { 100120, 9, "6c+", "Описание трассы", "Saht Jai / Satisfied", 1, "Sport 16m" },
                    { 100121, 9, "6c+", "Описание трассы", "Dtat Sin Jai / Decide", 1, "Sport 14m" },
                    { 100122, 7, "7a+", "Описание трассы", "Jai Det / Fearless", 1, "Sport 13m" },
                    { 100123, 10, "6a+", "Описание трассы", "Pak Jai / Rest Your Heart", 1, "Sport 20m" },
                    { 100124, 9, "6b", "Описание трассы", "Blaek Jai / Surprised / Wondering", 1, "Sport 21m" },
                    { 100125, 12, "6b+", "Описание трассы", "Bratup Jai / Impressed", 1, "Sport 22m" },
                    { 100126, 13, "6b", "Описание трассы", "Jai Rawn / Hot Headed", 1, "Sport 27m" },
                    { 100127, 17, "6a+", "Описание трассы", "Ruam Jai / Together", 1, "Sport 36m" },
                    { 100128, 18, "6c+", "Описание трассы", "Jai Teung Jai / Heart to Heart", 1, "Sport 35m" },
                    { 100129, 10, "7a+", "Описание трассы", "Jai Loy / Spaced-Out", 1, "Sport 23m" },
                    { 100130, 10, "6c", "Описание трассы", "Dtang Jai / Conscious", 1, "Sport 25m" },
                    { 100131, 8, "6c+", "Описание трассы", "Hua Jai Wai / Heart Attack", 1, "Sport 10m" },
                    { 100132, 13, "6a+", "Описание трассы", "Duang Jai / Flame Heart", 1, "Sport 25m" },
                    { 100133, 9, "5c", "Описание трассы", "Kuu Jai / Twin Heart", 1, "Sport 15m" },
                    { 100134, 14, "6a+", "Описание трассы", "Dtok Jai / Startled", 1, "Sport 17m" },
                    { 100135, 11, "5a", "Описание трассы", "Peaun Jai Rai / My Friend is Mean", 1, "Sport 18m" },
                    { 100136, 5, "5b", "Описание трассы", "Heun Fah / Ascending the Sky", 2, "Sport 21m" },
                    { 100137, 8, "5c+", "Описание трассы", "A Route with a View", 2, "Sport 22m" },
                    { 100138, 11, "6a+", "Описание трассы", "Skyscraper", 2, "Sport 29m" },
                    { 100139, 14, "6c", "Описание трассы", "The Keymaster", 3, "Sport 25m" },
                    { 100140, 8, "6b", "Описание трассы", "The Gatekeeper", 3, "Sport 25m" },
                    { 100141, 8, "7a", "Описание трассы", "Inferno", 3, "Sport 29m" },
                    { 100142, 9, "7a", "Описание трассы", "Unleash the Phat Physique", 3, "Sport 28m" },
                    { 100143, 8, "7a", "Описание трассы", "All Quiet on the Eastern Front", 3, "Sport 24m" },
                    { 100144, null, "6b+", "Описание трассы", "No name", 3, "Sport" },
                    { 100145, 7, "5a", "Описание трассы", "Short Tail", 4, "Sport 12m" },
                    { 100146, 9, "5b", "Описание трассы", "Cave Man", 4, "Sport 16m" },
                    { 100147, 6, "5c", "Описание трассы", "Horse's Heart", 4, "Sport 11m" },
                    { 100148, 9, "5c", "Описание трассы", "The Underworld", 4, "Sport 15m" },
                    { 100149, 12, "6a", "Описание трассы", "Beautiful Mess", 4, "Sport 19m" },
                    { 100150, null, "5c", "Описание трассы", "The End of Relationships", 4, "Sport 12m" },
                    { 100151, 6, "5c", "Описание трассы", "The Underground", 4, "Sport 11m" },
                    { 100152, 4, "5c", "Описание трассы", "In Deep Space", 4, "Sport 80m" },
                    { 100153, 10, "6c", "Описание трассы", "Spaceman Pitch 1", 4, "Sport 25m" },
                    { 100154, 15, "7b+", "Описание трассы", "Spaceman Pitch 2", 4, "Sport 30m" },
                    { 100155, 12, "6c", "Описание трассы", "Space Manouevers Pitch 1", 4, "Sport 30m" },
                    { 100156, 7, "7b", "Описание трассы", "Space Manoeuvers Pitch 2", 4, "Sport 15m" },
                    { 100157, 9, "7b", "Описание трассы", "Space Manoeuvers Pitch 3", 4, "Sport 25m" },
                    { 100158, 9, "6c+", "Описание трассы", "Sunseeker Pitch 1", 4, "Sport 22m" },
                    { 100159, 6, "6b+", "Описание трассы", "Sunseeker Pitch 2", 4, "Sport 25m" },
                    { 100160, 11, "7a", "Описание трассы", "Anxiety State Crisis / Anxiety State Crisis Pitch 2 42m", 4, "Sport 42m" },
                    { 100161, null, "V4", "Описание трассы", "10mg Boulder", 4, "Boulder 3m" },
                    { 100162, 5, "6a", "Описание трассы", "Reminisce", 5, "Sport 11m" },
                    { 100163, 23, "6a+", "Описание трассы", "Reunion 52m", 5, "Sport 52m" },
                    { 100164, 9, "5b+", "Описание трассы", "Handsome and Old", 5, "Sport 12m" },
                    { 100165, 9, "5c", "Описание трассы", "Teamwork", 5, "Sport 13m" },
                    { 100166, 10, "6a", "Описание трассы", "Smells Like Team Spirit", 5, "Sport 16m" },
                    { 100167, 8, "7b", "Описание трассы", "Walk the Plank", 5, "Sport 15m" },
                    { 100168, 12, "6b", "Описание трассы", "The Shining Path", 6, "Sport 20m" },
                    { 100169, 14, "6b+", "Описание трассы", "Uncontrolled Burning", 6, "Sport 26m" },
                    { 100170, 6, "6b", "Описание трассы", "Mumipeiko", 6, "Sport 15m" },
                    { 100171, 6, "7a+", "Описание трассы", "Unnamed Route Spor", 7, "Sport 9m" },
                    { 100172, 5, "6a", "Описание трассы", "No name 1", 7, "Sport" },
                    { 100173, null, "6b+", "Описание трассы", "No name 2", 7, "Sport" },
                    { 100174, null, "6c", "Описание трассы", "No name 3", 7, "Sport" },
                    { 100175, 6, "6a+", "Описание трассы", "Cool and Funky", 7, "Sport 12m" },
                    { 100176, 6, "6a+", "Описание трассы", "Welcome to the Wonderworld", 7, "Sport 12m" },
                    { 100177, 5, "7b", "Описание трассы", "Freeblast", 7, "Sport 13m" },
                    { 100178, 6, "6c+", "Описание трассы", "Foaming at the Mouth", 7, "Sport 13m" },
                    { 100179, 7, "7c", "Описание трассы", "The Foaming Pumpus", 7, "Sport 13m" },
                    { 100180, 7, "7b+", "Описание трассы", "The Wild Pumpus", 7, "Sport 12m" },
                    { 100181, 10, "7c+", "Описание трассы", "Wild & Free", 7, "Sport 15m" },
                    { 100182, 6, "7a", "Описание трассы", "Sport Satay", 7, "Sport 13m" },
                    { 100183, 8, "6a+", "Описание трассы", "Air Conditioner", 7, "Sport 14m" },
                    { 100184, null, "6a", "Описание трассы", "No name", 7, "Sport" },
                    { 100185, 7, "6b", "Описание трассы", "Show Off the Police", 7, "Sport 20m" },
                    { 100186, null, "6c", "Описание трассы", "Unnamed Route", 7, "Sport" },
                    { 100187, null, "6b", "Описание трассы", "Unnamed Route", 7, "Sport" },
                    { 100188, 13, "6a+", "Описание трассы", "Morning Glory", 8, "Sport 31m" },
                    { 100189, 10, "7a", "Описание трассы", "Earthquake", 8, "Sport 25m" },
                    { 100190, 31, "6a+", "Описание трассы", "Trojan Horse", 8, "Sport 55m" },
                    { 100191, 10, "5c", "Описание трассы", "Trojan Horse Pitch 1", 8, "Sport 15m" },
                    { 100192, 15, "6a+", "Описание трассы", "Trojan Horse, Pitch 2", 8, "Sport 25m" },
                    { 100193, 6, "5a", "Описание трассы", "Trojan Horse, Pitch 3", 8, "Sport 15m" },
                    { 100194, 10, "5", "Описание трассы", "The Muppet Show", 9, "Sport 27m" },
                    { 100195, 13, "5", "Описание трассы", "Ding Dong", 9, "Sport 24m" },
                    { 100196, 13, "5", "Описание трассы", "Rope and Rock", 9, "Sport 24m" },
                    { 100197, 6, "6b+", "Описание трассы", "Mai Roo Reuang / I Have No Idea", 9, "Sport 15m" },
                    { 100198, 8, "6b", "Описание трассы", "Magic Drop", 9, "Sport 18m" },
                    { 100199, 10, "6a+", "Описание трассы", "Reindeer Request", 9, "Sport 22m" },
                    { 100200, 11, "6a", "Описание трассы", "Ayah!", 9, "Sport 21m" },
                    { 100201, 7, "6a", "Описание трассы", "The Thai Who Loved Me", 9, "Sport 14m" },
                    { 100202, 5, "6a+", "Описание трассы", "Partners Left", 9, "Sport 13m" },
                    { 100203, 6, "6a", "Описание трассы", "Partners Right", 9, "Sport 13m" },
                    { 100204, 17, "5", "Описание трассы", "A Horse with No Name", 9, "Sport 37m" },
                    { 100205, 10, "6b", "Описание трассы", "The Bamboo Finders", 9, "Sport 21m" },
                    { 100206, 9, "6a+", "Описание трассы", "It's Got to Be Funky", 9, "Sport 20m" },
                    { 100207, 12, "6c", "Описание трассы", "The Beehouse", 9, "Sport 27m" },
                    { 100208, 11, "6c", "Описание трассы", "Blood, Love and Steel Pitch 1", 9, "Sport 26m" },
                    { 100209, 7, "6a+", "Описание трассы", "Blood, Love and Steel Pitch 2", 9, "Sport 17m" },
                    { 100210, 10, "6c", "Описание трассы", "Headhunters Pitch 1", 9, "Sport 26m" },
                    { 100211, 9, "7a", "Описание трассы", "Headhunters Pitch 2", 9, "Sport 20m" },
                    { 100212, 9, "7a+", "Описание трассы", "Headhunters Pitch 2", 9, "Sport 20m" },
                    { 100213, 8, "7a", "Описание трассы", "Headhunters Pitch 3", 9, "Sport 20m" },
                    { 100214, 7, "7b+", "Описание трассы", "Free the Spirit", 9, "Sport 20m" },
                    { 100215, 10, "7b+", "Описание трассы", "Baby Rock", 9, "Sport 30m" },
                    { 100216, 7, "8a+", "Описание трассы", "Wild Ride on a Crazy Horse", 9, "Sport 18m" },
                    { 100217, 11, "6c", "Описание трассы", "Dangerous Joy", 9, "Sport 20m" },
                    { 100218, 6, "6a+", "Описание трассы", "Give me More", 9, "Sport 20m" },
                    { 100219, 8, "7b", "Описание трассы", "The Horse Knows the Way", 9, "Sport 18m" },
                    { 100220, 7, "7a+", "Описание трассы", "Ma / The Horse's Ass", 9, "Sport 18m" },
                    { 100221, 5, "7a", "Описание трассы", "Don't Look a Gifthorse in the Mouth Pitch 1", 9, "Sport 18m" },
                    { 100222, 8, "6b+", "Описание трассы", "Don't Look a Gifthorse in the Mouth Pitch 2", 9, "Sport 16m" },
                    { 100223, 5, "6a", "Описание трассы", "Into The Sun Pitch 1", 9, "Sport 18m" },
                    { 100224, 9, "6b", "Описание трассы", "Into The Sun Pitch 2", 9, "Sport 16m" },
                    { 100225, null, "6b", "Описание трассы", "Some Like it Hot Sp", 9, "Sport 25m" },
                    { 100226, null, "6b+", "Описание трассы", "Some Like it Hot Pitch 2 Sp", 9, "Sport 25m" },
                    { 100227, null, "V5", "Описание трассы", "V5 20mg", 9, "Sport" },
                    { 100228, 5, "0", "Описание трассы", "Victoree / Victor-eee", 10, "Sport 12m" },
                    { 100229, 7, "5b+", "Описание трассы", "Robert's Stress", 10, "Sport 15m" },
                    { 100230, 8, "6b", "Описание трассы", "Groove is in the Heart", 10, "Sport 15m" },
                    { 100231, 7, "6a+", "Описание трассы", "Drill and Blast, Drill and Bolt", 10, "Sport 16m" },
                    { 100232, 7, "5c", "Описание трассы", "Out of the Trees", 10, "Sport 16m" },
                    { 100233, 9, "6a", "Описание трассы", "Snooze You Lose", 10, "Sport 16m" },
                    { 100234, 7, "6a", "Описание трассы", "While You Were Sleeping", 10, "Sport 15m" },
                    { 100235, 9, "6c", "Описание трассы", "Sandbag", 11, "Sport 20m" },
                    { 100236, 12, "6b", "Описание трассы", "Kee Dtak / Diarrhea", 11, "Sport 22m" },
                    { 100237, 10, "6c", "Описание трассы", "Gruntfest", 11, "Sport 19m" },
                    { 100238, 8, "6a+", "Описание трассы", "Kee Gai / Chicken Shit", 11, "Sport 19m" },
                    { 100239, 4, "6a", "Описание трассы", "Heartbeat", 11, "Sport 8m" },
                    { 100240, 8, "6c+", "Описание трассы", "The Tree Surgeon", 11, "Sport 18m" },
                    { 100241, 9, "6b", "Описание трассы", "Crazy Hot", 11, "Sport 19m" },
                    { 100242, 13, "6c", "Описание трассы", "Overheat", 12, "Sport 28m" },
                    { 100243, 9, "6a+", "Описание трассы", "Margueritaville", 12, "Sport 25m" },
                    { 100244, 8, "6b", "Описание трассы", "Tiera Del Fuego", 12, "Sport 20m" },
                    { 100245, 12, "6b+", "Описание трассы", "Every Man's An Island", 13, "Sport 15m" },
                    { 100246, 12, "5", "Описание трассы", "The Easy Bake Oven", 13, "Sport 25m" },
                    { 100247, 15, "5c", "Описание трассы", "Sideshow 45m", 13, "Sport 45m" },
                    { 100248, 9, "5c", "Описание трассы", "Sideshow - 1st Pitch", 13, "Sport 27m" },
                    { 100249, 4, "4", "Описание трассы", "Sideshow - 2nd Pitch", 13, "Sport 18m" },
                    { 100250, 11, "6a+", "Описание трассы", "Backburner", 13, "Sport 24m" },
                    { 100251, 11, "7a+", "Описание трассы", "The Balance of Power", 13, "Sport 25m" },
                    { 100252, 7, "7a", "Описание трассы", "The Incinerator - 1st Pitch", 13, "Sport 18m" },
                    { 100253, 11, "6a", "Описание трассы", "The Incinerator - 2nd Pitch", 13, "Sport 17m" },
                    { 100254, 11, "6a+", "Описание трассы", "Solarise", 13, "Sport 25m" },
                    { 100255, 10, "6a", "Описание трассы", "Fire in the Mind", 13, "Sport 24m" },
                    { 100256, 15, "6b+", "Описание трассы", "Black Hole Sun", 13, "Sport 30m" },
                    { 100257, 13, "6a+", "Описание трассы", "Love Me, Love My Route", 13, "Sport 23m" },
                    { 100258, 9, "6b", "Описание трассы", "Destiny", 14, "Sport 22m" },
                    { 100259, 7, "6a", "Описание трассы", "Sage", 14, "Sport 16m" },
                    { 100260, null, "6c", "Описание трассы", "S Song Of Stone", 14, "Sport" },
                    { 100261, 6, "6b+", "Описание трассы", "Serial Drilla", 14, "Sport 14m" },
                    { 100262, 5, "5b", "Описание трассы", "Tarzan", 15, "Sport 14m threads 1" },
                    { 100263, 6, "5b", "Описание трассы", "Rock Climbing 101", 15, "Sport 12m" },
                    { 100264, 7, "5c", "Описание трассы", "Flapper", 15, "Sport 15m" },
                    { 100265, 7, "5c", "Описание трассы", "Rock Climbing 102", 15, "Sport 14m threads 1" },
                    { 100266, 25, "5c+", "Описание трассы", "Unnamed multipitch 45m", 16, "Sport 45m threads 2" },
                    { 100267, 6, "6a", "Описание трассы", "The Chimney Sweep", 16, "Sport 12m" },
                    { 100268, 6, "6c+", "Описание трассы", "Chimney Creep", 16, "Sport 12m" },
                    { 100269, 5, "5b", "Описание трассы", "The Queen Bee", 16, "Sport 13m" },
                    { 100270, 8, "5c", "Описание трассы", "Gecko", 16, "Sport 16m" },
                    { 100271, null, "5", "Описание трассы", "No name 3", 16, "Sport" },
                    { 100272, null, "5c", "Описание трассы", "No name 4", 16, "Sport" },
                    { 100273, null, "0", "Описание трассы", "No name 5", 16, "Sport" },
                    { 100274, 5, "6b", "Описание трассы", "Happy Birthday", 16, "Sport 13m" },
                    { 100275, 6, "5b", "Описание трассы", "Samurai", 16, "Sport 13m" },
                    { 100276, 9, "5a", "Описание трассы", "Sii Pahn Haa / 4500", 16, "Sport 20m" },
                    { 100277, null, "5c", "Описание трассы", "unknown1", 17, "Sport 15m" },
                    { 100278, null, "6a", "Описание трассы", "unknown2", 17, "Sport 15m" },
                    { 100279, null, "6a", "Описание трассы", "unknown3", 17, "Sport 15m" },
                    { 100280, null, "6a", "Описание трассы", "unknown4", 17, "Sport 20m" },
                    { 100281, 12, "6a+", "Описание трассы", "Ling Jaw Jaw / Really Handsome", 17, "Sport 20m" },
                    { 100282, 9, "6b", "Описание трассы", "Jesse James / Left variation", 17, "Sport 18m" },
                    { 100283, 9, "7a+", "Описание трассы", "Jesse James / Right variation", 17, "Sport 18m" },
                    { 100284, null, "7a", "Описание трассы", "unknown5 Sp", 17, "Sport 20m" },
                    { 100285, null, "6a", "Описание трассы", "Noname1 Sp", 17, "Sport 20m" },
                    { 100286, 7, "5b", "Описание трассы", "Monkey Around", 17, "Sport 13m" },
                    { 100287, 7, "5b", "Описание трассы", "Miya Arom Siya", 17, "Sport 13m" },
                    { 100288, 7, "5c+", "Описание трассы", "Ling Leum / Flaky Monkey", 17, "Sport 11m" },
                    { 100289, 7, "6a+", "Описание трассы", "Ling Ling / Monkey Monkey", 17, "Sport 11m" },
                    { 100290, 7, "6a+", "Описание трассы", "Shock the Monkey", 17, "Sport 14m" },
                    { 100291, null, "0", "Описание трассы", "just", 18, " " },
                    { 100292, 5, "6a+", "Описание трассы", "Naam Prik Dtah Daeng / Red-eye Chili Paste", 19, "Sport 12m" },
                    { 100293, 6, "5c", "Описание трассы", "No name 1", 20, "Sport 10m" },
                    { 100294, null, "6a", "Описание трассы", "No name 2", 20, "Sport 25m" },
                    { 100295, null, "6b+", "Описание трассы", "No name 3", 20, "Sport 23m" },
                    { 100296, 8, "7a+", "Описание трассы", "The Absent Minded Bolter", 20, "Sport 18m" },
                    { 100297, 6, "6c", "Описание трассы", "Ants in My Pants", 20, "Sport 19m" },
                    { 100298, 11, "6c+", "Описание трассы", "The Wasp Factory", 20, "Sport 25m" },
                    { 100299, 8, "7b+", "Описание трассы", "Bleachin'", 20, "Sport 20m" },
                    { 100300, 12, "6b+", "Описание трассы", "Flushed", 20, "Sport 30m" },
                    { 100301, 13, "7b", "Описание трассы", "Intensify", 20, "Sport 30m" },
                    { 100302, null, "8b+", "Описание трассы", "Bristol Fashion", 20, "Sport" },
                    { 100303, null, "6c", "Описание трассы", "Sexy Beast", 20, "Sport 25m" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100099);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100100);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100101);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100102);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100103);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100104);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100105);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100106);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100107);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100108);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100109);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100110);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100111);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100112);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100113);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100114);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100115);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100116);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100117);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100118);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100119);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100120);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100121);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100122);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100123);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100124);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100125);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100126);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100127);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100128);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100129);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100130);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100131);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100132);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100133);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100134);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100135);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100136);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100137);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100138);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100139);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100140);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100141);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100142);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100143);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100144);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100145);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100146);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100147);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100148);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100149);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100150);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100151);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100152);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100153);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100154);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100155);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100156);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100157);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100158);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100159);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100160);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100161);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100162);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100163);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100164);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100165);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100166);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100167);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100168);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100169);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100170);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100171);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100172);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100173);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100174);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100175);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100176);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100177);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100178);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100179);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100180);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100181);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100182);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100183);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100184);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100185);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100186);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100187);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100188);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100189);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100190);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100191);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100192);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100193);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100194);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100195);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100196);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100197);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100198);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100199);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100200);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100201);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100202);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100203);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100204);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100205);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100206);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100207);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100208);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100209);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100210);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100211);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100212);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100213);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100214);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100215);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100216);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100217);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100218);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100219);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100220);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100221);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100222);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100223);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100224);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100225);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100226);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100227);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100228);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100229);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100230);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100231);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100232);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100233);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100234);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100235);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100236);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100237);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100238);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100239);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100240);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100241);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100242);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100243);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100244);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100245);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100246);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100247);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100248);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100249);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100250);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100251);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100252);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100253);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100254);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100255);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100256);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100257);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100258);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100259);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100260);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100261);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100262);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100263);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100264);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100265);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100266);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100267);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100268);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100269);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100270);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100271);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100272);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100273);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100274);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100275);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100276);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100277);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100278);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100279);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100280);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100281);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100282);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100283);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100284);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100285);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100286);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100287);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100288);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100289);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100290);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100291);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100292);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100293);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100294);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100295);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100296);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100297);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100298);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100299);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100300);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100301);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100302);

            migrationBuilder.DeleteData(
                table: "ClimbingRoutes",
                keyColumn: "ClimbingRouteId",
                keyValue: 100303);

            migrationBuilder.AlterColumn<string>(
                name: "Describe",
                table: "ClimbingRoutes",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "ClimbingRoutes",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
