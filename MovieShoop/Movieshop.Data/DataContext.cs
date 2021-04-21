namespace Movieshop.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Movieshop.Entities;
    using System;

    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions options) : base(options) { }

        // *** have to tell the datacontext about our models ***
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Producer> Producer { get; set; }
        public DbSet<Production> Production { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<ShoppingCard> ShoppingCard { get; set; }
        public DbSet<WatchLatter> WatchLatter { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ***** Data Seed *****

            #region Admin and Roles

            const string ADMIN_ID = "b4280b6a-0613-4cbd-a9e6-f1701e926e73";
            const string ROLE_ID = ADMIN_ID;
            const string password = "admin123abc!";

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ROLE_ID,
                    Name = "admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "b4280b6a -0613-4cbd-a9e6-f1701e926e74",
                    Name = "editor",
                    NormalizedName = "EDITOR"
                },
                new IdentityRole
                {
                    Id = "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                    Name = "guest",
                    NormalizedName = "GUEST"
                });

            var hashPassword = new PasswordHasher<IdentityUser>();

            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id= ADMIN_ID,
                    UserName = "admin@movieshop.com",
                    NormalizedUserName = "ADMIN@MOVIESHOP.COM",
                    Email = "admin@movieshop.com",
                    NormalizedEmail = "ADMIN@MOVIESHOP.COM",
                    EmailConfirmed = true,
                    PasswordHash = hashPassword.HashPassword(null, password),
                    SecurityStamp = string.Empty,
                    ConcurrencyStamp = "c8554266 -b401-4519-9aeb-a9283053fc58"
                });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = ROLE_ID,
                    UserId = ADMIN_ID
                });

            #endregion
            #region Movie
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1 ,
                    Title = "Godzilla vs. Kong",
                    ProducerId = 4,
                    ProducerName = "Thomas Tull, Jon Jashni",
                    ActersId = 8,
                    ActersName = "Vojche",
                    CategoryId = 2, 
                    CategoryName = "Action",
                    GenreId = 9,
                    GenreName = "Thriller",
                    ProductionId = 7,
                    ProductionName = " Legendary Pictures",
                    TimeLast =  1.54, 
                    YearsToWatch = 12,
                    Realise = DateTime.Now,
                    DateAdded = DateTime.Now,
                    Description = "Kong and his protectors undertake a perilous journey to find his true home." +
                    " Along for the ride is Jia, an orphaned girl who has a unique and powerful bond with the mighty beast. " +
                    "However, they soon find themselves in the path of an enraged Godzilla as he cuts a swath of destruction across the globe.",
                    Language = "English",
                    Country = "USA",
                    Price = 9.90,
                    Rating = 6.1,
                    Awards = 2,
                    URL = "godzilla-king-of-the-monsters-movie-poster-image0.jpg"
                },
                new Movie
                {
                    Id = 2,
                    Title = "Monster Hunter",
                    ProducerId = 3,
                    ProducerName = " Paul W. S. Anderson, Martin Moszkowicz",
                    ActersId = 4,
                    ActersName = "Jorgos",
                    CategoryId = 2, 
                    CategoryName = "Action",
                    GenreId = 8,
                    GenreName = "Crime",
                    ProductionId = 1,
                    ProductionName = "Universal Pictures",
                    TimeLast =  2.24, 
                    YearsToWatch = 16,
                    Realise = DateTime.Now,
                    DateAdded = DateTime.Now,
                    Description = "Behind our world, there is another -- a world of dangerous and powerful monsters that rule their " +
                    "domain with deadly ferocity." + " When Lt. Artemis and her loyal soldiers are transported " +
                    "from our world to the new one, the unflappable lieutenant receives the shock of her life." +
                    " In a desperate battle for survival against enormous enemies with incredible powers and " +
                    "unstoppable, terrifying attacks, Artemis teams up with a mysterious" + " hunter who has found a way to fight back.",
                    Language = "English",
                    Country = "USA",
                    Price = 6.99,
                    Rating = 6.7,
                    Awards = 7,
                    URL = "monster.jpg"
                },
                new Movie
                {
                    Id = 3,
                    Title = "Wonder Woman 1984",
                    ProducerId = 6,
                    ProducerName = "Charles Roven",
                    ActersId = 3,
                    ActersName = "Martin",
                    CategoryId = 2, 
                    CategoryName = "Action",
                    GenreId = 5,
                    GenreName = "Action",
                    ProductionId = 7,
                    ProductionName = "Warner Bros.Pictures, DC Films",
                    TimeLast =  2.6, 
                    YearsToWatch = 16,
                    Realise = DateTime.Now,
                    DateAdded = DateTime.Now,
                    Description = "Diana Prince lives quietly among mortals in the vibrant, sleek 1980s --" +
                    " an era of excess driven by the pursuit of having it all. Though she's come into her full powers," +
                    " she maintains a low profile by curating ancient artifacts, and only performing heroic acts incognito." +
                    " But soon, Diana will have to muster all of her strength, wisdom and courage as she finds herself squaring " +
                    "off against Maxwell Lord and the Cheetah, a villainess who possesses superhuman strength and agility.",
                    Language = "English",
                    Country = "USA",
                    Price = 5.49,
                    Rating = 6.5,
                    Awards = 5,
                    URL = "ww84.jpg"
                },
                new Movie
                {
                    Id = 4,
                    Title = "Mortal Kombat II",
                    ProducerId = 5,
                    ProducerName = " James Wan, Todd Garner",
                    ActersId = 1,
                    ActersName = "‎Stefan",
                    CategoryId = 2, 
                    CategoryName = "Action",
                    GenreId = 9,
                    GenreName = "Thriller",
                    ProductionId = 4,
                    ProductionName = "Columbia Pictures",
                    TimeLast =  1.33, 
                    YearsToWatch = 16,
                    Realise = DateTime.Now,
                    DateAdded = DateTime.Now,
                    Description = "Mortal Kombat is a mysterious, intergalactic tournament of ancient martial arts.",                    
                    Language = "English",
                    Country = "USA",
                    Price = 6.89,
                    Rating = 6.1,
                    Awards = 4,
                    URL = "mc.jfif"
                },
                new Movie
                {
                    Id = 5,
                    Title = "Tom and Jerry",
                    ProducerId = 6,
                    ProducerName = "Chris DeFaria",
                    ActersId = 6,
                    ActersName = "Tim Story",
                    CategoryId = 4, 
                    CategoryName = "Animation",
                    GenreId = 10,
                    GenreName = "Biography",
                    ProductionId = 3,
                    ProductionName = "Warner Animation Group",
                    TimeLast =  1.52, 
                    YearsToWatch = 8,
                    Realise = DateTime.Now,
                    DateAdded = DateTime.Now,
                    Description = "A legendary rivalry reemerges when Jerry moves into New York City's finest hotel on the eve of the wedding of the century," +
                    " forcing the desperate event planner to hire Tom to get rid of him. As mayhem ensues, the escalating cat-and-mouse battle soon threatens to destroy her career, " +
                    "the wedding, and possibly the hotel itself.",
                    Language = "English",
                    Country = "USA",
                    Price = 6.99,
                    Rating = 6.7,
                    Awards = 1,
                    URL = "tomandjery.jpg"
                },
                new Movie
                {
                    Id = 6,
                    Title = "Just Say Yes",
                    ProducerId = 4,
                    ProducerName = "Nikola",
                    ActersId = 7,
                    ActersName = "Yolanthe Sneijder-Cabau",
                    CategoryId = 5, 
                    CategoryName = "Comedy",
                    GenreId = 1,
                    GenreName = "Romance",
                    ProductionId = 6,
                    ProductionName = "AM Pictures",
                    TimeLast =  1.49, 
                    YearsToWatch = 12,
                    Realise = DateTime.Now,
                    DateAdded = DateTime.Now,
                    Description = "Incurable romantic Lotte finds her life upended when her plans for a picture-perfect" +
                    " wedding unravel -- just as her self-absorbed sister gets engaged.",
                    Language = "English",
                    Country = "USA",
                    Price = 5.59,
                    Rating = 5.9,
                    Awards = 5,
                    URL = "justsayyees.jpg"
                },
                new Movie
                {
                    Id = 7,
                    Title = "Fast & Furious",
                    ProducerId = 1,
                    ProducerName = "Chris Morgan",
                    ActersId = 9,
                    ActersName = "Leonardo DiCaprio",
                    CategoryId = 4 ,
                    CategoryName = "Action",
                    GenreId = 1,
                    GenreName = "Adventure",
                    ProductionId = 3,
                    ProductionName = "Seven Bucks Productions",
                    TimeLast =  3.20, 
                    YearsToWatch = 8,
                    Realise = DateTime.Now,
                    DateAdded = DateTime.Now,
                    Description = "US agent Luke Hobbs and British mercenary Deckard Shaw are forced to " +
                    "put their rivalry side and work together to stop a genetically enhanced supervillain.",
                    Language = "English",
                    Country = "USA",
                    Price = 9.99,
                    Rating = 7.8,
                    Awards = 11,
                    URL = "Hobbs.jfif"
                },
                new Movie
                {
                    Id = 8,
                    Title = "Ava",
                    ProducerId = 1,
                    ProducerName = " Jessica Chastain",
                    ActersId = 9,
                    ActersName = "Ljupce",
                    CategoryId = 4,
                    CategoryName = "Action",
                    GenreId = 1,
                    GenreName = "Crime",
                    ProductionId = 3,
                    ProductionName = "Voltage Pictures",
                    TimeLast = 3.20,
                    YearsToWatch = 8,
                    Realise = DateTime.Now,
                    DateAdded = DateTime.Now,
                    Description = "An assassin becomes marked for death by her own black ops organization " +
                    "after questioning orders and breaking protocol.",
                    Language = "English",
                    Country = "USA",
                    Price = 6.99,
                    Rating = 7.8,
                    Awards = 11,
                    URL = "ava.jpg"
                },
                new Movie
                {
                    Id = 9,
                    Title = "Bad Boys",
                    ProducerId = 1,
                    ProducerName = "Will Smith, Jerry Bruckheimer, Doug Belgrad, Даг Белград",
                    ActersId = 9,
                    ActersName = "Kristian",
                    CategoryId = 4,
                    CategoryName = "Action",
                    GenreId = 1,
                    GenreName = "Adventure",
                    ProductionId = 3,
                    ProductionName = "Columbia Pictures",
                    TimeLast = 3.20,
                    YearsToWatch = 8,
                    Realise = DateTime.Now,
                    DateAdded = DateTime.Now,
                    Description = "Detectives Mike Lowrey and Marcus Burnett join the Miami Police Department's" +
                    " special team AMMO to bring down the ruthless Armando, who is on a mission to kill Mike at his" +
                    " mother Isabel's orders.",
                    Language = "English",
                    Country = "USA",
                    Price = 8.10,
                    Rating = 7.8,
                    Awards = 11,
                    URL = "badboys.jpg"
                }
            );
            #endregion

            #region Actor
            modelBuilder.Entity<Actor>().HasData(
                new Actor
                {
                    Id = 1,
                    Name="Silvester Stalone",
                    BirthDate = DateTime.Now,
                    Country = "USA",
                    Awards = "33",
                    Gender = "Male",
                    YearsActive = "1968–present"
                },
                new Actor
                {
                    Id = 2,
                    Name="Brad Pitt",
                    BirthDate = DateTime.Now,
                    Country = "USA",
                    Awards = "119",
                    Gender = "Male",
                    YearsActive = " 1987–present"
                },
                new Actor
                {
                    Id = 3,
                    Name="Angelina Jolie",
                    BirthDate = DateTime.Now,
                    Country = "USA",
                    Awards = "60",
                    Gender = "Female",
                    YearsActive = "1982–present"
                },
                new Actor
                {
                    Id = 4,
                    Name= "Jason Statham",
                    BirthDate = DateTime.Now,
                    Country = "UK",
                    Awards = "1",
                    Gender = "Male",
                    YearsActive = "1993–present"
                },
                new Actor
                {
                    Id = 5,
                    Name= "Julia Roberts",
                    BirthDate = DateTime.Now,
                    Country = "USA",
                    Awards = "61",
                    Gender = "Female",
                    YearsActive = " 1987–present"
                },
                new Actor
                {
                    Id = 6,
                    Name= "Keira Knightley",
                    BirthDate = DateTime.Now,
                    Country = "UK",
                    Awards = "24",
                    Gender = "Female",
                    YearsActive = "1993–present"
                },
                 new Actor
                 {
                     Id = 7,
                     Name = "Tom Cruise",
                     BirthDate = DateTime.Now,
                     Country = "USA",
                     Awards = "36",
                     Gender = "Male",
                     YearsActive = " 1981–present"
                 },
                 new Actor
                 {
                     Id = 8,
                     Name = "Dwayne Johnson-The Rock",
                     BirthDate = DateTime.Now,
                     Country = "USA",
                     Awards = "16",
                     Gender = "Male",
                     YearsActive = " 1999–present"
                 },
                 new Actor
                 {
                     Id = 9,
                     Name = "Leonardo DiCaprio",
                     BirthDate = DateTime.Now,
                     Country = "USA",
                     Awards = "99",
                     Gender = "Male",
                     YearsActive = "1989–present"
                 }
             );
            #endregion

            #region Category
            modelBuilder.Entity<Category>().HasData(
                new Category {Id = 1, Name = "Romance" },
                new Category {Id = 2, Name = "Action"},
                new Category {Id = 3, Name = "Sci-Fi"},
                new Category {Id = 4, Name = "Drama"},
                new Category {Id = 5, Name = "Comedy"},
                new Category {Id = 6, Name = "Horror" },
                new Category {Id = 7, Name = "Adventure"},
                new Category {Id = 8, Name = "Crime"},
                new Category {Id = 9, Name = "Thriller" },
                new Category {Id = 10, Name = "Biography" },
                new Category {Id = 11, Name = "History" },
                new Category {Id = 12, Name = "Undefined"}
             );
            #endregion

            #region Genre
            modelBuilder.Entity<Genre>().HasData(
               new Genre { Id = 1, Name = "Romance" },
               new Genre { Id = 2, Name = "Action" },
               new Genre { Id = 3, Name = "Sci-Fi" },
               new Genre { Id = 4, Name = "Drama" },
               new Genre { Id = 5, Name = "Comedy" },
               new Genre { Id = 6, Name = "Horror" },
               new Genre { Id = 7, Name = "Adventure" },
               new Genre { Id = 8, Name = "Crime" },
               new Genre { Id = 9, Name = "Thriller" },
               new Genre { Id = 10, Name = "Biography" },
               new Genre { Id = 11, Name = "History" },
               new Genre { Id = 12, Name = "Undefined" }
            );
            #endregion

            #region Production
            modelBuilder.Entity<Production>().HasData(
                new Production
                {
                    Id= 1,
                    Name = "Universal Pictures",
                    Country = "USA",
                    Year = DateTime.Now
                },
                new Production
                {
                    Id= 2,
                    Name = "Warner Brothers",
                    Country = "USA",
                    Year = DateTime.Now
                },
                new Production
                {
                    Id= 3,
                    Name = "20th Century",
                    Country = "USA",
                    Year = DateTime.Now
                },
                new Production
                {
                    Id= 4,
                    Name = "Columbia Pictures",
                    Country = "USA",
                    Year = DateTime.Now
                },
                new Production
                {
                    Id= 5,
                    Name = "Walt Disney Pictures",
                    Country = "USA",
                    Year = DateTime.Now
                },  
                new Production
                {
                    Id= 6,
                    Name = "Universal Studios",
                    Country = "USA",
                    Year = DateTime.Now
                },
                new Production
                {
                    Id= 7,
                    Name = "New Line Cinema",
                    Country = "USA",
                    Year = DateTime.Now
                }   
            );
            #endregion
            
            #region Producer
            modelBuilder.Entity<Producer>().HasData(
                new Producer { 
                    Id = 1,
                    Name = "James Cameron",
                    Country = "Canada",
                    BirthDate = DateTime.Now,
                    YearsActive = "1974–present",
                    Gender = "Male"
                },
                new Producer { 
                    Id = 2,
                    Name = "Gore Verbinski",
                    Country = "USA",
                    BirthDate = DateTime.Now,
                    YearsActive = "	1989–present",
                    Gender = "Male"
                },
                new Producer { 
                    Id = 3,
                    Name = "Kevin Feige",
                    Country = "USA",
                    BirthDate = DateTime.Now,
                    YearsActive = "2000–present",
                    Gender = "Male"
                },
                new Producer { 
                    Id = 4,
                    Name = "Jerry Bruckheimer",
                    Country = "USA",
                    BirthDate = DateTime.Now,
                    YearsActive = "1972–present",
                    Gender = "Male"
                },
                new Producer { 
                    Id = 5,
                    Name = "David Heyman",
                    Country = "UK",
                    BirthDate = DateTime.Now,
                    YearsActive = "1992-present",
                    Gender = "Male"
                },
                new Producer { 
                    Id = 6,
                    Name = "Kathleen Kennedy",
                    Country = "USA",
                    BirthDate = DateTime.Now,
                    YearsActive = "1979–present",
                    Gender = "Female"
                }
            );
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
