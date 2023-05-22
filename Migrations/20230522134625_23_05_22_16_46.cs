using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace school_management_wpf_project.Migrations
{
    /// <inheritdoc />
    public partial class _23_05_22_16_46 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specializations_StudyYears_StudyYearId",
                table: "Specializations");

            migrationBuilder.DropIndex(
                name: "IX_Specializations_StudyYearId",
                table: "Specializations");

            migrationBuilder.DropColumn(
                name: "StudyYearId",
                table: "Specializations");

            migrationBuilder.CreateTable(
                name: "CourseStudyYearSpecializations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StudyYearSpecializationsId = table.Column<int>(type: "int", nullable: false),
                    StudyYearId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudyYearSpecializations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseStudyYearSpecializations_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudyYearSpecializations_StudyYearSpecializations_StudyYearSpecializationsId",
                        column: x => x.StudyYearSpecializationsId,
                        principalTable: "StudyYearSpecializations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudyYearSpecializations_StudyYears_StudyYearId",
                        column: x => x.StudyYearId,
                        principalTable: "StudyYears",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudyYearSpecializations_CourseId",
                table: "CourseStudyYearSpecializations",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudyYearSpecializations_StudyYearId",
                table: "CourseStudyYearSpecializations",
                column: "StudyYearId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudyYearSpecializations_StudyYearSpecializationsId",
                table: "CourseStudyYearSpecializations",
                column: "StudyYearSpecializationsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudyYearSpecializations");

            migrationBuilder.AddColumn<int>(
                name: "StudyYearId",
                table: "Specializations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Specializations_StudyYearId",
                table: "Specializations",
                column: "StudyYearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Specializations_StudyYears_StudyYearId",
                table: "Specializations",
                column: "StudyYearId",
                principalTable: "StudyYears",
                principalColumn: "Id");
        }
    }
}
