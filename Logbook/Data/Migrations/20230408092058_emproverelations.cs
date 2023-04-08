using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogBook.Data.Migrations
{
    public partial class emproverelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Lesson_LessonId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Student_StudentId",
                table: "Mark");

            migrationBuilder.DropIndex(
                name: "IX_Mark_LessonId",
                table: "Mark");

            migrationBuilder.DropIndex(
                name: "IX_Mark_StudentId",
                table: "Mark");

            migrationBuilder.AddColumn<int>(
                name: "MarkId",
                table: "Student",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MarkId",
                table: "Lesson",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_MarkId",
                table: "Student",
                column: "MarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_MarkId",
                table: "Lesson",
                column: "MarkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Mark_MarkId",
                table: "Lesson",
                column: "MarkId",
                principalTable: "Mark",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Mark_MarkId",
                table: "Student",
                column: "MarkId",
                principalTable: "Mark",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Mark_MarkId",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Mark_MarkId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_MarkId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Lesson_MarkId",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "MarkId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "MarkId",
                table: "Lesson");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_LessonId",
                table: "Mark",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_StudentId",
                table: "Mark",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Lesson_LessonId",
                table: "Mark",
                column: "LessonId",
                principalTable: "Lesson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Student_StudentId",
                table: "Mark",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
