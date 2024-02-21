using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.JSInterop.Implementation;

#nullable disable

namespace Mission6_LandonWebb.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Director = table.Column<string>(type: "TEXT", nullable: false),
                    Rating = table.Column<string>(type: "TEXT", nullable: false),
                    Edited = table.Column<bool>(type: "INTEGER", nullable: true),
                    LentTo = table.Column<string>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                    //table.ForeignKey(
                    //    name: "FK_Movies_Categories_CategoryId1",
                    //    column: x => x.CategoryId1,
                    //    principalTable: "Categories",
                    //    principalColumn: "CategoryId",
                    //    onDelete: ReferentialAction.Cascade);
                });
            //migrationBuilder.InsertData(
            //    table: "Categories",
            //    columns: new[] { "CategoryId", "Category" },
            //    values: new object[,]
            //    {
            //        { 1, "Miscellaneous" },
            //        { 2, "Drama" },
            //        { 3, "Television" },
            //        { 4, "Horror/Suspense" },
            //        { 5, "Comedy" },
            //        { 6, "Family" },
            //        { 7, "Action/Adventure" },
            //        { 8, "VHS" }

            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
