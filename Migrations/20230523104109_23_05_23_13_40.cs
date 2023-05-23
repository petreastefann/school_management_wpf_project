using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace school_management_wpf_project.Migrations {
	/// <inheritdoc />
	public partial class _23_05_23_13_40 : Migration {
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder) {
			migrationBuilder.CreateTable(
				name: "HomeroomTeachers",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_HomeroomTeachers", x => x.Id);
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
				name: "Specializations",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_Specializations", x => x.Id);
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
				name: "Subjects",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_Subjects", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Users",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
					FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_Users", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "StudyYearSpecializations",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					StudyYearId = table.Column<int>(type: "int", nullable: false),
					SpecializationId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table => {
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

			migrationBuilder.CreateTable(
				name: "HomeroomTeacherSubject",
				columns: table => new {
					HomeroomTeachersId = table.Column<int>(type: "int", nullable: false),
					SubjectsId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_HomeroomTeacherSubject", x => new { x.HomeroomTeachersId, x.SubjectsId });
					table.ForeignKey(
						name: "FK_HomeroomTeacherSubject_HomeroomTeachers_HomeroomTeachersId",
						column: x => x.HomeroomTeachersId,
						principalTable: "HomeroomTeachers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_HomeroomTeacherSubject_Subjects_SubjectsId",
						column: x => x.SubjectsId,
						principalTable: "Subjects",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
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
					table.ForeignKey(
						name: "FK_Attendances_Subjects_SubjectId",
						column: x => x.SubjectId,
						principalTable: "Subjects",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Attendances_Users_StudentId",
						column: x => x.StudentId,
						principalTable: "Users",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "Courses",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					HasFinalExam = table.Column<bool>(type: "bit", nullable: false),
					HomeroomTeacherId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_Courses", x => x.Id);
					table.ForeignKey(
						name: "FK_Courses_Users_HomeroomTeacherId",
						column: x => x.HomeroomTeacherId,
						principalTable: "Users",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "Classrooms",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					StudyYearSpecializationId = table.Column<int>(type: "int", nullable: false),
					HomeroomTeacherId1 = table.Column<int>(type: "int", nullable: false),
					HomeroomTeacherId = table.Column<int>(type: "int", nullable: true)
				},
				constraints: table => {
					table.PrimaryKey("PK_Classrooms", x => x.Id);
					table.ForeignKey(
						name: "FK_Classrooms_HomeroomTeachers_HomeroomTeacherId",
						column: x => x.HomeroomTeacherId,
						principalTable: "HomeroomTeachers",
						principalColumn: "Id");
					table.ForeignKey(
						name: "FK_Classrooms_StudyYearSpecializations_StudyYearSpecializationId",
						column: x => x.StudyYearSpecializationId,
						principalTable: "StudyYearSpecializations",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Classrooms_Users_HomeroomTeacherId1",
						column: x => x.HomeroomTeacherId1,
						principalTable: "Users",
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
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Absences_Users_StudentId",
						column: x => x.StudentId,
						principalTable: "Users",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

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
					table.ForeignKey(
						name: "FK_Averages_Courses_CourseId",
						column: x => x.CourseId,
						principalTable: "Courses",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Averages_Users_StudentId",
						column: x => x.StudentId,
						principalTable: "Users",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateTable(
				name: "CourseStudyYearSpecializations",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					CourseId = table.Column<int>(type: "int", nullable: false),
					StudyYearSpecializationId = table.Column<int>(type: "int", nullable: false),
					StudyYearId = table.Column<int>(type: "int", nullable: true)
				},
				constraints: table => {
					table.PrimaryKey("PK_CourseStudyYearSpecializations", x => x.Id);
					table.ForeignKey(
						name: "FK_CourseStudyYearSpecializations_Courses_CourseId",
						column: x => x.CourseId,
						principalTable: "Courses",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_CourseStudyYearSpecializations_StudyYearSpecializations_StudyYearSpecializationId",
						column: x => x.StudyYearSpecializationId,
						principalTable: "StudyYearSpecializations",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_CourseStudyYearSpecializations_StudyYears_StudyYearId",
						column: x => x.StudyYearId,
						principalTable: "StudyYears",
						principalColumn: "Id");
				});

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

			migrationBuilder.CreateTable(
				name: "StudentClassrooms",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					StudentId = table.Column<int>(type: "int", nullable: false),
					ClassroomId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_StudentClassrooms", x => x.Id);
					table.ForeignKey(
						name: "FK_StudentClassrooms_Classrooms_ClassroomId",
						column: x => x.ClassroomId,
						principalTable: "Classrooms",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_StudentClassrooms_Users_StudentId",
						column: x => x.StudentId,
						principalTable: "Users",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
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
				name: "Grades",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Value = table.Column<int>(type: "int", nullable: false),
					StudentCourseId = table.Column<int>(type: "int", nullable: true)
				},
				constraints: table => {
					table.PrimaryKey("PK_Grades", x => x.Id);
					table.ForeignKey(
						name: "FK_Grades_StudentCourses_StudentCourseId",
						column: x => x.StudentCourseId,
						principalTable: "StudentCourses",
						principalColumn: "Id");
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
				name: "IX_Averages_CourseId",
				table: "Averages",
				column: "CourseId");

			migrationBuilder.CreateIndex(
				name: "IX_Averages_StudentId",
				table: "Averages",
				column: "StudentId");

			migrationBuilder.CreateIndex(
				name: "IX_Classrooms_HomeroomTeacherId",
				table: "Classrooms",
				column: "HomeroomTeacherId");

			migrationBuilder.CreateIndex(
				name: "IX_Classrooms_HomeroomTeacherId1",
				table: "Classrooms",
				column: "HomeroomTeacherId1");

			migrationBuilder.CreateIndex(
				name: "IX_Classrooms_StudyYearSpecializationId",
				table: "Classrooms",
				column: "StudyYearSpecializationId");

			migrationBuilder.CreateIndex(
				name: "IX_Courses_HomeroomTeacherId",
				table: "Courses",
				column: "HomeroomTeacherId");

			migrationBuilder.CreateIndex(
				name: "IX_CourseStudyYearSpecializations_CourseId",
				table: "CourseStudyYearSpecializations",
				column: "CourseId");

			migrationBuilder.CreateIndex(
				name: "IX_CourseStudyYearSpecializations_StudyYearId",
				table: "CourseStudyYearSpecializations",
				column: "StudyYearId");

			migrationBuilder.CreateIndex(
				name: "IX_CourseStudyYearSpecializations_StudyYearSpecializationId",
				table: "CourseStudyYearSpecializations",
				column: "StudyYearSpecializationId");

			migrationBuilder.CreateIndex(
				name: "IX_Grades_StudentCourseId",
				table: "Grades",
				column: "StudentCourseId");

			migrationBuilder.CreateIndex(
				name: "IX_HomeroomTeacherSubject_SubjectsId",
				table: "HomeroomTeacherSubject",
				column: "SubjectsId");

			migrationBuilder.CreateIndex(
				name: "IX_StudentClassrooms_ClassroomId",
				table: "StudentClassrooms",
				column: "ClassroomId");

			migrationBuilder.CreateIndex(
				name: "IX_StudentClassrooms_StudentId",
				table: "StudentClassrooms",
				column: "StudentId");

			migrationBuilder.CreateIndex(
				name: "IX_StudentCourses_CourseId",
				table: "StudentCourses",
				column: "CourseId");

			migrationBuilder.CreateIndex(
				name: "IX_StudentCourses_StudentId",
				table: "StudentCourses",
				column: "StudentId");

			migrationBuilder.CreateIndex(
				name: "IX_Students_ClassroomId",
				table: "Students",
				column: "ClassroomId");

			migrationBuilder.CreateIndex(
				name: "IX_StudyYearSpecializations_SpecializationId",
				table: "StudyYearSpecializations",
				column: "SpecializationId");

			migrationBuilder.CreateIndex(
				name: "IX_StudyYearSpecializations_StudyYearId",
				table: "StudyYearSpecializations",
				column: "StudyYearId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder) {
			migrationBuilder.DropTable(
				name: "Absences");

			migrationBuilder.DropTable(
				name: "Attendances");

			migrationBuilder.DropTable(
				name: "Averages");

			migrationBuilder.DropTable(
				name: "CourseStudyYearSpecializations");

			migrationBuilder.DropTable(
				name: "Grades");

			migrationBuilder.DropTable(
				name: "HomeroomTeacherSubject");

			migrationBuilder.DropTable(
				name: "LoggedInUsers");

			migrationBuilder.DropTable(
				name: "StudentClassrooms");

			migrationBuilder.DropTable(
				name: "Students");

			migrationBuilder.DropTable(
				name: "StudentCourses");

			migrationBuilder.DropTable(
				name: "Subjects");

			migrationBuilder.DropTable(
				name: "Classrooms");

			migrationBuilder.DropTable(
				name: "Courses");

			migrationBuilder.DropTable(
				name: "HomeroomTeachers");

			migrationBuilder.DropTable(
				name: "StudyYearSpecializations");

			migrationBuilder.DropTable(
				name: "Users");

			migrationBuilder.DropTable(
				name: "Specializations");

			migrationBuilder.DropTable(
				name: "StudyYears");
		}
	}
}
