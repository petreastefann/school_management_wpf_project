using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace school_management_wpf_project.Migrations
{
    /// <inheritdoc />
    public partial class _23_05_21_22_35 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_HomeroomTeachers_HomeroomTeacherId",
                table: "Courses");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_HomeroomTeacherId",
                table: "Courses",
                column: "HomeroomTeacherId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_HomeroomTeacherId",
                table: "Courses");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_HomeroomTeachers_HomeroomTeacherId",
                table: "Courses",
                column: "HomeroomTeacherId",
                principalTable: "HomeroomTeachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
