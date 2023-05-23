using school_management_wpf_project.Data;
using school_management_wpf_project.Models;
using System.Linq;

namespace school_management_wpf_project.DataAccessLayer {
	public static class StudentCourseDAL {
		private static SchoolDbContext _db = new SchoolDbContext();

		public static StudentCourse GetByStudentAndCourse(User student, Course course) {
			var studentCourse = _db.StudentCourses.FirstOrDefault(sc => sc.Student.Id == student.Id && sc.Course.Id == course.Id);

			if(studentCourse != null) {
				return studentCourse;
			}
			return new StudentCourse();
		}

		public static void Update(StudentCourse studentCourse) {
			var studentCourseToUpdate = _db.StudentCourses.FirstOrDefault(sc => sc.Id == studentCourse.Id);

			if(studentCourseToUpdate != null) {
				studentCourseToUpdate.Absences = studentCourse.Absences;
				_db.StudentCourses.Update(studentCourseToUpdate);
				_db.SaveChanges();
			}
			else {
				studentCourseToUpdate = new StudentCourse();
				studentCourseToUpdate.Id = 0;
				studentCourseToUpdate.Absences = studentCourse.Absences;

				var student = _db.Users.FirstOrDefault(u => u.Id == studentCourse.Student.Id);
				var course = _db.Courses.FirstOrDefault(c => c.Id == studentCourse.Course.Id);

				studentCourseToUpdate.Student = student;
				studentCourseToUpdate.Course = course;

				_db.StudentCourses.Add(studentCourseToUpdate);
				_db.SaveChanges();
			}
		}
	}
}
