using Microsoft.EntityFrameworkCore;
using school_management_wpf_project.Data;
using school_management_wpf_project.Models;
using System.Collections.Generic;
using System.Linq;

namespace school_management_wpf_project.DataAccessLayer {
	public class StudyYearSpecializationDAL {
		private static SchoolDbContext _db = new SchoolDbContext();

		public static void Add(StudyYearSpecialization studyYearSpecialization) {
			var studyYear = _db.StudyYears.FirstOrDefault(s => s.Id == studyYearSpecialization.StudyYear.Id);
			if(studyYear != null) {
				studyYearSpecialization.StudyYear = studyYear;
			}

			var specialization = _db.Specializations.FirstOrDefault(s => s.Id == studyYearSpecialization.Specialization.Id);
			if(specialization != null) {
				studyYearSpecialization.Specialization = specialization;
			}

			studyYearSpecialization.Name = $"{studyYearSpecialization.StudyYear.Name} + {studyYearSpecialization.Specialization.Name}";
			studyYearSpecialization.Id = 0;
			_db.StudyYearSpecializations.Add(studyYearSpecialization);
			_db.SaveChanges();
		}

		public static List<StudyYearSpecialization> GetAll() {
			if(_db.StudyYearSpecializations.Count() > 0)
				return _db.StudyYearSpecializations
					.Include(c => c.Specialization)
					.Include(c => c.StudyYear).ToList();
			return new List<StudyYearSpecialization>();
		}
	}
}
