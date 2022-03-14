using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb_2___LINQ.Migrations
{
    public partial class Fix6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CourseId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentsSubjects_Students_StudentId",
                table: "StudentsSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentsSubjects_Subjects_SubjectId",
                table: "StudentsSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachersSubjects_Subjects_SubjectId",
                table: "TeachersSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachersSubjects_Teachers_TeacherId",
                table: "TeachersSubjects");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "TeachersSubjects",
                newName: "TeacherID");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "TeachersSubjects",
                newName: "SubjectID");

            migrationBuilder.RenameColumn(
                name: "TeacherSubjectId",
                table: "TeachersSubjects",
                newName: "TeacherSubjectID");

            migrationBuilder.RenameIndex(
                name: "IX_TeachersSubjects_TeacherId",
                table: "TeachersSubjects",
                newName: "IX_TeachersSubjects_TeacherID");

            migrationBuilder.RenameIndex(
                name: "IX_TeachersSubjects_SubjectId",
                table: "TeachersSubjects",
                newName: "IX_TeachersSubjects_SubjectID");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "Subjects",
                newName: "SubjectID");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "StudentsSubjects",
                newName: "SubjectID");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "StudentsSubjects",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "StudentSubjectId",
                table: "StudentsSubjects",
                newName: "StudentSubjectID");

            migrationBuilder.RenameIndex(
                name: "IX_StudentsSubjects_SubjectId",
                table: "StudentsSubjects",
                newName: "IX_StudentsSubjects_SubjectID");

            migrationBuilder.RenameIndex(
                name: "IX_StudentsSubjects_StudentId",
                table: "StudentsSubjects",
                newName: "IX_StudentsSubjects_StudentID");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Students",
                newName: "CourseID");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Students",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Students_CourseId",
                table: "Students",
                newName: "IX_Students_CourseID");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Courses",
                newName: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CourseID",
                table: "Students",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsSubjects_Students_StudentID",
                table: "StudentsSubjects",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsSubjects_Subjects_SubjectID",
                table: "StudentsSubjects",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeachersSubjects_Subjects_SubjectID",
                table: "TeachersSubjects",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeachersSubjects_Teachers_TeacherID",
                table: "TeachersSubjects",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CourseID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentsSubjects_Students_StudentID",
                table: "StudentsSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentsSubjects_Subjects_SubjectID",
                table: "StudentsSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachersSubjects_Subjects_SubjectID",
                table: "TeachersSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachersSubjects_Teachers_TeacherID",
                table: "TeachersSubjects");

            migrationBuilder.RenameColumn(
                name: "TeacherID",
                table: "TeachersSubjects",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "SubjectID",
                table: "TeachersSubjects",
                newName: "SubjectId");

            migrationBuilder.RenameColumn(
                name: "TeacherSubjectID",
                table: "TeachersSubjects",
                newName: "TeacherSubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_TeachersSubjects_TeacherID",
                table: "TeachersSubjects",
                newName: "IX_TeachersSubjects_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_TeachersSubjects_SubjectID",
                table: "TeachersSubjects",
                newName: "IX_TeachersSubjects_SubjectId");

            migrationBuilder.RenameColumn(
                name: "SubjectID",
                table: "Subjects",
                newName: "SubjectId");

            migrationBuilder.RenameColumn(
                name: "SubjectID",
                table: "StudentsSubjects",
                newName: "SubjectId");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "StudentsSubjects",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "StudentSubjectID",
                table: "StudentsSubjects",
                newName: "StudentSubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentsSubjects_SubjectID",
                table: "StudentsSubjects",
                newName: "IX_StudentsSubjects_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentsSubjects_StudentID",
                table: "StudentsSubjects",
                newName: "IX_StudentsSubjects_StudentId");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Students",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Students",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_CourseID",
                table: "Students",
                newName: "IX_Students_CourseId");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Courses",
                newName: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CourseId",
                table: "Students",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsSubjects_Students_StudentId",
                table: "StudentsSubjects",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsSubjects_Subjects_SubjectId",
                table: "StudentsSubjects",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeachersSubjects_Subjects_SubjectId",
                table: "TeachersSubjects",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeachersSubjects_Teachers_TeacherId",
                table: "TeachersSubjects",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
