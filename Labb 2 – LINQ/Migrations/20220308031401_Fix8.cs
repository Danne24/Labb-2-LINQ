using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb_2___LINQ.Migrations
{
    public partial class Fix8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentsTeachers",
                columns: table => new
                {
                    StudentTeacherID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(nullable: false),
                    TeacherID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsTeachers", x => x.StudentTeacherID);
                    table.ForeignKey(
                        name: "FK_StudentsTeachers_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsTeachers_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsTeachers_StudentID",
                table: "StudentsTeachers",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsTeachers_TeacherID",
                table: "StudentsTeachers",
                column: "TeacherID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsTeachers");
        }
    }
}
