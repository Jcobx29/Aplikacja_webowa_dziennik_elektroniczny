using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dziennik_elektroniczny.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_1ABiology");

            migrationBuilder.DropTable(
                name: "_1AChemistry");

            migrationBuilder.DropTable(
                name: "_1AEnglish");

            migrationBuilder.DropTable(
                name: "_1AGeography");

            migrationBuilder.DropTable(
                name: "_1AGerman");

            migrationBuilder.DropTable(
                name: "_1AHistory");

            migrationBuilder.DropTable(
                name: "_1AMath");

            migrationBuilder.DropTable(
                name: "ContactStudentInfo1A");

            migrationBuilder.DropTable(
                name: "_1AStudents");

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Biology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biology", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Biology_Student_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chemistry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chemistry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chemistry_Student_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactStudentInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactStudentInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactStudentInfo_Student_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "English",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_English", x => x.Id);
                    table.ForeignKey(
                        name: "FK_English_Student_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Geography",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geography", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Geography_Student_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "German",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_German", x => x.Id);
                    table.ForeignKey(
                        name: "FK_German_Student_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                    table.ForeignKey(
                        name: "FK_History_Student_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Math",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Math", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Math_Student_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "Student",
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
                name: "IX_ContactStudentInfo_StudentRef",
                table: "ContactStudentInfo",
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
                name: "IX_Math_StudentRef",
                table: "Math",
                column: "StudentRef",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Biology");

            migrationBuilder.DropTable(
                name: "Chemistry");

            migrationBuilder.DropTable(
                name: "ContactStudentInfo");

            migrationBuilder.DropTable(
                name: "English");

            migrationBuilder.DropTable(
                name: "Geography");

            migrationBuilder.DropTable(
                name: "German");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "Math");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.CreateTable(
                name: "_1AStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1AStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_1ABiology",
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
                    table.PrimaryKey("PK__1ABiology", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1ABiology__1AStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_1AStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1AChemistry",
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
                    table.PrimaryKey("PK__1AChemistry", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1AChemistry__1AStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_1AStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1AEnglish",
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
                    table.PrimaryKey("PK__1AEnglish", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1AEnglish__1AStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_1AStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1AGeography",
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
                    table.PrimaryKey("PK__1AGeography", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1AGeography__1AStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_1AStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1AGerman",
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
                    table.PrimaryKey("PK__1AGerman", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1AGerman__1AStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_1AStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1AHistory",
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
                    table.PrimaryKey("PK__1AHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1AHistory__1AStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_1AStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1AMath",
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
                    table.PrimaryKey("PK__1AMath", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1AMath__1AStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_1AStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactStudentInfo1A",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRef = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactStudentInfo1A", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactStudentInfo1A__1AStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_1AStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX__1ABiology_StudentRef",
                table: "_1ABiology",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1AChemistry_StudentRef",
                table: "_1AChemistry",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1AEnglish_StudentRef",
                table: "_1AEnglish",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1AGeography_StudentRef",
                table: "_1AGeography",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1AGerman_StudentRef",
                table: "_1AGerman",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1AHistory_StudentRef",
                table: "_1AHistory",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1AMath_StudentRef",
                table: "_1AMath",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactStudentInfo1A_StudentRef",
                table: "ContactStudentInfo1A",
                column: "StudentRef",
                unique: true);
        }
    }
}
