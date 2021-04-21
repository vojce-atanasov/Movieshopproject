using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movieshop.Data.Migrations
{
    public partial class book_mortalcombat1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 334, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 334, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 334, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 334, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 334, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 334, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 334, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 334, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 334, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a -0613-4cbd-a9e6-f1701e926e74",
                column: "ConcurrencyStamp",
                value: "a31cbe2c-12ee-481a-b473-6cf0b9c1cd5d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "2e888a90-d8f9-468d-b5ec-f8f8db51c4bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                column: "ConcurrencyStamp",
                value: "72b7e338-3949-40cc-ba42-f07953b612ef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOcEv08B7sJR0qahdsCP9o4+jQlndSwOYn0ExK4S8UPkxrVrp71bBbR3jk/oYw7vKw==");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(1987), new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(7700), new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(7817), new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "Realise", "URL" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(7830), new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(7826), "mc.jfif" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "Realise", "URL" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(7843), new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(7839), "tomandjery.jpg" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(7855), new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(7867), new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 335, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 335, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 335, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 335, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 335, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 335, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 335, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 335, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 335, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 335, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 5,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 335, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 6,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 335, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 7,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 20, 0, 335, DateTimeKind.Local).AddTicks(3272));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 66, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 67, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 67, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 67, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 67, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 67, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 67, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 67, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 67, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a -0613-4cbd-a9e6-f1701e926e74",
                column: "ConcurrencyStamp",
                value: "0d2d4b00-b80c-46db-9f03-35387c1e2bbd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "5a8774a5-e24d-4b6f-b13f-826569398f73");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                column: "ConcurrencyStamp",
                value: "28ae1f27-9e3b-4023-94f9-afbfa5a7211a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFKzO0aIhUeDjMQkD2poqla7Vtn2xkYIvoesaxCE4KrH+eMet93KEguClRhvc1K/2g==");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 12, 48, 65, DateTimeKind.Local).AddTicks(9011), new DateTime(2021, 4, 20, 11, 12, 48, 65, DateTimeKind.Local).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 12, 48, 66, DateTimeKind.Local).AddTicks(4841), new DateTime(2021, 4, 20, 11, 12, 48, 66, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 12, 48, 66, DateTimeKind.Local).AddTicks(4951), new DateTime(2021, 4, 20, 11, 12, 48, 66, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "Realise", "URL" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 12, 48, 66, DateTimeKind.Local).AddTicks(4964), new DateTime(2021, 4, 20, 11, 12, 48, 66, DateTimeKind.Local).AddTicks(4960), "mc.jpg" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "Realise", "URL" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 12, 48, 66, DateTimeKind.Local).AddTicks(4978), new DateTime(2021, 4, 20, 11, 12, 48, 66, DateTimeKind.Local).AddTicks(4974), "colette.jpg" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 12, 48, 66, DateTimeKind.Local).AddTicks(4990), new DateTime(2021, 4, 20, 11, 12, 48, 66, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 12, 48, 66, DateTimeKind.Local).AddTicks(5001), new DateTime(2021, 4, 20, 11, 12, 48, 66, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 68, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 68, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 68, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 68, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 68, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 68, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 67, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 68, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 68, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 68, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 5,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 68, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 6,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 68, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 7,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 12, 48, 68, DateTimeKind.Local).AddTicks(907));
        }
    }
}
