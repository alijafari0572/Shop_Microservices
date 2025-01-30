using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Products.Infra.Migrations
{
    /// <inheritdoc />
    public partial class initseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 3, 11, 182, DateTimeKind.Utc).AddTicks(661),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 14, 51, 44, 969, DateTimeKind.Utc).AddTicks(188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 3, 11, 182, DateTimeKind.Utc).AddTicks(249),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 14, 51, 44, 968, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 3, 11, 181, DateTimeKind.Utc).AddTicks(230),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 14, 51, 44, 968, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 15, 3, 11, 180, DateTimeKind.Utc).AddTicks(9843),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 14, 51, 44, 968, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Active", "Description", "ParentCategoryId", "Permalink", "Priority", "Title" },
                values: new object[,]
                {
                    { 16, false, "Cupidatat ut in sit ex. Laboris incididunt est mollit id laboris est duis fugiat sunt dolore culpa consectetur. Nulla velit ut nostrud proident anim minim aliqua esse. Nisi cillum do aliqua reprehenderit est.", null, "Lucinda-Patel", 0, "Bond Dale" },
                    { 52, false, "Ea nisi reprehenderit anim id excepteur. Non adipisicing qui ex pariatur consectetur culpa id adipisicing anim anim laborum. Cillum aute pariatur amet dolor ullamco aliqua sit irure magna ad cillum ea. Incididunt veniam laborum reprehenderit aute occaecat irure nisi irure cupidatat non veniam irure veniam nisi. Tempor eiusmod enim anim quis et dolor minim anim cillum proident officia cillum. Nostrud ullamco excepteur minim id duis laboris. Cupidatat eiusmod do anim ad in laborum sint irure eu elit.", null, "Carrie-Cooley", 0, "Atkinson Ortiz" },
                    { 56, true, "Labore ipsum quis duis occaecat. Veniam laboris nostrud ad consectetur in. Ad ipsum consectetur adipisicing nulla irure aliquip eiusmod ad. Duis incididunt occaecat fugiat irure esse est id aliquip Lorem. Sint aliqua fugiat cillum ad excepteur deserunt enim non irure dolore qui. Commodo nisi dolore deserunt commodo voluptate occaecat consectetur tempor esse. Nulla ea ad nisi do eu qui dolore.", null, "Sybil-Glass", 0, "Jerry Haney" },
                    { 74, true, "Ea sit proident laborum sint mollit minim culpa officia ut laborum consequat qui. Mollit amet labore do enim et cillum exercitation ullamco. Esse nulla eu incididunt et duis mollit.", null, "Carmen-Vincent", 0, "Amparo Walter" },
                    { 81, false, "Enim ad est proident anim cillum ex ex sint fugiat nisi minim sunt enim. Elit pariatur elit eiusmod velit sit eu aliquip ipsum nisi. Dolor fugiat magna dolore esse aliquip magna eiusmod. Sint aliqua dolore eu officia exercitation ut in adipisicing. Cillum ut laborum deserunt incididunt qui in in voluptate Lorem sunt eiusmod dolore qui reprehenderit. Exercitation excepteur id ea minim fugiat qui magna exercitation labore Lorem.", null, "Lavonne-Sharp", 0, "Chasity Oliver" },
                    { 84, true, "Eu ullamco adipisicing nisi adipisicing consectetur. Mollit dolore ullamco nisi sunt occaecat officia. Nulla officia ea incididunt commodo amet. Tempor consectetur laboris eu aliquip et dolore officia.", null, "Tyson-Hopper", 0, "Maynard Anthony" },
                    { 101, true, "Deserunt voluptate voluptate do ipsum magna elit velit fugiat ipsum. Eu non sunt pariatur excepteur aute eu. Elit adipisicing ipsum nostrud dolor. Ad labore elit laborum velit nulla aliquip dolor in aute nulla quis.", null, "Burris-Dickerson", 0, "Sanford Gould" },
                    { 117, false, "Cillum sint labore anim ipsum exercitation. Laboris veniam ut minim consectetur laborum duis. Commodo exercitation sint nisi amet irure magna dolor est occaecat non do Lorem est. Labore velit et aliqua qui ea. In veniam labore excepteur cillum nulla dolor. Consequat id consectetur fugiat qui irure do cillum dolor pariatur. Nisi ea sit minim cupidatat sunt commodo culpa duis magna cupidatat sit eiusmod ipsum sint.", null, "Rasmussen-Rutledge", 0, "Alston Freeman" },
                    { 156, false, "Et proident est voluptate labore velit non non velit. Ea exercitation irure enim do pariatur adipisicing do mollit. Velit nulla amet cupidatat voluptate eu incididunt excepteur labore sint. Eu commodo sit Lorem ea amet culpa et eu irure nisi.", null, "Alyssa-Medina", 0, "Lewis Becker" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 14, 51, 44, 969, DateTimeKind.Utc).AddTicks(188),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 3, 11, 182, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 14, 51, 44, 968, DateTimeKind.Utc).AddTicks(9800),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 3, 11, 182, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 14, 51, 44, 968, DateTimeKind.Utc).AddTicks(8373),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 3, 11, 181, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 30, 14, 51, 44, 968, DateTimeKind.Utc).AddTicks(7952),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2025, 1, 30, 15, 3, 11, 180, DateTimeKind.Utc).AddTicks(9843));
        }
    }
}
