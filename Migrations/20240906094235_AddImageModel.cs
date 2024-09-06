using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backcrazyhorse.Migrations
{
    /// <inheritdoc />
    public partial class AddImageModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "ClimbingRoutes");

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
                name: "IX_Image_ClimbingRouteId",
                table: "Image",
                column: "ClimbingRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_SectorId",
                table: "Image",
                column: "SectorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "SectorId",
                keyValue: 20);

            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "ClimbingRoutes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
