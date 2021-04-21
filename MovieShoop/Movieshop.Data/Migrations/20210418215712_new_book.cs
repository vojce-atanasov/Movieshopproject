using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movieshop.Data.Migrations
{
    public partial class new_book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ActersName", "DateAdded", "Description", "ProducerName", "Realise", "Title" },
                values: new object[] { "‎Scott Swan", new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(6170), "Mortal Kombat is a mysterious, intergalactic tournament of ancient martial arts.", " James Wan, Todd Garner", new DateTime(2021, 4, 18, 23, 57, 12, 182, DateTimeKind.Local).AddTicks(6167), "Mortal Kombat II" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a -0613-4cbd-a9e6-f1701e926e74",
                column: "ConcurrencyStamp",
                value: "f3fd8707-3776-4234-8d7b-e699a4be490f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "7fd73100-1de2-4b22-9f4b-80a2eb0a0280");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                column: "ConcurrencyStamp",
                value: "51bf81ae-9d08-4ebe-98b9-d76aa3e37bbc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGi+YOZi2HyqSqiZVTFfsF8Ya50oxq5HxJrgHDZvQ9pyOPLXVlyIcspPMtd8JHXKPA==");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 18, 21, 43, 34, 637, DateTimeKind.Local).AddTicks(7251), new DateTime(2021, 4, 18, 21, 43, 34, 637, DateTimeKind.Local).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(2804), new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(2916), new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActersName", "DateAdded", "Description", "ProducerName", "Realise", "Title" },
                values: new object[] { " ‎Sylvester Stallone", new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(2929), "Rambo must confront his past and unearth his ruthless combat skills to exact revenge in a final mission.", "David Heyman", new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(2924), "Rambo: Last Blood" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(2942), new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(2953), new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(2965), new DateTime(2021, 4, 18, 21, 43, 34, 638, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 640, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 640, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 640, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 640, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 640, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 640, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 639, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 639, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 639, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 639, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 5,
                column: "Year",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 639, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 6,
                column: "Year",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 639, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 7,
                column: "Year",
                value: new DateTime(2021, 4, 18, 21, 43, 34, 639, DateTimeKind.Local).AddTicks(8195));
        }
    }
}
