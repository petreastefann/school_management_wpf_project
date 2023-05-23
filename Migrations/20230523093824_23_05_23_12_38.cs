﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace school_management_wpf_project.Migrations {
	/// <inheritdoc />
	public partial class _23_05_23_12_38 : Migration {
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder) {
			migrationBuilder.CreateTable(
				name: "StudentCourses",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					StudentId = table.Column<int>(type: "int", nullable: false),
					CourseId = table.Column<int>(type: "int", nullable: false),
					Absences = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_StudentCourses", x => x.Id);
					table.ForeignKey(
						name: "FK_StudentCourses_Courses_CourseId",
						column: x => x.CourseId,
						principalTable: "Courses",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_StudentCourses_Users_StudentId",
						column: x => x.StudentId,
						principalTable: "Users",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateIndex(
				name: "IX_StudentCourses_CourseId",
				table: "StudentCourses",
				column: "CourseId");

			migrationBuilder.CreateIndex(
				name: "IX_StudentCourses_StudentId",
				table: "StudentCourses",
				column: "StudentId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder) {
			migrationBuilder.DropTable(
				name: "StudentCourses");
		}
	}
}
