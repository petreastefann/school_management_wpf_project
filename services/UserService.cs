using school_management_wpf_project.Data;
using school_management_wpf_project.Models;
using System.Linq;

namespace school_management_wpf_project.Services {
	public class UserService {
		private readonly SchoolDbContext _context;

		public UserService(SchoolDbContext context) {
			_context = context;
		}

		public bool CheckIfUserExists(string username, string password) {
			return _context.Users.Any(u => u.Username == username && u.Password == password);
		}

		public string? GetUserRole(string username) {
			var user = _context.Users.FirstOrDefault(u => u.Username == username);

			if(user != null) {
				return user.Role;
			}

			return null;
		}

		public User GetUserByUsername(string username) {
			return _context.Users.FirstOrDefault(u => u.Username == username);
		}
	}
}
