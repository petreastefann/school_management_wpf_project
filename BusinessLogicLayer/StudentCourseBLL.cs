using school_management_wpf_project.DataAccessLayer;
using school_management_wpf_project.Models;

namespace school_management_wpf_project.BusinessLogicLayer {
	public static class StudentCourseBLL {
		public static StudentCourse GetByStudentAndCourse(User student, Course course) {
			return StudentCourseDAL.GetByStudentAndCourse(student, course);
		}

		public static void Update(StudentCourse studentCourse) {
			StudentCourseDAL.Update(studentCourse);
		}
	}
}
