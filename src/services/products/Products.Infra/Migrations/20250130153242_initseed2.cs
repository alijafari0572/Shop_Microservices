using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Products.Infra.Migrations
{
    /// <inheritdoc />
    public partial class initseed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 32, 41, 922, DateTimeKind.Utc).AddTicks(9286),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 18, 24, 547, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 32, 41, 922, DateTimeKind.Utc).AddTicks(8847),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 18, 24, 547, DateTimeKind.Utc).AddTicks(7098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(9172),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(8679),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(8679), new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(8679), new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(8679), new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(8679), new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(8679), new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(8679), new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(8679), new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(8679), new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(8679), new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(9172) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Active", "CategoryId", "Code", "Description", "Permalink", "Price", "Title" },
                values: new object[,]
                {
                    { 15, true, 52, "Goff", "Minim dolor duis aliqua in mollit exercitation laborum magna exercitation. Dolor aute aliquip proident occaecat cupidatat labore non sit. Commodo ex deserunt amet voluptate.", "Yang-Blackburn", 0m, "Irwin Cain" },
                    { 37, true, 16, "Romero", "Cupidatat eiusmod duis in aliquip aute nisi incididunt cupidatat fugiat ea. Qui enim ut veniam et est qui laborum laboris velit deserunt aliquip ut consectetur fugiat. Nulla magna deserunt duis commodo nostrud cupidatat ullamco. Aliqua cupidatat non ullamco officia cillum enim dolore quis.", "Rice-Foreman", 0m, "Lesley Sims" },
                    { 53, false, 81, "Hattie", "Sint consequat nisi cupidatat aute exercitation officia eiusmod nisi laboris duis. Ipsum excepteur aliquip magna ut pariatur. Aliqua elit sint aute eiusmod nisi excepteur. Dolor ipsum adipisicing qui tempor ullamco magna tempor. Elit labore ipsum id deserunt excepteur ea ut. Id velit ipsum enim sit fugiat commodo deserunt commodo elit proident.", "Brandi-Schroeder", 0m, "Yvette Allen" },
                    { 67, true, 56, "Whitehead", "Adipisicing aliqua dolor tempor culpa do elit anim. Commodo adipisicing occaecat id dolor mollit cupidatat tempor laborum. Ea adipisicing eiusmod irure eu do consectetur officia id cillum.", "Enid-Mcpherson", 0m, "Monica Gamble" },
                    { 90, false, 156, "Irma", "Enim non est ex laboris in cupidatat tempor aute proident laboris qui anim id. Enim deserunt et fugiat incididunt amet est eiusmod enim dolore id veniam. Ex quis ipsum nostrud ipsum eiusmod. Nostrud qui ea amet laborum do sit laborum. In cillum ut dolor amet ipsum tempor cillum deserunt labore Lorem. Velit ea sint amet laborum nulla nulla sit non quis et.", "Andrews-Luna", 0m, "Gallegos Mcneil" },
                    { 133, true, 101, "Yates", "Sit mollit mollit proident aute minim do culpa do laboris. Lorem fugiat officia quis dolor aliqua aliqua minim aliqua dolor nostrud pariatur quis id nisi. Adipisicing excepteur aute incididunt elit ex culpa do laborum pariatur cupidatat quis nisi nisi consequat. Ullamco labore irure magna dolore. Nisi ea mollit sunt in. Dolor fugiat consectetur nulla sit incididunt deserunt eiusmod id anim. Ullamco Lorem adipisicing eu sit excepteur elit laborum deserunt occaecat fugiat.", "Morrow-Henderson", 0m, "Blackburn Chen" },
                    { 137, true, 74, "Latasha", "Id eiusmod enim adipisicing ullamco minim excepteur pariatur reprehenderit mollit adipisicing aute qui. Ipsum exercitation laborum minim non deserunt sit adipisicing aliqua aliqua velit irure. Dolor adipisicing voluptate dolore qui ut occaecat pariatur eu. Magna aliquip velit aliqua velit ea aute labore ex aliqua. Reprehenderit fugiat sunt nisi in sint.", "Randolph-Armstrong", 0m, "Pruitt Weiss" },
                    { 163, true, 156, "Tisha", "Sint magna consequat anim deserunt esse et dolore amet sint sunt. Enim ea eu est est elit veniam adipisicing. Sunt aliqua excepteur aliqua labore nisi culpa.", "Chrystal-Lewis", 0m, "Jolene Bradford" },
                    { 165, false, 84, "Butler", "Nulla exercitation id aliqua nisi proident do sint adipisicing fugiat. Pariatur excepteur eu laborum qui eiusmod amet voluptate consectetur esse laborum mollit ea minim excepteur. Id do do nulla irure elit fugiat.", "Maureen-Cleveland", 0m, "Serena Watts" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 18, 24, 547, DateTimeKind.Utc).AddTicks(7504),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 32, 41, 922, DateTimeKind.Utc).AddTicks(9286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 18, 24, 547, DateTimeKind.Utc).AddTicks(7098),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 32, 41, 922, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8467),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 18, 24, 546, DateTimeKind.Utc).AddTicks(8096),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 32, 41, 921, DateTimeKind.Utc).AddTicks(8679));

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
    }
}
