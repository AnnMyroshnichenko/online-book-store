using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAccess.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Fantasy", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Horror", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Detective", DisplayOrder = 6 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Project Hail Mary",
                    Description = "A lone astronaut must save Earth from disaster in this gripping sci-fi thriller.",
                    Author = "Andy Weir",
                    ISBN = "9780593135204",
                    PublicationDate = new DateTime(2025, 5, 4),
                    Price = 15.99,
                    CategoryId = 2,
                    ImageURL = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Dune",
                    Description = "A desert planet. A prophecy. A revolution. Classic space opera.",
                    Author = "Frank Herbert",
                    ISBN = "9780441013593",
                    PublicationDate = new DateTime(1965, 8, 1),
                    Price = 13.49,
                    CategoryId = 2,
                    ImageURL = ""
                },

                // Fantasy
                new Product
                {
                    Id = 3,
                    Title = "The Priory of the Orange Tree",
                    Description = "An epic feminist fantasy novel with dragons, politics, and magic.",
                    Author = "Samantha Shannon",
                    ISBN = "9781635570298",
                    PublicationDate = new DateTime(2025, 2, 26),
                    Price = 17.99,
                    CategoryId = 4,
                    ImageURL = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "The Stormlight Archive: Rhythm of War",
                    Description = "Book 4 of the epic fantasy series by Brandon Sanderson.",
                    Author = "Brandon Sanderson",
                    ISBN = "9780765326386",
                    PublicationDate = new DateTime(2020, 11, 17),
                    Price = 24.99,
                    CategoryId = 4,
                    ImageURL = ""
                },

                // Action
                new Product
                {
                    Id = 5,
                    Title = "The Terminal List",
                    Description = "A Navy SEAL seeks vengeance after his team is ambushed.",
                    Author = "Jack Carr",
                    ISBN = "9781501180811",
                    PublicationDate = new DateTime(2018, 3, 6),
                    Price = 10.99,
                    CategoryId = 1,
                    ImageURL = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "The Reckoning",
                    Description = "A riveting legal thriller packed with action and suspense.",
                    Author = "John Grisham",
                    ISBN = "9780385544153",
                    PublicationDate = new DateTime(2018, 10, 23),
                    Price = 11.99,
                    CategoryId = 1,
                    ImageURL = ""
                },

                // History
                new Product
                {
                    Id = 7,
                    Title = "The Splendid and the Vile",
                    Description = "A portrait of Winston Churchill during the Blitz.",
                    Author = "Erik Larson",
                    ISBN = "9780385348713",
                    PublicationDate = new DateTime(2020, 2, 25),
                    Price = 18.00,
                    CategoryId = 3,
                    ImageURL = ""
                },
                new Product
                {
                    Id = 8,
                    Title = "Killers of the Flower Moon",
                    Description = "True story of murder and the birth of the FBI.",
                    Author = "David Grann",
                    ISBN = "9780307742483",
                    PublicationDate = new DateTime(2017, 4, 18),
                    Price = 14.99,
                    CategoryId = 3,
                    ImageURL = ""
                },

                // Horror
                new Product
                {
                    Id = 9,
                    Title = "The Only Good Indians",
                    Description = "A disturbing horror novel blending Native American identity and supernatural revenge.",
                    Author = "Stephen Graham Jones",
                    ISBN = "9781982136451",
                    PublicationDate = new DateTime(2020, 7, 14),
                    Price = 12.99,
                    CategoryId = 5,
                    ImageURL = ""
                },
                new Product
                {
                    Id = 10,
                    Title = "The House of Hollow",
                    Description = "A dark, twisted fairy tale with horror elements.",
                    Author = "Krystal Sutherland",
                    ISBN = "9780593110348",
                    PublicationDate = new DateTime(2025, 4, 6),
                    Price = 11.99,
                    CategoryId = 5,
                    ImageURL = ""
                },

                // Detective
                new Product
                {
                    Id = 11,
                    Title = "The Thursday Murder Club",
                    Description = "Four elderly friends meet weekly to solve murders—until one happens close to home.",
                    Author = "Richard Osman",
                    ISBN = "9781984880963",
                    PublicationDate = new DateTime(2020, 9, 3),
                    Price = 13.99,
                    CategoryId = 6,
                    ImageURL = ""
                },
                new Product
                {
                    Id = 12,
                    Title = "A Good Girl's Guide to Murder",
                    Description = "A high school student reopens a closed murder case for a school project.",
                    Author = "Holly Jackson",
                    ISBN = "9781984896360",
                    PublicationDate = new DateTime(2025, 2, 4),
                    Price = 10.99,
                    CategoryId = 6,
                    ImageURL = ""
                }
            );

        }
    }
}
