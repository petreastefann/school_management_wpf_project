namespace school_management_wpf_project.Models {
	public class StudentCourseGrade {
		public int Id {
			get; set;
		}

		public StudentCourse StudentCourse {
			get; set;
		}

		public int Grade {
			get; set;
		}
	}
}
