using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace school_management_wpf_project.Migrations
{
    /// <inheritdoc />
    public partial class _23_05_22_16_39 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudyYearSpecializationId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudyYearSpecializations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudyYearId = table.Column<int>(type: "int", nullable: false),
                    SpecializationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyYearSpecializations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyYearSpecializations_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specializations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudyYearSpecializations_StudyYears_StudyYearId",
                        column: x => x.StudyYearId,
                        principalTable: "StudyYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudyYearSpecializationId",
                table: "Courses",
                column: "StudyYearSpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyYearSpecializations_SpecializationId",
                table: "StudyYearSpecializations",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyYearSpecializations_StudyYearId",
                table: "StudyYearSpecializations",
                column: "StudyYearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_StudyYearSpecializations_StudyYearSpecializationId",
                table: "Courses",
                column: "StudyYearSpecializationId",
                principalTable: "StudyYearSpecializations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_StudyYearSpecializations_StudyYearSpecializationId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "StudyYearSpecializations");

            migrationBuilder.DropIndex(
                name: "IX_Courses_StudyYearSpecializationId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StudyYearSpecializationId",
                table: "Courses");
        }
    }
}
