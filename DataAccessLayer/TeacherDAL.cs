using school_management_wpf_project.Data;
using school_management_wpf_project.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace school_management_wpf_project.DataAccessLayer {
	class TeacherDAL {
		private static SchoolDbContext _db = new SchoolDbContext();

		public static List<User> GetAll() {
			if(_db.Users.Count() > 0)
				return _db.Users.Where(u => u.Role == "teacher").ToList();
			return new List<User>();
		}
	}
}
