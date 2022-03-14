using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb_2___LINQ.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Teachers_TeacherID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_TeacherID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TeacherID",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Subjects",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_StudentId",
                table: "Teachers",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_StudentId",
                table: "Subjects",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Students_StudentId",
                table: "Subjects",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Students_StudentId",
                table: "Teachers",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Students_StudentId",
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

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Subjects");

            migrationBuilder.AddColumn<int>(
                name: "TeacherID",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_TeacherID",
                table: "Students",
                column: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Teachers_TeacherID",
                table: "Students",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
