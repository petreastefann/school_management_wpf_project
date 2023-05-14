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
		public Classroom Classroom {
			get; set;
		}
		public Specialization Specialization {
			get; set;
		}

		public Student(int id, string firstName, string lastName, Classroom classroom, Specialization specialization) {
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Classroom = classroom;
			Specialization = specialization;
		}

		public Student() {
			Id = 0;
			FirstName = "";
			LastName = "";
			Classroom = new Classroom();
			Specialization = new Specialization();
		}
	}
}
