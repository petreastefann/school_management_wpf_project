namespace school_management_wpf_project.Models {
	public class Student {
		public int Id {
			get; set;
		}
		public string FirstName {
			get; set;
		}
		public string LastName {
			get; set;
		}
		public Class Class {
			get; set;
		}
		public Specialization Specialization {
			get; set;
		}

		public Student(int id, string firstName, string lastName, Class @class, Specialization specialization) {
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Class = @class;
			Specialization = specialization;
		}
	}
}
