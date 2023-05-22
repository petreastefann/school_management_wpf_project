using Microsoft.EntityFrameworkCore;
using school_management_wpf_project.Data;
using school_management_wpf_project.Models;
using System.Collections.Generic;
using System.Linq;

namespace school_management_wpf_project.DataAccessLayer {
	public class ClassroomDAL {
		private static SchoolDbContext _db = new SchoolDbContext();

		public static void Add(Classroom classroom) {
			classroom.Id = 0;

			var studyYearSpecialization = _db.StudyYearSpecializations.FirstOrDefault(s => s.Id == classroom.StudyYearSpecialization.Id);
			if(studyYearSpecialization != null) {
				classroom.StudyYearSpecialization = studyYearSpecialization;
			}

			var homeroomTeacher = _db.Users.FirstOrDefault(u => u.Id == classroom.HomeroomTeacher.Id);
			if(homeroomTeacher != null) {
				classroom.HomeroomTeacher = homeroomTeacher;
			}

			_db.Add(classroom);
			_db.SaveChanges();
		}

		public static List<Classroom> GetAll() {
			if(_db.Classrooms.Count() > 0) {
				return _db.Classrooms
					.Include(c => c.StudyYearSpecialization)
					.Include(c => c.HomeroomTeacher)
					.ToList();
			}
			return new List<Classroom>();
		}


	}
}
