using school_management_wpf_project.DataAccessLayer;
using school_management_wpf_project.Models;

namespace school_management_wpf_project.BusinessLogicLayer {
	public class CourseStudyYearSpecializationBLL {
		public static void Add(CourseStudyYearSpecialization courseStudyYearSpecialization) {
			CourseStudyYearSpecializationDAL.Add(courseStudyYearSpecialization);
		}
	}
}
