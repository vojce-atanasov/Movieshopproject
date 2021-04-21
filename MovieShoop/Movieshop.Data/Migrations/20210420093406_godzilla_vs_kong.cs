using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movieshop.Data.Migrations
{
    public partial class godzilla_vs_kong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a -0613-4cbd-a9e6-f1701e926e74",
                column: "ConcurrencyStamp",
                value: "dec99c19-6736-451d-ba9f-d82e12990e86");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "67b11564-4a0e-4943-8521-75a6d0e888df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                column: "ConcurrencyStamp",
                value: "d746e21f-1268-4163-b89a-46d7144c1425");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJmZiYyPXljN6XWUdnlhdTJ2NHQkzHoTdq6ue1vrwnnDjZp77CuWdzaM2fKApQrarQ==");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActersName", "DateAdded", "Description", "ProducerName", "ProductionName", "Realise", "Title", "URL" },
                values: new object[] { "Vojche", new DateTime(2021, 4, 20, 11, 34, 5, 481, DateTimeKind.Local).AddTicks(5069), "Kong and his protectors undertake a perilous journey to find his true home. Along for the ride is Jia, an orphaned girl who has a unique and powerful bond with the mighty beast. However, they soon find themselves in the path of an enraged Godzilla as he cuts a swath of destruction across the globe.", "Thomas Tull, Jon Jashni", " Legendary Pictures", new DateTime(2021, 4, 20, 11, 34, 5, 481, DateTimeKind.Local).AddTicks(4210), "Godzilla vs. Kong", "godzilla-king-of-the-monsters-movie-poster-image0.jpg" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(854), new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(982), new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(995), new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActersName", "CategoryName", "DateAdded", "Description", "Price", "ProducerName", "ProductionName", "Realise", "Title" },
                values: new object[] { "Tim Story", "Animation", new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(1008), "A legendary rivalry reemerges when Jerry moves into New York City's finest hotel on the eve of the wedding of the century, forcing the desperate event planner to hire Tom to get rid of him. As mayhem ensues, the escalating cat-and-mouse battle soon threatens to destroy her career, the wedding, and possibly the hotel itself.", 6.9900000000000002, "Chris DeFaria", "Warner Animation Group", new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(1004), "Tom and Jerry" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(1020), new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(1032), new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 484, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 484, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 484, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 484, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 484, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 484, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 483, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 483, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 483, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 483, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 5,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 483, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 6,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 483, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Production",
                keyColumn: "Id",
                keyValue: 7,
                column: "Year",
                value: new DateTime(2021, 4, 20, 11, 34, 5, 483, DateTimeKind.Local).AddTicks(6810));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ActersName", "DateAdded", "Description", "ProducerName", "ProductionName", "Realise", "Title", "URL" },
                values: new object[] { "Dwayne Johnson-The Rock", new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(1987), "In the aftermath of a massive earthquake in California, a rescue-chopper pilot makes a dangerous journey with his ex-wife across the state in order to rescue his daughter.", "Jerry Bruckheimer", "New Line Cinema", new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(1110), "San Andreas", "San_Andreas_poster.jpg" });

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
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(7830), new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActersName", "CategoryName", "DateAdded", "Description", "Price", "ProducerName", "ProductionName", "Realise", "Title" },
                values: new object[] { " Keira Knightley", "Drama", new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(7843), "Colette is pushed by her husband to write novels under his name. Upon their success, she fights to make her talents known, challenging gender norms.", 5.79, "Kathleen Kennedy", "20th Century", new DateTime(2021, 4, 20, 11, 20, 0, 333, DateTimeKind.Local).AddTicks(7839), "Colette " });

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
    }
}
