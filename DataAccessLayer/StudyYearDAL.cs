using school_management_wpf_project.Data;
using school_management_wpf_project.Models;
using System.Collections.Generic;
using System.Linq;

namespace school_management_wpf_project.DataAccessLayer {
	public static class StudyYearDAL {
		private static SchoolDbContext _db = new SchoolDbContext();

		public static void Add(StudyYear studyYear) {
			_db.StudyYears.Add(studyYear);
			_db.SaveChanges();
		}

		public static List<StudyYear> GetAll() {
			if(_db.StudyYears.Count() > 0)
				return _db.StudyYears.ToList();
			return new List<StudyYear>();
		}
	}
}
