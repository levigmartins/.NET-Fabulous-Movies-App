using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class ComplexDataModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "Movie",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AddColumn<float>(
                name: "rate",
                table: "Movie",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "Movie",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserID = table.Column<string>(type: "TEXT", nullable: true),
                    MovieID = table.Column<string>(type: "TEXT", nullable: true),
                    title = table.Column<string>(type: "TEXT", nullable: true),
                    description = table.Column<string>(type: "TEXT", nullable: true),
                    Movieid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comment_Movie_Movieid",
                        column: x => x.Movieid,
                        principalTable: "Movie",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rent",
                columns: table => new
                {
                    RentID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    rentStartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    rentEndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rent", x => x.RentID);
                });

            migrationBuilder.CreateTable(
                name: "MovieRent",
                columns: table => new
                {
                    moviesid = table.Column<int>(type: "INTEGER", nullable: false),
                    rentsRentID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieRent", x => new { x.moviesid, x.rentsRentID });
                    table.ForeignKey(
                        name: "FK_MovieRent_Movie_moviesid",
                        column: x => x.moviesid,
                        principalTable: "Movie",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieRent_Rent_rentsRentID",
                        column: x => x.rentsRentID,
                        principalTable: "Rent",
                        principalColumn: "RentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_Movieid",
                table: "Comment",
                column: "Movieid");

            migrationBuilder.CreateIndex(
                name: "IX_MovieRent_rentsRentID",
                table: "MovieRent",
                column: "rentsRentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "MovieRent");

            migrationBuilder.DropTable(
                name: "Rent");

            migrationBuilder.DropColumn(
                name: "rate",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Movie");

            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "Movie",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");
        }
    }
}
