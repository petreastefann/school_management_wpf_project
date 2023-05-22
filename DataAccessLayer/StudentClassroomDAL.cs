using school_management_wpf_project.Data;
using school_management_wpf_project.Models;
using System.Linq;

namespace school_management_wpf_project.DataAccessLayer {
	public static class StudentClassroomDAL {
		private static SchoolDbContext _db = new SchoolDbContext();

		public static void Add(StudentClassroom studentClassroom) {
			studentClassroom.Id = 0;
			var student = _db.Users.FirstOrDefault(u => u.Id == studentClassroom.Student.Id);
			var classroom = _db.Classrooms.FirstOrDefault(c => c.Id == studentClassroom.Classroom.Id);

			if(student != null) {
				studentClassroom.Student = student;
			}
			if(classroom != null) {
				studentClassroom.Classroom = classroom;
			}

			_db.StudentClassrooms.Add(studentClassroom);
			_db.SaveChanges();
		}
	}
}
