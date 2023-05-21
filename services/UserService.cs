using Microsoft.EntityFrameworkCore;
using school_management_wpf_project.Data;
using school_management_wpf_project.Models;
using System.Linq;

namespace school_management_wpf_project.Services {
	public static class UserService {
		private static SchoolDbContext _context = new SchoolDbContext();

		public static User Login(string username, string password) {
			var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

			if(user != null) {
				_context.Database.ExecuteSqlRaw("TRUNCATE TABLE [LoggedInUsers]");
				_context.LoggedInUsers.Add(new LoggedInUser { UserId = user.Id });
				_context.SaveChanges();

				return user;
			}
			return null;
		}

		public static User GetLoggedInUser() {
			var loggedInUserId = _context.LoggedInUsers.FirstOrDefault();

			if(loggedInUserId != null) {
				return _context.Users.FirstOrDefault(u => u.Id == loggedInUserId.UserId);
			}
			return null;
		}

		public static string? GetUserRole(string username) {
			var user = _context.Users.FirstOrDefault(u => u.Username == username);

			if(user != null) {
				return user.Role;
			}

			return null;
		}

		public static User GetUserByUsername(string username) {
			return _context.Users.FirstOrDefault(u => u.Username == username);
		}
	}
}
