using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace school_management_wpf_project.Migrations {
	/// <inheritdoc />
	public partial class _21_05_23_21_09 : Migration {
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder) {
			migrationBuilder.CreateTable(
				name: "Averages",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					StudentId = table.Column<int>(type: "int", nullable: false),
					CourseId = table.Column<int>(type: "int", nullable: false),
					Grade = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_Averages", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "ClassroomTeachers",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_ClassroomTeachers", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "LoggedInUsers",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					UserId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_LoggedInUsers", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "StudyYears",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Year = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_StudyYears", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Teacher",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_Teacher", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Users",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_Users", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Specializations",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					StudyYearId = table.Column<int>(type: "int", nullable: true)
				},
				constraints: table => {
					table.PrimaryKey("PK_Specializations", x => x.Id);
					table.ForeignKey(
						name: "FK_Specializations_StudyYears_StudyYearId",
						column: x => x.StudyYearId,
						principalTable: "StudyYears",
						principalColumn: "Id");
				});

			migrationBuilder.CreateTable(
				name: "Courses",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					SpecializationId = table.Column<int>(type: "int", nullable: false),
					TeacherId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_Courses", x => x.Id);
					table.ForeignKey(
						name: "FK_Courses_Specializations_SpecializationId",
						column: x => x.SpecializationId,
						principalTable: "Specializations",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Courses_Teacher_TeacherId",
						column: x => x.TeacherId,
						principalTable: "Teacher",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "Absences",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					StudentId = table.Column<int>(type: "int", nullable: false),
					CourseId = table.Column<int>(type: "int", nullable: false),
					IsMotivated = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_Absences", x => x.Id);
					table.ForeignKey(
						name: "FK_Absences_Courses_CourseId",
						column: x => x.CourseId,
						principalTable: "Courses",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateTable(
				name: "Attendances",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					StudentId = table.Column<int>(type: "int", nullable: false),
					SubjectId = table.Column<int>(type: "int", nullable: false),
					Semester = table.Column<int>(type: "int", nullable: false),
					Status = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_Attendances", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Classrooms",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					SpecializationId = table.Column<int>(type: "int", nullable: false),
					TeacherId = table.Column<int>(type: "int", nullable: false),
					ClassroomTeacherId = table.Column<int>(type: "int", nullable: true),
					HomeroomTeacherId = table.Column<int>(type: "int", nullable: true)
				},
				constraints: table => {
					table.PrimaryKey("PK_Classrooms", x => x.Id);
					table.ForeignKey(
						name: "FK_Classrooms_ClassroomTeachers_ClassroomTeacherId",
						column: x => x.ClassroomTeacherId,
						principalTable: "ClassroomTeachers",
						principalColumn: "Id");
					table.ForeignKey(
						name: "FK_Classrooms_Specializations_SpecializationId",
						column: x => x.SpecializationId,
						principalTable: "Specializations",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Classrooms_Teacher_TeacherId",
						column: x => x.TeacherId,
						principalTable: "Teacher",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "HomeroomTeachers",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					ClassroomId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_HomeroomTeachers", x => x.Id);
					table.ForeignKey(
						name: "FK_HomeroomTeachers_Classrooms_ClassroomId",
						column: x => x.ClassroomId,
						principalTable: "Classrooms",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "Students",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					ClassroomId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_Students", x => x.Id);
					table.ForeignKey(
						name: "FK_Students_Classrooms_ClassroomId",
						column: x => x.ClassroomId,
						principalTable: "Classrooms",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "Subjects",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					ClassroomTeacherId = table.Column<int>(type: "int", nullable: true),
					HomeroomTeacherId = table.Column<int>(type: "int", nullable: true)
				},
				constraints: table => {
					table.PrimaryKey("PK_Subjects", x => x.Id);
					table.ForeignKey(
						name: "FK_Subjects_ClassroomTeachers_ClassroomTeacherId",
						column: x => x.ClassroomTeacherId,
						principalTable: "ClassroomTeachers",
						principalColumn: "Id");
					table.ForeignKey(
						name: "FK_Subjects_HomeroomTeachers_HomeroomTeacherId",
						column: x => x.HomeroomTeacherId,
						principalTable: "HomeroomTeachers",
						principalColumn: "Id");
				});

			migrationBuilder.CreateTable(
				name: "Grades",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					StudentId = table.Column<int>(type: "int", nullable: false),
					SubjectId = table.Column<int>(type: "int", nullable: false),
					Value = table.Column<int>(type: "int", nullable: false),
					Semester = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_Grades", x => x.Id);
					table.ForeignKey(
						name: "FK_Grades_Students_StudentId",
						column: x => x.StudentId,
						principalTable: "Students",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Grades_Subjects_SubjectId",
						column: x => x.SubjectId,
						principalTable: "Subjects",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "SubjectTeacher",
				columns: table => new {
					SubjectsId = table.Column<int>(type: "int", nullable: false),
					TeachersId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_SubjectTeacher", x => new { x.SubjectsId, x.TeachersId });
					table.ForeignKey(
						name: "FK_SubjectTeacher_Subjects_SubjectsId",
						column: x => x.SubjectsId,
						principalTable: "Subjects",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_SubjectTeacher_Teacher_TeachersId",
						column: x => x.TeachersId,
						principalTable: "Teacher",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateIndex(
				name: "IX_Absences_CourseId",
				table: "Absences",
				column: "CourseId");

			migrationBuilder.CreateIndex(
				name: "IX_Absences_StudentId",
				table: "Absences",
				column: "StudentId");

			migrationBuilder.CreateIndex(
				name: "IX_Attendances_StudentId",
				table: "Attendances",
				column: "StudentId");

			migrationBuilder.CreateIndex(
				name: "IX_Attendances_SubjectId",
				table: "Attendances",
				column: "SubjectId");

			migrationBuilder.CreateIndex(
				name: "IX_Classrooms_ClassroomTeacherId",
				table: "Classrooms",
				column: "ClassroomTeacherId");

			migrationBuilder.CreateIndex(
				name: "IX_Classrooms_HomeroomTeacherId",
				table: "Classrooms",
				column: "HomeroomTeacherId");

			migrationBuilder.CreateIndex(
				name: "IX_Classrooms_SpecializationId",
				table: "Classrooms",
				column: "SpecializationId");

			migrationBuilder.CreateIndex(
				name: "IX_Classrooms_TeacherId",
				table: "Classrooms",
				column: "TeacherId");

			migrationBuilder.CreateIndex(
				name: "IX_Courses_SpecializationId",
				table: "Courses",
				column: "SpecializationId");

			migrationBuilder.CreateIndex(
				name: "IX_Courses_TeacherId",
				table: "Courses",
				column: "TeacherId");

			migrationBuilder.CreateIndex(
				name: "IX_Grades_StudentId",
				table: "Grades",
				column: "StudentId");

			migrationBuilder.CreateIndex(
				name: "IX_Grades_SubjectId",
				table: "Grades",
				column: "SubjectId");

			migrationBuilder.CreateIndex(
				name: "IX_HomeroomTeachers_ClassroomId",
				table: "HomeroomTeachers",
				column: "ClassroomId");

			migrationBuilder.CreateIndex(
				name: "IX_Specializations_StudyYearId",
				table: "Specializations",
				column: "StudyYearId");

			migrationBuilder.CreateIndex(
				name: "IX_Students_ClassroomId",
				table: "Students",
				column: "ClassroomId");

			migrationBuilder.CreateIndex(
				name: "IX_Subjects_ClassroomTeacherId",
				table: "Subjects",
				column: "ClassroomTeacherId");

			migrationBuilder.CreateIndex(
				name: "IX_Subjects_HomeroomTeacherId",
				table: "Subjects",
				column: "HomeroomTeacherId");

			migrationBuilder.CreateIndex(
				name: "IX_SubjectTeacher_TeachersId",
				table: "SubjectTeacher",
				column: "TeachersId");

			migrationBuilder.AddForeignKey(
				name: "FK_Absences_Students_StudentId",
				table: "Absences",
				column: "StudentId",
				principalTable: "Students",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);

			migrationBuilder.AddForeignKey(
				name: "FK_Attendances_Students_StudentId",
				table: "Attendances",
				column: "StudentId",
				principalTable: "Students",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);

			migrationBuilder.AddForeignKey(
				name: "FK_Attendances_Subjects_SubjectId",
				table: "Attendances",
				column: "SubjectId",
				principalTable: "Subjects",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);

			migrationBuilder.AddForeignKey(
				name: "FK_Classrooms_HomeroomTeachers_HomeroomTeacherId",
				table: "Classrooms",
				column: "HomeroomTeacherId",
				principalTable: "HomeroomTeachers",
				principalColumn: "Id");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder) {
			migrationBuilder.DropForeignKey(
				name: "FK_Classrooms_ClassroomTeachers_ClassroomTeacherId",
				table: "Classrooms");

			migrationBuilder.DropForeignKey(
				name: "FK_Classrooms_HomeroomTeachers_HomeroomTeacherId",
				table: "Classrooms");

			migrationBuilder.DropTable(
				name: "Absences");

			migrationBuilder.DropTable(
				name: "Attendances");

			migrationBuilder.DropTable(
				name: "Averages");

			migrationBuilder.DropTable(
				name: "Grades");

			migrationBuilder.DropTable(
				name: "LoggedInUsers");

			migrationBuilder.DropTable(
				name: "SubjectTeacher");

			migrationBuilder.DropTable(
				name: "Users");

			migrationBuilder.DropTable(
				name: "Courses");

			migrationBuilder.DropTable(
				name: "Students");

			migrationBuilder.DropTable(
				name: "Subjects");

			migrationBuilder.DropTable(
				name: "ClassroomTeachers");

			migrationBuilder.DropTable(
				name: "HomeroomTeachers");

			migrationBuilder.DropTable(
				name: "Classrooms");

			migrationBuilder.DropTable(
				name: "Specializations");

			migrationBuilder.DropTable(
				name: "Teacher");

			migrationBuilder.DropTable(
				name: "StudyYears");
		}
	}
}
