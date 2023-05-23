using school_management_wpf_project.DataAccessLayer;
using school_management_wpf_project.Models;
using System.Collections.Generic;

namespace school_management_wpf_project.BusinessLogicLayer {
	class CourseBLL {
		public static void Add(Course course) {
			CourseDAL.Add(course);
		}
		public static List<Course> GetAll() {
			return CourseDAL.GetAll();
		}
		public static List<Course> GetAllByTeacher(User teacher) {
			return CourseDAL.GetAllByTeacher(teacher);
		}
	}
}
