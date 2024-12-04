using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dziennik_elektroniczny.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DbUppdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShorQuizAvarage",
                table: "Grades",
                newName: "ShortQuizAvarage");

            migrationBuilder.RenameColumn(
                name: "HomewokAvarage",
                table: "Grades",
                newName: "HomeworkAvarage");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShortQuizAvarage",
                table: "Grades",
                newName: "ShorQuizAvarage");

            migrationBuilder.RenameColumn(
                name: "HomeworkAvarage",
                table: "Grades",
                newName: "HomewokAvarage");
        }
    }
}
