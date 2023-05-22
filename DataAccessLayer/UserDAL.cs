using school_management_wpf_project.Data;
using school_management_wpf_project.Models;

namespace school_management_wpf_project.DataAccessLayer {
	public class UserDAL {
		private static SchoolDbContext _db = new SchoolDbContext();

		public static void Add(User user) {
			/*
						_db.Database.ExecuteSqlRaw($"InsertUser @firstName, @lastName, @email, @role, @password",
								new SqlParameter("@firstName", user.FirstName),
								new SqlParameter("@lastName", user.LastName),
								new SqlParameter("@email", user.Email),
								new SqlParameter("@password", user.Password),
								new SqlParameter("@role", user.Role)
								);

						_db.SaveChanges();*/
		}
	}
}
