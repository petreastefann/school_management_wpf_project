using school_management_wpf_project.DataAccessLayer;
using school_management_wpf_project.Models;

namespace school_management_wpf_project.BusinessLogicLayer {
	class CourseBLL {
		public static void Add(Course course) {
			CourseDAL.Add(course);
		}
		/*public static List<Course> GetAll() {
			return CourseDAL.GetAll();
		}*/
	}
}
