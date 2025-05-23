using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhiteLagoon.Infranstructure.Migrations
{
    /// <inheritdoc />
    public partial class seedVillaToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Created_Date", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "Updated_Date" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 22, 18, 37, 3, 495, DateTimeKind.Local).AddTicks(5017), "This is a description of Royal Villa", "https://example.com/royal-villa.jpg", "Royal Villa", 2, 200.0, 500, new DateTime(2025, 5, 22, 18, 37, 3, 499, DateTimeKind.Local).AddTicks(618) },
                    { 2, new DateTime(2025, 5, 22, 18, 37, 3, 499, DateTimeKind.Local).AddTicks(846), "This is a description of Luxury Villa", "https://example.com/luxury-villa.jpg", "Luxury Villa", 4, 300.0, 700, new DateTime(2025, 5, 22, 18, 37, 3, 499, DateTimeKind.Local).AddTicks(847) },
                    { 3, new DateTime(2025, 5, 22, 18, 37, 3, 499, DateTimeKind.Local).AddTicks(849), "This is a description of Beachfront Villa", "https://example.com/beachfront-villa.jpg", "Beachfront Villa", 6, 400.0, 900, new DateTime(2025, 5, 22, 18, 37, 3, 499, DateTimeKind.Local).AddTicks(850) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
