using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhiteLagoon.Infranstructure.Migrations
{
    /// <inheritdoc />
    public partial class seedVillaToDbWithoutDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_Date", "Updated_Date" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_Date", "Updated_Date" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_Date", "Updated_Date" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_Date", "Updated_Date" },
                values: new object[] { new DateTime(2025, 5, 22, 18, 37, 3, 495, DateTimeKind.Local).AddTicks(5017), new DateTime(2025, 5, 22, 18, 37, 3, 499, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_Date", "Updated_Date" },
                values: new object[] { new DateTime(2025, 5, 22, 18, 37, 3, 499, DateTimeKind.Local).AddTicks(846), new DateTime(2025, 5, 22, 18, 37, 3, 499, DateTimeKind.Local).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_Date", "Updated_Date" },
                values: new object[] { new DateTime(2025, 5, 22, 18, 37, 3, 499, DateTimeKind.Local).AddTicks(849), new DateTime(2025, 5, 22, 18, 37, 3, 499, DateTimeKind.Local).AddTicks(850) });
        }
    }
}
