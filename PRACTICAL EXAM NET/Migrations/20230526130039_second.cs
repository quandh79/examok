using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRACTICAL_EXAM_NET.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_classes_exams_ExamId",
                table: "classes");

            migrationBuilder.DropForeignKey(
                name: "FK_faculty_exams_ExamId",
                table: "faculty");

            migrationBuilder.DropForeignKey(
                name: "FK_subject_exams_ExamId",
                table: "subject");

            migrationBuilder.DropIndex(
                name: "IX_subject_ExamId",
                table: "subject");

            migrationBuilder.DropIndex(
                name: "IX_faculty_ExamId",
                table: "faculty");

            migrationBuilder.DropIndex(
                name: "IX_classes_ExamId",
                table: "classes");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "subject");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "faculty");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "classes");

            migrationBuilder.AddColumn<int>(
                name: "classesId",
                table: "exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "facultysId",
                table: "exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "subjectsId",
                table: "exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_exams_classesId",
                table: "exams",
                column: "classesId");

            migrationBuilder.CreateIndex(
                name: "IX_exams_facultysId",
                table: "exams",
                column: "facultysId");

            migrationBuilder.CreateIndex(
                name: "IX_exams_subjectsId",
                table: "exams",
                column: "subjectsId");

            migrationBuilder.AddForeignKey(
                name: "FK_exams_classes_classesId",
                table: "exams",
                column: "classesId",
                principalTable: "classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_exams_faculty_facultysId",
                table: "exams",
                column: "facultysId",
                principalTable: "faculty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_exams_subject_subjectsId",
                table: "exams",
                column: "subjectsId",
                principalTable: "subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_exams_classes_classesId",
                table: "exams");

            migrationBuilder.DropForeignKey(
                name: "FK_exams_faculty_facultysId",
                table: "exams");

            migrationBuilder.DropForeignKey(
                name: "FK_exams_subject_subjectsId",
                table: "exams");

            migrationBuilder.DropIndex(
                name: "IX_exams_classesId",
                table: "exams");

            migrationBuilder.DropIndex(
                name: "IX_exams_facultysId",
                table: "exams");

            migrationBuilder.DropIndex(
                name: "IX_exams_subjectsId",
                table: "exams");

            migrationBuilder.DropColumn(
                name: "classesId",
                table: "exams");

            migrationBuilder.DropColumn(
                name: "facultysId",
                table: "exams");

            migrationBuilder.DropColumn(
                name: "subjectsId",
                table: "exams");

            migrationBuilder.AddColumn<int>(
                name: "ExamId",
                table: "subject",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExamId",
                table: "faculty",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExamId",
                table: "classes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_subject_ExamId",
                table: "subject",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_faculty_ExamId",
                table: "faculty",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_classes_ExamId",
                table: "classes",
                column: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_classes_exams_ExamId",
                table: "classes",
                column: "ExamId",
                principalTable: "exams",
                principalColumn: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_faculty_exams_ExamId",
                table: "faculty",
                column: "ExamId",
                principalTable: "exams",
                principalColumn: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_subject_exams_ExamId",
                table: "subject",
                column: "ExamId",
                principalTable: "exams",
                principalColumn: "ExamId");
        }
    }
}
