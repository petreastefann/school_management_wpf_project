namespace school_management_wpf_project.Models {
	public class User {
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
		public User(string username, string password, string userType) {
			Username = username;
			Password = password;
			UserType = userType;
		}
		public User() {
			Username = "";
			Password = "";
			UserType = "";
		}
	}
}
