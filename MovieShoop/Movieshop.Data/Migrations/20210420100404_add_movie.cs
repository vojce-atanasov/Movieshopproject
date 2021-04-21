using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movieshop.Data.Migrations
{
    public partial class add_movie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ActersName", "DateAdded", "Description", "ProducerName", "Realise", "Title", "URL" },
                values: new object[] { "Jorgos", new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(503), "Behind our world, there is another -- a world of dangerous and powerful monsters that rule their domain with deadly ferocity. When Lt. Artemis and her loyal soldiers are transported from our world to the new one, the unflappable lieutenant receives the shock of her life. In a desperate battle for survival against enormous enemies with incredible powers and unstoppable, terrifying attacks, Artemis teams up with a mysterious hunter who has found a way to fight back.", " Paul W. S. Anderson, Martin Moszkowicz", new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(467), "Monster Hunter", "monster.jpg" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActersName", "DateAdded", "Description", "GenreName", "ProducerName", "ProductionName", "Realise", "Title", "URL" },
                values: new object[] { "Martin", new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(611), "Diana Prince lives quietly among mortals in the vibrant, sleek 1980s -- an era of excess driven by the pursuit of having it all. Though she's come into her full powers, she maintains a low profile by curating ancient artifacts, and only performing heroic acts incognito. But soon, Diana will have to muster all of her strength, wisdom and courage as she finds herself squaring off against Maxwell Lord and the Cheetah, a villainess who possesses superhuman strength and agility.", "Action", "Charles Roven", "Warner Bros.Pictures, DC Films", new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(605), "Wonder Woman 1984", "ww84.jpg" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(624), new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(619) });

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
                columns: new[] { "ActersName", "DateAdded", "Description", "Price", "ProducerName", "ProductionName", "Realise", "Title", "URL" },
                values: new object[] { "Yolanthe Sneijder-Cabau", new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(648), "Incurable romantic Lotte finds her life upended when her plans for a picture-perfect wedding unravel -- just as her self-absorbed sister gets engaged.", 5.5899999999999999, "Nikola", "AM Pictures", new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(643), "Just Say Yes", "justsayyees.jpg" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryName", "DateAdded", "Description", "GenreName", "ProducerName", "ProductionName", "Realise", "Title", "URL" },
                values: new object[] { "Action", new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(659), "US agent Luke Hobbs and British mercenary Deckard Shaw are forced to put their rivalry side and work together to stop a genetically enhanced supervillain.", "Adventure", "Chris Morgan", "Seven Bucks Productions", new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(654), "Fast & Furious", "Hobbs.jfif" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "ActersId", "ActersName", "ActorId", "Awards", "CategoryId", "CategoryName", "Country", "DateAdded", "Description", "GenreId", "GenreName", "Language", "Price", "ProducerId", "ProducerName", "ProductionId", "ProductionName", "Rating", "Realise", "TimeLast", "Title", "URL", "YearsToWatch" },
                values: new object[,]
                {
                    { 8, 9, "Ljupce", null, 11, 4, "Action", "USA", new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(670), "An assassin becomes marked for death by her own black ops organization after questioning orders and breaking protocol.", 1, "Crime", "English", 6.9900000000000002, 1, " Jessica Chastain", 3, "Voltage Pictures", 7.7999999999999998, new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(665), 3.2000000000000002, "Ava", "ava.jpg", 8 },
                    { 9, 9, "Kristian", null, 11, 4, "Action", "USA", new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(682), "Detectives Mike Lowrey and Marcus Burnett join the Miami Police Department's special team AMMO to bring down the ruthless Armando, who is on a mission to kill Mike at his mother Isabel's orders.", 1, "Adventure", "English", 8.0999999999999996, 1, "Will Smith, Jerry Bruckheimer, Doug Belgrad, Даг Белград", 3, "Columbia Pictures", 7.7999999999999998, new DateTime(2021, 4, 20, 12, 4, 3, 570, DateTimeKind.Local).AddTicks(677), 3.2000000000000002, "Bad Boys", "badboys.jpg", 8 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9);

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
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 34, 5, 481, DateTimeKind.Local).AddTicks(5069), new DateTime(2021, 4, 20, 11, 34, 5, 481, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActersName", "DateAdded", "Description", "ProducerName", "Realise", "Title", "URL" },
                values: new object[] { "Jason Statham", new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(854), "When a mysterious woman seduces Dominic Toretto into the world of terrorism and a betrayal of those closest to him, the crew face trials that will test them as never before", "Kevin Feige", new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(820), "The Fate of the Furious", "fateofthefurious.jpg" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActersName", "DateAdded", "Description", "GenreName", "ProducerName", "ProductionName", "Realise", "Title", "URL" },
                values: new object[] { "Angelina Jolie", new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(982), "A bored married couple is surprised to learn that they are both assassins hired by competing agencies to kill each other.", "Comedy", "Kathleen Kennedy", "New Line Cinema", new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(976), "Mr. & Mrs. Smith ", "smithFamily.jpg" });

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
                columns: new[] { "DateAdded", "Realise" },
                values: new object[] { new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(1008), new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActersName", "DateAdded", "Description", "Price", "ProducerName", "ProductionName", "Realise", "Title", "URL" },
                values: new object[] { "Tom Cruise", new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(1020), " talented New York City bartender takes a job at a bar in Jamaica and falls in love.", 6.8899999999999997, "Jerry Bruckheimer", "Universal Studios", new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(1015), "Cocktail", "coctail.jpg" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryName", "DateAdded", "Description", "GenreName", "ProducerName", "ProductionName", "Realise", "Title", "URL" },
                values: new object[] { "Drama", new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(1032), "A seventeen - year - old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill - fated R.M.S.Titanic.", "Romance", "James Cameron", "20th Century", new DateTime(2021, 4, 20, 11, 34, 5, 482, DateTimeKind.Local).AddTicks(1027), "Titanic", "titanic_.jpg" });

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
    }
}
