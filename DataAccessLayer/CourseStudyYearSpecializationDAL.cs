using school_management_wpf_project.Data;
using school_management_wpf_project.Models;

namespace school_management_wpf_project.DataAccessLayer {
	public class CourseStudyYearSpecializationDAL {
		private static SchoolDbContext _db = new SchoolDbContext();

		public static void Add(CourseStudyYearSpecialization courseStudyYearSpecialization) {
			_db.CourseStudyYearSpecializations.Add(courseStudyYearSpecialization);
			_db.SaveChanges();
		}
	}
}
