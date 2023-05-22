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
/*
 SqlException: Cannot insert explicit value for identity column in table 'Specializations' when IDENTITY_INSERT is set to OFF.
Cannot insert explicit value for identity column in table 'StudyYears' when IDENTITY_INSERT is set to OFF.
Cannot insert explicit value for identity column in table 'Users' when IDENTITY_INSERT is set to OFF.
Cannot insert explicit value for identity column in table 'Courses' when IDENTITY_INSERT is set to OFF.
Cannot insert explicit value for identity column in table 'StudyYearSpecializations' when IDENTITY_INSERT is set to OFF.
 */