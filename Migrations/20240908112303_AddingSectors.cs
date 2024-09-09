using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backcrazyhorse.Migrations
{
    /// <inheritdoc />
    public partial class AddingSectors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Images = table.Column<string>(type: "TEXT", nullable: true),
                    CountryId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionId);
                    table.ForeignKey(
                        name: "FK_Regions_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId");
                });

            migrationBuilder.CreateTable(
                name: "Massives",
                columns: table => new
                {
                    MassiveId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Images = table.Column<string>(type: "TEXT", nullable: true),
                    Describe = table.Column<string>(type: "TEXT", nullable: true),
                    RegionId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Massives", x => x.MassiveId);
                    table.ForeignKey(
                        name: "FK_Massives_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId");
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    SectorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Describe = table.Column<string>(type: "TEXT", nullable: true),
                    MassiveId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.SectorId);
                    table.ForeignKey(
                        name: "FK_Sectors_Massives_MassiveId",
                        column: x => x.MassiveId,
                        principalTable: "Massives",
                        principalColumn: "MassiveId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClimbingRoutes",
                columns: table => new
                {
                    ClimbingRouteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Describe = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    Testimonial = table.Column<string>(type: "TEXT", nullable: true),
                    BoltCount = table.Column<int>(type: "INTEGER", nullable: true),
                    SectorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClimbingRoutes", x => x.ClimbingRouteId);
                    table.ForeignKey(
                        name: "FK_ClimbingRoutes_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "SectorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Path = table.Column<string>(type: "TEXT", nullable: true),
                    ClimbingRouteId = table.Column<int>(type: "INTEGER", nullable: true),
                    SectorId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Image_ClimbingRoutes_ClimbingRouteId",
                        column: x => x.ClimbingRouteId,
                        principalTable: "ClimbingRoutes",
                        principalColumn: "ClimbingRouteId");
                    table.ForeignKey(
                        name: "FK_Image_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "SectorId");
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Name" },
                values: new object[] { 101010, "Thailand" });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "CountryId", "Images", "Name" },
                values: new object[] { 110101000, 101010, null, "Chiang Mai" });

            migrationBuilder.InsertData(
                table: "Massives",
                columns: new[] { "MassiveId", "Describe", "Images", "Name", "RegionId" },
                values: new object[] { 111, null, null, "Crazy Horse Buttress", 110101000 });

            migrationBuilder.InsertData(
                table: "Sectors",
                columns: new[] { "SectorId", "Describe", "MassiveId", "Name" },
                values: new object[,]
                {
                    { 1, "Описание сектора", 111, "Heart Wall" },
                    { 2, "Описание сектора", 111, "rooftop" },
                    { 3, "Описание сектора", 111, "The Gatekeeper Buttress" },
                    { 4, "Описание сектора", 111, "Anxiety State Crisis Cave" },
                    { 5, "Описание сектора", 111, "Reunion Buttress" },
                    { 6, "Описание сектора", 111, "Buddha Buttress" },
                    { 7, "Описание сектора", 111, "The Aircon Wall" },
                    { 8, "Описание сектора", 111, "Windy Cave" },
                    { 9, "Описание сектора", 111, "Crazy Horse Area" },
                    { 10, "Описание сектора", 111, "The Horse Shoe" },
                    { 11, "Описание сектора", 111, "The Archway" },
                    { 12, "Описание сектора", 111, "The Evening Terraces" },
                    { 13, "Описание сектора", 111, "The Furnace" },
                    { 14, "Описание сектора", 111, "The Junkyard" },
                    { 15, "Описание сектора", 111, "The Hanging Gardens" },
                    { 16, "Описание сектора", 111, "Tamarind Village" },
                    { 17, "Описание сектора", 111, "Little Monkey Cove" },
                    { 18, "Описание сектора", 111, "Vision" },
                    { 19, "Описание сектора", 111, "Naam Prik Wall" },
                    { 20, "Описание сектора", 111, "The Ant Hill" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClimbingRoutes_SectorId",
                table: "ClimbingRoutes",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ClimbingRouteId",
                table: "Image",
                column: "ClimbingRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_SectorId",
                table: "Image",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Massives_RegionId",
                table: "Massives",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Regions_CountryId",
                table: "Regions",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sectors_MassiveId",
                table: "Sectors",
                column: "MassiveId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "ClimbingRoutes");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "Massives");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
