using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelProject.Migrations
{
    public partial class SecondMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Activities");

            migrationBuilder.RenameColumn(
                name: "idActivity",
                table: "Activities",
                newName: "IdActivity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdActivity",
                table: "Activities",
                newName: "idActivity");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Activities",
                type: "INTEGER",
                nullable: true);
        }
    }
}
