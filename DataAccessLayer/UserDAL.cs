using school_management_wpf_project.Data;
using school_management_wpf_project.Models;

namespace school_management_wpf_project.DataAccessLayer {
	public class UserDAL {
		private static SchoolDbContext _db = new SchoolDbContext();

		public static void Add(User user) {
			user.Id = 0;
			_db.Users.Add(user);
			_db.SaveChanges();
		}
	}
}
