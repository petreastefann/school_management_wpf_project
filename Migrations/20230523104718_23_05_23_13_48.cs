using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace school_management_wpf_project.Migrations
{
    /// <inheritdoc />
    public partial class _23_05_23_13_48 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_StudentCourses_StudentCourseId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_StudentCourseId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "StudentCourseId",
                table: "Grades");

            migrationBuilder.CreateTable(
                name: "StudentCourseGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentCourseId = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourseGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentCourseGrades_StudentCourses_StudentCourseId",
                        column: x => x.StudentCourseId,
                        principalTable: "StudentCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseGrades_StudentCourseId",
                table: "StudentCourseGrades",
                column: "StudentCourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCourseGrades");

            migrationBuilder.AddColumn<int>(
                name: "StudentCourseId",
                table: "Grades",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentCourseId",
                table: "Grades",
                column: "StudentCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_StudentCourses_StudentCourseId",
                table: "Grades",
                column: "StudentCourseId",
                principalTable: "StudentCourses",
                principalColumn: "Id");
        }
    }
}
