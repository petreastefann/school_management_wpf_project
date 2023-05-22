using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace school_management_wpf_project.Models {
	public class StudyYear {
		[Key]
		public int Id {
			get; set;
		}
		public string Name {
			get; set;
		}
		public int Year {
			get; set;
		}
		public List<StudyYearSpecialization> StudyYearSpecializations {
			get; set;
		}
		public List<CourseStudyYearSpecialization> CourseStudyYearSpecializations {
			get; set;
		}
	}
}
