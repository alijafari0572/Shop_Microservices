using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Products.Infra.Migrations
{
    /// <inheritdoc />
    public partial class initseed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 18, 24, 547, DateTimeKind.Utc).AddTicks(7504),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 3, 11, 182, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 18, 24, 547, DateTimeKind.Utc).AddTicks(7098),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 3, 11, 182, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8467),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 3, 11, 181, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8096),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 3, 11, 180, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8096), new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8096), new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8096), new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8096), new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8096), new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8096), new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8096), new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8096), new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8096), new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8467) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 3, 11, 182, DateTimeKind.Utc).AddTicks(661),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 18, 24, 547, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 3, 11, 182, DateTimeKind.Utc).AddTicks(249),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 18, 24, 547, DateTimeKind.Utc).AddTicks(7098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 3, 11, 181, DateTimeKind.Utc).AddTicks(230),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 3, 11, 180, DateTimeKind.Utc).AddTicks(9843),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 3, 11, 180, DateTimeKind.Utc).AddTicks(9843), new DateTime(2025, 1, 30, 15, 3, 11, 181, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 3, 11, 180, DateTimeKind.Utc).AddTicks(9843), new DateTime(2025, 1, 30, 15, 3, 11, 181, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 3, 11, 180, DateTimeKind.Utc).AddTicks(9843), new DateTime(2025, 1, 30, 15, 3, 11, 181, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 3, 11, 180, DateTimeKind.Utc).AddTicks(9843), new DateTime(2025, 1, 30, 15, 3, 11, 181, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 3, 11, 180, DateTimeKind.Utc).AddTicks(9843), new DateTime(2025, 1, 30, 15, 3, 11, 181, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 3, 11, 180, DateTimeKind.Utc).AddTicks(9843), new DateTime(2025, 1, 30, 15, 3, 11, 181, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 3, 11, 180, DateTimeKind.Utc).AddTicks(9843), new DateTime(2025, 1, 30, 15, 3, 11, 181, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 3, 11, 180, DateTimeKind.Utc).AddTicks(9843), new DateTime(2025, 1, 30, 15, 3, 11, 181, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 3, 11, 180, DateTimeKind.Utc).AddTicks(9843), new DateTime(2025, 1, 30, 15, 3, 11, 181, DateTimeKind.Utc).AddTicks(230) });
        }
    }
}
