using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movieshop.Data.Migrations
{
    public partial class add_areas_identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 601, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 602, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 602, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 602, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 602, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 602, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 602, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 602, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                column: "BirthDate",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 602, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a -0613-4cbd-a9e6-f1701e926e74",
                column: "ConcurrencyStamp",
                value: "77aa9be7-7c9f-4bcd-a4e9-6e59af57d30e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "001f6dd2-78ee-4027-a148-fe9676b10df2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                column: "ConcurrencyStamp",
                value: "9c913ade-3495-4f57-86e3-c28b7ab0d081");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAUfldfHpxgLgr1m6bo8YruaJJvKG5y8SmjrfSybERsenYIyBD1Z4J8ZGiaRuFw7ow==");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 21, 12, 25, 43, 600, DateTimeKind.Local).AddTicks(8612), new DateTime(2021, 4, 21, 12, 25, 43, 600, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 21, 12, 25, 43, 601, DateTimeKind.Local).AddTicks(5021), new DateTime(2021, 4, 21, 12, 25, 43, 601, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 21, 12, 25, 43, 601, DateTimeKind.Local).AddTicks(5212), new DateTime(2021, 4, 21, 12, 25, 43, 601, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActersName", "DateAdded", "Realise" },
                values: new object[] { "‎Stefan", new DateTime(2021, 4, 21, 12, 25, 43, 601, DateTimeKind.Local).AddTicks(5226), new DateTime(2021, 4, 21, 12, 25, 43, 601, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 21, 12, 25, 43, 601, DateTimeKind.Local).AddTicks(5239), new DateTime(2021, 4, 21, 12, 25, 43, 601, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 21, 12, 25, 43, 601, DateTimeKind.Local).AddTicks(5251), new DateTime(2021, 4, 21, 12, 25, 43, 601, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 21, 12, 25, 43, 601, DateTimeKind.Local).AddTicks(5262), new DateTime(2021, 4, 21, 12, 25, 43, 601, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 21, 12, 25, 43, 601, DateTimeKind.Local).AddTicks(5273), new DateTime(2021, 4, 21, 12, 25, 43, 601, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 21, 12, 25, 43, 601, DateTimeKind.Local).AddTicks(5286), new DateTime(2021, 4, 21, 12, 25, 43, 601, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 603, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 603, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 603, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 603, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 603, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 603, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 603, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 603, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 603, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 603, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 5,
                column: "Year",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 603, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 6,
                column: "Year",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 603, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 7,
                column: "Year",
                value: new DateTime(2021, 4, 21, 12, 25, 43, 603, DateTimeKind.Local).AddTicks(2426));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a -0613-4cbd-a9e6-f1701e926e74",
                column: "ConcurrencyStamp",
                value: "f995e97d-0e00-45ad-aaff-7c928b38efeb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "cc435945-cb96-44e2-9bbb-694983c31273");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                column: "ConcurrencyStamp",
                value: "946aa117-6509-443f-bd22-0690892558e7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEF5ZK6RN3XgbC7zsHNbA7B+J1vARD4zGuNvyRlzGqsdaG6wwZnx+QnjABk0l44rawQ==");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 4, 3, 569, DateTimeKind.Local).AddTicks(4776), new DateTime(2021, 4, 20, 12, 4, 3, 569, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(503), new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(611), new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActersName", "DateAdded", "Realise" },
                values: new object[] { "‎Scott Swan", new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(624), new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(636), new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(648), new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(659), new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(670), new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(682), new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 571, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 572, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 572, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 572, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 572, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 572, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 571, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 571, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 571, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 571, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 5,
                column: "Year",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 571, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 6,
                column: "Year",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 571, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 7,
                column: "Year",
                value: new DateTime(2021, 4, 20, 12, 4, 3, 571, DateTimeKind.Local).AddTicks(6406));
        }
    }
}
