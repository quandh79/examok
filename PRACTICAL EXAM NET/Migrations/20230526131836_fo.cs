﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRACTICAL_EXAM_NET.Migrations
{
    /// <inheritdoc />
    public partial class fo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "exams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "exams");
        }
    }
}
