namespace school_management_wpf_project.Models {
	public class CourseStudyYearSpecialization {
		public int Id {
			get; set;
		}
		public Course Course {
			get; set;
		}
		public StudyYearSpecialization StudyYearSpecializations {
			get; set;
		}
	}
}
