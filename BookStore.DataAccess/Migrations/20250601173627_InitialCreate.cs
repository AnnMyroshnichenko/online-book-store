using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Action" },
                    { 2, 2, "SciFi" },
                    { 3, 3, "History" },
                    { 4, 4, "Fantasy" },
                    { 5, 5, "Horror" },
                    { 6, 6, "Detective" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "Price", "PublicationDate", "Title" },
                values: new object[,]
                {
                    { 1, "Andy Weir", 2, "A lone astronaut must save Earth from disaster in this gripping sci-fi thriller.", "9780593135204", 15.99, new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project Hail Mary" },
                    { 2, "Frank Herbert", 2, "A desert planet. A prophecy. A revolution. Classic space opera.", "9780441013593", 13.49, new DateTime(1965, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dune" },
                    { 3, "Samantha Shannon", 4, "An epic feminist fantasy novel with dragons, politics, and magic.", "9781635570298", 17.989999999999998, new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Priory of the Orange Tree" },
                    { 4, "Brandon Sanderson", 4, "Book 4 of the epic fantasy series by Brandon Sanderson.", "9780765326386", 24.989999999999998, new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Stormlight Archive: Rhythm of War" },
                    { 5, "Jack Carr", 1, "A Navy SEAL seeks vengeance after his team is ambushed.", "9781501180811", 10.99, new DateTime(2018, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Terminal List" },
                    { 6, "John Grisham", 1, "A riveting legal thriller packed with action and suspense.", "9780385544153", 11.99, new DateTime(2018, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Reckoning" },
                    { 7, "Erik Larson", 3, "A portrait of Winston Churchill during the Blitz.", "9780385348713", 18.0, new DateTime(2020, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Splendid and the Vile" },
                    { 8, "David Grann", 3, "True story of murder and the birth of the FBI.", "9780307742483", 14.99, new DateTime(2017, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Killers of the Flower Moon" },
                    { 9, "Stephen Graham Jones", 5, "A disturbing horror novel blending Native American identity and supernatural revenge.", "9781982136451", 12.99, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Only Good Indians" },
                    { 10, "Krystal Sutherland", 5, "A dark, twisted fairy tale with horror elements.", "9780593110348", 11.99, new DateTime(2025, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "The House of Hollow" },
                    { 11, "Richard Osman", 6, "Four elderly friends meet weekly to solve murders—until one happens close to home.", "9781984880963", 13.99, new DateTime(2020, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Thursday Murder Club" },
                    { 12, "Holly Jackson", 6, "A high school student reopens a closed murder case for a school project.", "9781984896360", 10.99, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Good Girl's Guide to Murder" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
