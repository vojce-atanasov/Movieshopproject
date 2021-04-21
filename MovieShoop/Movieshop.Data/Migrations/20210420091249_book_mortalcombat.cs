using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movieshop.Data.Migrations
{
    public partial class book_mortalcombat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 12, 48, 66, DateTimeKind.Local).AddTicks(4978), new DateTime(2021, 4, 20, 11, 12, 48, 66, DateTimeKind.Local).AddTicks(4974) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a -0613-4cbd-a9e6-f1701e926e74",
                column: "ConcurrencyStamp",
                value: "884725a2-4df3-4673-8ea0-23a2497d4f01");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "328a3134-3ff8-4d5f-b90a-972e40e2c197");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                column: "ConcurrencyStamp",
                value: "2aa0f293-99d4-4352-962a-cc7b50d95ada");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECGcXeC8sJ/DbiFS2c/xM8NmWZ13rg3+4z6EFWAQaPIS9fXJmPErHz9pz7TTOcUsTg==");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(2856), new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(6103), new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(6162), new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "Realise", "URL" },
                values: new object[] { new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(6170), new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(6167), "" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(6177), new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(6184), new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(6190), new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 183, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 183, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 183, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 183, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 183, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 183, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 183, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 183, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 183, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 183, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 5,
                column: "Year",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 183, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 6,
                column: "Year",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 183, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 7,
                column: "Year",
                value: new DateTime(2021, 4, 18, 23, 57, 12, 183, DateTimeKind.Local).AddTicks(5075));
        }
    }
}
