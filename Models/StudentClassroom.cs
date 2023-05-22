namespace school_management_wpf_project.Models {
	public class StudentClassroom {
		public int Id {
			get; set;
		}
		public User Student {
			get; set;
		}
		public Classroom Classroom {
			get; set;
		}
	}
}
