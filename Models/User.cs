namespace school_management_wpf_project.Models {
	internal class User {
		public int Id {
			get; set;
		}
		public string Username {
			get; set;
		}
		public string Password {
			get; set;
		}
		public string UserType {
			get; set;
		}
		public User(string username, string password) {
			Username = username;
			Password = password;
		}
	}
}
