using school_management_wpf_project.Data;
using school_management_wpf_project.Models;
using System.Collections.Generic;
using System.Linq;

namespace school_management_wpf_project.DataAccessLayer {
	class SpecializationDAL {
		private static SchoolDbContext _db = new SchoolDbContext();

		public static void Add(Specialization specialization) {
			_db.Specializations.Add(specialization);
			_db.SaveChanges();
		}
		public static List<Specialization> GetAll() {
			if(_db.Specializations.Count() > 0)
				return _db.Specializations.ToList();
			return new List<Specialization>();
		}
	}
}
