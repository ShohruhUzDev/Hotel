using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_interfeys.Migrations
{
    public partial class addproptoclient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Cost",
                table: "Rooms",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfArrival",
                table: "Clients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfDepartur",
                table: "Clients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "DateOfArrival",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "DateOfDepartur",
                table: "Clients");
        }
    }
}
