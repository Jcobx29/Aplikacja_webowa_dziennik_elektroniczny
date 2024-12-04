using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dziennik_elektroniczny.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DbNormalization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Biology");

            migrationBuilder.DropTable(
                name: "Chemistry");

            migrationBuilder.DropTable(
                name: "English");

            migrationBuilder.DropTable(
                name: "Geography");

            migrationBuilder.DropTable(
                name: "German");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "Maths");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Biology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRef = table.Column<int>(type: "int", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    TestAvarage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biology", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Biology_Students_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chemistry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRef = table.Column<int>(type: "int", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    TestAvarage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chemistry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chemistry_Students_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "English",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRef = table.Column<int>(type: "int", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    TestAvarage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_English", x => x.Id);
                    table.ForeignKey(
                        name: "FK_English_Students_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Geography",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRef = table.Column<int>(type: "int", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    TestAvarage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geography", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Geography_Students_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "German",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRef = table.Column<int>(type: "int", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    TestAvarage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_German", x => x.Id);
                    table.ForeignKey(
                        name: "FK_German_Students_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRef = table.Column<int>(type: "int", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    TestAvarage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                    table.ForeignKey(
                        name: "FK_History_Students_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Maths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRef = table.Column<int>(type: "int", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    TestAvarage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maths_Students_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Biology_StudentRef",
                table: "Biology",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chemistry_StudentRef",
                table: "Chemistry",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_English_StudentRef",
                table: "English",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Geography_StudentRef",
                table: "Geography",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_German_StudentRef",
                table: "German",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_History_StudentRef",
                table: "History",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Maths_StudentRef",
                table: "Maths",
                column: "StudentRef",
                unique: true);
        }
    }
}
