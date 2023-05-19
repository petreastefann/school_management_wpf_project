namespace school_management_wpf_project.Models {
	using System.ComponentModel.DataAnnotations;

	public class Student {
		[Key]
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

		public Student(string firstName, string lastName, Classroom classroom) {
			FirstName = firstName;
			LastName = lastName;
			Classroom = classroom;
		}

		public Student() {
			Id = 0;
			FirstName = "";
			LastName = "";
			Classroom = null;
		}
	}
}
