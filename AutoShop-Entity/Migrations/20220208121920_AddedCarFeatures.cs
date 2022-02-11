using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoShop_Entity.Migrations
{
    public partial class AddedCarFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carFeatures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ABS = table.Column<bool>(type: "bit", nullable: false),
                    ElectricWindows = table.Column<bool>(type: "bit", nullable: false),
                    Hatch = table.Column<bool>(type: "bit", nullable: false),
                    Bluetooth = table.Column<bool>(type: "bit", nullable: false),
                    AlarmSystem = table.Column<bool>(type: "bit", nullable: false),
                    ParkControl = table.Column<bool>(type: "bit", nullable: false),
                    Navigation = table.Column<bool>(type: "bit", nullable: false),
                    BoardComputer = table.Column<bool>(type: "bit", nullable: false),
                    MultiWheel = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carFeatures", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carFeatures");
        }
    }
}
