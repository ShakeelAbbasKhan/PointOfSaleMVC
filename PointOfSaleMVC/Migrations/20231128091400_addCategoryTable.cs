using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PointOfSaleMVC.Migrations
{
    /// <inheritdoc />
    public partial class addCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Category 1", 10 },
                    { 2, "Category 2", 20 },
                    { 3, "Category 3", 30 },
                    { 4, "Category 4", 40 },
                    { 5, "Category 5", 50 },
                    { 6, "Category 6", 60 },
                    { 7, "Category 7", 70 },
                    { 8, "Category 8", 80 },
                    { 9, "Category 9", 90 },
                    { 10, "Category 10", 100 },
                    { 11, "Category 11", 110 },
                    { 12, "Category 12", 120 },
                    { 13, "Category 13", 130 },
                    { 14, "Category 14", 140 },
                    { 15, "Category 15", 150 },
                    { 16, "Category 16", 160 },
                    { 17, "Category 17", 170 },
                    { 18, "Category 18", 180 },
                    { 19, "Category 19", 190 },
                    { 20, "Category 20", 200 },
                    { 21, "Category 21", 210 },
                    { 22, "Category 22", 220 },
                    { 23, "Category 23", 230 },
                    { 24, "Category 24", 240 },
                    { 25, "Category 25", 250 },
                    { 26, "Category 26", 260 },
                    { 27, "Category 27", 270 },
                    { 28, "Category 28", 280 },
                    { 29, "Category 29", 290 },
                    { 30, "Category 30", 300 },
                    { 31, "Category 31", 310 },
                    { 32, "Category 32", 320 },
                    { 33, "Category 33", 330 },
                    { 34, "Category 34", 340 },
                    { 35, "Category 35", 350 },
                    { 36, "Category 36", 360 },
                    { 37, "Category 37", 370 },
                    { 38, "Category 38", 380 },
                    { 39, "Category 39", 390 },
                    { 40, "Category 40", 400 },
                    { 41, "Category 41", 410 },
                    { 42, "Category 42", 420 },
                    { 43, "Category 43", 430 },
                    { 44, "Category 44", 440 },
                    { 45, "Category 45", 450 },
                    { 46, "Category 46", 460 },
                    { 47, "Category 47", 470 },
                    { 48, "Category 48", 480 },
                    { 49, "Category 49", 490 },
                    { 50, "Category 50", 500 },
                    { 51, "Category 51", 510 },
                    { 52, "Category 52", 520 },
                    { 53, "Category 53", 530 },
                    { 54, "Category 54", 540 },
                    { 55, "Category 55", 550 },
                    { 56, "Category 56", 560 },
                    { 57, "Category 57", 570 },
                    { 58, "Category 58", 580 },
                    { 59, "Category 59", 590 },
                    { 60, "Category 60", 600 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
