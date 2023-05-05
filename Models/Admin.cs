namespace school_management_wpf_project.Models {
	public class Admin {
		public int Id {
			get; set;
		}
		public string FirstName {
			get; set;
		}
		public string LastName {
			get; set;
		}

		public Admin(int id, string firstName, string lastName) {
			Id = id;
			FirstName = firstName;
			LastName = lastName;
		}
	}
}
