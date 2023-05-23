using school_management_wpf_project.DataAccessLayer;
using school_management_wpf_project.Models;
using System.Collections.Generic;

namespace school_management_wpf_project.BusinessLogicLayer {
	public static class StudentCourseBLL {
		public static StudentCourse GetByStudentAndCourse(User student, Course course) {
			return StudentCourseDAL.GetByStudentAndCourse(student, course);
		}

		public static List<StudentCourse> GetAllByStudent(User student) {
			return StudentCourseDAL.GetAllByStudent(student);
		}

		public static void Update(StudentCourse studentCourse) {
			StudentCourseDAL.Update(studentCourse);
		}
	}
}
