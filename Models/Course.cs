namespace school_management_wpf_project.Models {
	public class Course {
		public int Id {
			get; set;
		}
		public string Name {
			get; set;
		}
		public Specialization Specialization {
			get; set;
		}
		public Teacher Teacher {
			get; set;
		}
	}
}
