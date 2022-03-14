using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb_2___LINQ.Migrations
{
    public partial class Fix1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Students_StudentId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Teachers_TeacherID",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Students_StudentId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_StudentId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_StudentId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_TeacherID",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "TeacherID",
                table: "Subjects");

            migrationBuilder.CreateTable(
                name: "StudentsSubjects",
                columns: table => new
                {
                    StudentSubjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsSubjects", x => x.StudentSubjectId);
                    table.ForeignKey(
                        name: "FK_StudentsSubjects_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeachersSubjects",
                columns: table => new
                {
                    TeacherSubjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachersSubjects", x => x.TeacherSubjectId);
                    table.ForeignKey(
                        name: "FK_TeachersSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeachersSubjects_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsSubjects_StudentId",
                table: "StudentsSubjects",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsSubjects_SubjectId",
                table: "StudentsSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TeachersSubjects_SubjectId",
                table: "TeachersSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TeachersSubjects_TeacherId",
                table: "TeachersSubjects",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsSubjects");

            migrationBuilder.DropTable(
                name: "TeachersSubjects");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Subjects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherID",
                table: "Subjects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_StudentId",
                table: "Teachers",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_StudentId",
                table: "Subjects",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TeacherID",
                table: "Subjects",
                column: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Students_StudentId",
                table: "Subjects",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Teachers_TeacherID",
                table: "Subjects",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Students_StudentId",
                table: "Teachers",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
