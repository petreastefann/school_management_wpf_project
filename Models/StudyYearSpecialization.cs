using System.ComponentModel.DataAnnotations;

namespace school_management_wpf_project.Models {
	public class StudyYearSpecialization {
		[Key]
		public int Id {
			get; set;
		}
		public StudyYear StudyYear {
			get; set;
		}
		public Specialization Specialization {
			get; set;
		}
	}
}
