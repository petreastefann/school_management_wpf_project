namespace school_management_wpf_project.Models {
	public class Course {
		public int Id {
			get; set;
		}
		public string Name {
			get; set;
		}
		public bool HasFinalExam {
			get; set;
		}
		public User HomeroomTeacher {   // TODO
			get; set;
		}
	}
}
