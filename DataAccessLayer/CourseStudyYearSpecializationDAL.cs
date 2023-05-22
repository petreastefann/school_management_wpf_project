using school_management_wpf_project.Data;
using school_management_wpf_project.Models;
using System.Linq;

namespace school_management_wpf_project.DataAccessLayer {
	public class CourseStudyYearSpecializationDAL {
		private static SchoolDbContext _db = new SchoolDbContext();

		public static void Add(CourseStudyYearSpecialization courseStudyYearSpecialization) {
			courseStudyYearSpecialization.Id = 0;
			var specialization = _db.Specializations.FirstOrDefault(s => s.Id == courseStudyYearSpecialization.StudyYearSpecialization.Specialization.Id);
			if(specialization != null) {
				courseStudyYearSpecialization.StudyYearSpecialization.Specialization = specialization;
			}

			var studyYear = _db.StudyYears.FirstOrDefault(s => s.Id == courseStudyYearSpecialization.StudyYearSpecialization.StudyYear.Id);
			if(studyYear != null) {
				courseStudyYearSpecialization.StudyYearSpecialization.StudyYear = studyYear;
			}

			var course = _db.Courses.FirstOrDefault(c => c.Id == courseStudyYearSpecialization.Course.Id);
			if(course != null) {
				courseStudyYearSpecialization.Course = course;
			}

			var studyYearSpecialization = _db.StudyYearSpecializations.FirstOrDefault(s => s.Id == courseStudyYearSpecialization.StudyYearSpecialization.Id);
			if(studyYearSpecialization != null) {
				courseStudyYearSpecialization.StudyYearSpecialization = studyYearSpecialization;
			}

			_db.CourseStudyYearSpecializations.Add(courseStudyYearSpecialization);
			_db.SaveChanges();
		}

	}
}
