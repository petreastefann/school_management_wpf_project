using Microsoft.EntityFrameworkCore;
using school_management_wpf_project.Data;
using school_management_wpf_project.Models;
using System.Collections.Generic;
using System.Linq;

namespace school_management_wpf_project.DataAccessLayer {
	public class ClassroomDAL {
		private static SchoolDbContext _db = new SchoolDbContext();

		public static void Add(Classroom classroomToAdd) {
			_db.Add(classroomToAdd);
			_db.SaveChanges();
		}

		public static List<Classroom> GetAll() {
			if(_db.Classrooms.Count() > 0) {
				return _db.Classrooms
					.Include(c => c.Specialization)
					.Include(c => c.HomeroomTeacher)
					.ToList();
			}
			return new List<Classroom>();
		}


	}
}
