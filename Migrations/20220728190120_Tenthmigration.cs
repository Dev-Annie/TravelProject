using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelProject.Migrations
{
    public partial class Tenthmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Rentals",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "BatchNo",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "MRP",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Activities");

            migrationBuilder.RenameColumn(
                name: "RentalName",
                table: "Rentals",
                newName: "Rentalname");

            migrationBuilder.RenameColumn(
                name: "ShippingNo",
                table: "Rentals",
                newName: "Party");

            migrationBuilder.RenameColumn(
                name: "SerialNo",
                table: "Rentals",
                newName: "IdRentals");

            migrationBuilder.RenameColumn(
                name: "RentalCode",
                table: "Rentals",
                newName: "Fee");

            migrationBuilder.RenameColumn(
                name: "Manufacturer",
                table: "Rentals",
                newName: "City");

            migrationBuilder.AlterColumn<string>(
                name: "Rentalname",
                table: "Rentals",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdRentals",
                table: "Rentals",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rentals",
                table: "Rentals",
                column: "IdRentals");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Rentals",
                table: "Rentals");

            migrationBuilder.RenameColumn(
                name: "Rentalname",
                table: "Rentals",
                newName: "RentalName");

            migrationBuilder.RenameColumn(
                name: "Party",
                table: "Rentals",
                newName: "ShippingNo");

            migrationBuilder.RenameColumn(
                name: "Fee",
                table: "Rentals",
                newName: "RentalCode");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Rentals",
                newName: "Manufacturer");

            migrationBuilder.RenameColumn(
                name: "IdRentals",
                table: "Rentals",
                newName: "SerialNo");

            migrationBuilder.AlterColumn<string>(
                name: "RentalName",
                table: "Rentals",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "SerialNo",
                table: "Rentals",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Rentals",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "BatchNo",
                table: "Rentals",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Rentals",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "Rentals",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MRP",
                table: "Rentals",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Rentals",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Activities",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rentals",
                table: "Rentals",
                column: "Id");
        }
    }
}
