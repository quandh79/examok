using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRACTICAL_EXAM_NET.Migrations
{
    /// <inheritdoc />
    public partial class thr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "subjectsId",
                table: "exams",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "facultysId",
                table: "exams",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "classesId",
                table: "exams",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_exams_classes_classesId",
                table: "exams",
                column: "classesId",
                principalTable: "classes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_exams_faculty_facultysId",
                table: "exams",
                column: "facultysId",
                principalTable: "faculty",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_exams_subject_subjectsId",
                table: "exams",
                column: "subjectsId",
                principalTable: "subject",
                principalColumn: "Id");
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

            migrationBuilder.AlterColumn<int>(
                name: "subjectsId",
                table: "exams",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "facultysId",
                table: "exams",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "classesId",
                table: "exams",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
