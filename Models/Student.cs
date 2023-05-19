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
		public int ClassroomId {
			get; set;
		}

		public Student(string firstName, string lastName, int classroomId) {
			FirstName = firstName;
			LastName = lastName;
			ClassroomId = classroomId;
		}

		public Student() {
			FirstName = "";
			LastName = "";
			ClassroomId = 0;
		}
	}
}
